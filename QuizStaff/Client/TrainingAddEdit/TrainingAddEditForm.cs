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
using Client.TrainingEditForm;

namespace Client
{
    public partial class TrainingAddEdit : DevExpress.XtraEditors.XtraForm, ITrainingEditForm
    {

        public TrainingEditPresenter Presenter { get; set; }
        public TextEdit TrainingName { get { return textTrainingName; } }
        private TrainingViewModel model;

        public void SetBindings(List<QuestionDTO> questions)
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

        public TrainingAddEdit()
            : this(Guid.Empty) { }

        public TrainingAddEdit(Guid id)
        {
            InitializeComponent();

            mvvmTrainingContext.ViewModelType = typeof(TrainingViewModel);

            //presenter = new AddEditQuestionPresenter(this);
            //presenter.LoadQuestion(id);
            model = new TrainingViewModel();
            model.LoadTraining(id);
            mvvmTrainingContext.SetViewModel(typeof(TrainingViewModel), model);
            model.LoadTraining(id);
            BindToViewModel();            
        }

        private void BindToViewModel()
        {
            //binding property
            mvvmTrainingContext.SetBinding(textTrainingName, questionText => questionText.EditValue, "Training.TrainingTitle");
            mvvmTrainingContext.SetBinding(gridQuestions, answers => answers.DataSource, "Training.Questions");

            //Binding command  
            mvvmTrainingContext.BindCommand<TrainingViewModel>(cancelButton, viewModel => viewModel.Cancel());
            var currentQuestion = GetCurrentQuestion();
            mvvmTrainingContext.BindCommand<TrainingViewModel, Guid>(editQuestionButton, (viewModel, questionID)
                => viewModel.EditQuestion(questionID), x => currentQuestion.Id);
            mvvmTrainingContext.BindCommand<TrainingViewModel>(addQuestionButton, viewModel => viewModel.AddQuestion());
        }

        private void buttonAddQuestion_Click(object sender, EventArgs e)
        {
            Presenter.AddQuestion();
            gridView1.RefreshData();
        }

        private void buttonEditQuestion_Click(object sender, EventArgs e)
        {
            Presenter.EditQuestion((Question)((GridView)gridQuestions.MainView).GetFocusedRow());
            gridView1.RefreshData();
        }

        private Question GetCurrentQuestion()
        {
            int rowHandler = gridView1.FocusedRowHandle;
            return (Question)gridView1.GetRow(rowHandler);
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
    }
}