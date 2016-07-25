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
        
        public string Attribute1 { get; set; }
        public string Attribute2 { get; set; }
        public string Attribute3 { get; set; }
        public string Attribute4 { get; set; }
        public string Attribute5 { get; set; }
        public string Attribute6 { get; set; }
        public string Attribute7 { get; set; }
        public string Attribute8 { get; set; }
        public string Attribute9 { get; set; }
        public string Attribute10 { get; set; }

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
        public virtual RoleDTO UserRole { get; set; }

        public static implicit operator TesteeDTO(Testee testee)
        {
            TesteeDTO newTeste = Conversion.ConvertTesteeToDTO(testee);
           
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
