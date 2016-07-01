using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Question : Entity
    {
        public Question() 
        {
            Answers = new BindingList<Answer>();
        }

        public bool IsActive { get; set; }
        public virtual Training Training { get; set; }
        public string QuestionText { get; set; }
        public virtual BindingList<Answer> Answers { get; set; }
    }
}
