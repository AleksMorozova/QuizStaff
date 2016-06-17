namespace Client.AdminSettings
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
            this.dateImpactLabelLayoutControl = new DevExpress.XtraLayout.LayoutControl();
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
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.usersListLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.saveButtonLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.mvvmAdminSettingsContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dateImpactLabelLayoutControl)).BeginInit();
            this.dateImpactLabelLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testeeListGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testeesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersListLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmAdminSettingsContext)).BeginInit();
            this.SuspendLayout();
            // 
            // dateImpactLabelLayoutControl
            // 
            this.dateImpactLabelLayoutControl.Controls.Add(this.saveButton);
            this.dateImpactLabelLayoutControl.Controls.Add(this.testeeListGridControl);
            this.dateImpactLabelLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateImpactLabelLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.dateImpactLabelLayoutControl.Name = "dateImpactLabelLayoutControl";
            this.dateImpactLabelLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(780, 211, 391, 473);
            this.dateImpactLabelLayoutControl.OptionsView.UseDefaultDragAndDropRendering = false;
            this.dateImpactLabelLayoutControl.Root = this.layoutControlGroup;
            this.dateImpactLabelLayoutControl.Size = new System.Drawing.Size(639, 402);
            this.dateImpactLabelLayoutControl.TabIndex = 0;
            this.dateImpactLabelLayoutControl.Text = "layoutControl1";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(421, 368);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(201, 22);
            this.saveButton.StyleController = this.dateImpactLabelLayoutControl;
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Change settings";
            // 
            // testeeListGridControl
            // 
            this.testeeListGridControl.Location = new System.Drawing.Point(12, 28);
            this.testeeListGridControl.MainView = this.testeesGridView;
            this.testeeListGridControl.Name = "testeeListGridControl";
            this.testeeListGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTimeEdit1,
            this.repositoryItemCheckEdit1});
            this.testeeListGridControl.Size = new System.Drawing.Size(605, 326);
            this.testeeListGridControl.TabIndex = 4;
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
            this.checkGridColumn});
            this.testeesGridView.GridControl = this.testeeListGridControl;
            this.testeesGridView.Name = "testeesGridView";
            this.testeesGridView.OptionsFind.AlwaysVisible = true;
            this.testeesGridView.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.testeesGridView.OptionsView.ShowAutoFilterRow = true;
            // 
            // firstNameGridColumn
            // 
            this.firstNameGridColumn.Caption = "First name";
            this.firstNameGridColumn.FieldName = "FirstName";
            this.firstNameGridColumn.Name = "firstNameGridColumn";
            this.firstNameGridColumn.Visible = true;
            this.firstNameGridColumn.VisibleIndex = 1;
            this.firstNameGridColumn.Width = 140;
            // 
            // lastNameGridColumn
            // 
            this.lastNameGridColumn.Caption = "Last name";
            this.lastNameGridColumn.FieldName = "LastName";
            this.lastNameGridColumn.Name = "lastNameGridColumn";
            this.lastNameGridColumn.Visible = true;
            this.lastNameGridColumn.VisibleIndex = 2;
            this.lastNameGridColumn.Width = 140;
            // 
            // frequencyOfAskingGridColumn
            // 
            this.frequencyOfAskingGridColumn.Caption = "Frequency of asking";
            this.frequencyOfAskingGridColumn.FieldName = "UserSetting.FrequencyOfAsking";
            this.frequencyOfAskingGridColumn.Name = "frequencyOfAskingGridColumn";
            this.frequencyOfAskingGridColumn.Visible = true;
            this.frequencyOfAskingGridColumn.VisibleIndex = 3;
            this.frequencyOfAskingGridColumn.Width = 140;
            // 
            // amountOfQuestionsPerDayGridColumn
            // 
            this.amountOfQuestionsPerDayGridColumn.Caption = "Amount of questions";
            this.amountOfQuestionsPerDayGridColumn.FieldName = "UserSetting.AmountOfQuestionsPerDay";
            this.amountOfQuestionsPerDayGridColumn.Name = "amountOfQuestionsPerDayGridColumn";
            this.amountOfQuestionsPerDayGridColumn.Visible = true;
            this.amountOfQuestionsPerDayGridColumn.VisibleIndex = 4;
            this.amountOfQuestionsPerDayGridColumn.Width = 140;
            // 
            // timeOfStartGridColumn
            // 
            this.timeOfStartGridColumn.Caption = "Time of start";
            this.timeOfStartGridColumn.ColumnEdit = this.repositoryItemTimeEdit1;
            this.timeOfStartGridColumn.FieldName = "UserSetting.TimeOfStart";
            this.timeOfStartGridColumn.Name = "timeOfStartGridColumn";
            this.timeOfStartGridColumn.Visible = true;
            this.timeOfStartGridColumn.VisibleIndex = 5;
            this.timeOfStartGridColumn.Width = 145;
            // 
            // repositoryItemTimeEdit1
            // 
            this.repositoryItemTimeEdit1.AutoHeight = false;
            this.repositoryItemTimeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTimeEdit1.Name = "repositoryItemTimeEdit1";
            // 
            // attribute1GridColumn
            // 
            this.attribute1GridColumn.Caption = "Attribute1";
            this.attribute1GridColumn.FieldName = "Attribute1";
            this.attribute1GridColumn.Name = "attribute1GridColumn";
            // 
            // attribute2GridColumn
            // 
            this.attribute2GridColumn.Caption = "Attribute2";
            this.attribute2GridColumn.FieldName = "Attribute2";
            this.attribute2GridColumn.Name = "attribute2GridColumn";
            // 
            // attribute3GridColumn
            // 
            this.attribute3GridColumn.Caption = "Attribute3";
            this.attribute3GridColumn.FieldName = "Attribute3";
            this.attribute3GridColumn.Name = "attribute3GridColumn";
            // 
            // attribute4GridColumn
            // 
            this.attribute4GridColumn.Caption = "Attribute4";
            this.attribute4GridColumn.FieldName = "Attribute4";
            this.attribute4GridColumn.Name = "attribute4GridColumn";
            // 
            // attribute5GridColumn
            // 
            this.attribute5GridColumn.Caption = "Attribute5";
            this.attribute5GridColumn.FieldName = "Attribute5";
            this.attribute5GridColumn.Name = "attribute5GridColumn";
            // 
            // attribute6GridColumn
            // 
            this.attribute6GridColumn.Caption = "Attribute6";
            this.attribute6GridColumn.FieldName = "Attribute6";
            this.attribute6GridColumn.Name = "attribute6GridColumn";
            // 
            // attribute7GridColumn
            // 
            this.attribute7GridColumn.Caption = "Attribute7";
            this.attribute7GridColumn.FieldName = "Attribute7";
            this.attribute7GridColumn.Name = "attribute7GridColumn";
            // 
            // attribute8GridColumn
            // 
            this.attribute8GridColumn.Caption = "Attribute8";
            this.attribute8GridColumn.FieldName = "Attribute8";
            this.attribute8GridColumn.Name = "attribute8GridColumn";
            // 
            // attribute9GridColumn
            // 
            this.attribute9GridColumn.Caption = "Attribute9";
            this.attribute9GridColumn.FieldName = "Attribute9";
            this.attribute9GridColumn.Name = "attribute9GridColumn";
            // 
            // attribute10GridColumn
            // 
            this.attribute10GridColumn.Caption = "Attribute10";
            this.attribute10GridColumn.FieldName = "Attribute10";
            this.attribute10GridColumn.Name = "attribute10GridColumn";
            // 
            // checkGridColumn
            // 
            this.checkGridColumn.Caption = "Check";
            this.checkGridColumn.ColumnEdit = this.repositoryItemCheckEdit1;
            this.checkGridColumn.FieldName = "IsSelected";
            this.checkGridColumn.Name = "checkGridColumn";
            this.checkGridColumn.Visible = true;
            this.checkGridColumn.VisibleIndex = 0;
            this.checkGridColumn.Width = 54;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.usersListLayoutControlItem,
            this.saveButtonLayoutControlItem,
            this.emptySpaceItem1});
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
            this.usersListLayoutControlItem.Text = "Users list:";
            this.usersListLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.usersListLayoutControlItem.TextSize = new System.Drawing.Size(47, 13);
            // 
            // saveButtonLayoutControlItem
            // 
            this.saveButtonLayoutControlItem.Control = this.saveButton;
            this.saveButtonLayoutControlItem.Location = new System.Drawing.Point(409, 346);
            this.saveButtonLayoutControlItem.Name = "saveButtonLayoutControlItem";
            this.saveButtonLayoutControlItem.Size = new System.Drawing.Size(210, 36);
            this.saveButtonLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 5, 10, 0);
            this.saveButtonLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.saveButtonLayoutControlItem.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 346);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(409, 36);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // mvvmAdminSettingsContext
            // 
            this.mvvmAdminSettingsContext.ContainerControl = this;
            // 
            // AdminSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 402);
            this.Controls.Add(this.dateImpactLabelLayoutControl);
            this.Name = "AdminSettingsForm";
            this.Text = "AdminSettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dateImpactLabelLayoutControl)).EndInit();
            this.dateImpactLabelLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testeeListGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testeesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersListLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
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
    }
}