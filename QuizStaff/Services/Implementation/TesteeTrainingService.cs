using DAL;
using DAL.Repositories;
using DataTransferObject;
using DomainModel;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementation
{
    public class TesteeTrainingService: ITesteeTrainingService
    {
        public void UpdateTesteeTraining(QuizDBContext context, TesteeTrainingDTO testeeTraining)
        {
            EFTesteeTrainingRepository repo = new EFTesteeTrainingRepository(context);
            TesteeTraining updateTesteeTraining = Conversion.ConvertTesteeTrainingFromDTO(testeeTraining);
            repo.Update(updateTesteeTraining);
        }
    }
}
