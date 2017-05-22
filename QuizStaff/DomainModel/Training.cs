using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Training : Entity
    {
        public string TrainingTitle { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdditional { get; set; }

        public virtual BindingList<Question> Questions { get; set; }
        public virtual BindingList<TesteeTraining> TesteeTrainings { get; set; }
    }
}
