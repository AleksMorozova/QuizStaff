using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using DataTransferObject;

namespace Client
{
    public class TesteesListPresenter
    {
        private ITesteesListForm form;
        private Client.ServiceReference.ApplicationServerClient server;
        private ICollection<TesteeDTO> testees = new ObservableCollection<TesteeDTO>();
        // Becomes true when "Save" button on "Edit testee" form is pressed
        public bool DataChanged { get; set; }

        public TesteesListPresenter(ITesteesListForm form)
        {
            this.server = ServicesHolder.ServiceClient;
            this.form = form;
            this.LoadTestees();
        }

        public void LoadTestees()
        {
            if (WantToProceed())
            {
                this.testees = server.GetAllTestees().ToList();
                this.form.SetBindings(this.testees);
                this.DataChanged = false;
            }
        }

        private bool WantToProceed()
        {
            if (this.DataChanged)
            {
                return this.form.NotifyUnsavedData();
            }
            return true;
        }

        public void SaveTestees()
        {
            this.server.SaveAllTestees(this.testees.ToArray());
            this.DataChanged = false;
            //// TODO notify user that data saved succesfully
            MessageBox.Show("Saved");
        }
        public void Close()
        {
            if (WantToProceed())
            {
                this.form.CloseForm();
            }
        }
        public void EditTestee(TesteeDTO testee)
        {
            // TODO invoke new "Edit testee" form with testee's data in fields
            MessageBox.Show("Edit testee " + testee.FirstName);
        }
        public void AddTestee()
        {
            // TODO invoke new "Edit testee" form with blank fields
            MessageBox.Show("Add testee");
        }
    }
}
