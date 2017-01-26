using ApplicationServer;
using DAL.Repositories;
using DataTransferObject;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizServer
{
    public static class TesteeTrainingProcessing
    {
        public static void SynchronizeTesteeTrainings(List<string> trainingsTitle)
        {
            var processTitles = trainingsTitle;
            EFTesteeRepository testeeRepo = new EFTesteeRepository(Program.dbContext);
            var allTestees = testeeRepo.ReadAll().ToList();
            EFTrainingRepository trainingRepo = new EFTrainingRepository(Program.dbContext);
            var allTraining = trainingRepo.ReadAll().ToList();

            foreach (var t in allTestees)
            {
                foreach (var trainings in t.Trainings)
                {
                    trainings.IsActive = trainingsTitle.Contains(trainings.Training.TrainingTitle);
                    processTitles.Remove(trainings.Training.TrainingTitle);
                }
            }

            AddNewTesteeTraining(processTitles, allTestees);

            UpdateTestee(allTestees, testeeRepo);
        }

        private static void AddNewTesteeTraining(List<string> trainingsTitles, List<Testee> allTestees)
        {
            EFTrainingRepository trainingRepo = new EFTrainingRepository(Program.dbContext);
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
            repo.dbContext.SaveChanges();
            //foreach (var testee in allTestee)
            //{
            //    repo.Update(testee);
            //}
        }
    }
}

