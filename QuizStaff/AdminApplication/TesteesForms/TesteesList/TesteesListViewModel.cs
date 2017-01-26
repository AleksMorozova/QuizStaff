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
    public delegate void TesteeChangedEventHandler(object sender, EventArgs e);

    public class TesteesListViewModel
    {
        public BindingList<Testee> Testees { get; set; }
        private TesteeDTO[] ReadTestees { get; set; }

        public void GetAllTestee()
        {
            Testees = new BindingList<Testee>();
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
            FormManager.Instance.LocalizedForms(Program.СurrentLang);
            Testees.Add(testeeForm.Testee);
        }

        public void EditTestee(Testee editedTestee)
        {
            AddEditTesteeForm testeeForm = new AddEditTesteeForm(editedTestee);
            FormManager.Instance.OpenChildForm(testeeForm, "Edit testee: " + editedTestee.Login);
            FormManager.LocalizedFormList.Add(testeeForm);
            FormManager.Instance.LocalizedForms(Program.СurrentLang);
        }

        public void DeleteTestee(Testee deletedTestee)
        {
            if (deletedTestee != null)
            {
                if (deletedTestee.Id != Guid.Empty)
                {
                    deletedTestee.IsActive = false;
                    ServicesHolder.ServiceClient.SaveTestee(deletedTestee);
                }
                else
                {
                    var savedTestee = ServicesHolder.ServiceClient.FindByLogin(deletedTestee.Login);
                    savedTestee.IsActive = false;
                    ServicesHolder.ServiceClient.SaveTestee(savedTestee);
                }
                this.Testees.Remove(deletedTestee);
                OnTesteeListChanged(EventArgs.Empty);
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
            //ServicesHolder.ServiceClient.LoadTestee();
            ServicesHolder.ServiceClient.LoadTesteeFromEPE();
            XtraMessageBox.Show("Testees was successfully load");
        }    
    
        public event TesteeChangedEventHandler TesteeListChanged;
        protected virtual void OnTesteeListChanged(EventArgs e)
        {
            if (TesteeListChanged != null)
                TesteeListChanged(this, e);
        }
    }
}
