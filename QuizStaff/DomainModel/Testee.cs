using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Testee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private string email;
        private string login;
        private string password;

        List<History> Histories { get; set; }
        List<Training> Trainings { get; set; }

        public Testee(string firstname, string lastname, string email)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.email = email;

            login = string.Empty;
            password = string.Empty;

            Histories = new List<History>();
            Trainings = new List<Training>();
        }
    }
}
