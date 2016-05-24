using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.AddEditQuestionForm
{
    public class QuestionViewModel
    {
        public QuestionDTO Question { get; set; }

        public void SaveQuestion(QuestionDTO question) 
        {
            if (question != null)
            {
                if (question.Id != Guid.Empty)
                {
                    ServicesHolder.ServiceClient.UpdateQuestion(question);
                }
            }
        }

        public void Cancel()
        {
            //TODO: cancel edeting 
        }

        public void LoadQuestion(Guid id)
        {
            if (id == Guid.Empty)
            {
                this.Question = new QuestionDTO();
            }
            else
            {
                this.Question = ServicesHolder.ServiceClient.GetQuestion(id);
            }
        }
    }
}
