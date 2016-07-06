using DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class Conversion
    {
        public static void CopyProperty(object from, object to)
        {
            foreach (System.Reflection.PropertyInfo info in from.GetType().GetProperties())
            {
                try
                {
                    if (info.CanWrite)
                    {
                        to.GetType().GetProperty(info.Name).SetValue(to, info.GetValue(from, null), null);
                    }
                }
                catch
                { 
                    //TODO: write to log 
                }
            }
        }

        public static Training ConvertTrainingFromDTO (TrainingDTO currentTraining)
        {
            Training newTraining = new Training();
            Conversion.CopyProperty(currentTraining, newTraining);
            newTraining.Questions = new BindingList<Question>();
            foreach (var q in currentTraining.Questions)
            {
                if (q.IsActive)
                {
                    Question question = new Question();
                    Conversion.CopyProperty(q, question);
                    question.Answers = new BindingList<Answer>();

                    foreach (var a in q.Answers)
                    {
                        if (a.IsActive)
                        {
                            Answer newA = new Answer();
                            Conversion.CopyProperty(a, newA);
                            question.Answers.Add(newA);
                        }
                    }
                    newTraining.Questions.Add(question);
                }
            }

            return newTraining;
        }

        public static Training ConvertTrainingFromDTO_ForServer(TrainingDTO currentTraining)
        {
            Training newTraining = new Training();
            Conversion.CopyProperty(currentTraining, newTraining);
            newTraining.Questions = new BindingList<Question>();
            foreach (var q in currentTraining.Questions)
            {
                Question question = new Question();
                Conversion.CopyProperty(q, question);
                question.Answers = new BindingList<Answer>();

                foreach (var a in q.Answers)
                {
                    Answer newA = new Answer();
                    Conversion.CopyProperty(a, newA);
                    question.Answers.Add(newA);
                }
                newTraining.Questions.Add(question);
            }

            return newTraining;
        }

        public static TrainingDTO ConvertTrainingToDTO(Training currentTraining)
        {
            TrainingDTO newTraining = new TrainingDTO();
            Conversion.CopyProperty(currentTraining, newTraining);
            newTraining.Questions = new BindingList<QuestionDTO>();
            foreach (var q in currentTraining.Questions)
            {
                QuestionDTO question = new QuestionDTO();
                Conversion.CopyProperty(q, question);
                question.Answers = new BindingList<AnswerDTO>();

                foreach (var a in q.Answers)
                {
                    AnswerDTO newA = new AnswerDTO();
                    Conversion.CopyProperty(a, newA);
                    question.Answers.Add(newA);
                }
                newTraining.Questions.Add(question);
            }

            return newTraining;
        }

        public static TesteeDTO ConvertTesteeToDTO(Testee testee) 
        {
            TesteeDTO newTestee = new TesteeDTO();
            newTestee.Trainings = new BindingList<TesteeTrainingDTO>();
            newTestee.UserSetting = new SettingDTO();
            Conversion.CopyProperty(testee, newTestee);
            Conversion.CopyProperty(testee.UserSetting, newTestee.UserSetting);
            if (testee.Trainings != null)
            if (testee.Trainings.Count() > 0)
            {
                foreach (var t in testee.Trainings)
                {
                    newTestee.Trainings.Add(ConvertTesteeTrainingToDTO(t));
                }
            }

            return newTestee;
        }

        public static Testee ConvertTesteeFromDTO(TesteeDTO testee)
        {
            Testee newTestee = new Testee();
            newTestee.UserSetting = new Setting();
            newTestee.Trainings = new BindingList<TesteeTraining>();
            Conversion.CopyProperty(testee, newTestee);
            Conversion.CopyProperty(testee.UserSetting, newTestee.UserSetting);

            if (testee.Trainings!=null)
            if (testee.Trainings.Count() > 0)
            {
                foreach (var t in testee.Trainings)
                {
                    if (t.IsActive)
                    {
                        newTestee.Trainings.Add(ConvertTesteeTrainingFromDTO(t));
                    }
                }
            }

            return newTestee;
        }

        public static Testee ConvertTesteeFromDTO_ForServer(TesteeDTO testee)
        {
            Testee newTestee = new Testee();
            newTestee.UserSetting = new Setting();
            newTestee.Trainings = new BindingList<TesteeTraining>();
            Conversion.CopyProperty(testee, newTestee);
            Conversion.CopyProperty(testee.UserSetting, newTestee.UserSetting);
            
            if (testee.Trainings != null)
            if (testee.Trainings.Count() > 0)
            {
                foreach (var t in testee.Trainings)
                {
                    TesteeTraining training = new TesteeTraining();
                    training.Training = new Training();
                    training.Id = t.Id;
                    training.IsActive = t.IsActive;
                    Conversion.CopyProperty(t.Training, training.Training);
                    training.Id = t.Id;
                    newTestee.Trainings.Add(training);
                }
            }
            return newTestee;
        }

        public static TesteeTrainingDTO ConvertTesteeTrainingToDTO(TesteeTraining testeeTraining)
        {
            TesteeTrainingDTO newTesteeTraining = new TesteeTrainingDTO();
            newTesteeTraining.Id = testeeTraining.Id;
            newTesteeTraining.IsActive = testeeTraining.IsActive;
            newTesteeTraining.Training = new TrainingDTO();
            Conversion.CopyProperty(testeeTraining.Training, newTesteeTraining.Training);
            return newTesteeTraining;
        }

        public static TesteeTraining ConvertTesteeTrainingFromDTO(TesteeTrainingDTO testeeTraining)
        {
            TesteeTraining newTesteeTraining = new TesteeTraining();
            newTesteeTraining.Id = testeeTraining.Id;
            newTesteeTraining.IsActive = testeeTraining.IsActive;
            newTesteeTraining.Training = new Training();
            Conversion.CopyProperty(testeeTraining.Training, newTesteeTraining.Training);
            return newTesteeTraining;
        }

        public static Question ConvertQuestionFromDTO(QuestionDTO question) 
        {
            Question newQuestion = new Question();
            newQuestion.Answers = new BindingList<Answer>();
            if (question != null)
            {
                Conversion.CopyProperty(question, newQuestion);
                foreach (var a in question.Answers)
                {
                    Answer ans = new Answer();
                    CopyProperty(a, ans);
                    if (a.IsActive)
                        newQuestion.Answers.Add(ans);
                }
            }
            return newQuestion;
        }
    }
}

