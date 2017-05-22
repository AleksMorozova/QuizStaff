using DAL;
using DomainModel;
using LoadDataFromLMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface ILoaderService
    {
        void SynchronizeTestees(QuizDBContext context, List<Testee> loadedTestees);

        void LoadTrainings(QuizDBContext context);

        void LoadAdditionalQuestions(QuizDBContext context);
    }
}
