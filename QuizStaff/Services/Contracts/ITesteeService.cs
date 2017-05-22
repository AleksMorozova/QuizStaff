using DAL;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface ITesteeService
    {
        List<TesteeDTO> GetAllTestees(QuizDBContext dbContext);

        TesteeDTO FindByLogin(QuizDBContext dbContext, string login);

        TesteeDTO UpdateTestee(QuizDBContext dbContext, TesteeDTO testee);

        TesteeDTO SaveTestee(QuizDBContext dbContext, TesteeDTO testee);
    }
}
