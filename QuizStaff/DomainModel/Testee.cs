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
        public string Email { get; set; }
        public string Login { get; set; }
        private string password;

        public List<History> Histories { get; set; }
        public List<Training> Trainings { get; set; }

        public Testee(string firstname, string lastname, string email)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Email = email;

            this.Login = string.Empty;
            password = string.Empty;

            Histories = new List<History>();
            Trainings = new List<Training>();
        }
    }
}
