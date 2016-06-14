using Client.TesteesForm.TesteeAddEdit;
using DataTransferObject;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.TesteesForms.TesteesList
{
    public class TesteesListViewModel
    {
        public BindingList<TesteeDTO> Testees { get; set; }
        public void GetAllTestee()
        {
            Testees = new BindingList<TesteeDTO>();
            var testeesList = ServicesHolder.ServiceClient.GetAllTestees();
            foreach (var testee in testeesList)
            {
                Testees.Add(testee);              
            }
        }

        public void AddTestee(BindingList<TesteeDTO> testee)
        {
            AddEditTesteeForm testeeForm = new AddEditTesteeForm();
            FormManager.Instance.OpenChildForm(testeeForm, "Add testee");
            FormManager.childForms.Add(testeeForm);
            FormManager.Instance.LocalizedForms(Program.currentLang);
            testee.Add(testeeForm.Testee);
        }

        public void EditTestee(TesteeDTO editedTestee)
        {
            AddEditTesteeForm testeeForm = new AddEditTesteeForm(editedTestee);
            FormManager.Instance.OpenChildForm(testeeForm, "Edit testee: " + editedTestee.Login);
            FormManager.childForms.Add(testeeForm);
            FormManager.Instance.LocalizedForms(Program.currentLang);           
        }

        public void DeleteTestee(TesteeDTO deletedTestee)
        {
            deletedTestee.IsActive = false;
            ServicesHolder.ServiceClient.UpdateTestee(deletedTestee);
        }

        public void Save()
        {
            // TODO: implement save of loaded of testee
            XtraMessageBox.Show("Save");
        }

        public void Cancel()
        {
            // TODO: implement cancel of loading of testees
            XtraMessageBox.Show("Cancel");
        }

        public void LoadTestees()
        {
            // TODO: implement loading of testees from external source
            XtraMessageBox.Show("Load trainings");
        }
    }
}
