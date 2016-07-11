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
            var testees = new List<Testee>(repo.ReadAll().Where(_=>_.IsActive));
            return testees.Select(testee => (TesteeDTO)testee).ToList();
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

        //public List<QuestionDTO> GetTrainingQuestions(TrainingDTO training)
        //{
        //    EFRepository<Question> repo = new EFRepository<DomainModel.Question>();
        //    var testees = new List<Question>(repo.ReadAll()) ;
        //    var t= (from p in testees.Select(testee => (QuestionDTO)testee) where p.TrainingId==training.Id select p ).ToList() ;
        //    return t;
        //}

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
            // TODO: implement logic for finding question 

            EFRepository<Testee> repo = new EFRepository<Testee>();
            var currentTestee = repo.Read(id);

            BindingList<Question> allQuestions = new BindingList<Question>();
            foreach(var t in currentTestee.Trainings)
            {
                foreach (var q in t.Training.Questions)
                {
                    allQuestions.Add(q);
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
                question = allQuestions.First();
            }
    
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

        public List<TrainingDTO> GetAllActiveTrainings()
        {
            EFRepository<Training> repo = new EFRepository<Training>();
            var trainings = new List<Training>(repo.ReadAll().Where(_=>_.IsActive));
            return trainings.Select(training => (TrainingDTO)training).ToList();
        }

        public List<TrainingDTO> GetAllTrainings()
        {
            EFRepository<Training> repo = new EFRepository<Training>();
            var trainings = new List<Training>(repo.ReadAll());
            return trainings.Select(training => (TrainingDTO)training).ToList();
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

        public void UpdateTraining(TrainingDTO training)
        {
            EFTrainingRepository repo = new EFTrainingRepository();
            repo.Update(Conversion.ConvertTrainingFromDTO_ForServer(training));
        }

        public TrainingDTO SaveTraining(TrainingDTO training)
        {
            EFTrainingRepository repo = new EFTrainingRepository();
            Training savedTrainings = Conversion.ConvertTrainingFromDTO_ForServer(training);
            repo.Create(savedTrainings);
            return (TrainingDTO)savedTrainings;
        }

        public void SaveQuestion(QuestionDTO question)
        {
            EFRepository<Question> repo = new EFRepository<Question>();
            Question newQuestion = Conversion.ConvertQuestionFromDTO(question);
            repo.Create(newQuestion);
        }

        public void UpdateTestee(TesteeDTO testee)
        {
            EFTesteeRepository repo = new EFTesteeRepository();
            repo.Update(Conversion.ConvertTesteeFromDTO_ForServer(testee));
        }

        public TesteeDTO SaveTestee(TesteeDTO testee)
        {
            EFTesteeRepository repo = new EFTesteeRepository();
            Testee savedTestee = Conversion.ConvertTesteeFromDTO_ForServer(testee);
            repo.Create(savedTestee);
            return (TesteeDTO)savedTestee;
        }

        public void UpdateSettings(SettingDTO setting)
        {
            EFRepository<Setting> repo = new EFRepository<DomainModel.Setting>();
            Setting newSetting = new Setting();

            newSetting.Id = setting.Id;
            newSetting.FrequencyOfAsking = setting.FrequencyOfAsking;
            newSetting.AmountOfQuestionsPerDay = setting.AmountOfQuestionsPerDay;
            newSetting.TimeOfStart = setting.TimeOfStart;
            newSetting.CanUserEdit = setting.CanUserEdit;
            newSetting.ShowCorrectAnswer = setting.ShowCorrectAnswer;

            repo.Update(newSetting);
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


        public TrainingDTO FindByTitle(string title)
        {
            EFRepository<Training> repo = new EFRepository<DomainModel.Training>();
            var result = repo.ReadAll().Where(_ => _.TrainingTitle == title ).FirstOrDefault();
            return (result != null) ? result : new TrainingDTO() { IsActive = true };
        }
    }
}
