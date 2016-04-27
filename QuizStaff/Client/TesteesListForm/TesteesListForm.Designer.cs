namespace Client
{
    partial class TesteesListForm
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
            this.buttonAddTestee = new DevExpress.XtraEditors.SimpleButton();
            this.buttonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.buttonSave = new DevExpress.XtraEditors.SimpleButton();
            this.gridTestees = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.columnFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnLogin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnTrainings = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPopupContainerEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.repositoryItemPopupContainerEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.buttonLoadTestees = new DevExpress.XtraEditors.SimpleButton();
            this.buttonEditTestee = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridTestees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddTestee
            // 
            this.buttonAddTestee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddTestee.Location = new System.Drawing.Point(703, 12);
            this.buttonAddTestee.Name = "buttonAddTestee";
            this.buttonAddTestee.Size = new System.Drawing.Size(118, 22);
            this.buttonAddTestee.TabIndex = 1;
            this.buttonAddTestee.Text = "Add testee";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(703, 524);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(180, 22);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(889, 524);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(180, 22);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            // 
            // gridTestees
            // 
            this.gridTestees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridTestees.Location = new System.Drawing.Point(12, 40);
            this.gridTestees.MainView = this.gridView1;
            this.gridTestees.Name = "gridTestees";
            this.gridTestees.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPopupContainerEdit1,
            this.repositoryItemLookUpEdit1,
            this.repositoryItemGridLookUpEdit1,
            this.repositoryItemComboBox1,
            this.repositoryItemPopupContainerEdit2});
            this.gridTestees.Size = new System.Drawing.Size(1057, 478);
            this.gridTestees.TabIndex = 4;
            this.gridTestees.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView3});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.columnFirstName,
            this.columnLastName,
            this.columnLogin,
            this.columnEmail,
            this.columnTrainings});
            this.gridView1.GridControl = this.gridTestees;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            // 
            // columnFirstName
            // 
            this.columnFirstName.Caption = "First name";
            this.columnFirstName.FieldName = "FirstName";
            this.columnFirstName.Name = "columnFirstName";
            this.columnFirstName.Visible = true;
            this.columnFirstName.VisibleIndex = 0;
            // 
            // columnLastName
            // 
            this.columnLastName.Caption = "Last name";
            this.columnLastName.FieldName = "LastName";
            this.columnLastName.Name = "columnLastName";
            this.columnLastName.Visible = true;
            this.columnLastName.VisibleIndex = 1;
            // 
            // columnLogin
            // 
            this.columnLogin.Caption = "Login";
            this.columnLogin.FieldName = "Login";
            this.columnLogin.Name = "columnLogin";
            this.columnLogin.Visible = true;
            this.columnLogin.VisibleIndex = 2;
            // 
            // columnEmail
            // 
            this.columnEmail.Caption = "Email";
            this.columnEmail.FieldName = "Email";
            this.columnEmail.Name = "columnEmail";
            this.columnEmail.Visible = true;
            this.columnEmail.VisibleIndex = 3;
            // 
            // columnTrainings
            // 
            this.columnTrainings.Caption = "Trainings";
            this.columnTrainings.ColumnEdit = this.repositoryItemPopupContainerEdit2;
            this.columnTrainings.FieldName = "Trainings";
            this.columnTrainings.Name = "columnTrainings";
            this.columnTrainings.Visible = true;
            this.columnTrainings.VisibleIndex = 4;
            // 
            // repositoryItemPopupContainerEdit2
            // 
            this.repositoryItemPopupContainerEdit2.AutoHeight = false;
            this.repositoryItemPopupContainerEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemPopupContainerEdit2.Name = "repositoryItemPopupContainerEdit2";
            // 
            // repositoryItemPopupContainerEdit1
            // 
            this.repositoryItemPopupContainerEdit1.AutoHeight = false;
            this.repositoryItemPopupContainerEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemPopupContainerEdit1.Name = "repositoryItemPopupContainerEdit1";
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.View = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gridTestees;
            this.gridView3.Name = "gridView3";
            // 
            // buttonLoadTestees
            // 
            this.buttonLoadTestees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadTestees.Location = new System.Drawing.Point(951, 12);
            this.buttonLoadTestees.Name = "buttonLoadTestees";
            this.buttonLoadTestees.Size = new System.Drawing.Size(118, 22);
            this.buttonLoadTestees.TabIndex = 3;
            this.buttonLoadTestees.Text = "Load testees";
            // 
            // buttonEditTestee
            // 
            this.buttonEditTestee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditTestee.Location = new System.Drawing.Point(827, 12);
            this.buttonEditTestee.Name = "buttonEditTestee";
            this.buttonEditTestee.Size = new System.Drawing.Size(118, 22);
            this.buttonEditTestee.TabIndex = 2;
            this.buttonEditTestee.Text = "Edit testee";
            // 
            // TesteesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 558);
            this.Controls.Add(this.buttonAddTestee);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.gridTestees);
            this.Controls.Add(this.buttonLoadTestees);
            this.Controls.Add(this.buttonEditTestee);
            this.MinimumSize = new System.Drawing.Size(406, 200);
            this.Name = "TesteesListForm";
            this.Text = "Testees";
            ((System.ComponentModel.ISupportInitialize)(this.gridTestees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton buttonAddTestee;
        private DevExpress.XtraEditors.SimpleButton buttonCancel;
        private DevExpress.XtraEditors.SimpleButton buttonSave;
        private DevExpress.XtraGrid.GridControl gridTestees;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn columnFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn columnLastName;
        private DevExpress.XtraGrid.Columns.GridColumn columnLogin;
        private DevExpress.XtraGrid.Columns.GridColumn columnEmail;
        private DevExpress.XtraGrid.Columns.GridColumn columnTrainings;
        private DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit repositoryItemPopupContainerEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit repositoryItemPopupContainerEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.SimpleButton buttonLoadTestees;
        private DevExpress.XtraEditors.SimpleButton buttonEditTestee;





    }
}