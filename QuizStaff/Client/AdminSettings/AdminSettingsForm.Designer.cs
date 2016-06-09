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
            this.dateImpactLabelLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.toDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.fromDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.timeOfAskingEditTime = new DevExpress.XtraEditors.TimeEdit();
            this.frequencySpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.questionAmountTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.testeeListGridControl = new DevExpress.XtraGrid.GridControl();
            this.testeesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.loginGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.firstNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lastNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.frequencyLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.questionAmountLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.saveButtonLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.cancelButtonLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.timeOfAskingLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.usersListLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.fromDateEditLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.toDateEditLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.dateImpactLabel = new DevExpress.XtraLayout.SimpleLabelItem();
            this.mvvmAdminSettingsContext = new DevExpress.Utils.MVVM.MVVMContext();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            ((System.ComponentModel.ISupportInitialize)(this.dateImpactLabelLayoutControl)).BeginInit();
            this.dateImpactLabelLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeOfAskingEditTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencySpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionAmountTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testeeListGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testeesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionAmountLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButtonLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeOfAskingLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersListLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateEditLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDateEditLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateImpactLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmAdminSettingsContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateImpactLabelLayoutControl
            // 
            this.dateImpactLabelLayoutControl.Controls.Add(this.toDateEdit);
            this.dateImpactLabelLayoutControl.Controls.Add(this.fromDateEdit);
            this.dateImpactLabelLayoutControl.Controls.Add(this.cancelButton);
            this.dateImpactLabelLayoutControl.Controls.Add(this.saveButton);
            this.dateImpactLabelLayoutControl.Controls.Add(this.timeOfAskingEditTime);
            this.dateImpactLabelLayoutControl.Controls.Add(this.frequencySpinEdit);
            this.dateImpactLabelLayoutControl.Controls.Add(this.questionAmountTextEdit);
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
            // toDateEdit
            // 
            this.toDateEdit.EditValue = null;
            this.toDateEdit.Location = new System.Drawing.Point(537, 137);
            this.toDateEdit.Name = "toDateEdit";
            this.toDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.toDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.toDateEdit.Size = new System.Drawing.Size(90, 20);
            this.toDateEdit.StyleController = this.dateImpactLabelLayoutControl;
            this.toDateEdit.TabIndex = 17;
            // 
            // fromDateEdit
            // 
            this.fromDateEdit.EditValue = null;
            this.fromDateEdit.Location = new System.Drawing.Point(434, 137);
            this.fromDateEdit.Name = "fromDateEdit";
            this.fromDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fromDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fromDateEdit.Size = new System.Drawing.Size(99, 20);
            this.fromDateEdit.StyleController = this.dateImpactLabelLayoutControl;
            this.fromDateEdit.TabIndex = 16;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(542, 171);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(85, 22);
            this.cancelButton.StyleController = this.dateImpactLabelLayoutControl;
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Cancel";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(434, 171);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(94, 22);
            this.saveButton.StyleController = this.dateImpactLabelLayoutControl;
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // timeOfAskingEditTime
            // 
            this.timeOfAskingEditTime.EditValue = new System.DateTime(2016, 4, 28, 0, 0, 0, 0);
            this.timeOfAskingEditTime.Location = new System.Drawing.Point(519, 75);
            this.timeOfAskingEditTime.Name = "timeOfAskingEditTime";
            this.timeOfAskingEditTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeOfAskingEditTime.Properties.Mask.BeepOnError = true;
            this.timeOfAskingEditTime.Properties.Mask.EditMask = "t";
            this.timeOfAskingEditTime.Size = new System.Drawing.Size(108, 20);
            this.timeOfAskingEditTime.StyleController = this.dateImpactLabelLayoutControl;
            this.timeOfAskingEditTime.TabIndex = 13;
            // 
            // frequencySpinEdit
            // 
            this.frequencySpinEdit.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.frequencySpinEdit.Location = new System.Drawing.Point(519, 17);
            this.frequencySpinEdit.Name = "frequencySpinEdit";
            this.frequencySpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.frequencySpinEdit.Properties.IsFloatValue = false;
            this.frequencySpinEdit.Properties.Mask.EditMask = "N00";
            this.frequencySpinEdit.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.frequencySpinEdit.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.frequencySpinEdit.Size = new System.Drawing.Size(108, 20);
            this.frequencySpinEdit.StyleController = this.dateImpactLabelLayoutControl;
            this.frequencySpinEdit.TabIndex = 12;
            // 
            // questionAmountTextEdit
            // 
            this.questionAmountTextEdit.Location = new System.Drawing.Point(519, 46);
            this.questionAmountTextEdit.Name = "questionAmountTextEdit";
            this.questionAmountTextEdit.Size = new System.Drawing.Size(108, 20);
            this.questionAmountTextEdit.StyleController = this.dateImpactLabelLayoutControl;
            this.questionAmountTextEdit.TabIndex = 5;
            // 
            // testeeListGridControl
            // 
            this.testeeListGridControl.Location = new System.Drawing.Point(12, 28);
            this.testeeListGridControl.MainView = this.testeesGridView;
            this.testeeListGridControl.Name = "testeeListGridControl";
            this.testeeListGridControl.Size = new System.Drawing.Size(403, 362);
            this.testeeListGridControl.TabIndex = 4;
            this.testeeListGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.testeesGridView});
            // 
            // testeesGridView
            // 
            this.testeesGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.loginGridColumn,
            this.firstNameGridColumn,
            this.lastNameGridColumn});
            this.testeesGridView.GridControl = this.testeeListGridControl;
            this.testeesGridView.Name = "testeesGridView";
            this.testeesGridView.OptionsFind.AlwaysVisible = true;
            this.testeesGridView.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.testeesGridView.OptionsView.ShowAutoFilterRow = true;
            // 
            // loginGridColumn
            // 
            this.loginGridColumn.Caption = "Login";
            this.loginGridColumn.FieldName = "Login";
            this.loginGridColumn.Name = "loginGridColumn";
            this.loginGridColumn.Visible = true;
            this.loginGridColumn.VisibleIndex = 0;
            // 
            // firstNameGridColumn
            // 
            this.firstNameGridColumn.Caption = "First name";
            this.firstNameGridColumn.FieldName = "FirstName";
            this.firstNameGridColumn.Name = "firstNameGridColumn";
            this.firstNameGridColumn.Visible = true;
            this.firstNameGridColumn.VisibleIndex = 1;
            // 
            // lastNameGridColumn
            // 
            this.lastNameGridColumn.Caption = "Last name";
            this.lastNameGridColumn.FieldName = "LastName";
            this.lastNameGridColumn.Name = "lastNameGridColumn";
            this.lastNameGridColumn.Visible = true;
            this.lastNameGridColumn.VisibleIndex = 2;
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.frequencyLayoutControlItem,
            this.saveButtonLayoutControlItem,
            this.cancelButtonLayoutControlItem,
            this.timeOfAskingLayoutControlItem,
            this.fromDateEditLayoutControlItem,
            this.toDateEditLayoutControlItem,
            this.dateImpactLabel,
            this.splitterItem1,
            this.usersListLayoutControlItem,
            this.questionAmountLayoutControlItem});
            this.layoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup.Name = "Root";
            this.layoutControlGroup.Size = new System.Drawing.Size(639, 402);
            this.layoutControlGroup.TextVisible = false;
            // 
            // frequencyLayoutControlItem
            // 
            this.frequencyLayoutControlItem.Control = this.frequencySpinEdit;
            this.frequencyLayoutControlItem.Location = new System.Drawing.Point(422, 0);
            this.frequencyLayoutControlItem.Name = "frequencyLayoutControlItem";
            this.frequencyLayoutControlItem.Size = new System.Drawing.Size(197, 34);
            this.frequencyLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 5);
            this.frequencyLayoutControlItem.Text = "Frequency";
            this.frequencyLayoutControlItem.TextSize = new System.Drawing.Size(82, 13);
            // 
            // questionAmountLayoutControlItem
            // 
            this.questionAmountLayoutControlItem.Control = this.questionAmountTextEdit;
            this.questionAmountLayoutControlItem.Location = new System.Drawing.Point(422, 34);
            this.questionAmountLayoutControlItem.Name = "questionAmountLayoutControlItem";
            this.questionAmountLayoutControlItem.Size = new System.Drawing.Size(197, 29);
            this.questionAmountLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 5);
            this.questionAmountLayoutControlItem.Text = "Question amount";
            this.questionAmountLayoutControlItem.TextSize = new System.Drawing.Size(82, 13);
            // 
            // saveButtonLayoutControlItem
            // 
            this.saveButtonLayoutControlItem.Control = this.saveButton;
            this.saveButtonLayoutControlItem.Location = new System.Drawing.Point(422, 149);
            this.saveButtonLayoutControlItem.Name = "saveButtonLayoutControlItem";
            this.saveButtonLayoutControlItem.Size = new System.Drawing.Size(103, 233);
            this.saveButtonLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 5, 10, 0);
            this.saveButtonLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.saveButtonLayoutControlItem.TextVisible = false;
            // 
            // cancelButtonLayoutControlItem
            // 
            this.cancelButtonLayoutControlItem.Control = this.cancelButton;
            this.cancelButtonLayoutControlItem.Location = new System.Drawing.Point(525, 149);
            this.cancelButtonLayoutControlItem.Name = "cancelButtonLayoutControlItem";
            this.cancelButtonLayoutControlItem.Size = new System.Drawing.Size(94, 233);
            this.cancelButtonLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 0, 10, 0);
            this.cancelButtonLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.cancelButtonLayoutControlItem.TextVisible = false;
            // 
            // timeOfAskingLayoutControlItem
            // 
            this.timeOfAskingLayoutControlItem.Control = this.timeOfAskingEditTime;
            this.timeOfAskingLayoutControlItem.Location = new System.Drawing.Point(422, 63);
            this.timeOfAskingLayoutControlItem.Name = "timeOfAskingLayoutControlItem";
            this.timeOfAskingLayoutControlItem.Size = new System.Drawing.Size(197, 24);
            this.timeOfAskingLayoutControlItem.Text = "Time of asking";
            this.timeOfAskingLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Left;
            this.timeOfAskingLayoutControlItem.TextSize = new System.Drawing.Size(82, 13);
            // 
            // usersListLayoutControlItem
            // 
            this.usersListLayoutControlItem.Control = this.testeeListGridControl;
            this.usersListLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.usersListLayoutControlItem.Name = "usersListLayoutControlItem";
            this.usersListLayoutControlItem.Size = new System.Drawing.Size(417, 382);
            this.usersListLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 10, 0, 0);
            this.usersListLayoutControlItem.Text = "Users list:";
            this.usersListLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.usersListLayoutControlItem.TextSize = new System.Drawing.Size(82, 13);
            // 
            // fromDateEditLayoutControlItem
            // 
            this.fromDateEditLayoutControlItem.Control = this.fromDateEdit;
            this.fromDateEditLayoutControlItem.Location = new System.Drawing.Point(422, 109);
            this.fromDateEditLayoutControlItem.Name = "fromDateEditLayoutControlItem";
            this.fromDateEditLayoutControlItem.Size = new System.Drawing.Size(103, 40);
            this.fromDateEditLayoutControlItem.StartNewLine = true;
            this.fromDateEditLayoutControlItem.Text = "from";
            this.fromDateEditLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.fromDateEditLayoutControlItem.TextSize = new System.Drawing.Size(82, 13);
            // 
            // toDateEditLayoutControlItem
            // 
            this.toDateEditLayoutControlItem.Control = this.toDateEdit;
            this.toDateEditLayoutControlItem.Location = new System.Drawing.Point(525, 109);
            this.toDateEditLayoutControlItem.Name = "toDateEditLayoutControlItem";
            this.toDateEditLayoutControlItem.Size = new System.Drawing.Size(94, 40);
            this.toDateEditLayoutControlItem.Text = "to";
            this.toDateEditLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.toDateEditLayoutControlItem.TextSize = new System.Drawing.Size(82, 13);
            // 
            // dateImpactLabel
            // 
            this.dateImpactLabel.AllowHotTrack = false;
            this.dateImpactLabel.Location = new System.Drawing.Point(422, 87);
            this.dateImpactLabel.Name = "dateImpactLabel";
            this.dateImpactLabel.Size = new System.Drawing.Size(197, 22);
            this.dateImpactLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 0);
            this.dateImpactLabel.Text = "Dates of impact:";
            this.dateImpactLabel.TextSize = new System.Drawing.Size(82, 13);
            // 
            // mvvmAdminSettingsContext
            // 
            this.mvvmAdminSettingsContext.ContainerControl = this;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.Location = new System.Drawing.Point(417, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(5, 382);
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
            ((System.ComponentModel.ISupportInitialize)(this.toDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeOfAskingEditTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencySpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionAmountTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testeeListGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testeesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionAmountLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButtonLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeOfAskingLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersListLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateEditLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDateEditLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateImpactLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmAdminSettingsContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl dateImpactLabelLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private DevExpress.XtraGrid.GridControl testeeListGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView testeesGridView;
        private DevExpress.XtraLayout.LayoutControlItem usersListLayoutControlItem;
        private DevExpress.XtraEditors.TextEdit questionAmountTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem questionAmountLayoutControlItem;
        private DevExpress.XtraEditors.SpinEdit frequencySpinEdit;
        private DevExpress.XtraLayout.LayoutControlItem frequencyLayoutControlItem;
        private DevExpress.XtraEditors.TimeEdit timeOfAskingEditTime;
        private DevExpress.XtraLayout.LayoutControlItem timeOfAskingLayoutControlItem;
        private DevExpress.Utils.MVVM.MVVMContext mvvmAdminSettingsContext;
        private DevExpress.XtraGrid.Columns.GridColumn loginGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn firstNameGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn lastNameGridColumn;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraLayout.LayoutControlItem saveButtonLayoutControlItem;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraLayout.LayoutControlItem cancelButtonLayoutControlItem;
        private DevExpress.XtraEditors.DateEdit toDateEdit;
        private DevExpress.XtraEditors.DateEdit fromDateEdit;
        private DevExpress.XtraLayout.LayoutControlItem fromDateEditLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem toDateEditLayoutControlItem;
        private DevExpress.XtraLayout.SimpleLabelItem dateImpactLabel;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
    }
}