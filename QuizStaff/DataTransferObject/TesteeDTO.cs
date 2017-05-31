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
            Trainings = new BindingList<TesteeTrainingDTO>();
            Roles = new BindingList<TesteeRolesDTO>();
            Roles = new BindingList<TesteeRolesDTO>();
        }

        public Guid Id { get; set; }
        public bool IsActive { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Login { get; set; }

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
        public string Attribute11 { get; set; }
        public string Attribute12 { get; set; }
        public string Attribute13 { get; set; }
        public virtual SettingDTO UserSetting { get; set; }
        public virtual BindingList<HistoryDTO> Histories { get; set; }
        public virtual BindingList<TesteeTrainingDTO> Trainings { get; set; }
        public virtual BindingList<TesteeRolesDTO> Roles { get; set; }

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
