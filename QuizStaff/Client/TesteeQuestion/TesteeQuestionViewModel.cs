using DataTransferObject;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.TesteeQuestion
{
    public class TesteeQuestionViewModel
    {
        public Question question;

        public void LoadQuestionForTestee(Testee currentTestee) 
        {
            var loadQuestion = ServicesHolder.ServiceClient.GetRandomQuestionForTestee(currentTestee.Id);
            question = Conversion.ConvertQuestionFromDTO(loadQuestion);
        }

        public bool MultiSelect
        {
            get
            {
                return question.Answers.Where(answer => answer.IsCorrect == true).Count() != 1;
            }
        }

        public void SaveTesteeAnswer(Dictionary<AnswerDTO, bool> answers)
        {
            if (answers.Where(x => x.Value == true).Count() == 0)
            {
                //this.form.NotifyNoAnswersChecked();
            }
            else
            {
                var trueAnswers = answers.Where(x => x.Value == true).Select(x => x.Key).ToArray();
                var history = new HistoryDTO();
                history.AnsweringDate = DateTime.Now;
                history.Question = question;
                history.Testee = Program.currentTestee;
                history.Answers = new System.ComponentModel.BindingList<TesteeAnswerDTO>();
                foreach (var a in trueAnswers)
                    history.Answers.Add(new TesteeAnswerDTO() { Answer = a });
                ServicesHolder.ServiceClient.SaveTesteeAnswer(history);
            }
        }
    }
}
