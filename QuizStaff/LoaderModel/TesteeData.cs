using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoaderModel
{
    public struct TesteeData : IEquatable<TesteeData>
    {
        public string login;
        public string firstName;
        public string lastName;
        public string managerLogin;
        public string department;
        public string possition;

        public bool Equals(TesteeData other)
        {
            return login.Equals(other.login);
        }

        public override int GetHashCode()
        {
            int hashProductName = login == null ? 0 : login.GetHashCode();
            return hashProductName;
        }
    }
}
