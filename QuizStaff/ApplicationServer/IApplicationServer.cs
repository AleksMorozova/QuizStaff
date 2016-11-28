﻿using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServer
{
    [ServiceContract]
    public interface IApplicationServer
    {
        [OperationContract]
        List<TesteeDTO> GetAllTestees();

        [OperationContract]
        void SaveAllTestees(ICollection<TesteeDTO> testees);

        [OperationContract]
        TesteeDTO GetTesteeByID(Guid id);

        [OperationContract]
        void SaveTesteeAnswer(HistoryDTO history);

        [OperationContract]
        QuestionDTO GetRandomQuestionForTestee(Guid id);

        [OperationContract]
        List<TrainingDTO> GetAllActiveTrainings();

        [OperationContract]
        List<TrainingDTO> GetAllTrainings();

        [OperationContract]
        void SaveAllTrainings(ICollection<TrainingDTO> trainings);

        [OperationContract]
        TesteeDTO FindByLogin(string login);

        [OperationContract]
        void SaveAnswer(QuestionDTO question);

        [OperationContract]
        TrainingDTO UpdateTraining(TrainingDTO training);

        [OperationContract]
        TrainingDTO SaveTraining(TrainingDTO training);

        [OperationContract]
        void UpdateQuestion(QuestionDTO training);

        [OperationContract]
        void SaveQuestion(QuestionDTO training);

        [OperationContract]
        TesteeDTO UpdateTestee(TesteeDTO testee);

        [OperationContract]
        TesteeDTO SaveTestee(TesteeDTO testee);

        [OperationContract]
        void UpdateSettings(SettingDTO[] setting);

        [OperationContract]
        void DeleteAnswer(AnswerDTO answer);

        [OperationContract]
        void DeleteTesteeTraining(TesteeTrainingDTO testeeTraining);

        [OperationContract]
        void UpdateTesteeTrainings(TesteeTrainingDTO[] testeeTraining);

        [OperationContract]
        void UpdateTesteeTraining(TesteeTrainingDTO testeeTraining);

        [OperationContract]
        TrainingDTO FindByTitle(string title);

        [OperationContract]
        List<RoleDTO> GetAllRoles();

        [OperationContract]
        List<PermissionDTO> GetAllPermissions();

        [OperationContract]
        void UpdateRoles(RoleDTO role);

        [OperationContract]
        void UpdatePermissions(PermissionDTO permission);

        [OperationContract]
        void AddTesteeRole(TesteeDTO testee, RoleDTO role);

        [OperationContract]
        void UpdateAnswer(AnswerDTO answer);

        [OperationContract]
        void LoadTrainings();

        [OperationContract]
        void LoadTesteeFromEPE();

        [OperationContract]
        List<TesteeDTO> GetAllTesteesForReport(DateTime from, DateTime to);
    }
}
