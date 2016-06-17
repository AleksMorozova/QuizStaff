using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Testee : Entity, INotifyPropertyChanged
    {
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

        public string Email { get; set; }

        public string Login { get; set; }

        public bool IsActive { get; set; }

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

        public bool IsSelected { get; set; }

        private Setting userSettig;
        public virtual Setting UserSetting
        {
            get
            {
                return userSettig;
            }
            set
            {
                if (value != userSettig)
                {
                    userSettig = value;
                    OnPropertyChanged("UserSetting");
                }
            }
        }
        public virtual BindingList<History> Histories { get; set; }
        public virtual BindingList<TesteeTraining> Trainings { get; set; }
        public virtual BindingList<UserRole> Roles { get; set; }

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
