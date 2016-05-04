using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Training : Entity
    {
        public Training()
        {
        }

        public String TrainingTitle { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<TesteeTraining> TesteeTrainings { get; set; }
    }
}
