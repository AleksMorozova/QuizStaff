﻿namespace Client
{
    partial class TrainingAddEdit
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
            this.gridQuestions = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.QuestionText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textTrainingName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.questionsControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.mvvmTrainingContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.addQuestionButton = new DevExpress.XtraEditors.SimpleButton();
            this.addQuestionButtonLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.editQuestionButton = new DevExpress.XtraEditors.SimpleButton();
            this.editQuestionButtonLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.loadQuestionButton = new DevExpress.XtraEditors.SimpleButton();
            this.loadQuestionButtonLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveButtonLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButtonLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTrainingName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmTrainingContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addQuestionButtonLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editQuestionButtonLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadQuestionButtonLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButtonLayoutControl)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cancelButton);
            this.layoutControl1.Controls.Add(this.saveButton);
            this.layoutControl1.Controls.Add(this.loadQuestionButton);
            this.layoutControl1.Controls.Add(this.editQuestionButton);
            this.layoutControl1.Controls.Add(this.addQuestionButton);
            this.layoutControl1.Controls.Add(this.gridQuestions);
            this.layoutControl1.Controls.Add(this.textTrainingName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(618, 132, 674, 544);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(776, 416);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridQuestions
            // 
            this.gridQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridQuestions.Location = new System.Drawing.Point(12, 88);
            this.gridQuestions.MainView = this.gridView1;
            this.gridQuestions.Name = "gridQuestions";
            this.gridQuestions.Size = new System.Drawing.Size(752, 280);
            this.gridQuestions.TabIndex = 9;
            this.gridQuestions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridQuestions.DoubleClick += new System.EventHandler(this.gridQuestions_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.QuestionText});
            this.gridView1.GridControl = this.gridQuestions;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // QuestionText
            // 
            this.QuestionText.Caption = "Question";
            this.QuestionText.FieldName = "QuestionText";
            this.QuestionText.Name = "QuestionText";
            this.QuestionText.OptionsColumn.AllowEdit = false;
            this.QuestionText.OptionsColumn.AllowFocus = false;
            this.QuestionText.OptionsColumn.ReadOnly = true;
            this.QuestionText.Visible = true;
            this.QuestionText.VisibleIndex = 0;
            // 
            // textTrainingName
            // 
            this.textTrainingName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textTrainingName.EditValue = "";
            this.textTrainingName.Location = new System.Drawing.Point(12, 28);
            this.textTrainingName.Name = "textTrainingName";
            this.textTrainingName.Size = new System.Drawing.Size(752, 20);
            this.textTrainingName.StyleController = this.layoutControl1;
            this.textTrainingName.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem2,
            this.layoutControlItem1,
            this.emptySpaceItem3,
            this.questionsControlItem,
            this.addQuestionButtonLayoutControl,
            this.editQuestionButtonLayoutControl,
            this.loadQuestionButtonLayoutControl,
            this.saveButtonLayoutControl,
            this.cancelButtonLayoutControl});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(776, 416);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 360);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(555, 36);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textTrainingName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(756, 40);
            this.layoutControlItem1.Text = "Training Name";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(68, 13);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 40);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(456, 36);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // questionsControlItem
            // 
            this.questionsControlItem.Control = this.gridQuestions;
            this.questionsControlItem.Location = new System.Drawing.Point(0, 76);
            this.questionsControlItem.Name = "questionsControlItem";
            this.questionsControlItem.Size = new System.Drawing.Size(756, 284);
            this.questionsControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.questionsControlItem.TextVisible = false;
            // 
            // mvvmTrainingContext
            // 
            this.mvvmTrainingContext.ContainerControl = this;
            // 
            // addQuestionButton
            // 
            this.addQuestionButton.Location = new System.Drawing.Point(473, 57);
            this.addQuestionButton.Name = "addQuestionButton";
            this.addQuestionButton.Size = new System.Drawing.Size(86, 22);
            this.addQuestionButton.StyleController = this.layoutControl1;
            this.addQuestionButton.TabIndex = 12;
            this.addQuestionButton.Text = "Add question";
            // 
            // addQuestionButtonLayoutControl
            // 
            this.addQuestionButtonLayoutControl.Control = this.addQuestionButton;
            this.addQuestionButtonLayoutControl.Location = new System.Drawing.Point(456, 40);
            this.addQuestionButtonLayoutControl.Name = "addQuestionButtonLayoutControl";
            this.addQuestionButtonLayoutControl.Size = new System.Drawing.Size(100, 36);
            this.addQuestionButtonLayoutControl.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.addQuestionButtonLayoutControl.TextSize = new System.Drawing.Size(0, 0);
            this.addQuestionButtonLayoutControl.TextVisible = false;
            // 
            // editQuestionButton
            // 
            this.editQuestionButton.Location = new System.Drawing.Point(573, 57);
            this.editQuestionButton.Name = "editQuestionButton";
            this.editQuestionButton.Size = new System.Drawing.Size(86, 22);
            this.editQuestionButton.StyleController = this.layoutControl1;
            this.editQuestionButton.TabIndex = 13;
            this.editQuestionButton.Text = "Edit question";
            // 
            // editQuestionButtonLayoutControl
            // 
            this.editQuestionButtonLayoutControl.Control = this.editQuestionButton;
            this.editQuestionButtonLayoutControl.Location = new System.Drawing.Point(556, 40);
            this.editQuestionButtonLayoutControl.Name = "editQuestionButtonLayoutControl";
            this.editQuestionButtonLayoutControl.Size = new System.Drawing.Size(100, 36);
            this.editQuestionButtonLayoutControl.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.editQuestionButtonLayoutControl.TextSize = new System.Drawing.Size(0, 0);
            this.editQuestionButtonLayoutControl.TextVisible = false;
            // 
            // loadQuestionButton
            // 
            this.loadQuestionButton.Location = new System.Drawing.Point(673, 57);
            this.loadQuestionButton.Name = "loadQuestionButton";
            this.loadQuestionButton.Size = new System.Drawing.Size(91, 22);
            this.loadQuestionButton.StyleController = this.layoutControl1;
            this.loadQuestionButton.TabIndex = 14;
            this.loadQuestionButton.Text = "Load question";
            // 
            // loadQuestionButtonLayoutControl
            // 
            this.loadQuestionButtonLayoutControl.Control = this.loadQuestionButton;
            this.loadQuestionButtonLayoutControl.Location = new System.Drawing.Point(656, 40);
            this.loadQuestionButtonLayoutControl.Name = "loadQuestionButtonLayoutControl";
            this.loadQuestionButtonLayoutControl.Size = new System.Drawing.Size(100, 36);
            this.loadQuestionButtonLayoutControl.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 0, 5, 5);
            this.loadQuestionButtonLayoutControl.TextSize = new System.Drawing.Size(0, 0);
            this.loadQuestionButtonLayoutControl.TextVisible = false;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(572, 377);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(86, 22);
            this.saveButton.StyleController = this.layoutControl1;
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Save";
            // 
            // saveButtonLayoutControl
            // 
            this.saveButtonLayoutControl.Control = this.saveButton;
            this.saveButtonLayoutControl.Location = new System.Drawing.Point(555, 360);
            this.saveButtonLayoutControl.Name = "saveButtonLayoutControl";
            this.saveButtonLayoutControl.Size = new System.Drawing.Size(100, 36);
            this.saveButtonLayoutControl.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.saveButtonLayoutControl.TextSize = new System.Drawing.Size(0, 0);
            this.saveButtonLayoutControl.TextVisible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(672, 377);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(92, 22);
            this.cancelButton.StyleController = this.layoutControl1;
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Cancel";
            // 
            // cancelButtonLayoutControl
            // 
            this.cancelButtonLayoutControl.Control = this.cancelButton;
            this.cancelButtonLayoutControl.Location = new System.Drawing.Point(655, 360);
            this.cancelButtonLayoutControl.Name = "cancelButtonLayoutControl";
            this.cancelButtonLayoutControl.Size = new System.Drawing.Size(101, 36);
            this.cancelButtonLayoutControl.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 0, 5, 5);
            this.cancelButtonLayoutControl.TextSize = new System.Drawing.Size(0, 0);
            this.cancelButtonLayoutControl.TextVisible = false;
            // 
            // TrainingAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 416);
            this.Controls.Add(this.layoutControl1);
            this.Name = "TrainingAddEdit";
            this.Text = "Training: ";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTrainingName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmTrainingContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addQuestionButtonLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editQuestionButtonLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadQuestionButtonLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButtonLayoutControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.TextEdit textTrainingName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraGrid.GridControl gridQuestions;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn QuestionText;
        private DevExpress.XtraLayout.LayoutControlItem questionsControlItem;
        private DevExpress.Utils.MVVM.MVVMContext mvvmTrainingContext;
        private DevExpress.XtraEditors.SimpleButton addQuestionButton;
        private DevExpress.XtraLayout.LayoutControlItem addQuestionButtonLayoutControl;
        private DevExpress.XtraEditors.SimpleButton loadQuestionButton;
        private DevExpress.XtraEditors.SimpleButton editQuestionButton;
        private DevExpress.XtraLayout.LayoutControlItem editQuestionButtonLayoutControl;
        private DevExpress.XtraLayout.LayoutControlItem loadQuestionButtonLayoutControl;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraLayout.LayoutControlItem saveButtonLayoutControl;
        private DevExpress.XtraLayout.LayoutControlItem cancelButtonLayoutControl;
    }
}