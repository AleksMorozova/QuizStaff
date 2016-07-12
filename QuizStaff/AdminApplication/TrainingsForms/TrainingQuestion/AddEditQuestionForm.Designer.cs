namespace AdminApplication.TrainingsForms.TrainingQuestion
{
    partial class AddEditQuestionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditQuestionForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.answersGridControl = new DevExpress.XtraGrid.GridControl();
            this.answersGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.answerColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.isCorrectColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.isCorrectRepositoryItemCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.questionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.questionLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.answersLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.saveButtonLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.cancelButtonLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.questionBindingSource = new System.Windows.Forms.BindingSource();
            this.mvvmQuestionContext = new DevExpress.Utils.MVVM.MVVMContext();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.answersGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isCorrectRepositoryItemCheckEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answersLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButtonLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmQuestionContext)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cancelButton);
            this.layoutControl1.Controls.Add(this.saveButton);
            this.layoutControl1.Controls.Add(this.answersGridControl);
            this.layoutControl1.Controls.Add(this.questionTextEdit);
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(457, 272, 250, 350);
            this.layoutControl1.OptionsView.UseDefaultDragAndDropRendering = false;
            this.layoutControl1.Root = this.layoutControlGroup1;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.StyleController = this.layoutControl1;
            // 
            // saveButton
            // 
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.StyleController = this.layoutControl1;
            // 
            // answersGridControl
            // 
            this.answersGridControl.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.answersGridControl_EmbeddedNavigator_ButtonClick);
            resources.ApplyResources(this.answersGridControl, "answersGridControl");
            this.answersGridControl.MainView = this.answersGridView;
            this.answersGridControl.Name = "answersGridControl";
            this.answersGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.isCorrectRepositoryItemCheckEdit});
            this.answersGridControl.UseEmbeddedNavigator = true;
            this.answersGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.answersGridView});
            // 
            // answersGridView
            // 
            this.answersGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.answerColumn,
            this.isCorrectColumn});
            this.answersGridView.GridControl = this.answersGridControl;
            this.answersGridView.Name = "answersGridView";
            this.answersGridView.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace;
            this.answersGridView.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.answersGridView.OptionsView.ShowGroupPanel = false;
            this.answersGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.answersGridView_InitNewRow);
            // 
            // answerColumn
            // 
            resources.ApplyResources(this.answerColumn, "answerColumn");
            this.answerColumn.FieldName = "AnswerText";
            this.answerColumn.Name = "answerColumn";
            // 
            // isCorrectColumn
            // 
            resources.ApplyResources(this.isCorrectColumn, "isCorrectColumn");
            this.isCorrectColumn.ColumnEdit = this.isCorrectRepositoryItemCheckEdit;
            this.isCorrectColumn.FieldName = "IsCorrect";
            this.isCorrectColumn.Name = "isCorrectColumn";
            // 
            // isCorrectRepositoryItemCheckEdit
            // 
            resources.ApplyResources(this.isCorrectRepositoryItemCheckEdit, "isCorrectRepositoryItemCheckEdit");
            this.isCorrectRepositoryItemCheckEdit.Name = "isCorrectRepositoryItemCheckEdit";
            // 
            // questionTextEdit
            // 
            resources.ApplyResources(this.questionTextEdit, "questionTextEdit");
            this.questionTextEdit.Name = "questionTextEdit";
            this.questionTextEdit.StyleController = this.layoutControl1;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.questionLayoutControlItem,
            this.answersLayoutControlItem,
            this.saveButtonLayoutControlItem,
            this.emptySpaceItem1,
            this.cancelButtonLayoutControlItem});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(652, 449);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // questionLayoutControlItem
            // 
            this.questionLayoutControlItem.Control = this.questionTextEdit;
            this.questionLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.questionLayoutControlItem.Name = "questionLayoutControlItem";
            this.questionLayoutControlItem.Size = new System.Drawing.Size(632, 24);
            resources.ApplyResources(this.questionLayoutControlItem, "questionLayoutControlItem");
            this.questionLayoutControlItem.TextSize = new System.Drawing.Size(45, 13);
            // 
            // answersLayoutControlItem
            // 
            this.answersLayoutControlItem.Control = this.answersGridControl;
            this.answersLayoutControlItem.Location = new System.Drawing.Point(0, 24);
            this.answersLayoutControlItem.Name = "answersLayoutControlItem";
            this.answersLayoutControlItem.Size = new System.Drawing.Size(632, 369);
            this.answersLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 0);
            resources.ApplyResources(this.answersLayoutControlItem, "answersLayoutControlItem");
            this.answersLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.answersLayoutControlItem.TextSize = new System.Drawing.Size(45, 13);
            // 
            // saveButtonLayoutControlItem
            // 
            this.saveButtonLayoutControlItem.Control = this.saveButton;
            this.saveButtonLayoutControlItem.Location = new System.Drawing.Point(350, 393);
            this.saveButtonLayoutControlItem.Name = "saveButtonLayoutControlItem";
            this.saveButtonLayoutControlItem.Size = new System.Drawing.Size(141, 36);
            this.saveButtonLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.saveButtonLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.saveButtonLayoutControlItem.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 393);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(350, 36);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // cancelButtonLayoutControlItem
            // 
            this.cancelButtonLayoutControlItem.Control = this.cancelButton;
            this.cancelButtonLayoutControlItem.Location = new System.Drawing.Point(491, 393);
            this.cancelButtonLayoutControlItem.Name = "cancelButtonLayoutControlItem";
            this.cancelButtonLayoutControlItem.Size = new System.Drawing.Size(141, 36);
            this.cancelButtonLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 0, 5, 5);
            this.cancelButtonLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.cancelButtonLayoutControlItem.TextVisible = false;
            // 
            // mvvmQuestionContext
            // 
            this.mvvmQuestionContext.ContainerControl = this;
            // 
            // AddEditQuestionForm
            // 
            this.AcceptButton = this.saveButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.Controls.Add(this.layoutControl1);
            this.Name = "AddEditQuestionForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.answersGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isCorrectRepositoryItemCheckEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answersLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButtonLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmQuestionContext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl answersGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView answersGridView;
        private DevExpress.XtraGrid.Columns.GridColumn answerColumn;
        private DevExpress.XtraGrid.Columns.GridColumn isCorrectColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit isCorrectRepositoryItemCheckEdit;
        private DevExpress.XtraEditors.TextEdit questionTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem questionLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem answersLayoutControlItem;
        private System.Windows.Forms.BindingSource questionBindingSource;
        private DevExpress.Utils.MVVM.MVVMContext mvvmQuestionContext;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraLayout.LayoutControlItem saveButtonLayoutControlItem;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem cancelButtonLayoutControlItem;
    }
}