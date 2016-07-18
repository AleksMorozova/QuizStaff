﻿using DomainModel;
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
        public static Training ConvertTrainingFromDTO (TrainingDTO currentTraining)
        {
            Training newTraining = new Training();
            newTraining.Id = currentTraining.Id;
            newTraining.TrainingTitle = currentTraining.TrainingTitle;
            newTraining.IsActive = currentTraining.IsActive;

            newTraining.Questions = new BindingList<Question>();
            foreach (var question in currentTraining.Questions)
            {
                Question newQuestion = new Question();
                newQuestion.Id = question.Id;
                newQuestion.IsActive = question.IsActive;
                newQuestion.QuestionText = question.QuestionText;
                
                newQuestion.Answers = new BindingList<Answer>();
                foreach (var answer in question.Answers)
                {
                    Answer newAnswer = new Answer();
                    newAnswer.Id = answer.Id;
                    newAnswer.IsActive = answer.IsActive;
                    newAnswer.IsCorrect = answer.IsCorrect;
                    newAnswer.AnswerText = answer.AnswerText;
                    newQuestion.Answers.Add(newAnswer);       
                }
                newTraining.Questions.Add(newQuestion);
            }
            return newTraining;
        }

        public static TrainingDTO ConvertTrainingToDTO (Training currentTraining)
        {
            TrainingDTO newTraining = new TrainingDTO();
            newTraining.Id = currentTraining.Id;
            newTraining.TrainingTitle = currentTraining.TrainingTitle;
            newTraining.IsActive = currentTraining.IsActive;

            newTraining.Questions = new BindingList<QuestionDTO>();
            if (currentTraining.Questions != null)
            {
                foreach (var question in currentTraining.Questions)
                {
                    QuestionDTO newQuestion = new QuestionDTO();
                    newQuestion.Id = question.Id;
                    newQuestion.IsActive = question.IsActive;
                    newQuestion.QuestionText = question.QuestionText;
                    
                    newQuestion.Answers = new BindingList<AnswerDTO>();
                    if (question.Answers != null)
                    {
                        foreach (var answer in question.Answers)
                        {
                            AnswerDTO newAnswer = new AnswerDTO();
                            newAnswer.Id = answer.Id;
                            newAnswer.IsActive = answer.IsActive;
                            newAnswer.IsCorrect = answer.IsCorrect;
                            newAnswer.AnswerText = answer.AnswerText;
                            newQuestion.Answers.Add(newAnswer);
                        }
                        newTraining.Questions.Add(newQuestion);
                    }
                }
            }
            return newTraining;
        }

        public static TesteeDTO ConvertTesteeToDTO(Testee testee) 
        {
            TesteeDTO newTestee = new TesteeDTO();
            newTestee.Trainings = new BindingList<TesteeTrainingDTO>();
            newTestee.UserSetting = new SettingDTO();

            //Copy testee
            newTestee.Id = testee.Id;
            newTestee.FirstName = testee.FirstName;
            newTestee.LastName = testee.LastName;
            newTestee.Login = testee.Login;
            newTestee.Password = testee.Password;
            newTestee.IsActive = testee.IsActive;
            newTestee.Email = testee.Email;

            newTestee.Attribute1 = testee.Attribute1;
            newTestee.Attribute2 = testee.Attribute2;
            newTestee.Attribute3 = testee.Attribute3;
            newTestee.Attribute4 = testee.Attribute4;
            newTestee.Attribute5 = testee.Attribute5;
            newTestee.Attribute6 = testee.Attribute6;
            newTestee.Attribute8 = testee.Attribute8;
            newTestee.Attribute9 = testee.Attribute9;
            newTestee.Attribute10 = testee.Attribute10;

            //Copy settings
            newTestee.UserSetting.Id = testee.UserSetting.Id;
            newTestee.UserSetting.FrequencyOfAsking = testee.UserSetting.FrequencyOfAsking;
            newTestee.UserSetting.AmountOfQuestionsPerDay = testee.UserSetting.AmountOfQuestionsPerDay;
            newTestee.UserSetting.TimeOfStart = testee.UserSetting.TimeOfStart;
            newTestee.UserSetting.CanUserEdit = testee.UserSetting.CanUserEdit;
            newTestee.UserSetting.ShowCorrectAnswer = testee.UserSetting.ShowCorrectAnswer;

             if (testee.Trainings != null)
            {
                if (testee.Trainings.Count() > 0)
                {
                    foreach (var t in testee.Trainings)
                    {
                        if (t.Training!= null)
                            newTestee.Trainings.Add(ConvertTesteeTrainingToDTO(t));
                    }
                } 
            }

            return newTestee;
        }

        public static Testee ConvertTesteeFromDTO(TesteeDTO testee)
        {
            Testee newTestee = new Testee();
            newTestee.UserSetting = new Setting();
            newTestee.Trainings = new BindingList<TesteeTraining>();

            //Copy testee
            newTestee.Id = testee.Id;
            newTestee.FirstName = testee.FirstName;
            newTestee.LastName = testee.LastName;
            newTestee.Login = testee.Login;
            newTestee.Password = testee.Password;
            newTestee.IsActive = testee.IsActive;
            newTestee.Email = testee.Email;

            newTestee.Attribute1 = testee.Attribute1;
            newTestee.Attribute2 = testee.Attribute2;
            newTestee.Attribute3 = testee.Attribute3;
            newTestee.Attribute4 = testee.Attribute4;
            newTestee.Attribute5 = testee.Attribute5;
            newTestee.Attribute6 = testee.Attribute6;
            newTestee.Attribute8 = testee.Attribute8;
            newTestee.Attribute9 = testee.Attribute9;
            newTestee.Attribute10 = testee.Attribute10;

            //Copy settings
            newTestee.UserSetting.Id = testee.UserSetting.Id;
            newTestee.UserSetting.FrequencyOfAsking = testee.UserSetting.FrequencyOfAsking;
            newTestee.UserSetting.AmountOfQuestionsPerDay = testee.UserSetting.AmountOfQuestionsPerDay;
            newTestee.UserSetting.TimeOfStart = testee.UserSetting.TimeOfStart;
            newTestee.UserSetting.CanUserEdit = testee.UserSetting.CanUserEdit;
            newTestee.UserSetting.ShowCorrectAnswer = testee.UserSetting.ShowCorrectAnswer;

            //Copy trainings
            if (testee.Trainings != null)
            {
                if (testee.Trainings.Count() > 0)
                {
                    foreach (var currentTraining in testee.Trainings)
                    {
                        TesteeTraining training = new TesteeTraining();
                        training.Training = new Training();
                        training.Id = currentTraining.Id;
                        training.IsActive = currentTraining.IsActive;
                        training.IsSelect = currentTraining.IsSelect;
                        training.Training.Id = currentTraining.Training.Id;
                        training.Training.TrainingTitle = currentTraining.Training.TrainingTitle;
                        training.Training.IsActive = currentTraining.Training.IsActive;

                        newTestee.Trainings.Add(training);
                    }
                }
            }

            return newTestee;
        }

        public static TesteeTrainingDTO ConvertTesteeTrainingToDTO(TesteeTraining testeeTraining)
        {
            TesteeTrainingDTO newTesteeTraining = new TesteeTrainingDTO();
            newTesteeTraining.Id = testeeTraining.Id;
            newTesteeTraining.IsActive = testeeTraining.IsActive;
            newTesteeTraining.IsSelect = testeeTraining.IsSelect;
            newTesteeTraining.Training = new TrainingDTO();
            newTesteeTraining.Training.Id = testeeTraining.Training.Id;
            newTesteeTraining.Training.IsActive = testeeTraining.Training.IsActive;
            newTesteeTraining.Training.TrainingTitle = testeeTraining.Training.TrainingTitle;

            return newTesteeTraining;
        }

        public static TesteeTraining ConvertTesteeTrainingFromDTO(TesteeTrainingDTO testeeTraining)
        {
            TesteeTraining newTesteeTraining = new TesteeTraining();
            newTesteeTraining.Id = testeeTraining.Id;
            newTesteeTraining.IsActive = testeeTraining.IsActive;
            newTesteeTraining.IsSelect = testeeTraining.IsSelect;
            newTesteeTraining.Training = new Training();
            newTesteeTraining.Training.Id = testeeTraining.Training.Id;
            newTesteeTraining.Training.IsActive = testeeTraining.Training.IsActive;
            newTesteeTraining.Training.TrainingTitle = testeeTraining.Training.TrainingTitle;

            return newTesteeTraining;
        }

        public static Question ConvertQuestionFromDTO_ForClient(QuestionDTO question) 
        {
            Question newQuestion = new Question();
            newQuestion.Answers = new BindingList<Answer>();
            if (question != null)
            {
                newQuestion.Id = question.Id;          
                newQuestion.QuestionText = question.QuestionText;
                newQuestion.IsActive = question.IsActive;

                foreach (var answer in question.Answers)
                {
                    Answer newAnswer = new Answer();
                    newAnswer.Id = answer.Id;
                    newAnswer.IsActive = answer.IsActive;
                    newAnswer.IsCorrect = answer.IsCorrect;
                    newAnswer.AnswerText = answer.AnswerText;

                    if (answer.IsActive)
                        newQuestion.Answers.Add(newAnswer);
                }
            }
            return newQuestion;
        }

        public static History ConvertHistoryFromDTO(HistoryDTO currentHistory)
        {
            History newHistory = new History();
            newHistory.Id = currentHistory.Id;
            newHistory.AnsweringDate = currentHistory.AnsweringDate;

            return newHistory;
        }

        public static HistoryDTO ConvertHistoryToDTO(History currentHistory) 
        {
            HistoryDTO newHistory = new HistoryDTO();
            newHistory.Id = currentHistory.Id;
            newHistory.AnsweringDate = currentHistory.AnsweringDate;
            return newHistory;
        }

        public static TesteeAnswer ConvertTesteeAnswerFromDTO(TesteeAnswerDTO currentTesteeAnswer)
        {
            TesteeAnswer newTesteeAnswer = new TesteeAnswer();
            newTesteeAnswer.Id = currentTesteeAnswer.Id;

            return newTesteeAnswer;
        }

        public static TesteeAnswerDTO ConvertTesteeAnswerToDTO(TesteeAnswer currentTesteeAnswer)
        {
            TesteeAnswerDTO newTesteeAnswer = new TesteeAnswerDTO();
            newTesteeAnswer.Id = currentTesteeAnswer.Id;

            return newTesteeAnswer;
        }

        public static Answer ConvertAnswerFromDTO(AnswerDTO currentAnswer)
        {
            Answer newAnswer = new Answer();
            newAnswer.Id = currentAnswer.Id;
            newAnswer.AnswerText = currentAnswer.AnswerText;
            newAnswer.IsActive = currentAnswer.IsActive;
            newAnswer.IsCorrect = currentAnswer.IsCorrect;

            return newAnswer;
        }

        public static AnswerDTO ConvertAnswerToDTO(Answer currentAnswer)
        {
            AnswerDTO newAnswer = new AnswerDTO();
            newAnswer.Id = currentAnswer.Id;
            newAnswer.AnswerText = currentAnswer.AnswerText;
            newAnswer.IsActive = currentAnswer.IsActive;
            newAnswer.IsCorrect = currentAnswer.IsCorrect;

            return newAnswer;
        }

        public static Question ConvertQuestionFromDTO(QuestionDTO currentQuestion)
        {
            Question newQuestion = new Question();
            newQuestion.Id = currentQuestion.Id;
            newQuestion.QuestionText = currentQuestion.QuestionText;
            newQuestion.IsActive = currentQuestion.IsActive;

            return newQuestion;
        }

        public static QuestionDTO ConvertQuestionToDTO(Question currentQuestion)
        {
            QuestionDTO newQuestion = new QuestionDTO();
            newQuestion.Id = currentQuestion.Id;
            newQuestion.QuestionText = currentQuestion.QuestionText;
            newQuestion.IsActive = currentQuestion.IsActive;

            return newQuestion;
        }
      
        public static Testee CopyTestee(Testee testee)
        {
            Testee newTestee = new Testee();
            newTestee.Trainings = new BindingList<TesteeTraining>();
            newTestee.UserSetting = new Setting();

            //Copy testee
            newTestee.Id = testee.Id;
            newTestee.FirstName = testee.FirstName;
            newTestee.LastName = testee.LastName;
            newTestee.Login = testee.Login;
            newTestee.Password = testee.Password;
            newTestee.IsActive = testee.IsActive;
            newTestee.Email = testee.Email;

            newTestee.Attribute1 = testee.Attribute1;
            newTestee.Attribute2 = testee.Attribute2;
            newTestee.Attribute3 = testee.Attribute3;
            newTestee.Attribute4 = testee.Attribute4;
            newTestee.Attribute5 = testee.Attribute5;
            newTestee.Attribute6 = testee.Attribute6;
            newTestee.Attribute8 = testee.Attribute8;
            newTestee.Attribute9 = testee.Attribute9;
            newTestee.Attribute10 = testee.Attribute10;

            //Copy settings
            newTestee.UserSetting.Id = testee.UserSetting.Id;
            newTestee.UserSetting.FrequencyOfAsking = testee.UserSetting.FrequencyOfAsking;
            newTestee.UserSetting.AmountOfQuestionsPerDay = testee.UserSetting.AmountOfQuestionsPerDay;
            newTestee.UserSetting.TimeOfStart = testee.UserSetting.TimeOfStart;
            newTestee.UserSetting.CanUserEdit = testee.UserSetting.CanUserEdit;
            newTestee.UserSetting.ShowCorrectAnswer = testee.UserSetting.ShowCorrectAnswer;

            if (testee.Trainings != null)
            {
                if (testee.Trainings.Count() > 0)
                {
                    foreach (var training in testee.Trainings)
                    {
                        if (training.Training != null)
                            newTestee.Trainings.Add(training);
                    }
                }
            }

            return newTestee;
        }
    }
}

