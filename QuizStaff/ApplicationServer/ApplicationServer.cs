using ApplicationServer.DAL;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DomainModel;

namespace Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ApplicationServer : IApplicationServer
    {
        public string GetData(int value)
        {

            return string.Format("You entered: {0}", value);
        }

        public List<Testee> GetAllTestees()
        {
            QuizDBContext context = new QuizDBContext();
            context.Database.Initialize(true);
            EFRepository<Testee> repo = new EFRepository<DomainModel.Testee>();
            var testees = new List<Testee>();
            testees.Add(repo.ReadAll().First());
            return testees;
        
        }

        public Testee GetTestee()
        {
            QuizDBContext context = new QuizDBContext();
            context.Database.Initialize(true);
            EFRepository<Testee> repo = new EFRepository<DomainModel.Testee>();
            Testee t = new DomainModel.Testee();
            t.FirstName = "Testee";
            return t;

        }

        public void SaveAllTestees(List<Testee> testee)
        {
            // TODO save to database
        }
    }
}
