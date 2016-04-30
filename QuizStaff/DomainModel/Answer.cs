using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Answer
    {
        public string AnswerText { get; set; }
        public bool IsCorrect { get; set; }
        public Answer(string answertext, bool iscorrect)
        {
            this.AnswerText = answertext;
            this.IsCorrect = iscorrect;
        }
    }
}
