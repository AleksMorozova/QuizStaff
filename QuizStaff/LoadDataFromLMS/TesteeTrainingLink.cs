using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadDataFromLMS
{
    public struct TesteeTrainingLink : IEquatable<TesteeTrainingLink>
    {
        public string login;
        public string training;
        public DateTime assignmentDate;
        public ActivityStatus activityStatus;
        public DateTime attemptStartDate;
        public DateTime attemptEndDate;
        public DateTime dueDate;

        public bool Equals(TesteeTrainingLink other)
        {
            return login.Equals(other.login) && training.Equals(other.training);
        }

        public override int GetHashCode()
        {
            int hashLogin = login == null ? 0 : login.GetHashCode();
            int hashTraining = training == null ? 0 : training.GetHashCode();
            return hashLogin ^ hashTraining;
        }
    }
}
