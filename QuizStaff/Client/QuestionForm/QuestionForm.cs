using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataTransferObject;
using System.Drawing;

namespace Client
{
    public partial class QuestionForm : DevExpress.XtraEditors.XtraForm, IQuestionForm
    {
        public QuestionPresenter Presenter { get; set; }
        public QuestionForm()
        {
            InitializeComponent();
            var screen = Screen.FromPoint(this.Location);
            this.Location = new Point(screen.WorkingArea.Right - this.Width, screen.WorkingArea.Bottom - this.Height);
            flow.SetFlowBreak(labelQuestion, true);
        }

        public void CreateQuestionControls(QuestionDTO question, List<bool> testeeAnswers, bool multiSelect)
        {
            labelQuestion.DataBindings.Add("Text", question, "QuestionText");
            int counter = 0;
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
                (control as Control).Name = "control" + counter;
                (control as Control).DataBindings.Add("Text", answer, "AnswerText");
                control.Index = counter;
                control.CheckedChanged += (sender, e) => testeeAnswers[control.Index] = control.Checked;
                if (counter++ == 0 && !multiSelect)
                {
                    control.Checked = true;
                }
                flow.Controls.Add((control as Control));
                flow.SetFlowBreak((control as Control), true);
            }
        }

        public void NotifyNoAnswersChecked()
        {
            MessageBox.Show("You must select at least 1 answer.");
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            Presenter.Send();
        }

        public void CloseForm()
        {
            this.Close();
        }
    }
}