using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataTransferObject;
using System.Drawing;
using System.Globalization;
using System.ComponentModel;
using DomainModel;
using TesteeApplication.TesteeQuestion;

namespace TesteeApplication
{
    public partial class QuestionForm : DevExpress.XtraEditors.XtraForm
    {
        private Dictionary<AnswerDTO, bool> answers = new Dictionary<AnswerDTO, bool>();
        private TesteeQuestionViewModel model;
        private bool wasClick = false;
        public QuestionForm(Testee testee)
        {
            InitializeComponent();
            mvvmQuestionContext.ViewModelType = typeof(TesteeQuestionViewModel);
            BindCommands();
            model = mvvmQuestionContext.GetViewModel<TesteeQuestionViewModel>();
            mvvmQuestionContext.SetViewModel(typeof(TesteeQuestionViewModel), model);
            model.LoadQuestionForTestee(Program.currentTestee);
            CreateQuestionControls(model.question);

            // Send form to bottom right corner of display
            SetWindowsPosition();
        }
     
        private void BindCommands()
        {
            mvvmQuestionContext.BindCommand<TesteeQuestionViewModel, Dictionary<AnswerDTO, bool>>(buttonSend,
                (x, currentTraining) => x.SaveTesteeAnswer(currentTraining), x => answers);
        }
       
        private void SetWindowsPosition()
        {
            var screen = Screen.FromPoint(this.Location);
            this.Location = new Point(screen.WorkingArea.Right - this.Width, screen.WorkingArea.Bottom - this.Height);

            flow.SetFlowBreak(labelQuestion, true);
        }

        public void CreateQuestionControls(QuestionDTO question)
        {
            var multiSelect = model.MultiSelect;
            labelQuestion.Width = this.Width;
            labelQuestion.DataBindings.Add("Text", question, "QuestionText");
            bool selectFirstRadio = true;
            foreach (var answer in question.Answers)
            {
                ICheckControl control;
                if (multiSelect)
                {
                    control = new WrappingCheckBox();
                }
                else
                {
                    control = new WrappingRadioButton();
                }
                (control as Control).DataBindings.Add("Text", answer, "AnswerText");
                control.AnswerID = answer.Id;
                control.Answer = answer;
                control.CheckedChanged += (sender, e) => this.answers[control.Answer] = control.Checked;
                if (selectFirstRadio && !multiSelect)
                {
                    control.Checked = true;
                    selectFirstRadio = false;
                }
                flow.Controls.Add((control as Control));
                flow.SetFlowBreak((control as Control), true);
            }
        }

        private void QuestionForm_Load(object sender, EventArgs e)
        {
            // Resize form and back it to default size to solve horizontal scroll bug
            Size defaultSize = this.Size;
            this.Size = new Size(3000, defaultSize.Height);
            this.Size = defaultSize;
        }
        public void Localized(string language)
        {
            var resources = new ComponentResourceManager(typeof(QuestionForm));
            CultureInfo newCultureInfo = new CultureInfo(language);
            resources.ApplyResources(buttonSend, "buttonSend", newCultureInfo);           
        }

        private void QuestionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.Timer.Start();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionForm));
            buttonSend.Image = ((System.Drawing.Image)(resources.GetObject("buttonSend.Image")));
            if (wasClick)
            {
                this.Close();
            }
            wasClick = true;
        }
    }
}