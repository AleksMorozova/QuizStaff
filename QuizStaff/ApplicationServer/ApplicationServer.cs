using ApplicationServer.DAL;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DataTransferObject;

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

        public string GetData(int value)
        {

            return string.Format("You entered: {0}", value);
        }

        public List<TesteeDTO> GetAllTestees()
        {
            EFRepository<Testee> repo = new EFRepository<DomainModel.Testee>();
            var testees = new List<Testee>(repo.ReadAll());
            return testees.Select(testee => (TesteeDTO)testee).ToList();
        }

        public Testee GetTestee()
        {
            EFRepository<Testee> repo = new EFRepository<DomainModel.Testee>();
            Testee t = new DomainModel.Testee();
            t.FirstName = "Testee";
            return t;
        }

        public void SaveAllTestees(ICollection<TesteeDTO> testee)
        {
            // TODO: save to database
        }

        public List<Question> GetTrainingQuestions(Training training)
        {
            var questions = new List<Question>();
            //var first = new Question("первый вопрос", training);
            //var second = new Question("второй вопрос", training);

            //first.Answers.Add(new Answer("правильный", true));
            //first.Answers.Add(new Answer("неправильный", false));
            //first.Answers.Add(new Answer("тоже правильный", true));

            //second.Answers.Add(new Answer("правильный", true));
            //second.Answers.Add(new Answer("неправильный", false));
            //second.Answers.Add(new Answer("совсем неправильный", false));

            //questions.Add(first);
            //questions.Add(second);

            return questions;
        }

        public void SaveAllQuestions(Training training, List<Question> questions)
        {
            // Todo: save to database
        }

        public void SaveTesteeAnswer(Guid testeeID, Guid questionID, DateTime date, List<Guid> answersID)
        {
            // TODO: save to database
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
    }
}
