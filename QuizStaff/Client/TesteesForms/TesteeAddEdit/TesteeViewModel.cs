using Client.TrainingsForms.TrainingAddEdit;
using DataTransferObject;
using DevExpress.XtraEditors;
using DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.TesteesForm.TesteeAddEdit
{
    public class TesteeViewModel
    {
        public Testee Testee { get; set; }        
               
        public void AddTraining(Testee testee)
        {
            TrainingAddEditForm trainingForm = new TrainingAddEditForm();
            FormManager.Instance.OpenChildForm(trainingForm, "Add training");
            FormManager.childForms.Add(trainingForm);
            FormManager.Instance.LocalizedForms(Program.currentLang);
        }

        public BindingList<Training> AllTrainings { get; set; }

        public void GetAllTrainings()
        {
            AllTrainings = new BindingList<Training>();
            var trainingsList = ServicesHolder.ServiceClient.GetAllTrainings();
            foreach (var training in trainingsList)
            {
                //AllTrainings.Add(training);
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
