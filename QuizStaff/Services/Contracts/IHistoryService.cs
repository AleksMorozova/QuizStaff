using DAL;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IHistoryService
    {
        void SaveTesteeAnswer(QuizDBContext context, HistoryDTO history);
    }
}
