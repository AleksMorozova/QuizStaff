using DataTransferObject;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteeApplication.TesteeQuestion
{
    public class TesteeQuestionViewModel
    {
        public Question question;

        public void LoadQuestionForTestee(Testee currentTestee) 
        {
            var loadQuestion = ServicesHolder.ServiceClient.GetRandomQuestionForTestee(currentTestee.Id);
           
            if (loadQuestion!=null)
                question = Conversion.ConvertQuestionFromDTO_ForClient(loadQuestion);
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

        public bool FindWasAnswerCorrect(Dictionary<AnswerDTO, bool> answers)
        {
            var trueAnswers = answers.Where(x => x.Value == true).Select(x => x.Key).ToList();
            List<AnswerDTO> correctAnswer = new List<AnswerDTO>(); ;
            foreach (var a in  question.Answers.ToList().Where(_ => _.IsCorrect).ToList())
            {
                correctAnswer.Add(a);
            }
            return CompareLists(correctAnswer, trueAnswers); 
        }

        public static bool CompareLists(List<AnswerDTO> list1, List<AnswerDTO> list2)
        {

            if (list1.Count == list2.Count)
            {
                for (int i = 0; i < list1.Count; i++)
                {
                    if (!list1.Select(_=>_.Id).Contains(list2[i].Id))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
    }
}
