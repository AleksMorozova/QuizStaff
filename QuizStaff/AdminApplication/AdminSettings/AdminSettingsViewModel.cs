using DataTransferObject;
using DevExpress.Mvvm;
using DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm.DataAnnotations;

namespace AdminApplication.AdminSettings
{
    public class AdminSettingsViewModel
    {
        private BindingList<Testee> testees;
        public BindingList<Testee> Testees
        { 
            get 
            { 
                return testees;
            } 

            set 
            {
              if(testees!=value)
              {
                  testees = value;
                  RaisePropertyChanged("Testees");
              }
            } 
        }

        public void GetAllTestees()
        {
            testees = new BindingList<Testee>();
            var testeeList = ServicesHolder.ServiceClient.GetAllTestees();

            foreach (var testee in testeeList)
            {
                testees.Add(Conversion.ConvertTesteeFromDTO(testee));
            }
        }

        public void EditSettings(BindingList<Testee> selectedTestee) 
        {
            EditSettingsForm editSettings = new EditSettingsForm(selectedTestee);
            FormManager.LocalizedFormList.Add(editSettings);
            FormManager.Instance.LocalizedForms(Program.currentLang);
            editSettings.ShowDialog();
        }

        public void EditTesteeTrainigs(BindingList<Testee> selectedTestee)
        {
            EditTesteesTrainingsForm editTrainigs = new EditTesteesTrainingsForm(selectedTestee);
            FormManager.LocalizedFormList.Add(editTrainigs);
            FormManager.Instance.LocalizedForms(Program.currentLang);
            editTrainigs.ShowDialog();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
