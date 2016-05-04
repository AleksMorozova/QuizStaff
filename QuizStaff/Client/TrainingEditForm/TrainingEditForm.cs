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
    public partial class TrainingEditForm : DevExpress.XtraEditors.XtraForm, ITrainingEditForm
    {

        public TrainingEditPresenter Presenter { get; set; }
        public TextEdit TrainingName { get { return textTrainingName; } }


        public void SetBindings(List<Question> questions)
        {
            gridQuestions.DataSource = questions;
        }
        public bool NotifyUnsavedData()
        {
            DialogResult result = MessageBox.Show("Some of edit you have made not been saved.\nDo you want to proceed?",
                "Confirm data lost",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            return (result == DialogResult.OK) ? true : false;
        }
        public void CloseEditing()
        {
            // TODO close form
            MessageBox.Show("Form closed");
        }

        public TrainingEditForm(Training aim)
        {
            InitializeComponent();
            Presenter = new TrainingEditPresenter(this, aim);
            this.Text = "Training : " + aim.TrainingTitle;
        }

        private void TrainingEditForm_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonAddQuestion_Click(object sender, EventArgs e)
        {
            Presenter.AddQuestion();
        }

        private void buttonEditQuestion_Click(object sender, EventArgs e)
        {
            Presenter.EditQuestion((Question)((GridView)gridQuestions.MainView).GetFocusedRow());
        }

        private void buttonLoadQuestion_Click(object sender, EventArgs e)
        {
            Presenter.LoadQuestions();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Presenter.SaveQuestions();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Presenter.Close();
        }

        private void gridQuestions_DoubleClick(object sender, EventArgs e)
        {
            Presenter.EditQuestion((Question)((GridView)gridQuestions.MainView).GetFocusedRow());
        }

        private void buttonAddQuestion_Click_1(object sender, EventArgs e)
        {

        }
    }
}