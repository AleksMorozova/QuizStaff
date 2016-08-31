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

        public bool IsMultiSelect()
        {
            return question.Answers.Where(answer => answer.IsCorrect == true).Count() != 1;
        }

        public void SaveTesteeAnswer(List<Answer> answers)
        {
            var history = new HistoryDTO();
            history.AnsweringDate = DateTime.Now;
            history.Question = question;
            history.IsAnswerCorrect = FindWasAnswerCorrect(answers);
            history.Testee = Program.СurrentTestee;
            history.Answers = new System.ComponentModel.BindingList<TesteeAnswerDTO>();
            foreach (var a in answers)
            {
                history.Answers.Add(new TesteeAnswerDTO() { Answer = Conversion.ConvertAnswerToDTO(a)});
            }
            ServicesHolder.ServiceClient.SaveTesteeAnswer(history);
        }

        public bool FindWasAnswerCorrect(List<Answer> answers)
        {
            var trueAnswers = answers.ToList();
            List<Answer> correctAnswer = new List<Answer>(); ;
            foreach (var a in  question.Answers.ToList().Where(_ => _.IsCorrect).ToList())
            {
                correctAnswer.Add(a);
            }
            return CompareLists(correctAnswer, trueAnswers); 
        }

        public static bool CompareLists(List<Answer> list1, List<Answer> list2)
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
