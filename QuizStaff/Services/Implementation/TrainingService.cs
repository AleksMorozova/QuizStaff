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
    public class TrainingService: ITrainingService
    {
        public List<TrainingDTO> GetAllTrainings(QuizDBContext dbContext)
        {
            EFRepository<Training> repo = new EFRepository<Training>(dbContext);
            var trainings = new List<Training>(repo.ReadAll());
            return trainings.Select(training => (TrainingDTO)training).ToList();
        }

        public List<TrainingDTO> GetAllActiveTrainings(QuizDBContext dbContext)
        {
            EFRepository<Training> repo = new EFRepository<Training>(dbContext);
            var loadTrainings = repo.ReadAll();
            var selectedTrainings = loadTrainings.Where(x => x.IsActive).AsQueryable()
                .Select(training => new Training
                {
                    Id = training.Id,
                    TrainingTitle = training.TrainingTitle,
                    IsActive = training.IsActive,
                    TesteeTrainings = new BindingList<TesteeTraining>(training.TesteeTrainings.ToList().Where(_ => _.IsActive).ToList()),
                    Questions = new BindingList<Question>(training.Questions.ToList().Where(_ => _.IsActive)
                        .Select(question => new Question
                        {
                            Id = question.Id,
                            QuestionText = question.QuestionText,
                            IsActive = question.IsActive,
                            Training = question.Training,
                            Answers = new BindingList<Answer>(question.Answers.ToList().Where(_ => _.IsActive).ToList()),
                        }).ToList()),
                }).ToList();

            return selectedTrainings.Select(training => (TrainingDTO)training).ToList();
        }

        public TrainingDTO UpdateTraining(QuizDBContext dbContext, TrainingDTO training)
        {
            EFTrainingRepository repo = new EFTrainingRepository(dbContext);
            Training updateTrainings = Conversion.ConvertTrainingFromDTO(training);
            repo.Update(updateTrainings);
            return (TrainingDTO)updateTrainings;
        }

        public TrainingDTO SaveTraining(QuizDBContext dbContext, TrainingDTO training)
        {
            EFTrainingRepository repo = new EFTrainingRepository(dbContext);
            Training savedTrainings = Conversion.ConvertTrainingFromDTO(training);
            repo.Create(savedTrainings);
            return (TrainingDTO)savedTrainings;
        }

        public TrainingDTO FindByTitle(QuizDBContext dbContext, string title)
        {
            EFRepository<Training> repo = new EFRepository<Training>(dbContext);
            var result = repo.ReadAll().Where(_ => _.TrainingTitle == title).FirstOrDefault();
            return (result != null) ? result : new TrainingDTO() { IsActive = true };
        }
    }
}
