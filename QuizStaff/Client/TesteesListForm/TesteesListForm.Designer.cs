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
            this.buttonEditTestee = new DevExpress.XtraEditors.SimpleButton();
            this.buttonLoadTestees = new DevExpress.XtraEditors.SimpleButton();
            this.buttonSave = new DevExpress.XtraEditors.SimpleButton();
            this.buttonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.columnFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnLogin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnTrainings = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTestees = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTestees)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddTestee
            // 
            this.buttonAddTestee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddTestee.Location = new System.Drawing.Point(439, 12);
            this.buttonAddTestee.Name = "buttonAddTestee";
            this.buttonAddTestee.Size = new System.Drawing.Size(118, 23);
            this.buttonAddTestee.TabIndex = 0;
            this.buttonAddTestee.Text = "Add testee";
            // 
            // buttonEditTestee
            // 
            this.buttonEditTestee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditTestee.Location = new System.Drawing.Point(563, 12);
            this.buttonEditTestee.Name = "buttonEditTestee";
            this.buttonEditTestee.Size = new System.Drawing.Size(118, 23);
            this.buttonEditTestee.TabIndex = 1;
            this.buttonEditTestee.Text = "Edit testee";
            // 
            // buttonLoadTestees
            // 
            this.buttonLoadTestees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadTestees.Location = new System.Drawing.Point(687, 12);
            this.buttonLoadTestees.Name = "buttonLoadTestees";
            this.buttonLoadTestees.Size = new System.Drawing.Size(118, 23);
            this.buttonLoadTestees.TabIndex = 2;
            this.buttonLoadTestees.Text = "Load testees";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(625, 511);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(180, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(439, 511);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(180, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridTestees;
            this.gridView2.Name = "gridView2";
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
            this.columnTrainings.FieldName = "Trainings";
            this.columnTrainings.Name = "columnTrainings";
            this.columnTrainings.Visible = true;
            this.columnTrainings.VisibleIndex = 4;
            // 
            // gridTestees
            // 
            this.gridTestees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridTestees.Location = new System.Drawing.Point(12, 41);
            this.gridTestees.MainView = this.gridView1;
            this.gridTestees.Name = "gridTestees";
            this.gridTestees.Size = new System.Drawing.Size(793, 464);
            this.gridTestees.TabIndex = 3;
            this.gridTestees.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // TesteesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 546);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.gridTestees);
            this.Controls.Add(this.buttonLoadTestees);
            this.Controls.Add(this.buttonEditTestee);
            this.Controls.Add(this.buttonAddTestee);
            this.Name = "TesteesListForm";
            this.Text = "TesteesListForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTestees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton buttonAddTestee;
        private DevExpress.XtraEditors.SimpleButton buttonEditTestee;
        private DevExpress.XtraEditors.SimpleButton buttonLoadTestees;
        private DevExpress.XtraEditors.SimpleButton buttonSave;
        private DevExpress.XtraEditors.SimpleButton buttonCancel;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gridTestees;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn columnFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn columnLastName;
        private DevExpress.XtraGrid.Columns.GridColumn columnLogin;
        private DevExpress.XtraGrid.Columns.GridColumn columnEmail;
        private DevExpress.XtraGrid.Columns.GridColumn columnTrainings;

    }
}