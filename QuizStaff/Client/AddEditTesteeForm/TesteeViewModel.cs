using DataTransferObject;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
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
           //TODO: ??
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
                    //TODO:
                    //ServicesHolder.ServiceClient.SaveTestee(testee);
                }
                else
                {
                    //TODO:
                    //ServicesHolder.ServiceClient.UpdateTestee(testee);
                }
            }
        }        
    }
}
