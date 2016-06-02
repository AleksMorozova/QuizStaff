using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.TesteeQuestion
{
    public class TesteeQuestionViewModel
    {
        public QuestionDTO question;

        public void LoadQuestionForTestee(TesteeDTO currentTestee) 
        {
            question = ServicesHolder.ServiceClient.GetRandomQuestionForTestee(new Guid());
        }

        public bool MultiSelect
        {
            get
            {
                return question.Answers.Where(answer => answer.IsCorrect == true).Count() != 1;
            }
        }

        public void SaveTesteeAnswer(Dictionary<Guid, bool> answers)
        {
            if (answers.Where(x => x.Value == true).Count() == 0)
            {
                //this.form.NotifyNoAnswersChecked();
            }
            else
            {
                var trueAnswers = answers.Where(x => x.Value == true).Select(x => x.Key).ToArray();
                //this.server.SaveTesteeAnswer(this.testee.Id, this.question.Id, DateTime.Now, trueAnswers);
            }
        }
    }
}
