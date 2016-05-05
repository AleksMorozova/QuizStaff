using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DomainModel;
using DevExpress.XtraGrid.Views.Grid;

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
        public void SetBindings(List<Testee> testees)
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
            Presenter.EditTestee((Testee)((GridView)gridTestees.MainView).GetFocusedRow());
        }
    }
}