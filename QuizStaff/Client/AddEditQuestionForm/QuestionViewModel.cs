using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.AddEditQuestionForm
{
    public class QuestionViewModel
    {
        //public virtual string Question { get; set; }
        //public virtual List<AnswerDTO> Answers { get; set; }

        public QuestionDTO Question { get; set; }

        public void SaveQuestion(QuestionDTO question) 
        {
            //ServicesHolder.ServiceClient.SaveAnswer(question);
            //TODO: save question
            //if (id != Guid.Empty)
            //{
            //  update question

            //}
        }

        public void Cancel()
        {
            //TODO: cancel edeting 
        }

        public void LoadQuestion(Guid id)
        {
            //if (id == Guid.Empty)
            //{
            //    this.Question = new QuestionDTO();
            //}
            //else 
            //{
            //    this.Question = ServicesHolder.ServiceClient.GetQuestion(id);
            //}

            this.Question = new QuestionDTO()
            {
                QuestionText = "Test question 2",
                Answers = new List<AnswerDTO>() { new AnswerDTO() { AnswerText = "Test answer", IsCorrect = true } }
            };
        }
    }
}
