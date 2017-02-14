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

namespace AdminApplication.TrainingsForms.TrainingAddEdit
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
            model = mvvmTrainingContext.GetViewModel<TrainingViewModel>();   
            model.SetUpViewModel(training);
            mvvmTrainingContext.SetViewModel(typeof(TrainingViewModel), model);
            BindCommand();
            model.QuestionsListChanged += new TrainingChangedEventHandler(QuestionsListChanged);
            BindToViewModel(); 
        }

        private void BindCommand()
        {
            mvvmTrainingContext.BindCommand<TrainingViewModel>(cancelButton, viewModel => viewModel.Cancel());            
            mvvmTrainingContext.BindCommand<TrainingViewModel>(saveButton, viewModel => viewModel.Save());   
            mvvmTrainingContext.BindCommand<TrainingViewModel, Question>(editQuestionButton, (viewModel, question)
                => viewModel.EditQuestion(question), x => GetCurrentQuestion());
            mvvmTrainingContext.BindCommand<TrainingViewModel, Training>(addQuestionButton, (viewModel, training)
                => viewModel.AddQuestion(training), x => model.Training);
            mvvmTrainingContext.BindCommand<TrainingViewModel, Question>(deleteQuestionButton, (x, currentTraining)
                => x.DeleteQuestion(currentTraining), x => GetCurrentQuestion());
        }

        private void BindToViewModel()
        {
            mvvmTrainingContext.SetBinding(textTrainingName, questionText => questionText.EditValue, "TrainingTitle");
            mvvmTrainingContext.SetBinding(gridQuestions, answers => answers.DataSource, "Questions");
        }

        private void gridQuestions_DoubleClick(object sender, EventArgs e)
        {
            model.EditQuestion(GetCurrentQuestion());
        }

        private Question GetCurrentQuestion()
        {
            int rowHandler = questionsGridView.FocusedRowHandle;
            var editedQuestion = (Question)questionsGridView.GetRow(rowHandler);
            return editedQuestion;
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
            resources.ApplyResources(QuestionText, "QuestionText", newCultureInfo);
            resources.ApplyResources(saveButton, "saveButton", newCultureInfo);
            resources.ApplyResources(cancelButton, "cancelButton", newCultureInfo);
            resources.ApplyResources(deleteQuestionButton, "deleteQuestionButton", newCultureInfo);
            string title = !String.IsNullOrEmpty(resources.GetString("Title", newCultureInfo))
                ? resources.GetString("Title", newCultureInfo) : "Training";
            this.Text = title + (Training != null && !String.IsNullOrEmpty(Training.TrainingTitle) ? ":" + Training.TrainingTitle : "");
        }
       
        private void QuestionsListChanged(object sender, EventArgs e)
        {
            gridQuestions.Refresh();
        }
    }
}