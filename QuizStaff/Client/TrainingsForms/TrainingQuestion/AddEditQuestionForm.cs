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
using DataTransferObject;
using DevExpress.XtraGrid.Views.Grid;
using System.Globalization;

namespace Client.TrainingsForms.TrainingQuestion
{
    public partial class AddEditQuestionForm : DevExpress.XtraEditors.XtraForm, ILocalized
    {
        private QuestionViewModel model;

        public AddEditQuestionForm()
            : this(new QuestionDTO()) { }

        public AddEditQuestionForm(QuestionDTO question)
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

        public QuestionDTO Question 
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
            AnswerDTO answer = v.GetRow(e.RowHandle) as AnswerDTO;
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

            this.Text = resources.GetString("Title", newCultureInfo);
        }
    }
}