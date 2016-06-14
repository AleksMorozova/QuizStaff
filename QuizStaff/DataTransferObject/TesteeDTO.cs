using DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class TesteeDTO : INotifyPropertyChanged
    {
        private BindingList<TesteeTrainingDTO> trainings;
        public TesteeDTO() 
        {
            trainings = new BindingList<TesteeTrainingDTO>();
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
        public virtual Setting UserSetting { get; set; }
        public virtual ICollection<HistoryDTO> Histories { get; set; }
        
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

            if (testee.Trainings.Count() > 0)
            {
                foreach (var q in testee.Trainings)
                {
                    newTeste.Trainings.Add((TesteeTrainingDTO)q);
                }
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
