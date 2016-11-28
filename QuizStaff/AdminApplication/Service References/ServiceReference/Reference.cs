﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdminApplication.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IApplicationServer")]
    public interface IApplicationServer {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/GetAllTestees", ReplyAction="http://tempuri.org/IApplicationServer/GetAllTesteesResponse")]
        DataTransferObject.TesteeDTO[] GetAllTestees();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/GetAllTestees", ReplyAction="http://tempuri.org/IApplicationServer/GetAllTesteesResponse")]
        System.Threading.Tasks.Task<DataTransferObject.TesteeDTO[]> GetAllTesteesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/SaveAllTestees", ReplyAction="http://tempuri.org/IApplicationServer/SaveAllTesteesResponse")]
        void SaveAllTestees(DataTransferObject.TesteeDTO[] testees);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/SaveAllTestees", ReplyAction="http://tempuri.org/IApplicationServer/SaveAllTesteesResponse")]
        System.Threading.Tasks.Task SaveAllTesteesAsync(DataTransferObject.TesteeDTO[] testees);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/GetTesteeByID", ReplyAction="http://tempuri.org/IApplicationServer/GetTesteeByIDResponse")]
        DataTransferObject.TesteeDTO GetTesteeByID(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/GetTesteeByID", ReplyAction="http://tempuri.org/IApplicationServer/GetTesteeByIDResponse")]
        System.Threading.Tasks.Task<DataTransferObject.TesteeDTO> GetTesteeByIDAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/SaveTesteeAnswer", ReplyAction="http://tempuri.org/IApplicationServer/SaveTesteeAnswerResponse")]
        void SaveTesteeAnswer(DataTransferObject.HistoryDTO history);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/SaveTesteeAnswer", ReplyAction="http://tempuri.org/IApplicationServer/SaveTesteeAnswerResponse")]
        System.Threading.Tasks.Task SaveTesteeAnswerAsync(DataTransferObject.HistoryDTO history);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/GetRandomQuestionForTestee", ReplyAction="http://tempuri.org/IApplicationServer/GetRandomQuestionForTesteeResponse")]
        DataTransferObject.QuestionDTO GetRandomQuestionForTestee(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/GetRandomQuestionForTestee", ReplyAction="http://tempuri.org/IApplicationServer/GetRandomQuestionForTesteeResponse")]
        System.Threading.Tasks.Task<DataTransferObject.QuestionDTO> GetRandomQuestionForTesteeAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/GetAllActiveTrainings", ReplyAction="http://tempuri.org/IApplicationServer/GetAllActiveTrainingsResponse")]
        DataTransferObject.TrainingDTO[] GetAllActiveTrainings();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/GetAllActiveTrainings", ReplyAction="http://tempuri.org/IApplicationServer/GetAllActiveTrainingsResponse")]
        System.Threading.Tasks.Task<DataTransferObject.TrainingDTO[]> GetAllActiveTrainingsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/GetAllTrainings", ReplyAction="http://tempuri.org/IApplicationServer/GetAllTrainingsResponse")]
        DataTransferObject.TrainingDTO[] GetAllTrainings();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/GetAllTrainings", ReplyAction="http://tempuri.org/IApplicationServer/GetAllTrainingsResponse")]
        System.Threading.Tasks.Task<DataTransferObject.TrainingDTO[]> GetAllTrainingsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/SaveAllTrainings", ReplyAction="http://tempuri.org/IApplicationServer/SaveAllTrainingsResponse")]
        void SaveAllTrainings(DataTransferObject.TrainingDTO[] trainings);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/SaveAllTrainings", ReplyAction="http://tempuri.org/IApplicationServer/SaveAllTrainingsResponse")]
        System.Threading.Tasks.Task SaveAllTrainingsAsync(DataTransferObject.TrainingDTO[] trainings);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/FindByLogin", ReplyAction="http://tempuri.org/IApplicationServer/FindByLoginResponse")]
        DataTransferObject.TesteeDTO FindByLogin(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/FindByLogin", ReplyAction="http://tempuri.org/IApplicationServer/FindByLoginResponse")]
        System.Threading.Tasks.Task<DataTransferObject.TesteeDTO> FindByLoginAsync(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/SaveAnswer", ReplyAction="http://tempuri.org/IApplicationServer/SaveAnswerResponse")]
        void SaveAnswer(DataTransferObject.QuestionDTO question);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/SaveAnswer", ReplyAction="http://tempuri.org/IApplicationServer/SaveAnswerResponse")]
        System.Threading.Tasks.Task SaveAnswerAsync(DataTransferObject.QuestionDTO question);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/UpdateTraining", ReplyAction="http://tempuri.org/IApplicationServer/UpdateTrainingResponse")]
        DataTransferObject.TrainingDTO UpdateTraining(DataTransferObject.TrainingDTO training);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/UpdateTraining", ReplyAction="http://tempuri.org/IApplicationServer/UpdateTrainingResponse")]
        System.Threading.Tasks.Task<DataTransferObject.TrainingDTO> UpdateTrainingAsync(DataTransferObject.TrainingDTO training);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/SaveTraining", ReplyAction="http://tempuri.org/IApplicationServer/SaveTrainingResponse")]
        DataTransferObject.TrainingDTO SaveTraining(DataTransferObject.TrainingDTO training);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/SaveTraining", ReplyAction="http://tempuri.org/IApplicationServer/SaveTrainingResponse")]
        System.Threading.Tasks.Task<DataTransferObject.TrainingDTO> SaveTrainingAsync(DataTransferObject.TrainingDTO training);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/UpdateQuestion", ReplyAction="http://tempuri.org/IApplicationServer/UpdateQuestionResponse")]
        void UpdateQuestion(DataTransferObject.QuestionDTO training);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/UpdateQuestion", ReplyAction="http://tempuri.org/IApplicationServer/UpdateQuestionResponse")]
        System.Threading.Tasks.Task UpdateQuestionAsync(DataTransferObject.QuestionDTO training);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/SaveQuestion", ReplyAction="http://tempuri.org/IApplicationServer/SaveQuestionResponse")]
        void SaveQuestion(DataTransferObject.QuestionDTO training);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/SaveQuestion", ReplyAction="http://tempuri.org/IApplicationServer/SaveQuestionResponse")]
        System.Threading.Tasks.Task SaveQuestionAsync(DataTransferObject.QuestionDTO training);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/UpdateTestee", ReplyAction="http://tempuri.org/IApplicationServer/UpdateTesteeResponse")]
        DataTransferObject.TesteeDTO UpdateTestee(DataTransferObject.TesteeDTO testee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/UpdateTestee", ReplyAction="http://tempuri.org/IApplicationServer/UpdateTesteeResponse")]
        System.Threading.Tasks.Task<DataTransferObject.TesteeDTO> UpdateTesteeAsync(DataTransferObject.TesteeDTO testee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/SaveTestee", ReplyAction="http://tempuri.org/IApplicationServer/SaveTesteeResponse")]
        DataTransferObject.TesteeDTO SaveTestee(DataTransferObject.TesteeDTO testee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/SaveTestee", ReplyAction="http://tempuri.org/IApplicationServer/SaveTesteeResponse")]
        System.Threading.Tasks.Task<DataTransferObject.TesteeDTO> SaveTesteeAsync(DataTransferObject.TesteeDTO testee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/UpdateSettings", ReplyAction="http://tempuri.org/IApplicationServer/UpdateSettingsResponse")]
        void UpdateSettings(DataTransferObject.SettingDTO[] setting);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/UpdateSettings", ReplyAction="http://tempuri.org/IApplicationServer/UpdateSettingsResponse")]
        System.Threading.Tasks.Task UpdateSettingsAsync(DataTransferObject.SettingDTO[] setting);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/DeleteAnswer", ReplyAction="http://tempuri.org/IApplicationServer/DeleteAnswerResponse")]
        void DeleteAnswer(DataTransferObject.AnswerDTO answer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/DeleteAnswer", ReplyAction="http://tempuri.org/IApplicationServer/DeleteAnswerResponse")]
        System.Threading.Tasks.Task DeleteAnswerAsync(DataTransferObject.AnswerDTO answer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/DeleteTesteeTraining", ReplyAction="http://tempuri.org/IApplicationServer/DeleteTesteeTrainingResponse")]
        void DeleteTesteeTraining(DataTransferObject.TesteeTrainingDTO testeeTraining);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/DeleteTesteeTraining", ReplyAction="http://tempuri.org/IApplicationServer/DeleteTesteeTrainingResponse")]
        System.Threading.Tasks.Task DeleteTesteeTrainingAsync(DataTransferObject.TesteeTrainingDTO testeeTraining);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/UpdateTesteeTrainings", ReplyAction="http://tempuri.org/IApplicationServer/UpdateTesteeTrainingsResponse")]
        void UpdateTesteeTrainings(DataTransferObject.TesteeTrainingDTO[] testeeTraining);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/UpdateTesteeTrainings", ReplyAction="http://tempuri.org/IApplicationServer/UpdateTesteeTrainingsResponse")]
        System.Threading.Tasks.Task UpdateTesteeTrainingsAsync(DataTransferObject.TesteeTrainingDTO[] testeeTraining);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/UpdateTesteeTraining", ReplyAction="http://tempuri.org/IApplicationServer/UpdateTesteeTrainingResponse")]
        void UpdateTesteeTraining(DataTransferObject.TesteeTrainingDTO testeeTraining);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/UpdateTesteeTraining", ReplyAction="http://tempuri.org/IApplicationServer/UpdateTesteeTrainingResponse")]
        System.Threading.Tasks.Task UpdateTesteeTrainingAsync(DataTransferObject.TesteeTrainingDTO testeeTraining);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/FindByTitle", ReplyAction="http://tempuri.org/IApplicationServer/FindByTitleResponse")]
        DataTransferObject.TrainingDTO FindByTitle(string title);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/FindByTitle", ReplyAction="http://tempuri.org/IApplicationServer/FindByTitleResponse")]
        System.Threading.Tasks.Task<DataTransferObject.TrainingDTO> FindByTitleAsync(string title);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/GetAllRoles", ReplyAction="http://tempuri.org/IApplicationServer/GetAllRolesResponse")]
        DataTransferObject.RoleDTO[] GetAllRoles();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/GetAllRoles", ReplyAction="http://tempuri.org/IApplicationServer/GetAllRolesResponse")]
        System.Threading.Tasks.Task<DataTransferObject.RoleDTO[]> GetAllRolesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/GetAllPermissions", ReplyAction="http://tempuri.org/IApplicationServer/GetAllPermissionsResponse")]
        DataTransferObject.PermissionDTO[] GetAllPermissions();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/GetAllPermissions", ReplyAction="http://tempuri.org/IApplicationServer/GetAllPermissionsResponse")]
        System.Threading.Tasks.Task<DataTransferObject.PermissionDTO[]> GetAllPermissionsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/UpdateRoles", ReplyAction="http://tempuri.org/IApplicationServer/UpdateRolesResponse")]
        void UpdateRoles(DataTransferObject.RoleDTO role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/UpdateRoles", ReplyAction="http://tempuri.org/IApplicationServer/UpdateRolesResponse")]
        System.Threading.Tasks.Task UpdateRolesAsync(DataTransferObject.RoleDTO role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/UpdatePermissions", ReplyAction="http://tempuri.org/IApplicationServer/UpdatePermissionsResponse")]
        void UpdatePermissions(DataTransferObject.PermissionDTO permission);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/UpdatePermissions", ReplyAction="http://tempuri.org/IApplicationServer/UpdatePermissionsResponse")]
        System.Threading.Tasks.Task UpdatePermissionsAsync(DataTransferObject.PermissionDTO permission);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/AddTesteeRole", ReplyAction="http://tempuri.org/IApplicationServer/AddTesteeRoleResponse")]
        void AddTesteeRole(DataTransferObject.TesteeDTO testee, DataTransferObject.RoleDTO role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/AddTesteeRole", ReplyAction="http://tempuri.org/IApplicationServer/AddTesteeRoleResponse")]
        System.Threading.Tasks.Task AddTesteeRoleAsync(DataTransferObject.TesteeDTO testee, DataTransferObject.RoleDTO role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/UpdateAnswer", ReplyAction="http://tempuri.org/IApplicationServer/UpdateAnswerResponse")]
        void UpdateAnswer(DataTransferObject.AnswerDTO answer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/UpdateAnswer", ReplyAction="http://tempuri.org/IApplicationServer/UpdateAnswerResponse")]
        System.Threading.Tasks.Task UpdateAnswerAsync(DataTransferObject.AnswerDTO answer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/LoadTrainings", ReplyAction="http://tempuri.org/IApplicationServer/LoadTrainingsResponse")]
        void LoadTrainings();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/LoadTrainings", ReplyAction="http://tempuri.org/IApplicationServer/LoadTrainingsResponse")]
        System.Threading.Tasks.Task LoadTrainingsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/LoadTesteeFromEPE", ReplyAction="http://tempuri.org/IApplicationServer/LoadTesteeFromEPEResponse")]
        void LoadTesteeFromEPE();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/LoadTesteeFromEPE", ReplyAction="http://tempuri.org/IApplicationServer/LoadTesteeFromEPEResponse")]
        System.Threading.Tasks.Task LoadTesteeFromEPEAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/GetAllTesteesForReport", ReplyAction="http://tempuri.org/IApplicationServer/GetAllTesteesForReportResponse")]
        DataTransferObject.TesteeDTO[] GetAllTesteesForReport(System.DateTime from, System.DateTime to);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/GetAllTesteesForReport", ReplyAction="http://tempuri.org/IApplicationServer/GetAllTesteesForReportResponse")]
        System.Threading.Tasks.Task<DataTransferObject.TesteeDTO[]> GetAllTesteesForReportAsync(System.DateTime from, System.DateTime to);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IApplicationServerChannel : AdminApplication.ServiceReference.IApplicationServer, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ApplicationServerClient : System.ServiceModel.ClientBase<AdminApplication.ServiceReference.IApplicationServer>, AdminApplication.ServiceReference.IApplicationServer {
        
        public ApplicationServerClient() {
        }
        
        public ApplicationServerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ApplicationServerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ApplicationServerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ApplicationServerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DataTransferObject.TesteeDTO[] GetAllTestees() {
            return base.Channel.GetAllTestees();
        }
        
        public System.Threading.Tasks.Task<DataTransferObject.TesteeDTO[]> GetAllTesteesAsync() {
            return base.Channel.GetAllTesteesAsync();
        }
        
        public void SaveAllTestees(DataTransferObject.TesteeDTO[] testees) {
            base.Channel.SaveAllTestees(testees);
        }
        
        public System.Threading.Tasks.Task SaveAllTesteesAsync(DataTransferObject.TesteeDTO[] testees) {
            return base.Channel.SaveAllTesteesAsync(testees);
        }
        
        public DataTransferObject.TesteeDTO GetTesteeByID(System.Guid id) {
            return base.Channel.GetTesteeByID(id);
        }
        
        public System.Threading.Tasks.Task<DataTransferObject.TesteeDTO> GetTesteeByIDAsync(System.Guid id) {
            return base.Channel.GetTesteeByIDAsync(id);
        }
        
        public void SaveTesteeAnswer(DataTransferObject.HistoryDTO history) {
            base.Channel.SaveTesteeAnswer(history);
        }
        
        public System.Threading.Tasks.Task SaveTesteeAnswerAsync(DataTransferObject.HistoryDTO history) {
            return base.Channel.SaveTesteeAnswerAsync(history);
        }
        
        public DataTransferObject.QuestionDTO GetRandomQuestionForTestee(System.Guid id) {
            return base.Channel.GetRandomQuestionForTestee(id);
        }
        
        public System.Threading.Tasks.Task<DataTransferObject.QuestionDTO> GetRandomQuestionForTesteeAsync(System.Guid id) {
            return base.Channel.GetRandomQuestionForTesteeAsync(id);
        }
        
        public DataTransferObject.TrainingDTO[] GetAllActiveTrainings() {
            return base.Channel.GetAllActiveTrainings();
        }
        
        public System.Threading.Tasks.Task<DataTransferObject.TrainingDTO[]> GetAllActiveTrainingsAsync() {
            return base.Channel.GetAllActiveTrainingsAsync();
        }
        
        public DataTransferObject.TrainingDTO[] GetAllTrainings() {
            return base.Channel.GetAllTrainings();
        }
        
        public System.Threading.Tasks.Task<DataTransferObject.TrainingDTO[]> GetAllTrainingsAsync() {
            return base.Channel.GetAllTrainingsAsync();
        }
        
        public void SaveAllTrainings(DataTransferObject.TrainingDTO[] trainings) {
            base.Channel.SaveAllTrainings(trainings);
        }
        
        public System.Threading.Tasks.Task SaveAllTrainingsAsync(DataTransferObject.TrainingDTO[] trainings) {
            return base.Channel.SaveAllTrainingsAsync(trainings);
        }
        
        public DataTransferObject.TesteeDTO FindByLogin(string login) {
            return base.Channel.FindByLogin(login);
        }
        
        public System.Threading.Tasks.Task<DataTransferObject.TesteeDTO> FindByLoginAsync(string login) {
            return base.Channel.FindByLoginAsync(login);
        }
        
        public void SaveAnswer(DataTransferObject.QuestionDTO question) {
            base.Channel.SaveAnswer(question);
        }
        
        public System.Threading.Tasks.Task SaveAnswerAsync(DataTransferObject.QuestionDTO question) {
            return base.Channel.SaveAnswerAsync(question);
        }
        
        public DataTransferObject.TrainingDTO UpdateTraining(DataTransferObject.TrainingDTO training) {
            return base.Channel.UpdateTraining(training);
        }
        
        public System.Threading.Tasks.Task<DataTransferObject.TrainingDTO> UpdateTrainingAsync(DataTransferObject.TrainingDTO training) {
            return base.Channel.UpdateTrainingAsync(training);
        }
        
        public DataTransferObject.TrainingDTO SaveTraining(DataTransferObject.TrainingDTO training) {
            return base.Channel.SaveTraining(training);
        }
        
        public System.Threading.Tasks.Task<DataTransferObject.TrainingDTO> SaveTrainingAsync(DataTransferObject.TrainingDTO training) {
            return base.Channel.SaveTrainingAsync(training);
        }
        
        public void UpdateQuestion(DataTransferObject.QuestionDTO training) {
            base.Channel.UpdateQuestion(training);
        }
        
        public System.Threading.Tasks.Task UpdateQuestionAsync(DataTransferObject.QuestionDTO training) {
            return base.Channel.UpdateQuestionAsync(training);
        }
        
        public void SaveQuestion(DataTransferObject.QuestionDTO training) {
            base.Channel.SaveQuestion(training);
        }
        
        public System.Threading.Tasks.Task SaveQuestionAsync(DataTransferObject.QuestionDTO training) {
            return base.Channel.SaveQuestionAsync(training);
        }
        
        public DataTransferObject.TesteeDTO UpdateTestee(DataTransferObject.TesteeDTO testee) {
            return base.Channel.UpdateTestee(testee);
        }
        
        public System.Threading.Tasks.Task<DataTransferObject.TesteeDTO> UpdateTesteeAsync(DataTransferObject.TesteeDTO testee) {
            return base.Channel.UpdateTesteeAsync(testee);
        }
        
        public DataTransferObject.TesteeDTO SaveTestee(DataTransferObject.TesteeDTO testee) {
            return base.Channel.SaveTestee(testee);
        }
        
        public System.Threading.Tasks.Task<DataTransferObject.TesteeDTO> SaveTesteeAsync(DataTransferObject.TesteeDTO testee) {
            return base.Channel.SaveTesteeAsync(testee);
        }
        
        public void UpdateSettings(DataTransferObject.SettingDTO[] setting) {
            base.Channel.UpdateSettings(setting);
        }
        
        public System.Threading.Tasks.Task UpdateSettingsAsync(DataTransferObject.SettingDTO[] setting) {
            return base.Channel.UpdateSettingsAsync(setting);
        }
        
        public void DeleteAnswer(DataTransferObject.AnswerDTO answer) {
            base.Channel.DeleteAnswer(answer);
        }
        
        public System.Threading.Tasks.Task DeleteAnswerAsync(DataTransferObject.AnswerDTO answer) {
            return base.Channel.DeleteAnswerAsync(answer);
        }
        
        public void DeleteTesteeTraining(DataTransferObject.TesteeTrainingDTO testeeTraining) {
            base.Channel.DeleteTesteeTraining(testeeTraining);
        }
        
        public System.Threading.Tasks.Task DeleteTesteeTrainingAsync(DataTransferObject.TesteeTrainingDTO testeeTraining) {
            return base.Channel.DeleteTesteeTrainingAsync(testeeTraining);
        }
        
        public void UpdateTesteeTrainings(DataTransferObject.TesteeTrainingDTO[] testeeTraining) {
            base.Channel.UpdateTesteeTrainings(testeeTraining);
        }
        
        public System.Threading.Tasks.Task UpdateTesteeTrainingsAsync(DataTransferObject.TesteeTrainingDTO[] testeeTraining) {
            return base.Channel.UpdateTesteeTrainingsAsync(testeeTraining);
        }
        
        public void UpdateTesteeTraining(DataTransferObject.TesteeTrainingDTO testeeTraining) {
            base.Channel.UpdateTesteeTraining(testeeTraining);
        }
        
        public System.Threading.Tasks.Task UpdateTesteeTrainingAsync(DataTransferObject.TesteeTrainingDTO testeeTraining) {
            return base.Channel.UpdateTesteeTrainingAsync(testeeTraining);
        }
        
        public DataTransferObject.TrainingDTO FindByTitle(string title) {
            return base.Channel.FindByTitle(title);
        }
        
        public System.Threading.Tasks.Task<DataTransferObject.TrainingDTO> FindByTitleAsync(string title) {
            return base.Channel.FindByTitleAsync(title);
        }
        
        public DataTransferObject.RoleDTO[] GetAllRoles() {
            return base.Channel.GetAllRoles();
        }
        
        public System.Threading.Tasks.Task<DataTransferObject.RoleDTO[]> GetAllRolesAsync() {
            return base.Channel.GetAllRolesAsync();
        }
        
        public DataTransferObject.PermissionDTO[] GetAllPermissions() {
            return base.Channel.GetAllPermissions();
        }
        
        public System.Threading.Tasks.Task<DataTransferObject.PermissionDTO[]> GetAllPermissionsAsync() {
            return base.Channel.GetAllPermissionsAsync();
        }
        
        public void UpdateRoles(DataTransferObject.RoleDTO role) {
            base.Channel.UpdateRoles(role);
        }
        
        public System.Threading.Tasks.Task UpdateRolesAsync(DataTransferObject.RoleDTO role) {
            return base.Channel.UpdateRolesAsync(role);
        }
        
        public void UpdatePermissions(DataTransferObject.PermissionDTO permission) {
            base.Channel.UpdatePermissions(permission);
        }
        
        public System.Threading.Tasks.Task UpdatePermissionsAsync(DataTransferObject.PermissionDTO permission) {
            return base.Channel.UpdatePermissionsAsync(permission);
        }
        
        public void AddTesteeRole(DataTransferObject.TesteeDTO testee, DataTransferObject.RoleDTO role) {
            base.Channel.AddTesteeRole(testee, role);
        }
        
        public System.Threading.Tasks.Task AddTesteeRoleAsync(DataTransferObject.TesteeDTO testee, DataTransferObject.RoleDTO role) {
            return base.Channel.AddTesteeRoleAsync(testee, role);
        }
        
        public void UpdateAnswer(DataTransferObject.AnswerDTO answer) {
            base.Channel.UpdateAnswer(answer);
        }
        
        public System.Threading.Tasks.Task UpdateAnswerAsync(DataTransferObject.AnswerDTO answer) {
            return base.Channel.UpdateAnswerAsync(answer);
        }
        
        public void LoadTrainings() {
            base.Channel.LoadTrainings();
        }
        
        public System.Threading.Tasks.Task LoadTrainingsAsync() {
            return base.Channel.LoadTrainingsAsync();
        }
        
        public void LoadTesteeFromEPE() {
            base.Channel.LoadTesteeFromEPE();
        }
        
        public System.Threading.Tasks.Task LoadTesteeFromEPEAsync() {
            return base.Channel.LoadTesteeFromEPEAsync();
        }
        
        public DataTransferObject.TesteeDTO[] GetAllTesteesForReport(System.DateTime from, System.DateTime to) {
            return base.Channel.GetAllTesteesForReport(from, to);
        }
        
        public System.Threading.Tasks.Task<DataTransferObject.TesteeDTO[]> GetAllTesteesForReportAsync(System.DateTime from, System.DateTime to) {
            return base.Channel.GetAllTesteesForReportAsync(from, to);
        }
    }
}
