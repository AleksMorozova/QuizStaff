using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataTransferObject;
using System.Drawing;
using System.Globalization;
using System.ComponentModel;
using DomainModel;
using TesteeApplication.TesteeQuestion;
using DevExpress.XtraEditors;

namespace TesteeApplication
{
    public partial class QuestionForm : DevExpress.XtraEditors.XtraForm
    {
        private Dictionary<AnswerDTO, bool> answers = new Dictionary<AnswerDTO, bool>();
        private TesteeQuestionViewModel model;

        public QuestionForm(Testee testee)
        {
            InitializeComponent();
            Localized(Program.currentLang);
            mvvmQuestionContext.ViewModelType = typeof(TesteeQuestionViewModel);
            BindCommands();
            model = mvvmQuestionContext.GetViewModel<TesteeQuestionViewModel>();
            mvvmQuestionContext.SetViewModel(typeof(TesteeQuestionViewModel), model);
            model.LoadQuestionForTestee(Program.currentTestee);

            if (model.question != null)
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

        private const int WS_SYSMENU = 0x80000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style &= ~WS_SYSMENU;
                return cp;
            }
        }   

        public void CreateQuestionControls(QuestionDTO question)
        {
            var multiSelect = model.MultiSelect;
            labelQuestion.Width = this.Width;
            labelQuestion.DataBindings.Add("Text", question, "QuestionText");
            bool selectFirstRadio = false;
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

            this.Text = !String.IsNullOrEmpty(resources.GetString("Title", newCultureInfo))
                ? resources.GetString("Title", newCultureInfo) + " " : "Question for" + " ";
            this.Text += Program.currentTestee.Login;
        }

        private void QuestionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.Timer.Start();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            var resources = new ComponentResourceManager(typeof(QuestionForm));
            CultureInfo newCultureInfo = new CultureInfo(Program.currentLang);
           
            var header = !String.IsNullOrEmpty(resources.GetString("Header", newCultureInfo))
                ? resources.GetString("Header", newCultureInfo) : "Result";

            var message = !String.IsNullOrEmpty(resources.GetString("Message", newCultureInfo))
                ? resources.GetString("Message", newCultureInfo) : "Your answer was ";

            var result = model.FindWasAnswerCorrect(answers)
                ? (!String.IsNullOrEmpty(resources.GetString("Correct", newCultureInfo))
                    ? resources.GetString("Correct", newCultureInfo) : "correct")
                : (!String.IsNullOrEmpty(resources.GetString("Wrong", newCultureInfo))
                    ? resources.GetString("Wrong", newCultureInfo) : "wrong");

            if (DialogResult.OK == XtraMessageBox.Show(message + result, header, MessageBoxButtons.OK))
            {
                this.Close();
                Program.Timer.Start();
                Program.QuestionAmount += 1;
                Program.SetUpStartTime(Program.currentTestee.UserSetting.FrequencyOfAsking);
            }
        }
    }
}