using ApplicationServer.DAL;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DataTransferObject;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ApplicationServer : IApplicationServer
    {
        QuizDBContext context;

        public ApplicationServer()
        {
            context = new QuizDBContext();
            context.Database.Initialize(true);
        }

        public List<TesteeDTO> GetAllTestees()
        {
            EFRepository<Testee> repo = new EFRepository<DomainModel.Testee>();

            var selectedTestee = repo.ReadAll().Where(x => x.IsActive).AsQueryable()
                .Select(testee => new Testee
                {
                    Id = testee.Id,
                    FirstName = testee.FirstName,
                    LastName = testee.LastName,
                    Login = testee.Login,
                    Password = testee.Password,
                    IsActive = testee.IsActive,
                    Email = testee.Email,
                    
                    Attribute1 = testee.Attribute1,
                    Attribute2 = testee.Attribute2,
                    Attribute3 = testee.Attribute3,
                    Attribute4 = testee.Attribute4,
                    Attribute5 = testee.Attribute5,
                    Attribute6 = testee.Attribute6,
                    Attribute8 = testee.Attribute8,
                    Attribute9 = testee.Attribute9,
                    Attribute10 = testee.Attribute10,

                    UserSetting = testee.UserSetting,
                    Trainings = new BindingList<TesteeTraining>(testee.Trainings.ToList().Where(_ => _.IsActive).ToList()),
                    Roles = new BindingList<TesteeRoles>(testee.Roles.ToList()),
                    Histories = new BindingList<History>(testee.Histories.ToList())

                }).ToList();

            return selectedTestee.Select(testee => (TesteeDTO)testee).ToList();
        }

        public TesteeDTO GetTesteeByID(Guid id)
        {
            EFRepository<Testee> repo = new EFRepository<DomainModel.Testee>();
            Testee currentTestee = repo.Read(id);
            return currentTestee;
        }

        public void SaveAllTestees(ICollection<TesteeDTO> testee)
        {
            // TODO: save to database
        }

        public void SaveTesteeAnswer(HistoryDTO history)
        {
            EFHistoryRepository repo = new EFHistoryRepository();
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
            repo.Create(h);
        }

        public QuestionDTO GetRandomQuestionForTestee(Guid id)
        {
            EFRepository<Testee> repo = new EFRepository<Testee>();
            var currentTestee = repo.Read(id);

            BindingList<Question> allQuestions = new BindingList<Question>();
            foreach(var t in currentTestee.Trainings)
            {
                if (t.IsSelect)
                {
                    foreach (var q in t.Training.Questions)
                    {
                        allQuestions.Add(q);
                    }
                }
            }

            Question question = new Question();

            if (allQuestions.Count() > 1)
            {
                Random rnd = new Random();
                int index = rnd.Next(0, allQuestions.Count() - 1);
                question = allQuestions.ElementAt(index);
            }
            else 
            {
                question = allQuestions.FirstOrDefault();
            }

            if (question == null)
                return null;

            return (QuestionDTO)question;
        }

        #region Client's settings  
        public Boolean SetUsersSettings(SettingDTO sets, Guid id)
        {
            // Save to database
            try
            {
                return true;
            }
            catch
            {
                return false;
            }
        }

        public SettingDTO GetUsersSettings(Guid id)
        {
            Setting sets = new Setting() { AmountOfQuestionsPerDay = 1,
                                                FrequencyOfAsking = 1,
                                                    TimeOfStart = new DateTime(2016, 5, 8, 10, 10, 10, 10) };
            return sets;
        }
        #endregion

        public List<TrainingDTO> GetAllTrainings()
        {
            EFRepository<Training> repo = new EFRepository<Training>();
            var trainings = new List<Training>(repo.ReadAll());
            return trainings.Select(training => (TrainingDTO)training).ToList();
        }

        public List<TrainingDTO>GetAllActiveTrainings()
        {
            EFRepository<Training> repo = new EFRepository<Training>();

            var selectedTrainings = repo.ReadAll().Where(x => x.IsActive).AsQueryable()
                .Select(training => new Training
                {
                    Id = training.Id,
                    TrainingTitle = training.TrainingTitle,
                    IsActive = training.IsActive,
                    TesteeTrainings = new BindingList<TesteeTraining>(training.TesteeTrainings.ToList().Where(_ => _.IsActive).ToList()),
                    Questions = new BindingList<Question>(training.Questions.ToList().Where(_ => _.IsActive)
                        .Select(question => new Question
                        {
                            Id = question.Id,
                            QuestionText = question.QuestionText,
                            IsActive = question.IsActive,
                            Training = question.Training,
                            Answers = new BindingList<Answer>(question.Answers.ToList().Where(_ => _.IsActive).ToList()),
                        }).ToList()),
                }).ToList();

            return selectedTrainings.Select(training => (TrainingDTO)training).ToList();
        }

        public void SaveAllTrainings(ICollection<TrainingDTO> trainings)
        {
            // TODO: save to database
        }       

        public TesteeDTO FindByLogin(string login)
        {
            EFRepository<Testee> repo = new EFRepository<DomainModel.Testee>();
            var result = repo.ReadAll().Where(_ => _.Login == login && _.IsActive).FirstOrDefault();
            return (result != null) ? result : new TesteeDTO() { IsActive = true};
        }

        public void SaveAnswer(QuestionDTO question) 
        {
            EFRepository<Question> repo = new EFRepository<Question>();
            //repo.Create((Question)question);
        }

        public TrainingDTO UpdateTraining(TrainingDTO training)
        {
            EFTrainingRepository repo = new EFTrainingRepository();
            Training updateTrainings = Conversion.ConvertTrainingFromDTO(training);
            repo.Update(updateTrainings);
            return (TrainingDTO)updateTrainings;
        }

        public TrainingDTO SaveTraining(TrainingDTO training)
        {
            EFTrainingRepository repo = new EFTrainingRepository();
            Training savedTrainings = Conversion.ConvertTrainingFromDTO(training);
            repo.Create(savedTrainings);
            return (TrainingDTO)savedTrainings;
        }

        public void SaveQuestion(QuestionDTO question)
        {
            EFRepository<Question> repo = new EFRepository<Question>();
            Question newQuestion = Conversion.ConvertQuestionFromDTO(question);
            repo.Create(newQuestion);
        }

        public TesteeDTO UpdateTestee(TesteeDTO testee)
        {
            EFTesteeRepository repo = new EFTesteeRepository();
            Testee updatedTestee = Conversion.ConvertTesteeFromDTO(testee);
            repo.Update(updatedTestee);
            return (TesteeDTO)updatedTestee;
        }
        public void UpdateSomeTestees(TesteeDTO[] testeeArray)
        {
            EFTesteeRepository repo = new EFTesteeRepository();
            foreach (var testee in testeeArray)
            {
                Testee updatedTestee = Conversion.ConvertTesteeFromDTO(testee);
                repo.Update(updatedTestee);
            }
        }

        public TesteeDTO SaveTestee(TesteeDTO testee)
        {
            EFTesteeRepository repo = new EFTesteeRepository();
            Testee savedTestee = Conversion.ConvertTesteeFromDTO(testee);
            repo.Create(savedTestee);
            return (TesteeDTO)savedTestee;
        }

        public void UpdateSettings(SettingDTO[] settings)
        {
            EFRepository<Setting> repo = new EFRepository<DomainModel.Setting>();
            foreach(var setting in settings.ToList())
            {
                Setting newSetting = new Setting();
                newSetting.Id = setting.Id;
                newSetting.FrequencyOfAsking = setting.FrequencyOfAsking;
                newSetting.AmountOfQuestionsPerDay = setting.AmountOfQuestionsPerDay;
                newSetting.TimeOfStart = setting.TimeOfStart;
                newSetting.CanUserEdit = setting.CanUserEdit;
                newSetting.ShowCorrectAnswer = setting.ShowCorrectAnswer;
                
                repo.Update(newSetting);
            }      
        }

        public void UpdateQuestion(QuestionDTO question)
        {
            EFRepository<Question> repo = new EFRepository<Question>();
            Question newQuestion = Conversion.ConvertQuestionFromDTO(question);
            repo.Update(newQuestion);
        }

        public void DeleteAnswer(AnswerDTO answer)
        {
            EFRepository<Answer> repo = new EFRepository<Answer>();
            Answer newAnswer = Conversion.ConvertAnswerFromDTO(answer);
            repo.Update(newAnswer);
        }

        public void DeleteTesteeTraining(TesteeTrainingDTO testeeTraining) 
        {
            EFRepository<TesteeTraining> repo = new EFRepository<TesteeTraining>();
            repo.Update(Conversion.ConvertTesteeTrainingFromDTO(testeeTraining));
        }

        public void UpdateTesteeTraining(TesteeTrainingDTO[] testeeTrainings)
        {
            EFTesteeTrainingRepository repo = new EFTesteeTrainingRepository();
            foreach(var testeeTraining in testeeTrainings)
            {
                TesteeTraining updateTesteeTraining = Conversion.ConvertTesteeTrainingFromDTO(testeeTraining);
                repo.Update(updateTesteeTraining);
            }
        }

        public TrainingDTO FindByTitle(string title)
        {
            EFRepository<Training> repo = new EFRepository<DomainModel.Training>();
            var result = repo.ReadAll().Where(_ => _.TrainingTitle == title ).FirstOrDefault();
            return (result != null) ? result : new TrainingDTO() { IsActive = true };
        }


        public List<RoleDTO> GetAllRoles()
        {
            EFRepository<Role> repo = new EFRepository<Role>();
            var roles = new List<Role>(repo.ReadAll());
            return roles.Select(role => (RoleDTO)role).ToList();
        }

        public List<PermissionDTO> GetAllPermissions()
        {
            EFRepository<Permission> repo = new EFRepository<Permission>();
            var permissions = new List<Permission>(repo.ReadAll());
            return permissions.Select(permission => (PermissionDTO)permission).ToList();
        }


        public void UpdateRoles(RoleDTO role)
        {            
            EFRoleRepository repo = new EFRoleRepository();
            if (role.Id == Guid.Empty)
                {
                    repo.Create(Conversion.ConvertRoleFromDTO(role));
                }
                else 
                { 
                    repo.Update(Conversion.ConvertRoleFromDTO(role));
                }
        }

        public void UpdatePermissions(PermissionDTO permission)
        {
            Permission savedPermission = new Permission();
            savedPermission.Id = permission.Id;
            savedPermission.Title = permission.Title;

            EFPermissionRepository repo = new EFPermissionRepository();
            if (permission.Id == Guid.Empty)
            {
                repo.Create(savedPermission);
            }
            else
            {
                repo.Update(savedPermission);
            }
        }


        public void AddTesteeRole(TesteeDTO testee, RoleDTO role)
        {
            EFTesteeRepository repo = new EFTesteeRepository();
            testee.Roles.Add(new TesteeRolesDTO() { Role = role, IsActive = false });
            repo.Update(Conversion.ConvertTesteeFromDTO(testee));
        }
    }
}
