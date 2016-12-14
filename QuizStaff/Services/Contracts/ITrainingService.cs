using DAL;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface ITrainingService
    {
        List<TrainingDTO> GetAllTrainings(QuizDBContext dbContext);

        List<TrainingDTO> GetAllActiveTrainings(QuizDBContext dbContext);

        TrainingDTO UpdateTraining(QuizDBContext dbContext, TrainingDTO training);

        TrainingDTO SaveTraining(QuizDBContext dbContext, TrainingDTO training);
    }
}
