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
    public delegate void TesteeChangedEventHandler(object sender, EventArgs e);
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
            FormManager.Instance.LocalizedForms(Program.СurrentLang);
            editSettings.ShowDialog();
            OnTesteeListChanged(EventArgs.Empty);
        }

        public void EditTesteeTrainigs(BindingList<Testee> selectedTestee)
        {
            EditTesteesTrainingsForm editTrainigs = new EditTesteesTrainingsForm(selectedTestee);
            FormManager.LocalizedFormList.Add(editTrainigs);
            FormManager.Instance.LocalizedForms(Program.СurrentLang);
            editTrainigs.ShowDialog(); 
            OnTesteeListChanged(EventArgs.Empty);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
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
