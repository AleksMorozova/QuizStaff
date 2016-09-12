using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServer
{
    public struct LoginTrainingQuestion
    {
        public string login;
        public string training;
        public string question;
        public LoginTrainingQuestion(string login, string training, string question)
        {
            this.login = login;
            this.training = training;
            this.question = question;
        }
    }
}
