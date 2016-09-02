using AdminApplication.TrainingsForms.TrainingAddEdit;
using DataTransferObject;
using DevExpress.XtraEditors;
using DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminApplication.TesteesForm.TesteeAddEdit
{
    public delegate void TesteeChangedEventHandler(object sender, EventArgs e);

    public class TesteeViewModel : INotifyPropertyChanged 
    {    
        public BindingList<Role> AllRoles { get; set; }       
        public BindingList<Training> AllTrainings { get; set; }
        private Testee LoadedTeste{ get; set; }

        #region Testee

        private Testee testee;
        public Testee Testee
        {
            get
            {
                return testee;
            }
            set
            {
                if (testee != value)
                {
                    testee = value;
                    RaisePropertyChanged("Setting");
                    RaisePropertyChanged("AmountOfQuestionsPerDay");
                    RaisePropertyChanged("FrequencyOfAsking");
                    RaisePropertyChanged("TimeOfStart");
                    RaisePropertyChanged("CanUserEdit");
                    RaisePropertyChanged("ShowCorrectAnswer");
                    RaisePropertyChanged("FirstName");
                    RaisePropertyChanged("LastName");
                    RaisePropertyChanged("Email");
                    RaisePropertyChanged("Login");
                    RaisePropertyChanged("Trainings");
                }
            }
        }

        public string FirstName
        {
            get
            {
                return Testee.FirstName;
            }
            set
            {
                if (value != Testee.FirstName)
                {
                    Testee.FirstName = value;
                    RaisePropertyChanged("FirstName");
                }
            }
        }

        public string LastName
        {
            get
            {
                return Testee.LastName;
            }
            set
            {
                if (value != Testee.LastName)
                {
                    Testee.LastName = value;
                    RaisePropertyChanged("LastName");
                }
            }
        }

        public string Email
        {
            get
            {
                return Testee.Email;
            }
            set
            {
                if (value != Testee.Email)
                {
                    Testee.Email = value;
                    RaisePropertyChanged("Email");
                }
            }
        }

        public string Login
        {
            get
            {
                return Testee.Login;
            }
            set
            {
                if (value != Testee.Login)
                {
                    Testee.Login = value;
                    RaisePropertyChanged("Login");
                }
            }
        }

        public BindingList<TesteeTraining> Trainings
        {
            get
            {
                return Testee.Trainings;
            }
            set
            {
                if (value != Testee.Trainings)
                {
                    Testee.Trainings = value;
                    RaisePropertyChanged("Trainings");
                }
            }
        }

        public BindingList<TesteeRoles> Roles
        {
            get
            {
                return Testee.Roles;
            }
            set
            {
                if (value != Testee.Roles)
                {
                    Testee.Roles = value;
                    RaisePropertyChanged("Roles");
                }
            }
        }
        #endregion

        #region Setting

        public Setting Setting 
        { 
            get 
            { 
                return Testee.UserSetting; 
            }
            set 
            {
                if (Testee.UserSetting != value) 
                { 
                    Testee.UserSetting = value;
                    RaisePropertyChanged("Setting");
                    RaisePropertyChanged("AmountOfQuestionsPerDay");
                    RaisePropertyChanged("FrequencyOfAsking");
                    RaisePropertyChanged("TimeOfStart");
                    RaisePropertyChanged("CanUserEdit");
                    RaisePropertyChanged("ShowCorrectAnswer");
                }
            }
        }

        public int AmountOfQuestionsPerDay
        {
            get
            {
                return Setting.AmountOfQuestionsPerDay;
            }
            set
            {
                if (value != Setting.AmountOfQuestionsPerDay)
                {
                    Setting.AmountOfQuestionsPerDay = value;
                    RaisePropertyChanged("AmountOfQuestionsPerDay");
                }
            }
        }

        public int Minutes
        {
            get
            {
                return Setting.Minutes;
            }
            set
            {
                if (value != Setting.Minutes)
                {
                    Setting.Minutes = value;
                    RaisePropertyChanged("Minutes");
                }
            }
        }

        public int Hours
        {
            get
            {
                return Setting.Hours;
            }
            set
            {
                if (value != Setting.Hours)
                {
                    Setting.Hours = value;
                    RaisePropertyChanged("Hours");
                }
            }
        }

        public int Seconds
        {
            get
            {
                return Setting.Seconds;
            }
            set
            {
                if (value != Setting.Seconds)
                {
                    Setting.Seconds = value;
                    RaisePropertyChanged("Seconds");
                }
            }
        }

        public DateTime TimeOfStart
        {
            get 
            { 
                return Setting.TimeOfStart;
            }
            set
            {
                if (value != Setting.TimeOfStart)
                {
                    Setting.TimeOfStart = value;
                    RaisePropertyChanged("TimeOfStart");
                }
            }
        }

        public DateTime StartDate
        {
            get
            {
                return Setting.StartDate;
            }
            set
            {
                if (value != Setting.StartDate)
                {
                    Setting.StartDate = value;
                    RaisePropertyChanged("StartDate");
                }
            }
        }

        public DateTime EndDate
        {
            get
            {
                return Setting.EndDate;
            }
            set
            {
                if (value != Setting.EndDate)
                {
                    Setting.EndDate = value;
                    RaisePropertyChanged("EndDate");
                }
            }
        }

        public RecurrenceType Recurrence
        {
            get
            {
                return Setting.Recurrence;
            }
            set
            {
                if (value != Setting.Recurrence)
                {
                    Setting.Recurrence = value;
                    RaisePropertyChanged("Recurrence");
                }
            }
        }

        public bool CanUserEdit 
        {
            get
            {
                return Setting.CanUserEdit;
            }
            set
            {
                if (value != Setting.CanUserEdit)
                {
                    Setting.CanUserEdit = value;
                    RaisePropertyChanged("CanUserEdit");
                }
            }
        }

        public bool ShowCorrectAnswer
        {
            get
            {
                return Setting.ShowCorrectAnswer;
            }
            set
            {
                if (value != Setting.ShowCorrectAnswer)
                {
                    Setting.ShowCorrectAnswer = value;
                    RaisePropertyChanged("ShowCorrectAnswer");
                }
            }
        }
        
        #endregion
        
        public void SetUpViewModel(Testee testee)
        {
            GetAllTrainings();
            GetAllRoles();
            this.Testee = testee;
            LoadedTeste = Conversion.CopyTestee(testee);
        }

        private void GetAllTrainings()
        {
            AllTrainings = new BindingList<Training>();
            var trainingsList = ServicesHolder.ServiceClient.GetAllTrainings();
            foreach (var training in trainingsList)
            {
                AllTrainings.Add(Conversion.ConvertTrainingFromDTO(training));
            }
        }

        private void GetAllRoles()
        {
            AllRoles = new BindingList<Role>();
            var rolesList = ServicesHolder.ServiceClient.GetAllRoles();
            foreach (var role in rolesList)
            {
                AllRoles.Add(Conversion.ConvertRoleFromDTO(role));
            }
        }

        public void DeleteTraining(TesteeTraining deletedTraining)
        {
            if (deletedTraining != null)
            {
                deletedTraining.IsActive = false;
                Testee.Trainings.Remove(deletedTraining);
                ServicesHolder.ServiceClient.UpdateTesteeTraining(Conversion.ConvertTesteeTrainingToDTO(deletedTraining));
                OnTesteeListChanged(EventArgs.Empty);
            }
        }

        public void AddTraining(TesteeTraining addedTraining)
        {
            if (addedTraining != null)
            {
                addedTraining.IsActive = true;
                Testee.Trainings.Add(addedTraining);
            }
        }

        public void Cancel()
        {
            this.Testee = Conversion.CopyTestee(LoadedTeste);
        }       

        public void Save()
        {
            if (this.Testee != null)
            {
                if (this.Testee.Id == Guid.Empty)
                {
                    var savedTestee = ServicesHolder.ServiceClient.SaveTestee(Conversion.ConvertTesteeToDTO(this.Testee));
                    this.Testee = Conversion.ConvertTesteeFromDTO(savedTestee);
                }
                else
                {
                    var updateTestee = ServicesHolder.ServiceClient.UpdateTestee(Conversion.ConvertTesteeToDTO(this.Testee));
                    this.Testee = Conversion.ConvertTesteeFromDTO(updateTestee);
                }
            }
        }    
          
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        protected virtual void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));

            }
        }
              
        public event TesteeChangedEventHandler TesteeListChanged;
        protected virtual void OnTesteeListChanged(EventArgs e)
        {
            if (TesteeListChanged != null)
                TesteeListChanged(this, e);
        }
    }
}
