using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class History
    {
        public Testee Testee { get; set; }
        public Question Question { get; set; }
        public DateTime Date { get; set; }
        public List<UserAnswers> Answers { get; set; }

        public History(Testee testee, Question question, DateTime date)
        {
            this.Testee = testee;
            this.Question = question;
            this.Date = date;
            Answers = new List<UserAnswers>();
        }

    }
}
