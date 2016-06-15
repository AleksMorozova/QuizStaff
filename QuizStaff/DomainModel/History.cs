using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class History: Entity
    {
        public Guid TesteeId { get; set; }
        public Guid QuestionId { get; set; }

        public virtual Testee Testee { get; set; }
        public virtual Question Question { get; set; }
        public virtual DateTime AnsweringDate { get; set; }
        public virtual BindingList<TesteeAnswer> Answers { get; set; }
    }
}
