using DAL;
using DataLoader;
using DomainModel;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoadDataFromLMS;
using LoaderModel;
using DAL.Repositories;

namespace Services.Implementation
{
    public class LoaderService : ILoaderService
    {
        public void LoadAdditionalQuestions(QuizDBContext context)
        {
            Loader.LoadQuestionFromFile(@"D:\QuizTrainings\GeneralQuestions");
            var loadedQuestions = Loader.LoadedQuestions;
            TrainingDataPprocessing.SynchronizeAdditionalTrainings(context,loadedQuestions.Select(_ => _.Training).Distinct().ToList(), loadedQuestions);
            TesteeTrainingProcessing.SynchronizeTesteeTrainings(context, loadedQuestions.Select(_ => _.Training).Distinct().ToList());
        }

        public void LoadTrainings(QuizDBContext context)
        {
            Loader.LoadDataFromFile(@"D:\QuizTrainings\ISD_Report.xlsx");
            Loader.LoadQuestionFromFile(@"D:\QuizTrainings\Questions");

            List<string> trainingTitles = Loader.TesteesList.Select(_ => _.training).ToList();
            List<TesteeData> testees = Loader.TesteesTrainingsList;

            var loadedQuestions = Loader.LoadedQuestions;

            TrainingDataPprocessing.SynchronizeTrainings(context, trainingTitles.Distinct().ToList(), loadedQuestions);
            TesteeDataPprocessing.WriteTesteeFromLMS(context, testees.Distinct().ToList());

            WriteTesteeTrainings(context, Loader.TesteesList);
        }

        public void SynchronizeTestees(QuizDBContext context, List<Testee> loadedTestees)
        {
            TesteeDataPprocessing.SynchronizeTestees(context, loadedTestees);
        }

        public void UpdateTesteesTrainings(QuizDBContext context, List<TesteeTraining> allTesteeTrainings)
        {
            EFTesteeTrainingRepository repo = new EFTesteeTrainingRepository(context);
            foreach (var testeeTrainings in allTesteeTrainings)
            {
                if (testeeTrainings.Id == Guid.Empty)
                {
                    repo.Create(testeeTrainings);
                }
                else
                {
                    repo.Update(testeeTrainings);
                }
            }
        }

        private TesteeTraining UpdateTesteeTraining(TesteeTraining testeeTraining, bool isActive)
        {
            testeeTraining.IsActive = isActive;
            testeeTraining.IsSelect = true;
            return testeeTraining;
        }

        public void WriteTesteeTrainings(QuizDBContext context, List<TesteeTrainingLink> testeeTraining)
        {
            EFTesteeRepository repo = new EFTesteeRepository(context);
            EFTrainingRepository trainingRepo = new EFTrainingRepository(context);
            EFTesteeTrainingRepository testeeTrainingRepo = new EFTesteeTrainingRepository(context);

            var allTestees = repo.ReadAll().ToList();
            var allTrainings = trainingRepo.ReadAll().ToList();
            testeeTraining = testeeTraining.Distinct().ToList();

            List<TesteeTraining> updatedTesteeTrainings = new List<TesteeTraining>();
            var existingTesteTrainings = new List<TesteeTraining>(testeeTrainingRepo.ReadAll());

            updatedTesteeTrainings.AddRange((from link in testeeTraining
                                             select new { link }).AsEnumerable().Select(x =>
                                             {
                                                 var testee = allTestees.Where(_ => _.Login == x.link.login && _.IsActive).FirstOrDefault();
                                                 var trainings = allTrainings.Where(_ => _.TrainingTitle == x.link.training && _.IsActive).FirstOrDefault();
                                                 var testeeTrainingFromDB = existingTesteTrainings.FirstOrDefault(_ => _.Training == trainings && _.Testee == testee);
                                                 return (existingTesteTrainings.Contains(testeeTrainingFromDB))
                                                     ? UpdateTesteeTraining(testeeTrainingFromDB, true)
                                                     : new TesteeTraining() { Testee = testee, Training = trainings, IsActive = true, IsSelect = true };
                                             }));

            updatedTesteeTrainings.AddRange(existingTesteTrainings.Except(updatedTesteeTrainings).Select(x => UpdateTesteeTraining(x, false)));

            UpdateTesteesTrainings(context, updatedTesteeTrainings);
        }
    }
}
