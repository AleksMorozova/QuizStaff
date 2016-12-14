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
    public class TesteeService: ITesteeService
    {
        public List<TesteeDTO> GetAllTestees(QuizDBContext dbContext)
        {
            EFRepository<Testee> repo = new EFRepository<Testee>(dbContext);

            var loadedTestee = repo.ReadAll();
            var selectedTestee = loadedTestee.Where(x => x.IsActive).AsQueryable()
                .Select(testee => new Testee
                {
                    Id = testee.Id,
                    FirstName = testee.FirstName,
                    LastName = testee.LastName,
                    Login = testee.Login,
                    IsActive = testee.IsActive,
                    Email = testee.Email,

                    Attribute1 = testee.Attribute1,
                    Attribute2 = testee.Attribute2,
                    Attribute3 = testee.Attribute3,
                    Attribute4 = testee.Attribute4,
                    Attribute5 = testee.Attribute5,
                    Attribute6 = testee.Attribute6,
                    Attribute7 = testee.Attribute7,
                    Attribute8 = testee.Attribute8,
                    Attribute9 = testee.Attribute9,
                    Attribute10 = testee.Attribute10,
                    Attribute11 = testee.Attribute11,
                    Attribute12 = testee.Attribute12,
                    Attribute13 = testee.Attribute13,

                    UserSetting = testee.UserSetting,
                    Trainings = new BindingList<TesteeTraining>(testee.Trainings.ToList().Where(_ => _.IsActive).ToList()),
                    Roles = new BindingList<TesteeRoles>(testee.Roles.ToList()),
                    Histories = new BindingList<History>(testee.Histories.ToList())

                }).ToList();

            return selectedTestee.Select(testee => (TesteeDTO)testee).ToList();
        }

        public TesteeDTO FindByLogin(QuizDBContext dbContext, string login)
        {
            EFRepository<Testee> repo = new EFRepository<Testee>(dbContext);
            Testee result;
            if (login == "admin")
                result = repo.ReadAll().Where(_ => _.Login == login).FirstOrDefault();
            else
                result = repo.ReadAll().Where(_ => _.Login == login && _.IsActive).FirstOrDefault();
            return (result != null) ? result : new TesteeDTO() { IsActive = true, UserSetting = new Setting() { TimeOfStart = DateTime.Now, Recurrence = RecurrenceType.WithoutEnding, Minutes = 5 } };
        }

        public TesteeDTO UpdateTestee(QuizDBContext dbContext, TesteeDTO testee)
        {
            EFTesteeRepository repo = new EFTesteeRepository(dbContext);
            Testee updatedTestee = Conversion.ConvertTesteeFromDTO(testee);
            repo.Update(updatedTestee);
            return (TesteeDTO)updatedTestee;
        }

        public TesteeDTO SaveTestee(QuizDBContext dbContext, TesteeDTO testee)
        {
            EFTesteeRepository repo = new EFTesteeRepository(dbContext);
            Testee savedTestee = Conversion.ConvertTesteeFromDTO(testee);
            repo.Create(savedTestee);
            return (TesteeDTO)savedTestee;
        }
    }
}
