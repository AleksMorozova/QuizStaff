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

namespace Client.TrainingsForms.TrainingQuestion
{
    public partial class AddEditQuestionForm : DevExpress.XtraEditors.XtraForm, ILocalized
    {
        private QuestionViewModel model;

        public AddEditQuestionForm()
            : this(new Question()) { }

        public AddEditQuestionForm(Question question)
        {
            InitializeComponent();

            this.answersGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            mvvmQuestionContext.ViewModelType = typeof(QuestionViewModel);
            model = new QuestionViewModel();
            mvvmQuestionContext.SetViewModel(typeof(QuestionViewModel), model);
            model.Question = question;
            BindToViewModel();     
        }

        private void BindToViewModel()
        {
            mvvmQuestionContext.SetBinding(questionTextEdit, questionText => questionText.EditValue, "Question.QuestionText");
            mvvmQuestionContext.SetBinding(answersGridControl, answers => answers.DataSource, "Question.Answers");
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

        private void answersGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView v = sender as GridView;
            Answer answer = v.GetRow(e.RowHandle) as Answer;
            answer.IsCorrect = false;
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
            this.Text = !String.IsNullOrEmpty(resources.GetString("Title", newCultureInfo))
                ? resources.GetString("Title", newCultureInfo) : "Question";
        }

        private Answer GetCurrentAnswer()
        {
            int rowHandler = answersGridView.FocusedRowHandle;
            var editedAnswer = (Answer)answersGridView.GetRow(rowHandler);
            return editedAnswer;
        }

        private void answersGridControl_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            var answer = GetCurrentAnswer();
            answer.IsActive = false;
            AnswerDTO newAnswer = new AnswerDTO();
            Conversion.CopyProperty(answer, newAnswer);
            ServicesHolder.ServiceClient.DeleteAnswer(newAnswer);
        }
    }
}