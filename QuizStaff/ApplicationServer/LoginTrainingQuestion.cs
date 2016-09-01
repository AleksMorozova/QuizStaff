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
        public bool question;
        public LoginTrainingQuestion(string login, string training, bool question)
        {
            this.login = login;
            this.training = training;
            switch (question.ToString())
            {
                case "Yes": this.question = true;
                    break;
                case "No": this.question = false;
                    break;
                default: this.question = false;
                    break;
            }
        }
    }
}
