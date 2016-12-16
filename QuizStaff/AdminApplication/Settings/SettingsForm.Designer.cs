namespace AdminApplication.Settings
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.pathToAdditionalQuestionsTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.questionPathTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.lmsReportFileNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.lmsReporPathTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.checkedComboBoxEdit1 = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.timeOfUpdateTextEdit = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.mvvmSettingsContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pathToAdditionalQuestionsTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionPathTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lmsReportFileNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lmsReporPathTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeOfUpdateTextEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeOfUpdateTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmSettingsContext)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.saveButton);
            this.layoutControl1.Controls.Add(this.pathToAdditionalQuestionsTextEdit);
            this.layoutControl1.Controls.Add(this.questionPathTextEdit);
            this.layoutControl1.Controls.Add(this.lmsReportFileNameTextEdit);
            this.layoutControl1.Controls.Add(this.lmsReporPathTextEdit);
            this.layoutControl1.Controls.Add(this.checkedComboBoxEdit1);
            this.layoutControl1.Controls.Add(this.timeOfUpdateTextEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(753, 461);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 261);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(729, 22);
            this.saveButton.StyleController = this.layoutControl1;
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            // 
            // pathToAdditionalQuestionsTextEdit
            // 
            this.pathToAdditionalQuestionsTextEdit.Location = new System.Drawing.Point(24, 225);
            this.pathToAdditionalQuestionsTextEdit.Name = "pathToAdditionalQuestionsTextEdit";
            this.pathToAdditionalQuestionsTextEdit.Size = new System.Drawing.Size(705, 20);
            this.pathToAdditionalQuestionsTextEdit.StyleController = this.layoutControl1;
            this.pathToAdditionalQuestionsTextEdit.TabIndex = 9;
            // 
            // questionPathTextEdit
            // 
            this.questionPathTextEdit.EditValue = "D:\\QuizTrainings\\Questions";
            this.questionPathTextEdit.Location = new System.Drawing.Point(24, 180);
            this.questionPathTextEdit.Name = "questionPathTextEdit";
            this.questionPathTextEdit.Size = new System.Drawing.Size(705, 20);
            this.questionPathTextEdit.StyleController = this.layoutControl1;
            this.questionPathTextEdit.TabIndex = 8;
            // 
            // lmsReportFileNameTextEdit
            // 
            this.lmsReportFileNameTextEdit.EditValue = "ISD_Report";
            this.lmsReportFileNameTextEdit.Location = new System.Drawing.Point(24, 140);
            this.lmsReportFileNameTextEdit.Name = "lmsReportFileNameTextEdit";
            this.lmsReportFileNameTextEdit.Size = new System.Drawing.Size(187, 20);
            this.lmsReportFileNameTextEdit.StyleController = this.layoutControl1;
            this.lmsReportFileNameTextEdit.TabIndex = 7;
            // 
            // lmsReporPathTextEdit
            // 
            this.lmsReporPathTextEdit.EditValue = "D:\\QuizTrainings";
            this.lmsReporPathTextEdit.Location = new System.Drawing.Point(215, 140);
            this.lmsReporPathTextEdit.Name = "lmsReporPathTextEdit";
            this.lmsReporPathTextEdit.Size = new System.Drawing.Size(514, 20);
            this.lmsReporPathTextEdit.StyleController = this.layoutControl1;
            this.lmsReporPathTextEdit.TabIndex = 6;
            // 
            // checkedComboBoxEdit1
            // 
            this.checkedComboBoxEdit1.Location = new System.Drawing.Point(235, 58);
            this.checkedComboBoxEdit1.Name = "checkedComboBoxEdit1";
            this.checkedComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedComboBoxEdit1.Size = new System.Drawing.Size(494, 20);
            this.checkedComboBoxEdit1.StyleController = this.layoutControl1;
            this.checkedComboBoxEdit1.TabIndex = 5;
            this.checkedComboBoxEdit1.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.checkedComboBoxEdit1_Closed);
            // 
            // timeOfUpdateTextEdit
            // 
            this.timeOfUpdateTextEdit.EditValue = "1";
            this.timeOfUpdateTextEdit.Location = new System.Drawing.Point(24, 58);
            this.timeOfUpdateTextEdit.Name = "timeOfUpdateTextEdit";
            this.timeOfUpdateTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeOfUpdateTextEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeOfUpdateTextEdit.Properties.DisplayFormat.FormatString = "";
            this.timeOfUpdateTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.timeOfUpdateTextEdit.Properties.EditFormat.FormatString = "";
            this.timeOfUpdateTextEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.timeOfUpdateTextEdit.Properties.Mask.EditMask = "t";
            this.timeOfUpdateTextEdit.Size = new System.Drawing.Size(207, 20);
            this.timeOfUpdateTextEdit.StyleController = this.layoutControl1;
            this.timeOfUpdateTextEdit.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3,
            this.layoutControlItem7});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(753, 461);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(733, 82);
            this.layoutControlGroup2.Text = "Automatic updates parameters";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.timeOfUpdateTextEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(211, 40);
            this.layoutControlItem1.Text = "Frequency of automatic update";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(151, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.checkedComboBoxEdit1;
            this.layoutControlItem2.Location = new System.Drawing.Point(211, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(498, 40);
            this.layoutControlItem2.Text = "Time of automatic update";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(151, 13);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 82);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(733, 167);
            this.layoutControlGroup3.Text = "Report and question parameters";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.lmsReporPathTextEdit;
            this.layoutControlItem3.Location = new System.Drawing.Point(191, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(518, 40);
            this.layoutControlItem3.Text = "Path to LMS report ";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(151, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.lmsReportFileNameTextEdit;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(191, 40);
            this.layoutControlItem4.Text = "LMS report file name";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(151, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.questionPathTextEdit;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(709, 40);
            this.layoutControlItem5.Text = "Path to questions";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(151, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.pathToAdditionalQuestionsTextEdit;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 80);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(709, 45);
            this.layoutControlItem6.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 0);
            this.layoutControlItem6.Text = "Path to additional questions";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(151, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.saveButton;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 249);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(733, 192);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // mvvmSettingsContext
            // 
            this.mvvmSettingsContext.ContainerControl = this;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 461);
            this.Controls.Add(this.layoutControl1);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pathToAdditionalQuestionsTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionPathTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lmsReportFileNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lmsReporPathTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeOfUpdateTextEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeOfUpdateTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmSettingsContext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.CheckedComboBoxEdit checkedComboBoxEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit lmsReporPathTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit questionPathTextEdit;
        private DevExpress.XtraEditors.TextEdit lmsReportFileNameTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.Utils.MVVM.MVVMContext mvvmSettingsContext;
        private DevExpress.XtraEditors.TextEdit pathToAdditionalQuestionsTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.DateEdit timeOfUpdateTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    }
}