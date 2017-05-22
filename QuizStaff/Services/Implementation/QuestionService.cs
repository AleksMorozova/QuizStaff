using DAL;
using DAL.Repositories;
using DataTransferObject;
using DomainModel;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementation
{
    public class QuestionService: IQuestionService
    {
        public void UpdateQuestion(QuizDBContext dbContext, QuestionDTO question)
        {
            EFRepository<Question> repo = new EFRepository<Question>(dbContext);
            Question newQuestion = Conversion.ConvertQuestionFromDTO(question);
            repo.Update(newQuestion);
        }

        public QuestionDTO GetRandomQuestionForTestee(QuizDBContext dbContext, Guid id)
        {
            EFRepository<Testee> repo = new EFRepository<Testee>(dbContext);
            var currentTestee = repo.Read(id);

            BindingList<Question> allQuestions = new BindingList<Question>();
            foreach (var training in currentTestee.Trainings)
            {
                if (training.IsSelect && training.Training.IsActive)
                {
                    foreach (var trainingQuestion in training.Training.Questions)
                    {
                        allQuestions.Add(trainingQuestion);
                    }
                }
            }

            Question question = new Question();

            if (allQuestions.Count() > 1)
            {
                Random rnd = new Random();
                int index = rnd.Next(0, allQuestions.Count() - 1);
                question = allQuestions.ElementAt(index);
            }
            else
            {
                question = allQuestions.FirstOrDefault();
            }

            if (question == null)
                return null;

            return (QuestionDTO)question;
        }

        public void UpdateAnswer(QuizDBContext dbContext, AnswerDTO answer)
        {
            EFRepository<Answer> repo = new EFRepository<Answer>(dbContext);
            Answer newAnswer = Conversion.ConvertAnswerFromDTO(answer);
            repo.Update(newAnswer);
        }
    }
}
