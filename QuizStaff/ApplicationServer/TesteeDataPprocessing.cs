using ApplicationServer;
using DAL.Repositories;
using DomainModel;
using LoadDataFromLMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizServer
{
    public static class TesteeDataPprocessing
    {
        public static void SynchronizeTestees(List<Testee> loadedTestees)
        {
            EFRoleRepository roleRepo = new EFRoleRepository(Program.dbContext);
            Role role = roleRepo.ReadAll().Where(_ => _.Name == "Testee").FirstOrDefault();

            List<Testee> savedTestee = new List<Testee>();

            EFTesteeRepository repo = new EFTesteeRepository(Program.dbContext);

            var testeeLogin = loadedTestees.Select(_ => _.Login).ToList();
            var allTestees = repo.ReadAll().ToList();

            savedTestee.AddRange((from testee in loadedTestees
                                  select new { testee }).AsEnumerable().Select(x =>
                                  {
                                      return (allTestees.Select(_ => _.Login).Contains(x.testee.Login))
                                          ? UpdateTestee(UpdatedTesteeFromEPE(allTestees.Where(_ => _.Login == x.testee.Login).First(), x.testee), true)
                                          : CreateNewTesteeFromEPE(x.testee, role);

                                  }));

            var savedLoggins = savedTestee.Select(l => l.Login);

            var deletedTestee = allTestees.Where(_ => !savedLoggins.Contains(_.Login)).Select(t => t);

            savedTestee.AddRange(deletedTestee.Select(x => UpdateTestee(x, false)));

            WriteTesteeToDB(savedTestee, repo);
        }

        public static void WriteTesteeFromLMS(List<TesteeData> testees)
        {
            EFRoleRepository roleRepo = new EFRoleRepository(Program.dbContext);

            Role role = roleRepo.ReadAll().Where(_ => _.Name == "Testee").FirstOrDefault();
            List<Testee> savedTestee = new List<Testee>();
            EFTesteeRepository repo = new EFTesteeRepository(Program.dbContext);

            var testeeLogin = testees.Select(_ => _.login).ToList();
            var allTestees = repo.ReadAll().ToList();
            savedTestee.AddRange((from testee in testees
                                  select new { testee }).AsEnumerable().Select(x =>
                                  {
                                      return (allTestees.Select(_ => _.Login).Contains(x.testee.login))
                                          ? UpdateTestee(UpdatedTesteeFromLMS(allTestees.Where(_ => _.Login == x.testee.login).First(), x.testee), true)
                                          : CreateNewTesteeFromEPE(x.testee, role);
                                  }));

            //TODO: check delete of entity
            //savedTestee.AddRange(allTestees.Except(savedTestee).Select(x => UpdateTestee(x, false)));

            WriteTesteeToDB(savedTestee, repo);
        }

        private static Testee UpdatedTesteeFromEPE(Testee existingTestee, Testee newTestee)
        {
            existingTestee.Login = newTestee.Login;
            existingTestee.FirstName = newTestee.FirstName;
            existingTestee.LastName = newTestee.LastName;
            existingTestee.IsActive = true;

            existingTestee.Attribute1 = newTestee.Attribute1;
            existingTestee.Attribute2 = newTestee.Attribute2;
            existingTestee.Attribute3 = newTestee.Attribute3;
            existingTestee.Attribute4 = newTestee.Attribute4;
            existingTestee.Attribute5 = newTestee.Attribute5;
            existingTestee.Attribute6 = newTestee.Attribute6;
            existingTestee.Attribute7 = newTestee.Attribute7;
            existingTestee.Attribute8 = newTestee.Attribute8;
            existingTestee.Attribute9 = newTestee.Attribute9;
            existingTestee.Attribute10 = newTestee.Attribute10;
            existingTestee.Attribute11 = newTestee.Attribute11;
            existingTestee.Attribute12 = newTestee.Attribute12;
            existingTestee.Attribute13 = newTestee.Attribute13;

            return existingTestee;
        }

        private static Testee CreateNewTesteeFromEPE(Testee testee, Role role)
        {
            Testee newTestee = new Testee();

            newTestee.Login = testee.Login;
            newTestee.FirstName = testee.FirstName;
            newTestee.LastName = testee.LastName;
            newTestee.IsActive = true;
            newTestee.UserSetting = new Setting() { Minutes = 5, AmountOfQuestionsPerDay = 10, TimeOfStart = DateTime.Now, EndDate = DateTime.Now, Recurrence = RecurrenceType.WithExactRepeated };
            newTestee.Trainings = new BindingList<TesteeTraining>();
            newTestee.Roles = new BindingList<TesteeRoles>() { new TesteeRoles() { Role = role } };

            newTestee.Email = testee.Email;

            newTestee.Attribute1 = testee.Attribute1;
            newTestee.Attribute2 = testee.Attribute2;
            newTestee.Attribute3 = testee.Attribute3;
            newTestee.Attribute4 = testee.Attribute4;
            newTestee.Attribute5 = testee.Attribute5;
            newTestee.Attribute6 = testee.Attribute6;
            newTestee.Attribute7 = testee.Attribute7;
            newTestee.Attribute8 = testee.Attribute8;
            newTestee.Attribute9 = testee.Attribute9;
            newTestee.Attribute10 = testee.Attribute10;
            newTestee.Attribute11 = testee.Attribute11;
            newTestee.Attribute12 = testee.Attribute12;
            newTestee.Attribute13 = testee.Attribute13;

            return newTestee;
        }

        private static Testee UpdatedTesteeFromLMS(Testee existingTestee, TesteeData newTestee)
        {
            existingTestee.Login = newTestee.login;
            existingTestee.FirstName = newTestee.firstName;
            existingTestee.LastName = newTestee.lastName;
            existingTestee.IsActive = true;

            existingTestee.Attribute5 = newTestee.department;
            existingTestee.Attribute8 = newTestee.possition;
            existingTestee.Attribute10 = newTestee.managerLogin;

            return existingTestee;
        }

        private static Testee CreateNewTesteeFromEPE(TesteeData testee, Role role)
        {
            Testee newTestee = new Testee();

            newTestee.Login = testee.login;
            newTestee.FirstName = testee.firstName;
            newTestee.LastName = testee.lastName;
            newTestee.IsActive = true;

            newTestee.Attribute5 = testee.department;
            newTestee.Attribute8 = testee.possition;
            newTestee.Attribute10 = testee.managerLogin;

            newTestee.UserSetting = new Setting() { Minutes = 5, AmountOfQuestionsPerDay = 10, TimeOfStart = DateTime.Now, EndDate = DateTime.Now, Recurrence = RecurrenceType.WithExactRepeated };
            newTestee.Trainings = new BindingList<TesteeTraining>();
            newTestee.Roles = new BindingList<TesteeRoles>() { new TesteeRoles() { Role = role, IsActive = true } };

            return newTestee;
        }

        private static void WriteTesteeToDB(List<Testee> allTestee, EFTesteeRepository repo)
        {
            foreach (var testee in allTestee)
            {
                if (testee.Login != "val_edu" || testee.Login != "tkas_edu" || testee.Login != "atok_edu" || testee.Login != "omor")
                {
                    if (testee.Id == Guid.Empty)
                    {
                        repo.Create(testee);
                    }
                    else
                    {
                        repo.Update(testee);
                    }
                }
            }
        }

        private static Testee UpdateTestee(Testee testee, bool isActive)
        {
            if (testee.Login != "val_edu" || testee.Login != "tkas_edu" || testee.Login != "atok_edu" || testee.Login != "omor")
            {
                testee.IsActive = isActive;
            }

            return testee;
        }
    }
}
