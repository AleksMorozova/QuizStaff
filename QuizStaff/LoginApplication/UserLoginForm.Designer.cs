namespace LoginApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLoginForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.domainLlabel = new DevExpress.XtraEditors.LabelControl();
            this.loginButton = new DevExpress.XtraEditors.SimpleButton();
            this.passwordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.loginTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.loginLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.passwordLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.domainLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domainLayoutControlItem)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.domainLlabel);
            this.layoutControl1.Controls.Add(this.loginButton);
            this.layoutControl1.Controls.Add(this.passwordTextEdit);
            this.layoutControl1.Controls.Add(this.loginTextEdit);
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(480, 284, 494, 494);
            this.layoutControl1.Root = this.layoutControlGroup1;
            // 
            // domainLlabel
            // 
            this.domainLlabel.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("domainLlabel.Appearance.Font")));
            resources.ApplyResources(this.domainLlabel, "domainLlabel");
            this.domainLlabel.Name = "domainLlabel";
            this.domainLlabel.StyleController = this.layoutControl1;
            // 
            // loginButton
            // 
            this.loginButton.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("loginButton.Appearance.Font")));
            this.loginButton.Appearance.Options.UseFont = true;
            this.loginButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.loginButton, "loginButton");
            this.loginButton.Name = "loginButton";
            this.loginButton.StyleController = this.layoutControl1;
            // 
            // passwordTextEdit
            // 
            resources.ApplyResources(this.passwordTextEdit, "passwordTextEdit");
            this.passwordTextEdit.Name = "passwordTextEdit";
            this.passwordTextEdit.Properties.PasswordChar = '*';
            this.passwordTextEdit.Properties.UseSystemPasswordChar = true;
            this.passwordTextEdit.StyleController = this.layoutControl1;
            // 
            // loginTextEdit
            // 
            resources.ApplyResources(this.loginTextEdit, "loginTextEdit");
            this.loginTextEdit.Name = "loginTextEdit";
            this.loginTextEdit.StyleController = this.layoutControl1;
            this.loginTextEdit.EditValueChanged += new System.EventHandler(this.loginTextEdit_EditValueChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.loginLayoutControlItem,
            this.passwordLayoutControlItem,
            this.layoutControlItem3,
            this.emptySpaceItem2,
            this.emptySpaceItem1,
            this.domainLayoutControlItem});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlGroup1.Size = new System.Drawing.Size(307, 161);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 0, 0);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // loginLayoutControlItem
            // 
            this.loginLayoutControlItem.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("loginLayoutControlItem.AppearanceItemCaption.Font")));
            this.loginLayoutControlItem.AppearanceItemCaption.Options.UseFont = true;
            this.loginLayoutControlItem.Control = this.loginTextEdit;
            this.loginLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.loginLayoutControlItem.Name = "loginLayoutControlItem";
            this.loginLayoutControlItem.Size = new System.Drawing.Size(287, 43);
            resources.ApplyResources(this.loginLayoutControlItem, "loginLayoutControlItem");
            this.loginLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.loginLayoutControlItem.TextSize = new System.Drawing.Size(55, 16);
            // 
            // passwordLayoutControlItem
            // 
            this.passwordLayoutControlItem.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("passwordLayoutControlItem.AppearanceItemCaption.Font")));
            this.passwordLayoutControlItem.AppearanceItemCaption.Options.UseFont = true;
            this.passwordLayoutControlItem.Control = this.passwordTextEdit;
            this.passwordLayoutControlItem.Location = new System.Drawing.Point(0, 43);
            this.passwordLayoutControlItem.Name = "passwordLayoutControlItem";
            this.passwordLayoutControlItem.Size = new System.Drawing.Size(287, 43);
            resources.ApplyResources(this.passwordLayoutControlItem, "passwordLayoutControlItem");
            this.passwordLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.passwordLayoutControlItem.TextSize = new System.Drawing.Size(55, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.loginButton;
            this.layoutControlItem3.Location = new System.Drawing.Point(95, 116);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(97, 35);
            this.layoutControlItem3.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 0);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 116);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(95, 35);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(192, 116);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(95, 35);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // domainLayoutControlItem
            // 
            this.domainLayoutControlItem.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("domainLayoutControlItem.AppearanceItemCaption.Font")));
            this.domainLayoutControlItem.AppearanceItemCaption.Options.UseFont = true;
            this.domainLayoutControlItem.Control = this.domainLlabel;
            this.domainLayoutControlItem.Location = new System.Drawing.Point(0, 86);
            this.domainLayoutControlItem.Name = "domainLayoutControlItem";
            this.domainLayoutControlItem.Size = new System.Drawing.Size(287, 30);
            this.domainLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 5);
            resources.ApplyResources(this.domainLayoutControlItem, "domainLayoutControlItem");
            this.domainLayoutControlItem.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.domainLayoutControlItem.TextSize = new System.Drawing.Size(48, 16);
            this.domainLayoutControlItem.TextToControlDistance = 5;
            // 
            // UserLoginForm
            // 
            this.AcceptButton = this.loginButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserLoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domainLayoutControlItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton loginButton;
        private DevExpress.XtraEditors.TextEdit passwordTextEdit;
        private DevExpress.XtraEditors.TextEdit loginTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem loginLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem passwordLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.LabelControl domainLlabel;
        private DevExpress.XtraLayout.LayoutControlItem domainLayoutControlItem;
    }
}