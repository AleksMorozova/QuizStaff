using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Question
    {
        public string QuestionText { get; set; }
        public Training Training{ get; set; }
        public List<Answer> Answers { get; set; }

        public Question(string questiontext, Training training)
        {
            this.QuestionText = questiontext;
            this.Training = training;
            Answers = new List<Answer>();
        }
    }
}
