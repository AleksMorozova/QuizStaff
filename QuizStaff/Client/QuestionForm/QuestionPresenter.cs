using System;
using System.Collections.Generic;
using System.Linq;
using DataTransferObject;

namespace Client
{
    public class QuestionPresenter
    {
        private QuestionDTO question;
        private IQuestionForm form;
        private Client.ServiceReference.ApplicationServerClient server;
        private TesteeDTO testee;
        private Dictionary<Guid, bool> answers;

        private bool MultiSelect
        {
            get
            {
                return this.question.Answers.Where(answer => answer.IsCorrect == true).Count() != 1;
            }
        }

        public QuestionPresenter(IQuestionForm form, TesteeDTO testee)
        {
            this.testee = testee;
            this.form = form;
            this.server = ServicesHolder.ServiceClient;
            this.question = this.server.GetRandomQuestionForTestee(testee.Id);
            this.answers = new Dictionary<Guid, bool>(question.Answers.ToDictionary(x => x.ID, x => false));
            this.form.CreateQuestionControls(this.question, this.answers, this.MultiSelect);
        }

        public void Send()
        {
            if (this.answers.Where(x => x.Value == true).Count() == 0)
            {
                this.form.NotifyNoAnswersChecked();
            }
            else
            {
                var trueAnswers = this.answers.Where(x => x.Value == true).Select(x => x.Key).ToArray();
                this.server.SaveTesteeAnswer(this.testee.Id, this.question.Id, DateTime.Now, trueAnswers);
                this.form.CloseForm();
            }
        }
    }
}
