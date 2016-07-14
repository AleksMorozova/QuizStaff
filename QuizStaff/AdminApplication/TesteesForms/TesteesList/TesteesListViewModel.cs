using AdminApplication.TesteesForm.TesteeAddEdit;
using DataTransferObject;
using DevExpress.XtraEditors;
using DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminApplication.TesteesForms.TesteesList
{
    public class TesteesListViewModel
    {
        public BindingList<Testee> Testees { get; set; }
        private TesteeDTO[] ReadTestees { get; set; }

        public void GetAllTestee()
        {
            Testees = new BindingList<Testee>();

            if (ReadTestees == null)
                ReadTestees = ServicesHolder.ServiceClient.GetAllTestees();

            foreach (var testee in ReadTestees)
            {
                if (testee.IsActive)
                    Testees.Add(Conversion.ConvertTesteeFromDTO(testee));              
            }
        }

        public void AddTestee()
        {
            AddEditTesteeForm testeeForm = new AddEditTesteeForm();
            FormManager.Instance.OpenChildForm(testeeForm, "Add testee");
            FormManager.LocalizedFormList.Add(testeeForm);
            FormManager.Instance.LocalizedForms(Program.currentLang);
            Testees.Add(testeeForm.Testee);
        }

        public void EditTestee(Testee editedTestee)
        {
            AddEditTesteeForm testeeForm = new AddEditTesteeForm(editedTestee);
            FormManager.Instance.OpenChildForm(testeeForm, "Edit testee: " + editedTestee.Login);
            FormManager.LocalizedFormList.Add(testeeForm);
            FormManager.Instance.LocalizedForms(Program.currentLang);           
        }

        public void DeleteTestee(Testee deletedTestee)
        {
            if (deletedTestee.Id != Guid.Empty)
            {
                deletedTestee.IsActive = false;
                ServicesHolder.ServiceClient.UpdateTestee(deletedTestee);
            }
            else 
            {
                var savedTestee = ServicesHolder.ServiceClient.FindByLogin(deletedTestee.Login);
                savedTestee.IsActive = false;
                ServicesHolder.ServiceClient.UpdateTestee(savedTestee);
            }
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
