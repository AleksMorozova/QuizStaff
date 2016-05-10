using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DataTransferObject;

namespace Client
{
    public partial class TesteesListForm : DevExpress.XtraEditors.XtraForm, ITesteesListForm
    {
        public TesteesListPresenter Presenter { get; set; }

        public TesteesListForm()
        {
            InitializeComponent();
            this.Presenter = new TesteesListPresenter(this);
            gridTestees.Select();
        }
        public void SetBindings(ICollection<TesteeDTO> testees)
        {
            gridTestees.DataSource = testees;
        }
        public bool NotifyUnsavedData()
        {
            DialogResult result = MessageBox.Show("Some of edit you have made not been saved.\nDo you want to proceed?",
                "Confirm data lost",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            return (result == DialogResult.OK) ? true : false;
        }
        public void CloseForm()
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Presenter.SaveTestees();
        }

        private void buttonLoadTestees_Click(object sender, EventArgs e)
        {
            Presenter.LoadTestees();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Presenter.Close();
        }

        private void buttonAddTestee_Click(object sender, EventArgs e)
        {
            Presenter.AddTestee();
        }

        private void buttonEditTestee_Click(object sender, EventArgs e)
        {
            var testee = (TesteeDTO)((GridView)gridTestees.MainView).GetFocusedRow();
            if (testee != null)
            {
                Presenter.EditTestee(testee);
            }
        }
    }
}