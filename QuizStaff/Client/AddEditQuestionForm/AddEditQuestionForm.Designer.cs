namespace Client.AddEditQuestionForm
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
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.answersGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.questionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mvvmQuestionContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.answersGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(457, 272, 250, 350);
            this.layoutControl1.OptionsView.UseDefaultDragAndDropRendering = false;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(652, 449);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(508, 410);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(132, 22);
            this.cancelButton.StyleController = this.layoutControl1;
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(367, 410);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(127, 22);
            this.saveButton.StyleController = this.layoutControl1;
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            // 
            // answersGridControl
            // 
            this.answersGridControl.Location = new System.Drawing.Point(12, 62);
            this.answersGridControl.MainView = this.gridView1;
            this.answersGridControl.Name = "answersGridControl";
            this.answersGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.isCorrectRepositoryItemCheckEdit});
            this.answersGridControl.Size = new System.Drawing.Size(628, 339);
            this.answersGridControl.TabIndex = 5;
            this.answersGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.answerColumn,
            this.isCorrectColumn});
            this.gridView1.GridControl = this.answersGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // answerColumn
            // 
            this.answerColumn.Caption = "Answer";
            this.answerColumn.FieldName = "AnswerText";
            this.answerColumn.Name = "answerColumn";
            this.answerColumn.Visible = true;
            this.answerColumn.VisibleIndex = 0;
            // 
            // isCorrectColumn
            // 
            this.isCorrectColumn.Caption = "Is correct";
            this.isCorrectColumn.ColumnEdit = this.isCorrectRepositoryItemCheckEdit;
            this.isCorrectColumn.FieldName = "IsCorrect";
            this.isCorrectColumn.Name = "isCorrectColumn";
            this.isCorrectColumn.Visible = true;
            this.isCorrectColumn.VisibleIndex = 1;
            // 
            // isCorrectRepositoryItemCheckEdit
            // 
            this.isCorrectRepositoryItemCheckEdit.AutoHeight = false;
            this.isCorrectRepositoryItemCheckEdit.Name = "isCorrectRepositoryItemCheckEdit";
            // 
            // questionTextEdit
            // 
            this.questionTextEdit.Location = new System.Drawing.Point(60, 12);
            this.questionTextEdit.Name = "questionTextEdit";
            this.questionTextEdit.Size = new System.Drawing.Size(580, 20);
            this.questionTextEdit.StyleController = this.layoutControl1;
            this.questionTextEdit.TabIndex = 4;
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
            this.questionLayoutControlItem.Text = "Question";
            this.questionLayoutControlItem.TextSize = new System.Drawing.Size(45, 13);
            // 
            // answersLayoutControlItem
            // 
            this.answersLayoutControlItem.Control = this.answersGridControl;
            this.answersLayoutControlItem.Location = new System.Drawing.Point(0, 24);
            this.answersLayoutControlItem.Name = "answersLayoutControlItem";
            this.answersLayoutControlItem.Size = new System.Drawing.Size(632, 369);
            this.answersLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 0);
            this.answersLayoutControlItem.Text = "Answers:";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(652, 449);
            this.Controls.Add(this.layoutControl1);
            this.Name = "AddEditQuestionForm";
            this.Text = "AddEditQuestionForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.answersGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
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