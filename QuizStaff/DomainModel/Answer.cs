using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Answer: Entity
    {
        public string AnswerText { get; set; }
        public bool IsCorrect { get; set; }
        public bool IsActive { get; set; }
        public virtual Question Question { get; set; }
    }
}
