using DataTransferObject;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.AddEditTesteeForm
{
    public class TesteeViewModel
    {
        public TesteeDTO Testee { get; set; }        
               
        public void AddTraining(TesteeDTO testee)
        {
            TrainingAddEditForm trainingForm = new TrainingAddEditForm();
            FormManager.Instance.OpenChildForm(trainingForm, "Add training");
            FormManager.childForms.Add(trainingForm);
            FormManager.Instance.LocalizedForms(Program.currentLang);
        }

        public BindingList<TrainingDTO> AllTrainings { get; set; }

        public void GetAllTrainings()
        {
            AllTrainings = new BindingList<TrainingDTO>();
            var trainingsList = ServicesHolder.ServiceClient.GetAllTrainings();
            foreach (var training in trainingsList)
            {
                AllTrainings.Add(training);
            }
        }

        public void Cancel()
        {
            //TODO: cancel edeting 
        }       

        public void Save(TesteeDTO testee)
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
