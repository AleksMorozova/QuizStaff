using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class History: Entity
    {
        public History()
        {
        }

        public Guid TesteeId { get; set; }
        public Guid QuestionId { get; set; }

        public virtual Testee Testee { get; set; }
        public virtual Question Question { get; set; }
        public virtual DateTime AnsweringDate { get; set; }
        public virtual ICollection<TesteeAnswer> Answers { get; set; }
    }
}
