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

namespace Client.AddEditQuestionForm
{
    public partial class AddEditQuestionForm : DevExpress.XtraEditors.XtraForm
    {
        private QuestionViewModel model;

        public AddEditQuestionForm()
            : this(new QuestionDTO()) { }

        public AddEditQuestionForm(QuestionDTO question)
        {
            InitializeComponent();
            this.answersGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            //answersGridControl.MainView.p.NewItemRowPosition = NewItemRowPosition.Bottom;
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
    }
}