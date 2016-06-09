﻿using ApplicationServer.DAL;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DataTransferObject;
using System.Collections;
using System.Collections.ObjectModel;

namespace Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ApplicationServer : IApplicationServer
    {
        QuizDBContext context;

        public ApplicationServer()
        {
            context = new QuizDBContext();
            context.Database.Initialize(true);
        }

        public List<TesteeDTO> GetAllTestees()
        {
            EFRepository<Testee> repo = new EFRepository<DomainModel.Testee>();
            var testees = new List<Testee>(repo.ReadAll());
            return testees.Select(testee => (TesteeDTO)testee).ToList();
        }

        public TesteeDTO GetTesteeByID(Guid id)
        {
            EFRepository<Testee> repo = new EFRepository<DomainModel.Testee>();
            Testee currentTestee = repo.Read(id);
            return currentTestee;
        }

        public void SaveAllTestees(ICollection<TesteeDTO> testee)
        {
            // TODO: save to database
        }

        public List<QuestionDTO> GetTrainingQuestions(TrainingDTO training)
        {
            EFRepository<Question> repo = new EFRepository<DomainModel.Question>();
            var testees = new List<Question>(repo.ReadAll()) ;
            var t= (from p in testees.Select(testee => (QuestionDTO)testee) where p.TrainingId==training.Id select p ).ToList() ;
            return t;
        }
        public void SaveTesteeAnswer(Guid testeeID, Guid questionID, DateTime date, List<Guid> answersID)
        {
            // TODO: save to database
        }

        public QuestionDTO GetRandomQuestionForTestee(Guid id)
        {
            // TODO: implement logic for finding question 

            List<Answer> l = new List<Answer>();
            l.Add(new Answer() { AnswerText = "This is answer first", IsCorrect = true, Id = Guid.NewGuid() });
            l.Add(new Answer() { AnswerText = "This is answer second", IsCorrect = true, Id = Guid.NewGuid() });
            l.Add(new Answer() { AnswerText = "This is answer third", IsCorrect = true, Id = Guid.NewGuid() });
            l.Add(new Answer() { AnswerText = "This is answer fourth", IsCorrect = true, Id = Guid.NewGuid() });
            var question = new Question() { QuestionText = "What you gonna do when they come for you?", Answers = l };
          
            return question;
        }
        #region Client's settings  
        public Boolean SetUsersSettings(SettingDTO sets, Guid id)
        {
            // Save to database
            try
            {
                return true;
            }
            catch
            {
                return false;
            }
        }

        public SettingDTO GetUsersSettings(Guid id)
        {
            Setting sets = new Setting() { AmountOfQuestionsPerDay = 1,
                                                FrequencyOfAsking = 1,
                                                    TimeOfStart = new DateTime(2016, 5, 8, 10, 10, 10, 10) };
            return sets;
        }
        #endregion

        public List<TrainingDTO> GetAllTrainings()
        {
            EFRepository<Training> repo = new EFRepository<Training>();
            var trainings = new List<Training>(repo.ReadAll());
            return trainings.Select(training => (TrainingDTO)training).ToList();
        }

        public void SaveAllTrainings(ICollection<TrainingDTO> trainings)
        {
            // TODO: save to database
        }       

        public TesteeDTO FindByLogin(string login)
        {
            EFRepository<Testee> repo = new EFRepository<DomainModel.Testee>();
            var result = repo.ReadAll().Where(_ => _.Login == login).FirstOrDefault();
            return (result!=null) ? result : new TesteeDTO();
        }

        public void SaveAnswer(QuestionDTO question) 
        {
            EFRepository<Question> repo = new EFRepository<Question>();
            //repo.Create((Question)question);
        }

        public void UpdateTraining(TrainingDTO training)
        {
            EFTrainingRepository repo = new EFTrainingRepository();
            Training newTraining = new Training();
            newTraining.Questions = new Collection<Question>();
            Conversion.CopyProperty(training, newTraining);
            if (training.Questions.Count() > 0)
            {
                foreach (var q in training.Questions) 
                {
                    Question question = new Question();
                    Conversion.CopyProperty(q, question);
                    question.Answers = new Collection<Answer>();
                    foreach (var a in q.Answers)
                    {
                        Answer newA = new Answer();
                        Conversion.CopyProperty(a, newA);
                        question.Answers.Add(newA);
                    }
                    newTraining.Questions.Add(question);
                }
            }
            repo.Update(newTraining);
        }

        public void SaveTraining(TrainingDTO training)
        {
            EFTrainingRepository repo = new EFTrainingRepository();
            Training newTraining = new Training();
            newTraining.Questions = new Collection<Question>();

            Conversion.CopyProperty(training, newTraining);
            if (training.Questions.Count() > 0)
            {
                foreach (var q in training.Questions)
                {
                    Question question = new Question();
                    Conversion.CopyProperty(q, question);
                    question.Answers = new Collection<Answer>();
                    foreach (var a in q.Answers)
                    {
                        Answer newA = new Answer();
                        Conversion.CopyProperty(a, newA);
                        question.Answers.Add(newA);
                    }
                    newTraining.Questions.Add(question);
                }
            }
            repo.Create(newTraining);
        }

        public void SaveQuestion(QuestionDTO training)
        {
            EFRepository<Question> repo = new EFRepository<Question>();
            Question newTraining = new Question();
            Conversion.CopyProperty(training, newTraining);
            repo.Create(newTraining);
        }

        public void UpdateQuestion(QuestionDTO training)
        {
            EFRepository<Question> repo = new EFRepository<Question>();
            Question newTraining = new Question();
            Conversion.CopyProperty(training, newTraining);
            repo.Update(newTraining);
        }

        public void UpdateTestee(TesteeDTO testee)
        {
            EFTesteeRepository repo = new EFTesteeRepository();
            Testee newTestee = new Testee();
            Conversion.CopyProperty(testee, newTestee);
            repo.Update(newTestee);
        }

        public void SaveTestee(TesteeDTO testee)
        {
            EFTesteeRepository repo = new EFTesteeRepository();
            Testee newTestee = new Testee();
            Conversion.CopyProperty(testee, newTestee);
            repo.Create(newTestee);
        }
    }
}
