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
using DevExpress.XtraGrid.Views.Grid;
using System.Globalization;
using DomainModel;
using DataTransferObject;

namespace AdminApplication.TrainingsForms.TrainingQuestion
{
    public partial class AddEditQuestionForm : DevExpress.XtraEditors.XtraForm, ILocalized
    {
        private QuestionViewModel model;

        public AddEditQuestionForm()
            : this(new Question() { IsActive=true}) { }

        public AddEditQuestionForm(Question question)
        {
            InitializeComponent();

            this.answersGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            mvvmQuestionContext.ViewModelType = typeof(QuestionViewModel);
            model = mvvmQuestionContext.GetViewModel<QuestionViewModel>();   
            mvvmQuestionContext.SetViewModel(typeof(QuestionViewModel), model);
            BindCommand();
            model.QuestionsListChanged += new QuestionChangedEventHandler(AnswersListChanged);
            model.Question = question;
            BindToViewModel();     
        }

        private void BindCommand()
        {
            mvvmQuestionContext.BindCommand<QuestionViewModel, Answer>(addAnswerButton, (viewModel, answer)
                => viewModel.AddAnswer(answer), x => new Answer() {IsActive = true, IsCorrect = true});
            mvvmQuestionContext.BindCommand<QuestionViewModel, Answer>(deleteAnswerButton, (x, currentTraining)
                => x.DeleteAnswer(currentTraining), x => GetCurrentAnswer());
        }

        private void BindToViewModel()
        {
            mvvmQuestionContext.SetBinding(questionTextEdit, questionText => questionText.EditValue, "QuestionText");
            mvvmQuestionContext.SetBinding(answersGridControl, answers => answers.DataSource, "Answers");
        }

        private Answer GetCurrentAnswer()
        {
            int rowHandler = answersGridView.FocusedRowHandle;
            var editedAnswer = (Answer)answersGridView.GetRow(rowHandler);
            return editedAnswer;
        }

        public Question Question 
        { 
            get
            { 
                return model.Question; 
            }
            set
            {
                model.Question = value;
            }
        }

        public void Localized(string language)
        {
            var resources = new ComponentResourceManager(typeof(AddEditQuestionForm));
            CultureInfo newCultureInfo = new CultureInfo(language);
            resources.ApplyResources(questionLayoutControlItem, "questionLayoutControlItem", newCultureInfo);
            resources.ApplyResources(answersLayoutControlItem, "answersLayoutControlItem", newCultureInfo);
            resources.ApplyResources(answerColumn, "answerColumn", newCultureInfo);
            resources.ApplyResources(isCorrectColumn, "isCorrectColumn", newCultureInfo);
            resources.ApplyResources(saveButton, "saveButton", newCultureInfo);
            resources.ApplyResources(cancelButton, "cancelButton", newCultureInfo);
            resources.ApplyResources(addAnswerButton, "addAnswerButton", newCultureInfo);
            resources.ApplyResources(deleteAnswerButton, "deleteAnswerButton", newCultureInfo);

            this.Text = !String.IsNullOrEmpty(resources.GetString("Title", newCultureInfo))
                ? resources.GetString("Title", newCultureInfo) : "Question";
        }

        private void AnswersListChanged(object sender, EventArgs e)
        {
            answersGridControl.Refresh();
        }
     
        private void answersGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView v = sender as GridView;
            Answer answer = v.GetRow(e.RowHandle) as Answer;
            answer.IsCorrect = false;
            answer.IsActive = true;
        }
    }
}