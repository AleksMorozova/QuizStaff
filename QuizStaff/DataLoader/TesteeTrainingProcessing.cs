using DAL;
using DAL.Repositories;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLoader
{
    public static class TesteeTrainingProcessing
    {
        public static void SynchronizeTesteeTrainings(QuizDBContext context, List<string> trainingsTitle)
        {
            var processTitles = trainingsTitle;
            EFTesteeRepository testeeRepo = new EFTesteeRepository(context);
            var allTestees = testeeRepo.ReadAll().ToList();
            EFTrainingRepository trainingRepo = new EFTrainingRepository(context);
            var allTraining = trainingRepo.ReadAll().ToList();

            foreach (var t in allTestees)
            {
                foreach (var trainings in t.Trainings)
                {
                    trainings.IsActive = trainingsTitle.Contains(trainings.Training.TrainingTitle);
                    processTitles.Remove(trainings.Training.TrainingTitle);
                }
            }

            AddNewTesteeTraining(context, processTitles, allTestees);

            UpdateTestee(allTestees, testeeRepo);
        }

        private static void AddNewTesteeTraining(QuizDBContext context, List<string> trainingsTitles, List<Testee> allTestees)
        {
            EFTrainingRepository trainingRepo = new EFTrainingRepository(context);
            var allTraining = trainingRepo.ReadAll().ToList();

            foreach (var title in trainingsTitles)
            {
                foreach (var t in allTestees)
                {
                    var tr = new TesteeTraining();
                    tr.IsActive = true;
                    tr.Training = allTraining.Where(_ => _.TrainingTitle == title).FirstOrDefault();
                    t.Trainings.Add(tr);
                }
            }
        }

        private static void UpdateTestee(List<Testee> allTestee, EFTesteeRepository repo)
        {
            repo.Save();

            // repo.dbContext.SaveChanges();
            //foreach (var testee in allTestee)
            //{
            //    repo.Update(testee);
            //}
        }
    }
}
