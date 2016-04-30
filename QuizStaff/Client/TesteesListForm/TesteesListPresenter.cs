using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;
using Server;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace Client
{
    public class TesteesListPresenter
    {
        public ITesteesListForm form;
        private IApplicationServer server;
        private List<Testee> testees = new List<Testee>();
        // Becomes true when "Save" button on "Edit testee" form is pressed
        public bool DataChanged { get; set; }

        public TesteesListPresenter(ITesteesListForm form)
        {
            // TODO make an instance of real server
            this.server = new ApplicationServer();

            this.form = form;
            this.LoadTestees();
        }

        public void LoadTestees()
        {
            if (WantToProceed())
            {
                this.testees = server.GetAllTestees();
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
            this.server.SaveAllTestees(this.testees);
            this.DataChanged = false;
            // TODO notify user that data saved succesfully
            MessageBox.Show("Saved");
        }
        public void Close()
        {
            if (WantToProceed())
            {
                this.form.CloseForm();
            }
        }
        public void EditTestee(Testee testee)
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
