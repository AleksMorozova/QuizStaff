using DomainModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class TesteeDTO : INotifyPropertyChanged
    {

        public TesteeDTO() 
        {
            trainings = new BindingList<TesteeTrainingDTO>();
            userSetting = new SettingDTO();
        }

        public Guid Id { get; set; }
        public bool IsActive { get; set; }

        private string firstName;
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (value != firstName)
                {
                    firstName = value;
                    OnPropertyChanged("FirstName");
                }
            }
        }

        private string lastName;
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (value != lastName)
                {
                    lastName = value;
                    OnPropertyChanged("LastName");
                }
            }
        }

        private string email;
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (value != email)
                {
                    email = value;
                    OnPropertyChanged("Email");
                }
            }
        }

        private string login;
        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                if (value != login)
                {
                    login = value;
                    OnPropertyChanged("Login");
                }
            }
        }
        
        public string Password { get; set; }

        private SettingDTO userSetting;
        public virtual SettingDTO UserSetting
        {
            get
            {
                return userSetting;
            }
            set
            {
                userSetting = value;
                OnPropertyChanged("UserSetting");
            }
        }

        private BindingList<HistoryDTO> histories;
        public virtual BindingList<HistoryDTO> Histories
        {
            get
            {
                return histories;
            }
            set
            {
                histories = value;
            }
        }

        private BindingList<TesteeTrainingDTO> trainings;
        public virtual BindingList<TesteeTrainingDTO> Trainings 
        { 
            get 
            { 
                return trainings; 
            } 
            set 
            { 
                trainings = value; 
            } 
        }

        public static implicit operator TesteeDTO(Testee testee)
        {
            TesteeDTO newTeste = new TesteeDTO();

            Conversion.CopyProperty(testee, newTeste);
            Conversion.CopyProperty(testee.UserSetting, newTeste.UserSetting);

            if (testee.Trainings!=null)
            foreach (var q in testee.Trainings)
            {
                newTeste.Trainings.Add((TesteeTrainingDTO)q);
            }
           
            return newTeste;
        }

        public event PropertyChangedEventHandler PropertyChanged;
       
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
