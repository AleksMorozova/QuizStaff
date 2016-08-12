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
        public virtual Testee Testee { get; set; }
        public virtual Question Question { get; set; }
        public virtual DateTime AnsweringDate { get; set; }
        public virtual bool IsAnswerCorrect { get; set; }
        public virtual BindingList<TesteeAnswer> Answers { get; set; }
    }
}
