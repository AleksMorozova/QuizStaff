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
            newTestee.UserSetting.Hours = testee.UserSetting.Hours;
            newTestee.UserSetting.Minutes = testee.UserSetting.Minutes;
            newTestee.UserSetting.Seconds = testee.UserSetting.Seconds;
            newTestee.UserSetting.StartDate = testee.UserSetting.TimeOfStart;
            newTestee.UserSetting.EndDate = (testee.UserSetting.EndDate != DateTime.MinValue) ? testee.UserSetting.EndDate : DateTime.MaxValue;
            newTestee.UserSetting.Recurrence = testee.UserSetting.Recurrence;

            newTestee.UserSetting.AmountOfQuestionsPerDay = testee.UserSetting.AmountOfQuestionsPerDay;
            newTestee.UserSetting.TimeOfStart = testee.UserSetting.TimeOfStart;
            newTestee.UserSetting.CanUserEdit = testee.UserSetting.CanUserEdit;
            newTestee.UserSetting.ShowCorrectAnswer = testee.UserSetting.ShowCorrectAnswer;

            newTestee.Roles = new BindingList<TesteeRolesDTO>();

            if (testee.Roles!=null && testee.Roles.Count() > 0)
            {
                foreach (var role in testee.Roles)
                {
                    if (role.Role != null)
                        newTestee.Roles.Add(ConvertTesteeRoleToDTO(role));
                }
            } 

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

            if (testee.Histories != null)
            {
                if (testee.Histories.Count() > 0)
                {
                    foreach (var t in testee.Histories)
                    {
                        newTestee.Histories.Add(ConvertHistoryToDTO(t));
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
            newTestee.UserSetting.Hours = testee.UserSetting.Hours;
            newTestee.UserSetting.Minutes = testee.UserSetting.Minutes;
            newTestee.UserSetting.Seconds = testee.UserSetting.Seconds;
            newTestee.UserSetting.EndDate = (testee.UserSetting.EndDate != DateTime.MinValue) ? testee.UserSetting.EndDate : DateTime.MaxValue;
            newTestee.UserSetting.Recurrence = testee.UserSetting.Recurrence;
            newTestee.UserSetting.AmountOfQuestionsPerDay = testee.UserSetting.AmountOfQuestionsPerDay;
            newTestee.UserSetting.TimeOfStart = testee.UserSetting.TimeOfStart;
            newTestee.UserSetting.CanUserEdit = testee.UserSetting.CanUserEdit;
            newTestee.UserSetting.ShowCorrectAnswer = testee.UserSetting.ShowCorrectAnswer;

            newTestee.Roles = new BindingList<TesteeRoles>();
            if (testee.Roles.Count() > 0)
            {
                foreach (var role in testee.Roles)
                {
                    if (role.Role != null)
                        newTestee.Roles.Add(ConvertTesteeRoleFromDTO(role));
                }
            } 

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
            newTestee.Histories = new BindingList<History>();
            if (testee.Histories != null)
            {
                if (testee.Histories.Count() > 0)
                {
                    foreach (var t in testee.Histories)
                    {
                        newTestee.Histories.Add(ConvertHistoryFromDTO(t));
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
            newHistory.IsAnswerCorrect = currentHistory.IsAnswerCorrect;
            newHistory.Question = Conversion.ConvertQuestionFromDTO(currentHistory.Question);
            return newHistory;
        }

        public static HistoryDTO ConvertHistoryToDTO(History currentHistory) 
        {
            HistoryDTO newHistory = new HistoryDTO();
            newHistory.Id = currentHistory.Id;
            newHistory.AnsweringDate = currentHistory.AnsweringDate;
            newHistory.IsAnswerCorrect = currentHistory.IsAnswerCorrect;
            newHistory.Question = Conversion.ConvertQuestionToDTO(currentHistory.Question);
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
            newTestee.UserSetting.Hours = testee.UserSetting.Hours;
            newTestee.UserSetting.Minutes = testee.UserSetting.Minutes;
            newTestee.UserSetting.Seconds = testee.UserSetting.Seconds;
            newTestee.UserSetting.EndDate = (testee.UserSetting.EndDate !=DateTime.MinValue) ? testee.UserSetting.EndDate : DateTime.MaxValue;
            newTestee.UserSetting.Recurrence = testee.UserSetting.Recurrence;
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

        public static Training CopyTraining(Training currentTraining)
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

        public static Setting CopySetting(Setting setting)
        {
            Setting newSetting = new Setting();

            newSetting.Id = setting.Id;
            newSetting.Hours = setting.Hours;
            newSetting.Minutes = setting.Minutes;
            newSetting.Seconds = setting.Seconds;
            newSetting.EndDate = setting.EndDate;
            newSetting.Recurrence = setting.Recurrence;
            newSetting.AmountOfQuestionsPerDay = setting.AmountOfQuestionsPerDay;
            newSetting.TimeOfStart = setting.TimeOfStart;
            newSetting.CanUserEdit = setting.CanUserEdit;
            newSetting.ShowCorrectAnswer = setting.ShowCorrectAnswer;

            return newSetting;
        }

        public static Role ConvertRoleFromDTO(RoleDTO role) 
        {
            Role newRole = new Role();
            newRole.Id = role.Id;
            newRole.Name = role.Name;
            newRole.Permissions = new BindingList<RolePermission>();

            foreach (var p in role.Permissions)
            {
                RolePermission permission = new RolePermission();
                permission.Id = p.Id;

                permission.Permission = new Permission();
                permission.Permission.Id = p.Permission.Id;
                permission.Permission.Title = p.Permission.Title;
                permission.Permission.Type = p.Permission.Type;

                newRole.Permissions.Add(permission);
            }

            return newRole;
        }

        public static RoleDTO ConvertRoleToDTO(Role role)
        {
            RoleDTO newRole = new RoleDTO();
            newRole.Id = role.Id;
            newRole.Name = role.Name;
            newRole.Permissions = new BindingList<RolePermissionDTO>();

            foreach (var p in role.Permissions)
            {
                RolePermissionDTO permission = new RolePermissionDTO();
                permission.Id = p.Id;

                permission.Permission = new Permission();
                permission.Permission.Id = p.Permission.Id;
                permission.Permission.Title = p.Permission.Title;
                permission.Permission.Type = p.Permission.Type;

                newRole.Permissions.Add(permission);
            }

            return newRole;
        }

        public static RolePermission ConvertRolePermissonFromDTO(RolePermissionDTO rolePermission)
        {
            RolePermission newRolePermission = new RolePermission();
            newRolePermission.Id = rolePermission.Id;
            newRolePermission.Role = Conversion.ConvertRoleFromDTO(rolePermission.Role);

            newRolePermission.Permission = new Permission();
            newRolePermission.Permission.Id = rolePermission.Permission.Id;
            newRolePermission.Permission.Title = rolePermission.Permission.Title;
            newRolePermission.Permission.Type = rolePermission.Permission.Type;

            return newRolePermission;
        }

        public static RolePermissionDTO ConvertRolePermissonToDTO(RolePermission rolePermission)
        {
            RolePermissionDTO newRolePermission = new RolePermissionDTO();
            newRolePermission.Id = rolePermission.Id;
            newRolePermission.Role = Conversion.ConvertRoleToDTO(rolePermission.Role);

            newRolePermission.Permission = new PermissionDTO();
            newRolePermission.Permission.Id = rolePermission.Permission.Id;
            newRolePermission.Permission.Title = rolePermission.Permission.Title;
            newRolePermission.Permission.Type = rolePermission.Permission.Type;

            return newRolePermission;
        }

        public static TesteeRolesDTO ConvertTesteeRoleToDTO(TesteeRoles role)
        {
            TesteeRolesDTO newRole = new TesteeRolesDTO();
            newRole.IsActive = role.IsActive;
            newRole.Id = role.Id;
            newRole.Role = ConvertRoleToDTO(role.Role);
            return newRole;
        }

        public static TesteeRoles ConvertTesteeRoleFromDTO(TesteeRolesDTO role)
        {
            TesteeRoles newRole = new TesteeRoles();
            newRole.IsActive = role.IsActive;
            newRole.Id = role.Id;
            newRole.Role = ConvertRoleFromDTO(role.Role);
            return newRole;
        }
    }
}

