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
    public class TesteeViewModel : INotifyPropertyChanged 
    {
        private Testee LoadedTeste
        {
            get;
            set;
        }

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
                   // OnPropertyChanged("Email");
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

        public int FrequencyOfAsking
        {
            get
            {
                return Setting.FrequencyOfAsking;
            }
            set
            {
                if (value != Setting.FrequencyOfAsking)
                {
                    Setting.FrequencyOfAsking = value;
                    RaisePropertyChanged("FrequencyOfAsking");
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
            this.Testee = testee;
            LoadedTeste = Conversion.CopyTestee(testee);
        }

        public void AddTraining(Testee testee)
        {
            TrainingAddEditForm trainingForm = new TrainingAddEditForm();
            FormManager.Instance.OpenChildForm(trainingForm, "Add training");
            FormManager.LocalizedFormList.Add(trainingForm);
            FormManager.Instance.LocalizedForms(Program.currentLang);
        }

        public BindingList<Training> AllTrainings { get; set; }

        public void GetAllTrainings()
        {
            AllTrainings = new BindingList<Training>();
            var trainingsList = ServicesHolder.ServiceClient.GetAllTrainings();
            foreach (var training in trainingsList)
            {
                AllTrainings.Add(Conversion.ConvertTrainingFromDTO(training));
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

        public void DeleteTraining(TesteeTraining deletedTraining)
        {
            if (deletedTraining!=null)
                deletedTraining.IsActive = false;
        }
    }
}
