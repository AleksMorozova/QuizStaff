namespace Client.TesteesForm.TesteeAddEdit
{
    partial class AddEditTesteeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditTesteeForm));
            this.settingDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.questionAmountSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.gridTrainings = new DevExpress.XtraGrid.GridControl();
            this.gridViewTrainings = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.titleGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.trainingsRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEmail = new DevExpress.XtraEditors.TextEdit();
            this.textLogin = new DevExpress.XtraEditors.TextEdit();
            this.textLastName = new DevExpress.XtraEditors.TextEdit();
            this.textFirstName = new DevExpress.XtraEditors.TextEdit();
            this.addTrainingButton = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemTranings = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItemEmail = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemFirstName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemLogin = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemLastName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemQuestionAmount = new DevExpress.XtraLayout.LayoutControlItem();
            this.mvvmTesteeContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.frequencySpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.frequencyLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.settingDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionAmountSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTrainings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTrainings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemTranings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemQuestionAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmTesteeContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencySpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyLayoutControlItem)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.frequencySpinEdit);
            this.layoutControl1.Controls.Add(this.questionAmountSpinEdit);
            this.layoutControl1.Controls.Add(this.saveButton);
            this.layoutControl1.Controls.Add(this.gridTrainings);
            this.layoutControl1.Controls.Add(this.textEmail);
            this.layoutControl1.Controls.Add(this.textLogin);
            this.layoutControl1.Controls.Add(this.textLastName);
            this.layoutControl1.Controls.Add(this.textFirstName);
            this.layoutControl1.Controls.Add(this.addTrainingButton);
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(453, 119, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup3;
            // 
            // questionAmountSpinEdit
            // 
            resources.ApplyResources(this.questionAmountSpinEdit, "questionAmountSpinEdit");
            this.questionAmountSpinEdit.Name = "questionAmountSpinEdit";
            this.questionAmountSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("spinEdit1.Properties.Buttons1"))))});
            this.questionAmountSpinEdit.StyleController = this.layoutControl1;
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.StyleController = this.layoutControl1;
            // 
            // gridTrainings
            // 
            resources.ApplyResources(this.gridTrainings, "gridTrainings");
            this.gridTrainings.MainView = this.gridViewTrainings;
            this.gridTrainings.Name = "gridTrainings";
            this.gridTrainings.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.trainingsRepositoryItemLookUpEdit});
            this.gridTrainings.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTrainings});
            // 
            // gridViewTrainings
            // 
            this.gridViewTrainings.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.titleGridColumn});
            this.gridViewTrainings.GridControl = this.gridTrainings;
            this.gridViewTrainings.Name = "gridViewTrainings";
            this.gridViewTrainings.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace;
            this.gridViewTrainings.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gridViewTrainings.OptionsDetail.EnableMasterViewMode = false;
            this.gridViewTrainings.OptionsView.ShowGroupPanel = false;
            this.gridViewTrainings.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridViewTrainings_InitNewRow);
            // 
            // titleGridColumn
            // 
            resources.ApplyResources(this.titleGridColumn, "titleGridColumn");
            this.titleGridColumn.ColumnEdit = this.trainingsRepositoryItemLookUpEdit;
            this.titleGridColumn.FieldName = "Training.TrainingTitle";
            this.titleGridColumn.Name = "titleGridColumn";
            // 
            // trainingsRepositoryItemLookUpEdit
            // 
            resources.ApplyResources(this.trainingsRepositoryItemLookUpEdit, "trainingsRepositoryItemLookUpEdit");
            this.trainingsRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("trainingsRepositoryItemLookUpEdit.Buttons"))))});
            this.trainingsRepositoryItemLookUpEdit.DisplayMember = "TrainingTitle";
            this.trainingsRepositoryItemLookUpEdit.Name = "trainingsRepositoryItemLookUpEdit";
            this.trainingsRepositoryItemLookUpEdit.ValueMember = "TrainingTitle";
            this.trainingsRepositoryItemLookUpEdit.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            resources.ApplyResources(this.gridColumn1, "gridColumn1");
            this.gridColumn1.FieldName = "TrainingTitle";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // textEmail
            // 
            resources.ApplyResources(this.textEmail, "textEmail");
            this.textEmail.Name = "textEmail";
            this.textEmail.StyleController = this.layoutControl1;
            // 
            // textLogin
            // 
            resources.ApplyResources(this.textLogin, "textLogin");
            this.textLogin.Name = "textLogin";
            this.textLogin.StyleController = this.layoutControl1;
            // 
            // textLastName
            // 
            resources.ApplyResources(this.textLastName, "textLastName");
            this.textLastName.Name = "textLastName";
            this.textLastName.StyleController = this.layoutControl1;
            // 
            // textFirstName
            // 
            resources.ApplyResources(this.textFirstName, "textFirstName");
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.StyleController = this.layoutControl1;
            // 
            // addTrainingButton
            // 
            resources.ApplyResources(this.addTrainingButton, "addTrainingButton");
            this.addTrainingButton.Name = "addTrainingButton";
            this.addTrainingButton.StyleController = this.layoutControl1;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup3.GroupBordersVisible = false;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemTranings,
            this.layoutControlItem7,
            this.emptySpaceItem1,
            this.layoutControlItemEmail,
            this.layoutControlItemFirstName,
            this.layoutControlItemLogin,
            this.layoutControlItemLastName,
            this.layoutControlItem2,
            this.layoutControlItemQuestionAmount,
            this.frequencyLayoutControlItem});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "Root";
            this.layoutControlGroup3.Size = new System.Drawing.Size(584, 461);
            // 
            // layoutControlItemTranings
            // 
            this.layoutControlItemTranings.Control = this.gridTrainings;
            this.layoutControlItemTranings.Location = new System.Drawing.Point(0, 106);
            this.layoutControlItemTranings.Name = "layoutControlItemTranings";
            this.layoutControlItemTranings.Size = new System.Drawing.Size(564, 285);
            resources.ApplyResources(this.layoutControlItemTranings, "layoutControlItemTranings");
            this.layoutControlItemTranings.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItemTranings.TextSize = new System.Drawing.Size(82, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.addTrainingButton;
            this.layoutControlItem7.Location = new System.Drawing.Point(462, 80);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(102, 26);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 80);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(462, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItemEmail
            // 
            this.layoutControlItemEmail.Control = this.textEmail;
            this.layoutControlItemEmail.Location = new System.Drawing.Point(282, 40);
            this.layoutControlItemEmail.Name = "layoutControlItemEmail";
            this.layoutControlItemEmail.Size = new System.Drawing.Size(282, 40);
            resources.ApplyResources(this.layoutControlItemEmail, "layoutControlItemEmail");
            this.layoutControlItemEmail.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItemEmail.TextSize = new System.Drawing.Size(82, 13);
            // 
            // layoutControlItemFirstName
            // 
            this.layoutControlItemFirstName.Control = this.textFirstName;
            this.layoutControlItemFirstName.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemFirstName.Name = "layoutControlItemFirstName";
            this.layoutControlItemFirstName.Size = new System.Drawing.Size(282, 40);
            resources.ApplyResources(this.layoutControlItemFirstName, "layoutControlItemFirstName");
            this.layoutControlItemFirstName.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItemFirstName.TextSize = new System.Drawing.Size(82, 13);
            // 
            // layoutControlItemLogin
            // 
            this.layoutControlItemLogin.Control = this.textLogin;
            this.layoutControlItemLogin.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItemLogin.Name = "layoutControlItemLogin";
            this.layoutControlItemLogin.Size = new System.Drawing.Size(282, 40);
            resources.ApplyResources(this.layoutControlItemLogin, "layoutControlItemLogin");
            this.layoutControlItemLogin.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItemLogin.TextSize = new System.Drawing.Size(82, 13);
            // 
            // layoutControlItemLastName
            // 
            this.layoutControlItemLastName.Control = this.textLastName;
            this.layoutControlItemLastName.Location = new System.Drawing.Point(282, 0);
            this.layoutControlItemLastName.Name = "layoutControlItemLastName";
            this.layoutControlItemLastName.Size = new System.Drawing.Size(282, 40);
            resources.ApplyResources(this.layoutControlItemLastName, "layoutControlItemLastName");
            this.layoutControlItemLastName.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItemLastName.TextSize = new System.Drawing.Size(82, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.saveButton;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 415);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(564, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItemQuestionAmount
            // 
            this.layoutControlItemQuestionAmount.Control = this.questionAmountSpinEdit;
            this.layoutControlItemQuestionAmount.Location = new System.Drawing.Point(0, 391);
            this.layoutControlItemQuestionAmount.Name = "layoutControlItemQuestionAmount";
            this.layoutControlItemQuestionAmount.Size = new System.Drawing.Size(282, 24);
            resources.ApplyResources(this.layoutControlItemQuestionAmount, "layoutControlItemQuestionAmount");
            this.layoutControlItemQuestionAmount.TextSize = new System.Drawing.Size(82, 13);
            // 
            // mvvmTesteeContext
            // 
            this.mvvmTesteeContext.ContainerControl = this;
            // 
            // frequencySpinEdit
            // 
            resources.ApplyResources(this.frequencySpinEdit, "frequencySpinEdit");
            this.frequencySpinEdit.Name = "frequencySpinEdit";
            this.frequencySpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("spinEdit1.Properties.Buttons"))))});
            this.frequencySpinEdit.StyleController = this.layoutControl1;
            // 
            // frequencyLayoutControlItem
            // 
            this.frequencyLayoutControlItem.Control = this.frequencySpinEdit;
            this.frequencyLayoutControlItem.Location = new System.Drawing.Point(282, 391);
            this.frequencyLayoutControlItem.Name = "frequencyLayoutControlItem";
            this.frequencyLayoutControlItem.Size = new System.Drawing.Size(282, 24);
            resources.ApplyResources(this.frequencyLayoutControlItem, "frequencyLayoutControlItem");
            this.frequencyLayoutControlItem.TextSize = new System.Drawing.Size(82, 13);
            // 
            // AddEditTesteeForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "AddEditTesteeForm";
            ((System.ComponentModel.ISupportInitialize)(this.settingDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.questionAmountSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTrainings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTrainings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemTranings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemQuestionAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmTesteeContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencySpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyLayoutControlItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraGrid.GridControl gridTrainings;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTrainings;
        private DevExpress.XtraEditors.TextEdit textEmail;
        private DevExpress.XtraEditors.TextEdit textLogin;
        private DevExpress.XtraEditors.TextEdit textLastName;
        private DevExpress.XtraEditors.TextEdit textFirstName;
        private DevExpress.XtraEditors.SimpleButton addTrainingButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemTranings;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemEmail;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemFirstName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemLogin;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemLastName;
        private DevExpress.XtraGrid.Columns.GridColumn titleGridColumn;
        private DevExpress.Utils.MVVM.MVVMContext mvvmTesteeContext;
        private System.Windows.Forms.BindingSource settingDTOBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit trainingsRepositoryItemLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SpinEdit questionAmountSpinEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemQuestionAmount;
        private DevExpress.XtraEditors.SpinEdit frequencySpinEdit;
        private DevExpress.XtraLayout.LayoutControlItem frequencyLayoutControlItem;
    }
}