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
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.updateParametersLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.timeOfUpdateLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.reportFilePathLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.reportFileNameLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.questionFilesPathLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.additionalQuestionsPathLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.mvvmSettingsContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pathToAdditionalQuestionsTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionPathTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lmsReportFileNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lmsReporPathTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateParametersLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeOfUpdateLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportFilePathLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportFileNameLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionFilesPathLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionalQuestionsPathLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
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
            this.checkedComboBoxEdit1.Location = new System.Drawing.Point(24, 58);
            this.checkedComboBoxEdit1.Name = "checkedComboBoxEdit1";
            this.checkedComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedComboBoxEdit1.Size = new System.Drawing.Size(705, 20);
            this.checkedComboBoxEdit1.StyleController = this.layoutControl1;
            this.checkedComboBoxEdit1.TabIndex = 5;
            this.checkedComboBoxEdit1.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.checkedComboBoxEdit1_Closed);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.updateParametersLayoutControlGroup,
            this.layoutControlGroup3,
            this.layoutControlItem7,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(753, 461);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // updateParametersLayoutControlGroup
            // 
            this.updateParametersLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.timeOfUpdateLayoutControlItem});
            this.updateParametersLayoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.updateParametersLayoutControlGroup.Name = "updateParametersLayoutControlGroup";
            this.updateParametersLayoutControlGroup.Size = new System.Drawing.Size(733, 82);
            this.updateParametersLayoutControlGroup.Text = "Automatic updates parameters";
            // 
            // timeOfUpdateLayoutControlItem
            // 
            this.timeOfUpdateLayoutControlItem.Control = this.checkedComboBoxEdit1;
            this.timeOfUpdateLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.timeOfUpdateLayoutControlItem.Name = "timeOfUpdateLayoutControlItem";
            this.timeOfUpdateLayoutControlItem.Size = new System.Drawing.Size(709, 40);
            this.timeOfUpdateLayoutControlItem.Text = "Time of automatic update";
            this.timeOfUpdateLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.timeOfUpdateLayoutControlItem.TextSize = new System.Drawing.Size(133, 13);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.reportFilePathLayoutControlItem,
            this.reportFileNameLayoutControlItem,
            this.questionFilesPathLayoutControlItem,
            this.additionalQuestionsPathLayoutControlItem});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 82);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(733, 167);
            this.layoutControlGroup3.Text = "Report and question parameters";
            // 
            // reportFilePathLayoutControlItem
            // 
            this.reportFilePathLayoutControlItem.Control = this.lmsReporPathTextEdit;
            this.reportFilePathLayoutControlItem.Location = new System.Drawing.Point(191, 0);
            this.reportFilePathLayoutControlItem.Name = "reportFilePathLayoutControlItem";
            this.reportFilePathLayoutControlItem.Size = new System.Drawing.Size(518, 40);
            this.reportFilePathLayoutControlItem.Text = "Path to LMS report ";
            this.reportFilePathLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.reportFilePathLayoutControlItem.TextSize = new System.Drawing.Size(133, 13);
            // 
            // reportFileNameLayoutControlItem
            // 
            this.reportFileNameLayoutControlItem.Control = this.lmsReportFileNameTextEdit;
            this.reportFileNameLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.reportFileNameLayoutControlItem.Name = "reportFileNameLayoutControlItem";
            this.reportFileNameLayoutControlItem.Size = new System.Drawing.Size(191, 40);
            this.reportFileNameLayoutControlItem.Text = "LMS report file name";
            this.reportFileNameLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.reportFileNameLayoutControlItem.TextSize = new System.Drawing.Size(133, 13);
            // 
            // questionFilesPathLayoutControlItem
            // 
            this.questionFilesPathLayoutControlItem.Control = this.questionPathTextEdit;
            this.questionFilesPathLayoutControlItem.Location = new System.Drawing.Point(0, 40);
            this.questionFilesPathLayoutControlItem.Name = "questionFilesPathLayoutControlItem";
            this.questionFilesPathLayoutControlItem.Size = new System.Drawing.Size(709, 40);
            this.questionFilesPathLayoutControlItem.Text = "Path to questions";
            this.questionFilesPathLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.questionFilesPathLayoutControlItem.TextSize = new System.Drawing.Size(133, 13);
            // 
            // additionalQuestionsPathLayoutControlItem
            // 
            this.additionalQuestionsPathLayoutControlItem.Control = this.pathToAdditionalQuestionsTextEdit;
            this.additionalQuestionsPathLayoutControlItem.Location = new System.Drawing.Point(0, 80);
            this.additionalQuestionsPathLayoutControlItem.Name = "additionalQuestionsPathLayoutControlItem";
            this.additionalQuestionsPathLayoutControlItem.Size = new System.Drawing.Size(709, 45);
            this.additionalQuestionsPathLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 0);
            this.additionalQuestionsPathLayoutControlItem.Text = "Path to additional questions";
            this.additionalQuestionsPathLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.additionalQuestionsPathLayoutControlItem.TextSize = new System.Drawing.Size(133, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.saveButton;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 249);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(733, 26);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 275);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(733, 166);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateParametersLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeOfUpdateLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportFilePathLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportFileNameLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionFilesPathLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionalQuestionsPathLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmSettingsContext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.CheckedComboBoxEdit checkedComboBoxEdit1;
        private DevExpress.XtraLayout.LayoutControlItem timeOfUpdateLayoutControlItem;
        private DevExpress.XtraEditors.TextEdit lmsReporPathTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem reportFilePathLayoutControlItem;
        private DevExpress.XtraEditors.TextEdit questionPathTextEdit;
        private DevExpress.XtraEditors.TextEdit lmsReportFileNameTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup updateParametersLayoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem reportFileNameLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem questionFilesPathLayoutControlItem;
        private DevExpress.Utils.MVVM.MVVMContext mvvmSettingsContext;
        private DevExpress.XtraEditors.TextEdit pathToAdditionalQuestionsTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem additionalQuestionsPathLayoutControlItem;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}