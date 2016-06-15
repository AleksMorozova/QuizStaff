using DomainModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class QuestionDTO
    { 
        public  QuestionDTO()
        {
            Answers = new BindingList<AnswerDTO>();
        }

        public Guid Id { get; set; }
       
        public Guid TrainingId { get; set; }
      
        public bool IsActive { get; set; }

        public string QuestionText { get; set; }
       
        public virtual TrainingDTO Training { get; set; }

        public virtual BindingList<AnswerDTO> Answers { get; set; }

        public static implicit operator QuestionDTO(Question question)
        {
            QuestionDTO newQuestion = new QuestionDTO();
            newQuestion.Answers = new BindingList<AnswerDTO>();

            if (question != null)
            {
                Conversion.CopyProperty(question, newQuestion);
                foreach (var a in question.Answers)
                {
                    newQuestion.Answers.Add((AnswerDTO)a);
                }
            }
            return newQuestion;
        }
    }
}
