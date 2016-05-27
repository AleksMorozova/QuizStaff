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
        private TrainingViewModel model;

        public TrainingAddEdit()
            : this(new TrainingDTO()) { }

        public TrainingAddEdit(TrainingDTO training)
        {
            InitializeComponent();

            mvvmTrainingContext.ViewModelType = typeof(TrainingViewModel);
            BindCommand();
            model = new TrainingViewModel();          
            model.Training = training;
            mvvmTrainingContext.SetViewModel(typeof(TrainingViewModel), model);   
            BindToViewModel(); 
            currentTraining = model.Training;  
        }

        private TrainingDTO currentTraining;

        private void BindCommand()
        {
            mvvmTrainingContext.BindCommand<TrainingViewModel>(cancelButton, viewModel => viewModel.Cancel());

            mvvmTrainingContext.BindCommand<TrainingViewModel, QuestionDTO>(editQuestionButton, (viewModel, questionID)
                => viewModel.EditQuestion(questionID), x => GetCurrentQuestion());

            mvvmTrainingContext.BindCommand<TrainingViewModel, TrainingDTO>(addQuestionButton, (viewModel, training)
                => viewModel.AddQuestion(training), x => currentTraining);

            mvvmTrainingContext.BindCommand<TrainingViewModel>(loadQuestionButton, viewModel => viewModel.LoadQuestions());

            mvvmTrainingContext.BindCommand<TrainingViewModel, TrainingDTO>(saveButton, (viewModel, training)
                => viewModel.Save(training), x => currentTraining);
        }

        private void BindToViewModel()
        {
            mvvmTrainingContext.SetBinding(textTrainingName, questionText => questionText.EditValue, "Training.TrainingTitle");
            mvvmTrainingContext.SetBinding(gridQuestions, answers => answers.DataSource, "Training.Questions");
        }

        private QuestionDTO GetCurrentQuestion()
        {
            if (currentTraining!=null)
            model.Training = currentTraining;
            int rowHandler = questionsGridView.FocusedRowHandle;
            var editedQuestion = (QuestionDTO)questionsGridView.GetRow(rowHandler);
            return editedQuestion;
        }

        private void gridQuestions_DoubleClick(object sender, EventArgs e)
        {
            model.EditQuestion(GetCurrentQuestion());
        }

        public TrainingDTO Training
        {
            get
            {
                return model.Training;
            }
            set
            {
                model.Training = value;
            }
        }
    }
}