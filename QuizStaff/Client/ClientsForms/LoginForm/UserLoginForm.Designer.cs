namespace Client.ClientsForms.LoginForm
{
    partial class UserLoginForm
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.asAdminBox = new DevExpress.XtraEditors.CheckEdit();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.loginButton = new DevExpress.XtraEditors.SimpleButton();
            this.passwordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.loginTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asAdminBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.asAdminBox);
            this.layoutControl1.Controls.Add(this.cancelButton);
            this.layoutControl1.Controls.Add(this.loginButton);
            this.layoutControl1.Controls.Add(this.passwordTextEdit);
            this.layoutControl1.Controls.Add(this.loginTextEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(480, 284, 494, 494);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(416, 179);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // asAdminBox
            // 
            this.asAdminBox.Location = new System.Drawing.Point(304, 148);
            this.asAdminBox.Name = "asAdminBox";
            this.asAdminBox.Properties.Caption = "As Admin";
            this.asAdminBox.Size = new System.Drawing.Size(100, 19);
            this.asAdminBox.StyleController = this.layoutControl1;
            this.asAdminBox.TabIndex = 8;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(210, 92);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(194, 22);
            this.cancelButton.StyleController = this.layoutControl1;
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(12, 92);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(194, 22);
            this.loginButton.StyleController = this.layoutControl1;
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Login";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordTextEdit
            // 
            this.passwordTextEdit.Location = new System.Drawing.Point(12, 68);
            this.passwordTextEdit.Name = "passwordTextEdit";
            this.passwordTextEdit.Properties.PasswordChar = '*';
            this.passwordTextEdit.Properties.UseSystemPasswordChar = true;
            this.passwordTextEdit.Size = new System.Drawing.Size(392, 20);
            this.passwordTextEdit.StyleController = this.layoutControl1;
            this.passwordTextEdit.TabIndex = 5;
            // 
            // loginTextEdit
            // 
            this.loginTextEdit.Location = new System.Drawing.Point(12, 28);
            this.loginTextEdit.Name = "loginTextEdit";
            this.loginTextEdit.Size = new System.Drawing.Size(392, 20);
            this.loginTextEdit.StyleController = this.layoutControl1;
            this.loginTextEdit.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem2,
            this.layoutControlItem5,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(416, 179);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.loginTextEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(396, 40);
            this.layoutControlItem1.Text = "Login";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(46, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.passwordTextEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(396, 40);
            this.layoutControlItem2.Text = "Password";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(46, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.loginButton;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 80);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(198, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cancelButton;
            this.layoutControlItem4.Location = new System.Drawing.Point(198, 80);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(198, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(292, 106);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(104, 30);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.asAdminBox;
            this.layoutControlItem5.Location = new System.Drawing.Point(292, 136);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(104, 23);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 106);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(292, 53);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // UserLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 179);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserLoginForm";
            this.Text = "UserLoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.asAdminBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.SimpleButton loginButton;
        private DevExpress.XtraEditors.TextEdit passwordTextEdit;
        private DevExpress.XtraEditors.TextEdit loginTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.CheckEdit asAdminBox;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}