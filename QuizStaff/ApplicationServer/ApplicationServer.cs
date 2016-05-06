using ApplicationServer.DAL;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DomainModel;
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

        public List<QuestionDTO> GetTrainingQuestions(TrainingDTO training)
        {
            EFRepository<Question> repo = new EFRepository<DomainModel.Question>();
            var testees = new List<Question>(repo.ReadAll());
            return testees.Select(testee => (QuestionDTO)testee).ToList();
        }
    }
}
