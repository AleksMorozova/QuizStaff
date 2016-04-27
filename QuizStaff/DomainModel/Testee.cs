using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Testee : Entity
    {
        public Testee()
        {
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public virtual Setting UserSetting { get; set; }
        public virtual ICollection<History> Histories { get; set; }
        public virtual ICollection<Training> Trainings { get; set; }
    }
}
