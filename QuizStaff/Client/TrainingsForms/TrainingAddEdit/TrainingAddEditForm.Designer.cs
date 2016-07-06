namespace Client.TrainingsForms.TrainingAddEdit
{
    partial class TrainingAddEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainingAddEditForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.deleteQuestionButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.loadQuestionButton = new DevExpress.XtraEditors.SimpleButton();
            this.editQuestionButton = new DevExpress.XtraEditors.SimpleButton();
            this.addQuestionButton = new DevExpress.XtraEditors.SimpleButton();
            this.gridQuestions = new DevExpress.XtraGrid.GridControl();
            this.questionsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.QuestionText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textTrainingName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.questionsControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.addQuestionButtonLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.editQuestionButtonLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.loadQuestionButtonLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.saveButtonLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.cancelButtonLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.ldeleteQuestionButtonLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.mvvmTrainingContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTrainingName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addQuestionButtonLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editQuestionButtonLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadQuestionButtonLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButtonLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ldeleteQuestionButtonLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmTrainingContext)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.deleteQuestionButton);
            this.layoutControl1.Controls.Add(this.cancelButton);
            this.layoutControl1.Controls.Add(this.saveButton);
            this.layoutControl1.Controls.Add(this.loadQuestionButton);
            this.layoutControl1.Controls.Add(this.editQuestionButton);
            this.layoutControl1.Controls.Add(this.addQuestionButton);
            this.layoutControl1.Controls.Add(this.gridQuestions);
            this.layoutControl1.Controls.Add(this.textTrainingName);
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(618, 132, 674, 544);
            this.layoutControl1.Root = this.layoutControlGroup1;
            // 
            // deleteQuestionButton
            // 
            resources.ApplyResources(this.deleteQuestionButton, "deleteQuestionButton");
            this.deleteQuestionButton.Name = "deleteQuestionButton";
            this.deleteQuestionButton.StyleController = this.layoutControl1;
            this.deleteQuestionButton.Click += new System.EventHandler(this.deleteQuestionButton_Click);
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.StyleController = this.layoutControl1;
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.StyleController = this.layoutControl1;
            // 
            // loadQuestionButton
            // 
            resources.ApplyResources(this.loadQuestionButton, "loadQuestionButton");
            this.loadQuestionButton.Name = "loadQuestionButton";
            this.loadQuestionButton.StyleController = this.layoutControl1;
            // 
            // editQuestionButton
            // 
            resources.ApplyResources(this.editQuestionButton, "editQuestionButton");
            this.editQuestionButton.Name = "editQuestionButton";
            this.editQuestionButton.StyleController = this.layoutControl1;
            // 
            // addQuestionButton
            // 
            resources.ApplyResources(this.addQuestionButton, "addQuestionButton");
            this.addQuestionButton.Name = "addQuestionButton";
            this.addQuestionButton.StyleController = this.layoutControl1;
            // 
            // gridQuestions
            // 
            resources.ApplyResources(this.gridQuestions, "gridQuestions");
            this.gridQuestions.MainView = this.questionsGridView;
            this.gridQuestions.Name = "gridQuestions";
            this.gridQuestions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.questionsGridView});
            this.gridQuestions.DoubleClick += new System.EventHandler(this.gridQuestions_DoubleClick);
            // 
            // questionsGridView
            // 
            this.questionsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.QuestionText});
            this.questionsGridView.GridControl = this.gridQuestions;
            this.questionsGridView.Name = "questionsGridView";
            this.questionsGridView.OptionsDetail.EnableMasterViewMode = false;
            this.questionsGridView.OptionsView.ShowGroupPanel = false;
            // 
            // QuestionText
            // 
            resources.ApplyResources(this.QuestionText, "QuestionText");
            this.QuestionText.FieldName = "QuestionText";
            this.QuestionText.Name = "QuestionText";
            this.QuestionText.OptionsColumn.AllowEdit = false;
            this.QuestionText.OptionsColumn.AllowFocus = false;
            this.QuestionText.OptionsColumn.ReadOnly = true;
            // 
            // textTrainingName
            // 
            resources.ApplyResources(this.textTrainingName, "textTrainingName");
            this.textTrainingName.Name = "textTrainingName";
            this.textTrainingName.StyleController = this.layoutControl1;
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
            this.cancelButtonLayoutControl,
            this.ldeleteQuestionButtonLayoutControlItem});
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
            resources.ApplyResources(this.layoutControlItem1, "layoutControlItem1");
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(68, 13);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 40);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(356, 36);
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
            // addQuestionButtonLayoutControl
            // 
            this.addQuestionButtonLayoutControl.Control = this.addQuestionButton;
            this.addQuestionButtonLayoutControl.Location = new System.Drawing.Point(356, 40);
            this.addQuestionButtonLayoutControl.Name = "addQuestionButtonLayoutControl";
            this.addQuestionButtonLayoutControl.Size = new System.Drawing.Size(100, 36);
            this.addQuestionButtonLayoutControl.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.addQuestionButtonLayoutControl.TextSize = new System.Drawing.Size(0, 0);
            this.addQuestionButtonLayoutControl.TextVisible = false;
            // 
            // editQuestionButtonLayoutControl
            // 
            this.editQuestionButtonLayoutControl.Control = this.editQuestionButton;
            this.editQuestionButtonLayoutControl.Location = new System.Drawing.Point(456, 40);
            this.editQuestionButtonLayoutControl.Name = "editQuestionButtonLayoutControl";
            this.editQuestionButtonLayoutControl.Size = new System.Drawing.Size(100, 36);
            this.editQuestionButtonLayoutControl.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.editQuestionButtonLayoutControl.TextSize = new System.Drawing.Size(0, 0);
            this.editQuestionButtonLayoutControl.TextVisible = false;
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
            // ldeleteQuestionButtonLayoutControlItem
            // 
            this.ldeleteQuestionButtonLayoutControlItem.Control = this.deleteQuestionButton;
            this.ldeleteQuestionButtonLayoutControlItem.Location = new System.Drawing.Point(556, 40);
            this.ldeleteQuestionButtonLayoutControlItem.Name = "ldeleteQuestionButtonLayoutControlItem";
            this.ldeleteQuestionButtonLayoutControlItem.Size = new System.Drawing.Size(100, 36);
            this.ldeleteQuestionButtonLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.ldeleteQuestionButtonLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.ldeleteQuestionButtonLayoutControlItem.TextVisible = false;
            // 
            // mvvmTrainingContext
            // 
            this.mvvmTrainingContext.ContainerControl = this;
            // 
            // TrainingAddEditForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "TrainingAddEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTrainingName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addQuestionButtonLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editQuestionButtonLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadQuestionButtonLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButtonLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ldeleteQuestionButtonLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmTrainingContext)).EndInit();
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
        private DevExpress.XtraGrid.Views.Grid.GridView questionsGridView;
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
        private DevExpress.XtraEditors.SimpleButton deleteQuestionButton;
        private DevExpress.XtraLayout.LayoutControlItem ldeleteQuestionButtonLayoutControlItem;
    }
}