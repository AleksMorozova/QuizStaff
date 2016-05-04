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
            var testees = new List<Testee>();
            var t = new Testee("Bogdan", "Nashilnik", "mail@gmail.com") { Login = "qwer" };
            var training = new Training("Философия улицы");
            training.Questions.Add(new Question("Хм?", training));
            t.Trainings.Add(training);
            t.Trainings.Add(new Training("Брат за брата"));
            testees.Add(t);
            testees.Add(new Testee("Oleg", "Lobanov", "mail@gmail.com") { Login = "qwer"});
            testees.Add(new Testee("Fedor", "Voloshin", "mail@gmail.com") { Login = "qwer" });
            testees.Add(new Testee("Nikita", "Tsyhankov", "mail@gmail.com") { Login = "qwer" });
            testees.Add(new Testee("Valeriy", "Baditsa", "mail@gmail.com") { Login = "qwer" });
            return testees;
        
        }

        public List<Training> GetAllTrainings()
        {
            List<Training> trainingList = new List<Training>();
            trainingList.Add(new Training("Training_1"));
            trainingList.Add(new Training("Training_2"));
            trainingList.Add(new Training("Training_3"));
            trainingList.Add(new Training("Training_4"));

            return trainingList;
        }

        public void SaveAllTestees(List<Testee> testee)
        {
            // TODO save to database
        }

        public void SaveAllTrainings(List<Training> trainingList)
        {
            // TODO save to database
        }

    }
}
