using ApplicationServer.DAL;
using DataTransferObject;
using DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationServer;
using LoadDataFromLMS;

namespace ApplicationServer
{
    public class ApplicationServer : IApplicationServer
    {
        public static QuizDBContext dbContext;

        public ApplicationServer()
        {
            dbContext = new QuizDBContext();
            dbContext.Database.Initialize(true);
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

        public List<TesteeDTO> GetAllTesteesForReport(DateTime from, DateTime to)
        {
            EFRepository<Testee> repo = new EFRepository<DomainModel.Testee>();

            var selectedTestee = repo.ReadAll().Where(x => x.IsActive).AsQueryable()
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
                    Attribute8 = testee.Attribute8,
                    Attribute9 = testee.Attribute9,
                    Attribute10 = testee.Attribute10,

                    UserSetting = testee.UserSetting,
                    Trainings = new BindingList<TesteeTraining>(testee.Trainings.ToList().Where(_ => _.IsActive).ToList()),
                    Roles = new BindingList<TesteeRoles>(testee.Roles.ToList()),
                    Histories = new BindingList<History>(testee.Histories.Where(_=> _.AnsweringDate >= from && _.AnsweringDate < to).ToList())

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
            h.IsAnswerCorrect = history.IsAnswerCorrect;
            repo.Create(h);
        }

        public QuestionDTO GetRandomQuestionForTestee(Guid id)
        {
            EFRepository<Testee> repo = new EFRepository<Testee>();
            var currentTestee = repo.Read(id);

            BindingList<Question> allQuestions = new BindingList<Question>();
            foreach (var t in currentTestee.Trainings)
            {
                if (t.IsSelect && t.Training.IsActive)
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

        public List<TrainingDTO> GetAllTrainings()
        {
            EFRepository<Training> repo = new EFRepository<Training>();
            var trainings = new List<Training>(repo.ReadAll());
            return trainings.Select(training => (TrainingDTO)training).ToList();
        }

        public List<TrainingDTO> GetAllActiveTrainings()
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
            EFRepository<Testee> repo = new EFRepository<Testee>();
            Testee result;
            if (login == "admin")
                result = repo.ReadAll().Where(_ => _.Login == login).FirstOrDefault();
            else
                result = repo.ReadAll().Where(_ => _.Login == login && _.IsActive).FirstOrDefault();
            return (result != null) ? result : new TesteeDTO() { IsActive = true, UserSetting = new Setting() { TimeOfStart = DateTime.Now, Recurrence = RecurrenceType.WithoutEnding, Minutes = 5 } };
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
            foreach (var setting in settings.ToList())
            {
                Setting newSetting = new Setting();
                newSetting.Id = setting.Id;
                newSetting.Hours = setting.Hours;
                newSetting.Minutes = setting.Minutes;
                newSetting.Seconds = setting.Seconds;
                setting.EndDate = (setting.EndDate != DateTime.MinValue) ? setting.EndDate : DateTime.MaxValue;
                newSetting.Recurrence = setting.Recurrence;
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

        public void UpdateTesteeTrainings(TesteeTrainingDTO[] testeeTrainings)
        {
            EFTesteeTrainingRepository repo = new EFTesteeTrainingRepository();
            foreach (var testeeTraining in testeeTrainings)
            {
                TesteeTraining updateTesteeTraining = Conversion.ConvertTesteeTrainingFromDTO(testeeTraining);
                repo.Update(updateTesteeTraining);
            }
        }

        public void UpdateTesteeTraining(TesteeTrainingDTO testeeTraining)
        {
            EFTesteeTrainingRepository repo = new EFTesteeTrainingRepository();
            TesteeTraining updateTesteeTraining = Conversion.ConvertTesteeTrainingFromDTO(testeeTraining);
            repo.Update(updateTesteeTraining);
        }

        public TrainingDTO FindByTitle(string title)
        {
            EFRepository<Training> repo = new EFRepository<DomainModel.Training>();
            var result = repo.ReadAll().Where(_ => _.TrainingTitle == title).FirstOrDefault();
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
            savedPermission.Type = permission.Type;

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

        public void UpdateAnswer(AnswerDTO answer)
        {
            EFRepository<Answer> repo = new EFRepository<Answer>();
            Answer newAnswer = Conversion.ConvertAnswerFromDTO(answer);
            repo.Update(newAnswer);
        }
        public List<TesteeTraining> FindTesteesTrainings()
        {
            EFRepository<TesteeTraining> repo = new EFRepository<TesteeTraining>();
            return repo.ReadAll().ToList();
        }

        #region Write loaded information

        public void WriteTrainings(List<string> trainingTitles)
        {
            Loader.LoadQuestionFromFile(@"C:\Users\omor\Desktop\Questions");
            var loadedQuestions = Loader.LoadedQuestions;
            EFRepository<Question> questionRepo = new EFRepository<Question>();

            trainingTitles = trainingTitles.Distinct().ToList();
            List<Training> trainings = new List<Training>();
            EFTrainingRepository repo = new EFTrainingRepository();
            var allTrainings = new List<Training>(repo.ReadAll());

            trainings.AddRange((from title in trainingTitles
                                select new { title }).AsEnumerable().Select(x =>
                                {
                                    return (allTrainings.Select(_ => _.TrainingTitle).Contains(x.title))
                                        ? UpdateTraining(allTrainings.Where(_ => _.TrainingTitle == x.title).First(), true, loadedQuestions.Where(_ => _.Training == x.title).ToList())
                                        : new Training() { TrainingTitle = x.title, IsActive = true, Questions = AddQuestions(loadedQuestions.Where(_ => _.Training == x.title).ToList()) };
                                }));

            trainings.AddRange(allTrainings.Except(trainings).Select(x => UpdateTraining(x, false, loadedQuestions.Where(_ => _.Training == x.TrainingTitle).ToList())));

            UpdateTrainings(trainings);
        }

        private BindingList<Question> AddQuestions(List<LoadedQuestion> list)
        {
            BindingList<Question> questions = new BindingList<Question>();

            foreach (var q in list)
            {
                Question question = new Question();
                question.QuestionText = q.Question;
                question.Answers = new BindingList<Answer>();
                foreach (var a in q.Answers)
                {
                    Answer answer = new Answer();
                    answer.AnswerText = a.Answer;
                    answer.IsCorrect = (a.IsCorrect == "correct");
                    answer.IsActive = true;
                }
                question.IsActive = true;
            }
            return questions;
        }

        private Training UpdateTraining(Training training, bool isActive, List<LoadedQuestion> questions)
        {
            var allQuestion = questions.Select(_ => _.Question);
            BindingList<Question> newQuestion = new BindingList<Question>();
            List<Question> activeQuestion = new List<Question>();
            List<Question> updatedQuestion = new List<Question>();

            foreach (var q in questions)
            {
                if (training.Questions.Select(_ => _.QuestionText).Contains(q.Question))
                {
                    //check answer
                    activeQuestion.Add(training.Questions.FirstOrDefault(_ => _.QuestionText == q.Question));
                }
                else
                {
                    //create new question
                    var loadedQuestion = questions.Where(_ => _.Question == q.Question).FirstOrDefault();
                    if (loadedQuestion != null)
                    {
                        Question question = new Question();
                        question.QuestionText = loadedQuestion.Question;
                        question.IsActive = true;
                        question.Answers = new BindingList<Answer>();
                        newQuestion.Add(question);
                    }
                }
            }

            var unActiveTraining = training.Questions.Except(activeQuestion).ToList();

            foreach (var q in newQuestion)
            {
                training.Questions.Add(q);
            }

            activeQuestion.ForEach(q => UpdateQuestion(q, true));
            unActiveTraining.ForEach(q => UpdateQuestion(q, false));

            updatedQuestion.AddRange(activeQuestion);
            updatedQuestion.AddRange(unActiveTraining);

            UpdateQuestions(updatedQuestion);

            training.IsActive = isActive;
            return training;
        }

        public void UpdateTrainings(List<Training> allTrainings)
        {
            EFTrainingRepository repo = new EFTrainingRepository();
            foreach (var training in allTrainings)
            {
                if (training.Id == Guid.Empty)
                {
                    repo.Create(training);
                }
                else
                {
                    repo.Update(training);
                }
            }
        }

        public void UpdateQuestions(List<Question> questions)
        {
            EFRepository<Question> repo = new EFRepository<Question>();
            foreach (var question in questions)
            {
                if (question.Id != Guid.Empty)
                {
                    repo.Update(question);
                }
            }
        }

        public Question UpdateQuestion(Question question, bool isActive)
        {
            question.IsActive = isActive;
            return question;
        }

        public void WriteTestee(List<TesteeData> testees)
        {
            EFRoleRepository roleRepo = new EFRoleRepository();

            Role role = roleRepo.ReadAll().Where(_ => _.Name == "Testee").FirstOrDefault();
            List<Testee> savedTestee = new List<Testee>();
            EFTesteeRepository repo = new EFTesteeRepository();

            var testeeLogin = testees.Select(_ => _.login).ToList();
            var allTestees = dbContext.Set<Testee>().ToList();

            savedTestee.AddRange((from testee in testees
                                  select new { testee }).AsEnumerable().Select(x =>
                                  {
                                      return (allTestees.Select(_ => _.Login).Contains(x.testee.login))
                                          ? UpdateTestee(allTestees.Where(_ => _.Login == x.testee.login).First(), true)
                                          : new Testee()
                                          {
                                              Login = x.testee.login,
                                              FirstName = x.testee.firstName,
                                              LastName = x.testee.lastName,
                                              Attribute1 = x.testee.department,
                                              Attribute2 = x.testee.possition,
                                              Attribute3 = x.testee.managerLogin,
                                              IsActive = true,
                                              UserSetting = new Setting() { Minutes = 5, AmountOfQuestionsPerDay = 10, TimeOfStart = DateTime.Now, EndDate = DateTime.Now, Recurrence = RecurrenceType.WithExactRepeated },
                                              Trainings = new BindingList<TesteeTraining>(),
                                              Roles = new BindingList<TesteeRoles>() { new TesteeRoles() { Role = role } }
                                          };
                                  }));

            savedTestee.AddRange(allTestees.Except(savedTestee).Select(x => UpdateTestee(x, false)));

            UpdateTestees(savedTestee, repo);
        }

        public void UpdateTestees(List<Testee> allTestee, EFTesteeRepository repo)
        {
            foreach (var testee in allTestee)
            {
                if (testee.Login != "val_edu" || testee.Login != "tkas_edu" || testee.Login != "atok_edu" || testee.Login != "omor")
                {
                    if (testee.Id == Guid.Empty)
                    {
                        repo.Create(testee);
                    }
                    else
                    {
                        repo.Update(testee);
                    }

                }
            }
        }

        private Testee UpdateTestee(Testee testee, bool isActive)
        {
            testee.IsActive = isActive;
            return testee;
        }

        private TesteeTraining UpdateTesteeTraining(TesteeTraining testeeTraining, bool isActive)
        {
            testeeTraining.IsActive = isActive;
            testeeTraining.IsSelect = true;
            return testeeTraining;
        }

        public void UpdateTesteesTrainings(List<TesteeTraining> allTesteeTrainings)
        {
            EFTesteeTrainingRepository repo = new EFTesteeTrainingRepository();
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
            QuizDBContext dbContext = new QuizDBContext();

            var allTestees = dbContext.Set<Testee>().ToList();
            var allTrainings = dbContext.Set<Training>().ToList();
            testeeTraining = testeeTraining.Distinct().ToList();

            List<TesteeTraining> updatedTesteeTrainings = new List<TesteeTraining>();
            var existingTesteTrainings = new List<TesteeTraining>(dbContext.Set<TesteeTraining>());

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
            Loader.LoadDataFromFile(@"C:\Users\omor\Desktop\ISD_Report_20160914.xlsx");

            List<string> trainingTitles = Loader.TesteesList.Select(_ => _.training).ToList();
            List<TesteeData> testees = Loader.TesteesTrainingsList;

            WriteTrainings(trainingTitles.Distinct().ToList());
            WriteTestee(testees.Distinct().ToList());

            WriteTesteeTrainings(Loader.TesteesList);
        }

        #endregion
    }
}
