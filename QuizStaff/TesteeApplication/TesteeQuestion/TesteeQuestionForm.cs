﻿using System;
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
using DataTransferObject;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Controls;
using System.Globalization;
using DevExpress.Utils.Text;

namespace TesteeApplication.TesteeQuestion
{
    public partial class TesteeQuestionForm : DevExpress.XtraEditors.XtraForm
    {
        private TesteeQuestionViewModel model;



        public TesteeQuestionForm(Testee testee)
        {
            InitializeComponent();
            
            Localized(Program.СurrentLang);
            mvvmQuestionContext.ViewModelType = typeof(TesteeQuestionViewModel);
            BindCommands();
            model = mvvmQuestionContext.GetViewModel<TesteeQuestionViewModel>();
            mvvmQuestionContext.SetViewModel(typeof(TesteeQuestionViewModel), model);
            model.LoadQuestionForTestee(Program.СurrentTestee);

            if (model.question != null)
            {     
                SetUpCombobox();
                SetUpCheckedListType();
            }
        }

        private void SetWindowsPosition()
        {
            Screen rightmost = Screen.AllScreens[0];
            foreach (Screen screen in Screen.AllScreens)
            {
                if (screen.WorkingArea.Right > rightmost.WorkingArea.Right)
                    rightmost = screen;
            }

            this.Left = (Program.FirstShow) ? rightmost.WorkingArea.Right - this.Width : Program.LeftPosition;
            this.Top = (Program.FirstShow) ? rightmost.WorkingArea.Bottom - this.Height : Program.TopPosition;
            Program.FirstShow = false;
        }

        public void SetUpCombobox()
        {
            //fill comboBox and question label
            questionLabel.Text = model.question.QuestionText;

            foreach (var a in model.question.Answers)
            {
                answersCheckedList.Items.Add(a.AnswerText);
            }
        }

        public void SetUpCheckedListType()
        {
            //determination of CheckedList type depends on amount of right question 
            if (!model.IsMultiSelect())
            {
                answersCheckedList.CheckStyle = CheckStyles.Radio;
                answersCheckedList.SelectionMode = SelectionMode.One;
            }
        }

        private void BindCommands() 
        { 

        }

        private void Localized(string language) 
        {
            var resources = new ComponentResourceManager(typeof(TesteeQuestionForm));
            CultureInfo newCultureInfo = new CultureInfo(language);
            resources.ApplyResources(OKButton, "OKButton", newCultureInfo);

            this.Text = !String.IsNullOrEmpty(resources.GetString("Title", newCultureInfo))
                ? resources.GetString("Title", newCultureInfo) + " " : "Question for" + " ";
            this.Text += Program.СurrentTestee.Login;
        }

        //hide control box without hidding form title 
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

        private void OKButton_Click(object sender, EventArgs e)
        {
            Program.LeftPosition = this.Left;
            Program.TopPosition = this.Top;

            List<Answer> list = new List<Answer>();

            foreach (CheckedListBoxItem item in answersCheckedList.Items)
            {
                if (item.CheckState == CheckState.Checked)
                {
                    list.Add(model.question.Answers.Where(_ => _.AnswerText.ToString() == item.Value.ToString()).First());
                }
            }

            model.SaveTesteeAnswer(list);

            var resources = new ComponentResourceManager(typeof(TesteeQuestionForm));
            CultureInfo newCultureInfo = new CultureInfo(Program.СurrentLang);

            var header = !String.IsNullOrEmpty(resources.GetString("Header", newCultureInfo))
                ? resources.GetString("Header", newCultureInfo) : "Result";

            var message = !String.IsNullOrEmpty(resources.GetString("Message", newCultureInfo))
                ? resources.GetString("Message", newCultureInfo) : "Your answer was ";

            var result = model.FindWasAnswerCorrect(list)
                ? (!String.IsNullOrEmpty(resources.GetString("Correct", newCultureInfo))
                    ? resources.GetString("Correct", newCultureInfo) : "correct")
                : (!String.IsNullOrEmpty(resources.GetString("Wrong", newCultureInfo))
                    ? resources.GetString("Wrong", newCultureInfo) : "wrong");

            if (DialogResult.OK == XtraMessageBox.Show(message + result, header, MessageBoxButtons.OK))
            {
                this.Close();
            }
        }

        private void TesteeQuestionForm_Load(object sender, EventArgs e)
        {
            SetWindowsPosition();
        }

        private void answersCheckedList_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            if (e.State == CheckState.Checked)
            {
                foreach (CheckedListBoxItem item in answersCheckedList.Items)
                {
                    if (item.Value != answersCheckedList.Items[e.Index].Value && item.CheckState == CheckState.Checked)
                    {
                        if (!model.IsMultiSelect())
                            item.CheckState = CheckState.Unchecked;
                    }
                }
            }
        }

        //Dynamically determine the distance between CheckedList items
        private void answersCheckedList_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            CheckedListBoxControl control = (CheckedListBoxControl)sender;
            string text = control.GetItemText(e.Index);
            Size textSize = TextUtils.GetStringSize(e.Graphics, text, control.Appearance.Font,
                StringFormat.GenericDefault, control.ClientRectangle.Width);
            e.ItemHeight = textSize.Height + 10;
        }
    }
}