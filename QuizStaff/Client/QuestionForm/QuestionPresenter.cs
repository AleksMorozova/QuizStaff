using System;
using System.Collections.Generic;
using System.Linq;
using DataTransferObject;

namespace Client
{
    public class QuestionPresenter
    {
        private QuestionDTO question;
        public IQuestionForm Form { get; set; }
        private Client.ServiceReference.ApplicationServerClient server;
        private TesteeDTO testee;
        private List<bool> answers;

        private bool MultiSelect
        {
            get
            {
                return this.question.Answers.Where(answer => answer.IsCorrect == true).Count() != 1;
            }
        }

        public QuestionPresenter(IQuestionForm form, QuestionDTO question, TesteeDTO testee)
        {
            this.question = question;
            this.testee = testee;
            this.Form = form;
            this.Form.Presenter = this;
            this.server = ServicesHolder.ServiceClient;
            this.answers = new List<bool>(question.Answers.Select(x => false));
            this.Form.CreateQuestionControls(this.question, this.answers, this.MultiSelect);
        }
        public void Send()
        {
            if (this.answers.Where(x => x == true).Count() == 0)
            {
                this.Form.NotifyNoAnswersChecked();
            }
            else
            {
                List<Guid> list = new List<Guid>();
                int i = 0;
                foreach (var answer in this.question.Answers)
                {
                    if (this.answers[i++])
                    {
                        list.Add(answer.ID);
                    }
                }
                this.server.SaveTesteeAnswer(this.testee.Id, this.question.Id, DateTime.Now, list.ToArray());
                this.Form.CloseForm();
            }
        }
    }
}
