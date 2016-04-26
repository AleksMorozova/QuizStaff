using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class TesteesListPresenter
    {
        public List<Testee> testees { get; set; }
        public ITesteesListForm Form { get; private set; }

        public TesteesListPresenter(ITesteesListForm form)
        {
            this.Form = form;

            this.testees = Creator.CreateTesteesList();

            form.SetBindings(this.testees);
        }

        public void Show()
        {
            this.Form.Show();
        }
    }

    #region Creator
    class Creator
    {
        public static List<Testee> CreateTesteesList()
        {
            var testees = new List<Testee>();
            testees.Add(new Testee("Bogdan", "Nashilnik", "google@gmail.com"));
            testees.Add(new Testee("Oleg", "Lobanov", "google@gmail.ua"));
            testees.Add(new Testee("Fedor", "Voloshin", "google@gmail.com"));
            return testees;
        }
    }
    #endregion
    #region Classes
    public class Testee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private string email;
        private string login;
        private string password;

        List<History> Histories { get; set; }
        List<Training> Trainings { get; set; }

        public Testee(string firstname, string lastname, string email)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.email = email;

            login = string.Empty;
            password = string.Empty;

            Histories = new List<History>();
            Trainings = new List<Training>();
        }
    }
    public class History
    {
        public Testee Testee { get; set; }
        public Question Question { get; set; }
        public DateTime Date { get; set; }
        public List<UserAnswers> Answers { get; set; }

        public History(Testee testee, Question question, DateTime date)
        {
            this.Testee = testee;
            this.Question = question;
            this.Date = date;
            Answers = new List<UserAnswers>();
        }
    }
    public class Answer
    {
        public string AnswerText { get; set; }
        public bool IsCorrect { get; set; }
        public Answer(string answertext, bool iscorrect)
        {
            this.AnswerText = answertext;
            this.IsCorrect = iscorrect;
        }
    }
    public class UserAnswers
    {
        public List<Answer> Answer { get; set; }
        public UserAnswers()
        {
            Answer = new List<Answer>();
        }
    }
    public class Training
    {
        public String TrainingTitle { get; set; }
        public List<Question> Questions { get; set; }

        public Training(string trainingtitle)
        {
            this.TrainingTitle = trainingtitle;
            this.Questions = new List<Question>();
        }
    }
    public class Question
    {
        public string QuestionText { get; set; }
        public Training Training { get; set; }
        public List<Answer> Answers { get; set; }

        public Question(string questiontext, Training training)
        {
            this.QuestionText = questiontext;
            this.Training = training;
            Answers = new List<Answer>();
        }
    }
    #endregion
}
