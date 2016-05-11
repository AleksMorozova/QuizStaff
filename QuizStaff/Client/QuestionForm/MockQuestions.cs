using System.Collections.Generic;
using DomainModel;

namespace Client
{
    static class MockQuestions
    {
        static public Question Radio()
        {
            List<Answer> l = new List<Answer>();
            l.Add(new Answer() { AnswerText = "This is correct answer.", IsCorrect = true });
            string longStr = "dsadasdas ";
            for (int i = 0; i <= 15; i++)
            {
                longStr += "dsadasdas ";
            }
            l.Add(new Answer() { AnswerText = new string('q', 20), IsCorrect = false });
            l.Add(new Answer() { AnswerText = longStr, IsCorrect = false });
            l.Add(new Answer() { AnswerText = "I am adding some controls to Flow layout panel. In between some controls I need a line break. How can I achieve this please. Thanks", IsCorrect = false });
            var question = new Question() { QuestionText = "What you gonna do when they come for you?", Answers = l };
            return question;
        }
        static public Question CheckBox()
        {
            List<Answer> l = new List<Answer>();
            l.Add(new Answer() { AnswerText = "This is correct answer.", IsCorrect = true });
            string longStr = "dsadasdas ";
            for (int i = 0; i <= 15; i++)
            {
                longStr += "dsadasdas ";
            }
            l.Add(new Answer() { AnswerText = new string('q', 20), IsCorrect = true });
            l.Add(new Answer() { AnswerText = longStr, IsCorrect = true });
            l.Add(new Answer() { AnswerText = "I am adding some controls to Flow layout panel. In between some controls I need a line break. How can I achieve this please. Thanks", IsCorrect = false });
            var question = new Question() { QuestionText = "What you gonna do when they come for you?", Answers = l };
            return question;
        }
        static public Question NoCorr()
        {
            List<Answer> l = new List<Answer>();
            l.Add(new Answer() { AnswerText = "This is correct answer.", IsCorrect = false });
            l.Add(new Answer() { AnswerText = new string('q', 200), IsCorrect = false });
            l.Add(new Answer() { AnswerText = new string('q', 20), IsCorrect = false });
            l.Add(new Answer() { AnswerText = new string('q', 5), IsCorrect = false });
            var question = new Question() { QuestionText = "What you gonna do when they come for you?", Answers = l };
            return question;
        }
    }
}
