using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
[DataContract]
    public class Testee : Entity
    {
        public Testee()
        {
        }
    [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        public string Password { get; set; }
        public virtual Setting UserSetting { get; set; }
        public virtual ICollection<History> Histories { get; set; }
        public virtual ICollection<TesteeTraining> Trainings { get; set; }

    }
}
