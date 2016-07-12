namespace AdminApplication.AdminSettings
{
    partial class AdminSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSettingsForm));
            this.dateImpactLabelLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.editSettingsSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.testeeListGridControl = new DevExpress.XtraGrid.GridControl();
            this.testeesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.firstNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lastNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.frequencyOfAskingGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.amountOfQuestionsPerDayGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.timeOfStartGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTimeEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.attribute1GridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.attribute2GridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.attribute3GridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.attribute4GridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.attribute5GridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.attribute6GridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.attribute7GridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.attribute8GridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.attribute9GridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.attribute10GridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.checkGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.showCorrectAnswerGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.showAnswerRepositoryItemCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.canEditGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.canEditRepositoryItemCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.usersListLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.saveButtonLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.editSettingsLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.mvvmAdminSettingsContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dateImpactLabelLayoutControl)).BeginInit();
            this.dateImpactLabelLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testeeListGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testeesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showAnswerRepositoryItemCheckEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canEditRepositoryItemCheckEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersListLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editSettingsLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmAdminSettingsContext)).BeginInit();
            this.SuspendLayout();
            // 
            // dateImpactLabelLayoutControl
            // 
            this.dateImpactLabelLayoutControl.Controls.Add(this.editSettingsSimpleButton);
            this.dateImpactLabelLayoutControl.Controls.Add(this.saveButton);
            this.dateImpactLabelLayoutControl.Controls.Add(this.testeeListGridControl);
            resources.ApplyResources(this.dateImpactLabelLayoutControl, "dateImpactLabelLayoutControl");
            this.dateImpactLabelLayoutControl.Name = "dateImpactLabelLayoutControl";
            this.dateImpactLabelLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(727, 211, 391, 473);
            this.dateImpactLabelLayoutControl.OptionsView.UseDefaultDragAndDropRendering = false;
            this.dateImpactLabelLayoutControl.Root = this.layoutControlGroup;
            // 
            // editSettingsSimpleButton
            // 
            resources.ApplyResources(this.editSettingsSimpleButton, "editSettingsSimpleButton");
            this.editSettingsSimpleButton.Name = "editSettingsSimpleButton";
            this.editSettingsSimpleButton.StyleController = this.dateImpactLabelLayoutControl;
            this.editSettingsSimpleButton.Click += new System.EventHandler(this.editSettingsSimpleButton_Click);
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.StyleController = this.dateImpactLabelLayoutControl;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // testeeListGridControl
            // 
            resources.ApplyResources(this.testeeListGridControl, "testeeListGridControl");
            this.testeeListGridControl.MainView = this.testeesGridView;
            this.testeeListGridControl.Name = "testeeListGridControl";
            this.testeeListGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTimeEdit1,
            this.repositoryItemCheckEdit1,
            this.showAnswerRepositoryItemCheckEdit,
            this.canEditRepositoryItemCheckEdit});
            this.testeeListGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.testeesGridView});
            // 
            // testeesGridView
            // 
            this.testeesGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.firstNameGridColumn,
            this.lastNameGridColumn,
            this.frequencyOfAskingGridColumn,
            this.amountOfQuestionsPerDayGridColumn,
            this.timeOfStartGridColumn,
            this.attribute1GridColumn,
            this.attribute2GridColumn,
            this.attribute3GridColumn,
            this.attribute4GridColumn,
            this.attribute5GridColumn,
            this.attribute6GridColumn,
            this.attribute7GridColumn,
            this.attribute8GridColumn,
            this.attribute9GridColumn,
            this.attribute10GridColumn,
            this.checkGridColumn,
            this.showCorrectAnswerGridColumn,
            this.canEditGridColumn});
            this.testeesGridView.GridControl = this.testeeListGridControl;
            this.testeesGridView.Name = "testeesGridView";
            this.testeesGridView.OptionsDetail.EnableMasterViewMode = false;
            this.testeesGridView.OptionsFind.AlwaysVisible = true;
            this.testeesGridView.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.testeesGridView.OptionsView.ShowAutoFilterRow = true;
            // 
            // firstNameGridColumn
            // 
            resources.ApplyResources(this.firstNameGridColumn, "firstNameGridColumn");
            this.firstNameGridColumn.FieldName = "FirstName";
            this.firstNameGridColumn.Name = "firstNameGridColumn";
            this.firstNameGridColumn.OptionsColumn.AllowEdit = false;
            // 
            // lastNameGridColumn
            // 
            resources.ApplyResources(this.lastNameGridColumn, "lastNameGridColumn");
            this.lastNameGridColumn.FieldName = "LastName";
            this.lastNameGridColumn.Name = "lastNameGridColumn";
            this.lastNameGridColumn.OptionsColumn.AllowEdit = false;
            // 
            // frequencyOfAskingGridColumn
            // 
            resources.ApplyResources(this.frequencyOfAskingGridColumn, "frequencyOfAskingGridColumn");
            this.frequencyOfAskingGridColumn.FieldName = "UserSetting.FrequencyOfAsking";
            this.frequencyOfAskingGridColumn.Name = "frequencyOfAskingGridColumn";
            this.frequencyOfAskingGridColumn.OptionsColumn.AllowEdit = false;
            // 
            // amountOfQuestionsPerDayGridColumn
            // 
            resources.ApplyResources(this.amountOfQuestionsPerDayGridColumn, "amountOfQuestionsPerDayGridColumn");
            this.amountOfQuestionsPerDayGridColumn.FieldName = "UserSetting.AmountOfQuestionsPerDay";
            this.amountOfQuestionsPerDayGridColumn.Name = "amountOfQuestionsPerDayGridColumn";
            this.amountOfQuestionsPerDayGridColumn.OptionsColumn.AllowEdit = false;
            // 
            // timeOfStartGridColumn
            // 
            resources.ApplyResources(this.timeOfStartGridColumn, "timeOfStartGridColumn");
            this.timeOfStartGridColumn.ColumnEdit = this.repositoryItemTimeEdit1;
            this.timeOfStartGridColumn.FieldName = "UserSetting.TimeOfStart";
            this.timeOfStartGridColumn.Name = "timeOfStartGridColumn";
            this.timeOfStartGridColumn.OptionsColumn.AllowEdit = false;
            // 
            // repositoryItemTimeEdit1
            // 
            resources.ApplyResources(this.repositoryItemTimeEdit1, "repositoryItemTimeEdit1");
            this.repositoryItemTimeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemTimeEdit1.Buttons"))))});
            this.repositoryItemTimeEdit1.Name = "repositoryItemTimeEdit1";
            // 
            // attribute1GridColumn
            // 
            resources.ApplyResources(this.attribute1GridColumn, "attribute1GridColumn");
            this.attribute1GridColumn.FieldName = "Attribute1";
            this.attribute1GridColumn.Name = "attribute1GridColumn";
            this.attribute1GridColumn.OptionsColumn.AllowEdit = false;
            // 
            // attribute2GridColumn
            // 
            resources.ApplyResources(this.attribute2GridColumn, "attribute2GridColumn");
            this.attribute2GridColumn.FieldName = "Attribute2";
            this.attribute2GridColumn.Name = "attribute2GridColumn";
            this.attribute2GridColumn.OptionsColumn.AllowEdit = false;
            // 
            // attribute3GridColumn
            // 
            resources.ApplyResources(this.attribute3GridColumn, "attribute3GridColumn");
            this.attribute3GridColumn.FieldName = "Attribute3";
            this.attribute3GridColumn.Name = "attribute3GridColumn";
            this.attribute3GridColumn.OptionsColumn.AllowEdit = false;
            // 
            // attribute4GridColumn
            // 
            resources.ApplyResources(this.attribute4GridColumn, "attribute4GridColumn");
            this.attribute4GridColumn.FieldName = "Attribute4";
            this.attribute4GridColumn.Name = "attribute4GridColumn";
            this.attribute4GridColumn.OptionsColumn.AllowEdit = false;
            // 
            // attribute5GridColumn
            // 
            resources.ApplyResources(this.attribute5GridColumn, "attribute5GridColumn");
            this.attribute5GridColumn.FieldName = "Attribute5";
            this.attribute5GridColumn.Name = "attribute5GridColumn";
            this.attribute5GridColumn.OptionsColumn.AllowEdit = false;
            // 
            // attribute6GridColumn
            // 
            resources.ApplyResources(this.attribute6GridColumn, "attribute6GridColumn");
            this.attribute6GridColumn.FieldName = "Attribute6";
            this.attribute6GridColumn.Name = "attribute6GridColumn";
            this.attribute6GridColumn.OptionsColumn.AllowEdit = false;
            // 
            // attribute7GridColumn
            // 
            resources.ApplyResources(this.attribute7GridColumn, "attribute7GridColumn");
            this.attribute7GridColumn.FieldName = "Attribute7";
            this.attribute7GridColumn.Name = "attribute7GridColumn";
            this.attribute7GridColumn.OptionsColumn.AllowEdit = false;
            // 
            // attribute8GridColumn
            // 
            resources.ApplyResources(this.attribute8GridColumn, "attribute8GridColumn");
            this.attribute8GridColumn.FieldName = "Attribute8";
            this.attribute8GridColumn.Name = "attribute8GridColumn";
            this.attribute8GridColumn.OptionsColumn.AllowEdit = false;
            // 
            // attribute9GridColumn
            // 
            resources.ApplyResources(this.attribute9GridColumn, "attribute9GridColumn");
            this.attribute9GridColumn.FieldName = "Attribute9";
            this.attribute9GridColumn.Name = "attribute9GridColumn";
            this.attribute9GridColumn.OptionsColumn.AllowEdit = false;
            // 
            // attribute10GridColumn
            // 
            resources.ApplyResources(this.attribute10GridColumn, "attribute10GridColumn");
            this.attribute10GridColumn.FieldName = "Attribute10";
            this.attribute10GridColumn.Name = "attribute10GridColumn";
            this.attribute10GridColumn.OptionsColumn.AllowEdit = false;
            // 
            // checkGridColumn
            // 
            resources.ApplyResources(this.checkGridColumn, "checkGridColumn");
            this.checkGridColumn.ColumnEdit = this.repositoryItemCheckEdit1;
            this.checkGridColumn.FieldName = "IsSelected";
            this.checkGridColumn.Name = "checkGridColumn";
            // 
            // repositoryItemCheckEdit1
            // 
            resources.ApplyResources(this.repositoryItemCheckEdit1, "repositoryItemCheckEdit1");
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // showCorrectAnswerGridColumn
            // 
            resources.ApplyResources(this.showCorrectAnswerGridColumn, "showCorrectAnswerGridColumn");
            this.showCorrectAnswerGridColumn.ColumnEdit = this.showAnswerRepositoryItemCheckEdit;
            this.showCorrectAnswerGridColumn.FieldName = "UserSetting.ShowCorrectAnswer";
            this.showCorrectAnswerGridColumn.Name = "showCorrectAnswerGridColumn";
            this.showCorrectAnswerGridColumn.OptionsColumn.AllowEdit = false;
            // 
            // showAnswerRepositoryItemCheckEdit
            // 
            resources.ApplyResources(this.showAnswerRepositoryItemCheckEdit, "showAnswerRepositoryItemCheckEdit");
            this.showAnswerRepositoryItemCheckEdit.Name = "showAnswerRepositoryItemCheckEdit";
            // 
            // canEditGridColumn
            // 
            resources.ApplyResources(this.canEditGridColumn, "canEditGridColumn");
            this.canEditGridColumn.ColumnEdit = this.canEditRepositoryItemCheckEdit;
            this.canEditGridColumn.FieldName = "UserSetting.CanUserEdit";
            this.canEditGridColumn.Name = "canEditGridColumn";
            // 
            // canEditRepositoryItemCheckEdit
            // 
            resources.ApplyResources(this.canEditRepositoryItemCheckEdit, "canEditRepositoryItemCheckEdit");
            this.canEditRepositoryItemCheckEdit.Name = "canEditRepositoryItemCheckEdit";
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.usersListLayoutControlItem,
            this.saveButtonLayoutControlItem,
            this.emptySpaceItem1,
            this.editSettingsLayoutControlItem});
            this.layoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup.Name = "Root";
            this.layoutControlGroup.Size = new System.Drawing.Size(639, 402);
            this.layoutControlGroup.TextVisible = false;
            // 
            // usersListLayoutControlItem
            // 
            this.usersListLayoutControlItem.Control = this.testeeListGridControl;
            this.usersListLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.usersListLayoutControlItem.Name = "usersListLayoutControlItem";
            this.usersListLayoutControlItem.Size = new System.Drawing.Size(619, 346);
            this.usersListLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 10, 0, 0);
            resources.ApplyResources(this.usersListLayoutControlItem, "usersListLayoutControlItem");
            this.usersListLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.usersListLayoutControlItem.TextSize = new System.Drawing.Size(47, 13);
            // 
            // saveButtonLayoutControlItem
            // 
            this.saveButtonLayoutControlItem.Control = this.saveButton;
            this.saveButtonLayoutControlItem.Location = new System.Drawing.Point(488, 346);
            this.saveButtonLayoutControlItem.Name = "saveButtonLayoutControlItem";
            this.saveButtonLayoutControlItem.Size = new System.Drawing.Size(131, 36);
            this.saveButtonLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 5, 10, 0);
            this.saveButtonLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.saveButtonLayoutControlItem.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 346);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(342, 36);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // editSettingsLayoutControlItem
            // 
            this.editSettingsLayoutControlItem.Control = this.editSettingsSimpleButton;
            this.editSettingsLayoutControlItem.Location = new System.Drawing.Point(342, 346);
            this.editSettingsLayoutControlItem.Name = "editSettingsLayoutControlItem";
            this.editSettingsLayoutControlItem.Size = new System.Drawing.Size(146, 36);
            this.editSettingsLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 5, 10, 0);
            this.editSettingsLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.editSettingsLayoutControlItem.TextVisible = false;
            // 
            // mvvmAdminSettingsContext
            // 
            this.mvvmAdminSettingsContext.ContainerControl = this;
            // 
            // AdminSettingsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateImpactLabelLayoutControl);
            this.Name = "AdminSettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dateImpactLabelLayoutControl)).EndInit();
            this.dateImpactLabelLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testeeListGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testeesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showAnswerRepositoryItemCheckEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canEditRepositoryItemCheckEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersListLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editSettingsLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmAdminSettingsContext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl dateImpactLabelLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private DevExpress.XtraGrid.GridControl testeeListGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView testeesGridView;
        private DevExpress.XtraLayout.LayoutControlItem usersListLayoutControlItem;
        private DevExpress.Utils.MVVM.MVVMContext mvvmAdminSettingsContext;
        private DevExpress.XtraGrid.Columns.GridColumn firstNameGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn lastNameGridColumn;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraLayout.LayoutControlItem saveButtonLayoutControlItem;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn frequencyOfAskingGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn amountOfQuestionsPerDayGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn timeOfStartGridColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn attribute1GridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn attribute2GridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn attribute3GridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn attribute4GridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn attribute5GridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn attribute6GridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn attribute7GridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn attribute8GridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn attribute9GridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn attribute10GridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn checkGridColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn showCorrectAnswerGridColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit showAnswerRepositoryItemCheckEdit;
        private DevExpress.XtraGrid.Columns.GridColumn canEditGridColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit canEditRepositoryItemCheckEdit;
        private DevExpress.XtraEditors.SimpleButton editSettingsSimpleButton;
        private DevExpress.XtraLayout.LayoutControlItem editSettingsLayoutControlItem;
    }
}