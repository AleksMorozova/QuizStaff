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
using System.Globalization;

namespace Client.TrainingsForms.TrainingAddEdit
{
    public partial class TrainingAddEditForm : DevExpress.XtraEditors.XtraForm, ILocalized
    {
        private TrainingViewModel model;

        public TrainingAddEditForm()
            : this(new Training() { IsActive = true, Questions = new BindingList<Question>()}) { }

        public TrainingAddEditForm(Training training)
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

        private Training currentTraining;

        private void BindCommand()
        {
            mvvmTrainingContext.BindCommand<TrainingViewModel>(cancelButton, viewModel => viewModel.Cancel());

            mvvmTrainingContext.BindCommand<TrainingViewModel, Question>(editQuestionButton, (viewModel, question)
                => viewModel.EditQuestion(question), x => GetCurrentQuestion());

            mvvmTrainingContext.BindCommand<TrainingViewModel, Training>(addQuestionButton, (viewModel, training)
                => viewModel.AddQuestion(training), x => currentTraining);

            mvvmTrainingContext.BindCommand<TrainingViewModel>(loadQuestionButton, viewModel => viewModel.LoadQuestions());

            mvvmTrainingContext.BindCommand<TrainingViewModel, Training>(saveButton, (viewModel, training)
                => viewModel.Save(training), x => currentTraining);

            mvvmTrainingContext.BindCommand<TrainingViewModel, Question>(deleteQuestionButton,
                (x, currentTraining) => x.DeleteQuestion(currentTraining), x => GetCurrentQuestion());
        }

        private void BindToViewModel()
        {
            mvvmTrainingContext.SetBinding(textTrainingName, questionText => questionText.EditValue, "Training.TrainingTitle");
            mvvmTrainingContext.SetBinding(gridQuestions, answers => answers.DataSource, "Training.Questions");
        }

        private Question GetCurrentQuestion()
        {
            int rowHandler = questionsGridView.FocusedRowHandle;
            var editedQuestion = (Question)questionsGridView.GetRow(rowHandler);
            return editedQuestion;
        }

        private void gridQuestions_DoubleClick(object sender, EventArgs e)
        {
            model.EditQuestion(GetCurrentQuestion());
        }

        public Training Training
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
        
        public void Localized(string language)
        {
            var resources = new ComponentResourceManager(typeof(TrainingAddEditForm));
            CultureInfo newCultureInfo = new CultureInfo(language);
            resources.ApplyResources(layoutControlItem1, "layoutControlItem1", newCultureInfo);
            resources.ApplyResources(addQuestionButton, "addQuestionButton", newCultureInfo);
            resources.ApplyResources(editQuestionButton, "editQuestionButton", newCultureInfo);
            resources.ApplyResources(loadQuestionButton, "loadQuestionButton", newCultureInfo);
            resources.ApplyResources(QuestionText, "QuestionText", newCultureInfo);
            resources.ApplyResources(saveButton, "saveButton", newCultureInfo);
            resources.ApplyResources(cancelButton, "cancelButton", newCultureInfo);

            this.Text = resources.GetString("Title", newCultureInfo) + (Training != null && !String.IsNullOrEmpty(Training.TrainingTitle) ? ":" + Training.TrainingTitle : "");
        }
    }
}