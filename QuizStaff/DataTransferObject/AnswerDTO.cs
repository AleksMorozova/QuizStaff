using DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class AnswerDTO 
    {
        public Guid Id { get; set; }
       
        public bool IsActive { get; set; }
      
        public string AnswerText { get; set; }
       
        public bool IsCorrect { get; set; }

        public static implicit operator AnswerDTO(Answer answer)
        {
            AnswerDTO newAnswer = Conversion.ConvertAnswerToDTO(answer);
            return newAnswer;
        }
    }
}
