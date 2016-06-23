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
    public class TesteeViewModel
    {
        private Testee testee;
        public Testee Testee
        { 
            get { return testee; } 
            set
            { 
                if(testee!=value) 
                    testee = value;
            }
        }

        public Setting Setting { 
            get { return Testee.UserSetting; }
            set { if (Testee.UserSetting!=value) Testee.UserSetting = value; }
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
            //TODO: cancel edeting 
        }       

        public void Save(Testee testee)
        {
            if (testee != null)
            {
                if (testee.Id == Guid.Empty)
                {
                    ServicesHolder.ServiceClient.SaveTestee(testee);
                }
                else
                {
                    ServicesHolder.ServiceClient.UpdateTestee(testee);
                }
            }
        }        
    }
}
