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
    public class HistoryService: IHistoryService
    {
        public void SaveTesteeAnswer(QuizDBContext context,  HistoryDTO history)
        {
            EFHistoryRepository repo = new EFHistoryRepository(context);
            History savedHistory = new History();
            savedHistory.Answers = new BindingList<TesteeAnswer>();
            foreach (var a in history.Answers)
            {
                TesteeAnswer answer = new TesteeAnswer();

                answer.Answer = new Answer();
                answer.Answer.AnswerText = a.Answer.AnswerText;
                answer.Answer.Id = a.Answer.Id;
                answer.Answer.IsActive = a.Answer.IsActive;
                answer.Answer.IsCorrect = a.Answer.IsCorrect;

                savedHistory.Answers.Add(answer);
            }
            savedHistory.AnsweringDate = history.AnsweringDate;
            savedHistory.Question = Conversion.ConvertQuestionFromDTO(history.Question);
            savedHistory.Testee = Conversion.ConvertTesteeFromDTO(history.Testee);
            savedHistory.IsAnswerCorrect = history.IsAnswerCorrect;
            repo.Create(savedHistory);
        }
    }
}
