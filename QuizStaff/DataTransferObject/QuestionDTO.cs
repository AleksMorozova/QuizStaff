using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class QuestionDTO
    {
        public Guid Id { get; set; }
        public Guid TrainingId { get; set; }
        public string QuestionText { get; set; }
        public virtual Training Training { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }

        public static implicit operator QuestionDTO(Question question)
        {
            QuestionDTO newQuestion = new QuestionDTO();
            Conversion.CopyProperty(question, newQuestion);
            return newQuestion;
        }
    }
}
