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

        public List<QuestionDTO> GetTrainingQuestions(TrainingDTO training)
        {
            EFRepository<Question> repo = new EFRepository<DomainModel.Question>();
            var testees = new List<Question>(repo.ReadAll()) ;
            var t= (from p in testees.Select(testee => (QuestionDTO)testee) where p.TrainingId==training.Id select p ).ToList() ;
            return t;
        }
        public void SaveTesteeAnswer(Guid testeeID, Guid questionID, DateTime date, List<Guid> answersID)
        {
            // TODO: save to database
        }

        public QuestionDTO GetRandomQuestionForTestee(Guid id)
        {
            // TODO: implement logic for finding question 

            BindingList<Answer> l = new BindingList<Answer>();
            l.Add(new Answer() { AnswerText = "This is answer first", IsCorrect = true, Id = Guid.NewGuid() });
            l.Add(new Answer() { AnswerText = "This is answer second", IsCorrect = true, Id = Guid.NewGuid() });
            l.Add(new Answer() { AnswerText = "This is answer third", IsCorrect = true, Id = Guid.NewGuid() });
            l.Add(new Answer() { AnswerText = "This is answer fourth", IsCorrect = true, Id = Guid.NewGuid() });
            var question = new Question() { QuestionText = "What you gonna do when they come for you?", Answers = l };
          
            return question;
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
            var trainings = new List<Training>(repo.ReadAll().Where(_=>_.IsActive));
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
            repo.Update(Conversion.ConvertTrainingFromDTO(training));
        }

        public void SaveTraining(TrainingDTO training)
        {
            EFTrainingRepository repo = new EFTrainingRepository();
            repo.Create(Conversion.ConvertTrainingFromDTO(training));
        }

        public void SaveQuestion(QuestionDTO training)
        {
            EFRepository<Question> repo = new EFRepository<Question>();
            Question newTraining = new Question();
            Conversion.CopyProperty(training, newTraining);
            repo.Create(newTraining);
        }

        public void UpdateTestee(TesteeDTO testee)
        {
            EFTesteeRepository repo = new EFTesteeRepository();
            Testee newTestee = new Testee();
            newTestee.UserSetting = new Setting();
            newTestee.Trainings = new BindingList<TesteeTraining>();
            Conversion.CopyProperty(testee, newTestee);
            Conversion.CopyProperty(testee.UserSetting, newTestee.UserSetting);
            if (testee.Trainings != null)
            {
                foreach (var t in testee.Trainings)
                {
                    TesteeTraining training = new TesteeTraining();
                    Conversion.CopyProperty(t, training);
                    newTestee.Trainings.Add(training);
                }
            }

            repo.Update(newTestee);
        }

        public void SaveTestee(TesteeDTO testee)
        {
            EFTesteeRepository repo = new EFTesteeRepository();
            Testee newTestee = new Testee();
            newTestee.Trainings = new BindingList<TesteeTraining>();
            Conversion.CopyProperty(testee, newTestee);
            if (testee.Trainings.Count() > 0)
            {
                foreach (var t in testee.Trainings)
                {
                    TesteeTraining training = new TesteeTraining();
                    Conversion.CopyProperty(t, training);
                    newTestee.Trainings.Add(training);
                }
            }
            repo.Create(newTestee);
        }

        public void UpdateSettings(SettingDTO setting)
        {
            EFRepository<Setting> repo = new EFRepository<DomainModel.Setting>();
            Setting newSetting = new Setting();
            Conversion.CopyProperty(setting, newSetting);
            repo.Update(newSetting);
        }

        public void UpdateQuestion(QuestionDTO question)
        {
            EFRepository<Question> repo = new EFRepository<Question>();
            Question newQuestion = new Question();
            Conversion.CopyProperty(question, newQuestion);
            repo.Update(newQuestion);
        }

        public void DeleteAnswer(AnswerDTO answer)
        {
            EFRepository<Answer> repo = new EFRepository<Answer>();
            Answer newAnswer = new Answer();
            Conversion.CopyProperty(answer, newAnswer);
            repo.Update(newAnswer);
        }
    }
}
