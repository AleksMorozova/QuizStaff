using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.AddEditQuestionForm
{
    public class AddEditQuestionPresenter
    {   
        public IAddEditQuestionView view = null;

        public AddEditQuestionPresenter(IAddEditQuestionView projectsView)
        {
            view = projectsView;
        }

        public void LoadQuestion(Guid id) 
        {
            //if (id == Guid.Empty)
            //{
            //    view.Question = new QuestionDTO();
            //}
            //else 
            //{
            //    view.Question = ServicesHolder.ServiceClient.GetQuestion(id);
            //}

            view.Question = new QuestionDTO() { QuestionText = "Test question 2", 
               Answers = new List<AnswerDTO>() { new AnswerDTO(){AnswerText = "Test answer", IsCorrect = true}} };
        }
    }
}
