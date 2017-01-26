using DataTransferObject;
using DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoadDataFromLMS;
using QuizServer;
using Services.Contracts;
using Services.Implementation;
using DAL.Repositories;
using System.ServiceModel;

namespace ApplicationServer
{
    [ServiceBehavior]
    public class ApplicationServer : IApplicationServer
    {
        public ApplicationServer()
        {

        }

        # region Testee 

        public List<TesteeDTO> GetAllTestees()
        {
            return RegistrateDependencies.TesteeService.GetAllTestees(Program.dbContext);
        }

        public TesteeDTO FindByLogin(string login)
        {
            return RegistrateDependencies.TesteeService.FindByLogin(Program.dbContext, login);
        }

        public TesteeDTO SaveTestee(TesteeDTO testee)
        {
            return (testee.Id == Guid.Empty) 
                ? RegistrateDependencies.TesteeService.SaveTestee(Program.dbContext, testee) 
                : RegistrateDependencies.TesteeService.UpdateTestee(Program.dbContext, testee);
        }

        #endregion

        #region Training

        public List<TrainingDTO> GetAllTrainings()
        {
            return RegistrateDependencies.TrainingService.GetAllTrainings(Program.dbContext);
        }

        public List<TrainingDTO> GetAllActiveTrainings()
        {
            return RegistrateDependencies.TrainingService.GetAllActiveTrainings(Program.dbContext);
        }

        public TrainingDTO SaveTraining(TrainingDTO training)
        {
            return (training.Id == Guid.Empty)
                ? RegistrateDependencies.TrainingService.SaveTraining(Program.dbContext, training)
                : RegistrateDependencies.TrainingService.UpdateTraining(Program.dbContext, training);
        }

        public TrainingDTO FindByTitle(string title)
        {
            return RegistrateDependencies.TrainingService.FindByTitle(Program.dbContext, title);
        }
        #endregion

        #region Question

        public void SaveQuestion(QuestionDTO question)
        {
            RegistrateDependencies.QuestionService.UpdateQuestion(Program.dbContext, question);
        }

        public QuestionDTO GetRandomQuestionForTestee(Guid id)
        {
            return RegistrateDependencies.QuestionService.GetRandomQuestionForTestee(Program.dbContext, id);
        }

        #endregion Question

        public List<TesteeDTO> GetAllTesteesForReport(DateTime from, DateTime to, 
            string Company, string OfficeLoc, string Sector, string Division, string Department,  string Position)
        {
            EFRepository<Testee> repo = new EFRepository<Testee>(Program.dbContext);

            var q = repo.ReadAll().Where(x => x.IsActive).AsQueryable();

            #region Sort
            //Company
            if (!string.IsNullOrEmpty(Company))
            {
                q = q.Where(_=>_.Attribute1 == Company);
            }
            //OfficeLoc
            if (!string.IsNullOrEmpty(OfficeLoc))
            {
                q = q.Where(_ => _.Attribute2 == OfficeLoc);
            }
            //Sectore
            if (!string.IsNullOrEmpty(Sector))
            {
                q = q.Where(_ => _.Attribute3 == Sector);
            }
            //Division
            if (!string.IsNullOrEmpty(Division))
            {
                q = q.Where(_ => _.Attribute4 == Division);
            }
            //Department
            if (!string.IsNullOrEmpty(Department))
            {
                q = q.Where(_ => _.Attribute5 == Department);
            }
           
            //Position
            if (!string.IsNullOrEmpty(Position))
            {
                q = q.Where(_ => _.Attribute8 == Position);
            }  
            #endregion

            var selectedTestee = q
                .Select(testee => new Testee
                {
                    Id = testee.Id,
                    FirstName = testee.FirstName,
                    LastName = testee.LastName,
                    Login = testee.Login,
                    IsActive = testee.IsActive,
                    Email = testee.Email,

                    Attribute1 = testee.Attribute1,
                    Attribute2 = testee.Attribute2,
                    Attribute3 = testee.Attribute3,
                    Attribute4 = testee.Attribute4,
                    Attribute5 = testee.Attribute5,
                    Attribute6 = testee.Attribute6,
                    Attribute7 = testee.Attribute7,
                    Attribute8 = testee.Attribute8,
                    Attribute9 = testee.Attribute9,
                    Attribute10 = testee.Attribute10,
                    Attribute11 = testee.Attribute11,
                    Attribute12 = testee.Attribute12,
                    Attribute13 = testee.Attribute13,
                    UserSetting = testee.UserSetting,
                    Trainings = new BindingList<TesteeTraining>(testee.Trainings.ToList().Where(_ => _.IsActive).ToList()),
                    Roles = new BindingList<TesteeRoles>(testee.Roles.ToList()),
                    Histories = new BindingList<History>(testee.Histories.Where(_=> _.AnsweringDate >= from && _.AnsweringDate < to).ToList())

                }).ToList();

            return selectedTestee.Select(testee => (TesteeDTO)testee).ToList();
        }

        public void SaveTesteeAnswer(HistoryDTO history)
        {
            EFHistoryRepository repo = new EFHistoryRepository(Program.dbContext);
            History h = new History();
            h.Answers = new BindingList<TesteeAnswer>();
            foreach (var a in history.Answers)
            {
                TesteeAnswer ans = new TesteeAnswer();

                ans.Answer = new Answer();
                ans.Answer.AnswerText = a.Answer.AnswerText;
                ans.Answer.Id = a.Answer.Id;
                ans.Answer.IsActive = a.Answer.IsActive;
                ans.Answer.IsCorrect = a.Answer.IsCorrect;

                h.Answers.Add(ans);
            }
            h.AnsweringDate = history.AnsweringDate;
            h.Question = Conversion.ConvertQuestionFromDTO(history.Question);
            h.Testee = Conversion.ConvertTesteeFromDTO(history.Testee);
            h.IsAnswerCorrect = history.IsAnswerCorrect;
            repo.Create(h);
        }

        public void UpdateSettings(SettingDTO[] settings)
        {
            EFSettingRepository repo = new EFSettingRepository(Program.dbContext);
            foreach (var setting in settings.ToList())
            {
                Setting newSetting = new Setting();
                newSetting.Id = setting.Id;
                newSetting.Hours = setting.Hours;
                newSetting.Minutes = setting.Minutes;
                newSetting.Seconds = setting.Seconds;
                newSetting.EndDate = DateTime.Now;
                newSetting.Recurrence = setting.Recurrence;
                newSetting.AmountOfQuestionsPerDay = setting.AmountOfQuestionsPerDay;
                newSetting.TimeOfStart = setting.TimeOfStart;
                newSetting.CanUserEdit = setting.CanUserEdit;
                newSetting.ShowCorrectAnswer = setting.ShowCorrectAnswer;

                repo.Update(newSetting);
            }
        }

        public void UpdateTesteeTrainings(TesteeTrainingDTO[] testeeTrainings)
        {
            EFTesteeTrainingRepository repo = new EFTesteeTrainingRepository(Program.dbContext);
            foreach (var testeeTraining in testeeTrainings)
            {
                TesteeTraining updateTesteeTraining = Conversion.ConvertTesteeTrainingFromDTO(testeeTraining);
                repo.Update(updateTesteeTraining);
            }
        }

        public void UpdateTesteeTraining(TesteeTrainingDTO testeeTraining)
        {
            EFTesteeTrainingRepository repo = new EFTesteeTrainingRepository(Program.dbContext);
            TesteeTraining updateTesteeTraining = Conversion.ConvertTesteeTrainingFromDTO(testeeTraining);
            repo.Update(updateTesteeTraining);
        }

        public List<RoleDTO> GetAllRoles()
        {
            EFRepository<Role> repo = new EFRepository<Role>(Program.dbContext);
            var roles = new List<Role>(repo.ReadAll());
            return roles.Select(role => (RoleDTO)role).ToList();
        }

        public List<PermissionDTO> GetAllPermissions()
        {
            EFRepository<Permission> repo = new EFRepository<Permission>(Program.dbContext);
            var permissions = new List<Permission>(repo.ReadAll());
            return permissions.Select(permission => (PermissionDTO)permission).ToList();
        }

        public void UpdateRoles(RoleDTO role)
        {
            EFRoleRepository repo = new EFRoleRepository(Program.dbContext);
            if (role.Id == Guid.Empty)
            {
                repo.Create(Conversion.ConvertRoleFromDTO(role));
            }
            else
            {
                repo.Update(Conversion.ConvertRoleFromDTO(role));
            }
        }

        public void AddTesteeRole(TesteeDTO testee, RoleDTO role)
        {
            EFTesteeRepository repo = new EFTesteeRepository(Program.dbContext);
            testee.Roles.Add(new TesteeRolesDTO() { Role = role, IsActive = false });
            repo.Update(Conversion.ConvertTesteeFromDTO(testee));
        }

        public void UpdateAnswer(AnswerDTO answer)
        {
            EFRepository<Answer> repo = new EFRepository<Answer>(Program.dbContext);
            Answer newAnswer = Conversion.ConvertAnswerFromDTO(answer);
            repo.Update(newAnswer);
        }

        public List<TesteeTraining> FindTesteesTrainings()
        {
            EFRepository<TesteeTraining> repo = new EFRepository<TesteeTraining>(Program.dbContext);
            return repo.ReadAll().ToList();
        }

        #region Write loaded information

        private TesteeTraining UpdateTesteeTraining(TesteeTraining testeeTraining, bool isActive)
        {
            testeeTraining.IsActive = isActive;
            testeeTraining.IsSelect = true;
            return testeeTraining;
        }

        public void UpdateTesteesTrainings(List<TesteeTraining> allTesteeTrainings)
        {
            EFTesteeTrainingRepository repo = new EFTesteeTrainingRepository(Program.dbContext);
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

        public void WriteTesteeTrainings(List<TesteeTrainingLink> testeeTraining)
        {
            var allTestees = Program.dbContext.Set<Testee>().ToList();
            var allTrainings = Program.dbContext.Set<Training>().ToList();
            testeeTraining = testeeTraining.Distinct().ToList();

            List<TesteeTraining> updatedTesteeTrainings = new List<TesteeTraining>();
            var existingTesteTrainings = new List<TesteeTraining>(Program.dbContext.Set<TesteeTraining>());

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

            UpdateTesteesTrainings(updatedTesteeTrainings);
        }      
    
        public void LoadTrainings()
        {
            Loader.LoadDataFromFile(@"D:\QuizTrainings\ISD_Report.xlsx");
            Loader.LoadQuestionFromFile(@"D:\QuizTrainings\Questions");

            List<string> trainingTitles = Loader.TesteesList.Select(_ => _.training).ToList();
            List<TesteeData> testees = Loader.TesteesTrainingsList;
            
            var loadedQuestions = Loader.LoadedQuestions;

            TrainingDataPprocessing.SynchronizeTrainings(trainingTitles.Distinct().ToList(), loadedQuestions);
            TesteeDataPprocessing.WriteTesteeFromLMS (testees.Distinct().ToList());

            WriteTesteeTrainings(Loader.TesteesList);
        }

        public void LoadTesteeFromEPE()
        {
            var loadedTestees = EPELoader.LoadTesteeFromEPE();
            TesteeDataPprocessing.SynchronizeTestees(loadedTestees);
        }

        public void LoadAdditionalQuestions()
        {
            Loader.LoadQuestionFromFile(@"D:\QuizTrainings\GeneralQuestions");
            var loadedQuestions = Loader.LoadedQuestions;
            TrainingDataPprocessing.SynchronizeAdditionalTrainings(loadedQuestions.Select(_=>_.Training).Distinct().ToList(), loadedQuestions);
            TesteeTrainingProcessing.SynchronizeTesteeTrainings(loadedQuestions.Select(_ => _.Training).Distinct().ToList());
        }
        
        #endregion

        public ApplicationSettingsDTO GetApplicationSettings()
        {
            return RegistrateDependencies.ApplicationSettingsService.GetSettings(Program.dbContext);
        }

        public ApplicationSettingsDTO SaveApplicationSettings(ApplicationSettingsDTO setting)
        {
            return (setting.Id == Guid.Empty)
             ? RegistrateDependencies.ApplicationSettingsService.SaveApplicationSettings(Program.dbContext, setting)
             : RegistrateDependencies.ApplicationSettingsService.UpdateApplicationSettings(Program.dbContext, setting);       
        }
    }
}
