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
using DataTransferObject;

namespace Client
{
    public partial class TesteesListForm : DevExpress.XtraEditors.XtraForm, ITesteesListForm
    {
        public TesteesListPresenter Presenter { get; set; }

        public TesteesListForm()
        {
            InitializeComponent();
        }
        public void SetBindings(List<TesteeDTO> testees)
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
        public void Close()
        {
            // TODO close form
            MessageBox.Show("Form closed");
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

        // TODO remove this after tests
        private void button1_Click(object sender, EventArgs e)
        {
            Presenter.DataChanged = !Presenter.DataChanged;
            MessageBox.Show("DataChanged =" + Presenter.DataChanged);
        }

        private void gridTestees_DoubleClick(object sender, EventArgs e)
        {
            Presenter.EditTestee((Testee)((GridView)gridTestees.MainView).GetFocusedRow());
        }
    }

    

}