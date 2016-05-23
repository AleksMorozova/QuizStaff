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
    public partial class TrainingAddEdit : DevExpress.XtraEditors.XtraForm
    {

        public TrainingEditPresenter Presenter { get; set; }
        public TextEdit TrainingName { get { return textTrainingName; } }
        private TrainingViewModel model;

        public TrainingAddEdit()
            : this(Guid.Empty) { }

        public TrainingAddEdit(Guid id)
        {
            InitializeComponent();

            mvvmTrainingContext.ViewModelType = typeof(TrainingViewModel);
            BindCommand();
            //presenter = new AddEditQuestionPresenter(this);
            //presenter.LoadQuestion(id);
            model = new TrainingViewModel();
            model.LoadTraining(id);
            mvvmTrainingContext.SetViewModel(typeof(TrainingViewModel), model);
            model.LoadTraining(id);
            BindToViewModel();            
        }

        private void BindCommand()
        {
            mvvmTrainingContext.BindCommand<TrainingViewModel>(cancelButton, viewModel => viewModel.Cancel());

            var currentQuestion = GetCurrentQuestion();
            mvvmTrainingContext.BindCommand<TrainingViewModel, Guid>(editQuestionButton, (viewModel, questionID)
                => viewModel.EditQuestion(questionID), x => currentQuestion.Id);

            mvvmTrainingContext.BindCommand<TrainingViewModel>(addQuestionButton, viewModel => viewModel.AddQuestion());
            mvvmTrainingContext.BindCommand<TrainingViewModel>(loadQuestionButton, viewModel => viewModel.LoadQuestions());
            mvvmTrainingContext.BindCommand<TrainingViewModel>(saveButton, viewModel => viewModel.Save());
        }

        private void BindToViewModel()
        {
            //binding property
            mvvmTrainingContext.SetBinding(textTrainingName, questionText => questionText.EditValue, "Training.TrainingTitle");
            mvvmTrainingContext.SetBinding(gridQuestions, answers => answers.DataSource, "Training.Questions");
        }

        private Question GetCurrentQuestion()
        {
            int rowHandler = gridView1.FocusedRowHandle;
            return (Question)gridView1.GetRow(rowHandler);
        }

        private void gridQuestions_DoubleClick(object sender, EventArgs e)
        {
            Presenter.EditQuestion((Question)((GridView)gridQuestions.MainView).GetFocusedRow());
        }
    }
}