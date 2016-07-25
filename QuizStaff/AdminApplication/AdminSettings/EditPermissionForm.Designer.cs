namespace AdminApplication.AdminSettings
{
    partial class EditPermissionForm
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
            this.permissionGridControl = new DevExpress.XtraGrid.GridControl();
            this.permissionGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.permissionGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.deletePermissionButton = new DevExpress.XtraEditors.SimpleButton();
            this.addPermissionButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.permissionGridControlLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.mvvmPermissionContext = new DevExpress.Utils.MVVM.MVVMContext();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.permissionGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissionGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissionGridControlLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmPermissionContext)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.permissionGridControl);
            this.layoutControl1.Controls.Add(this.deletePermissionButton);
            this.layoutControl1.Controls.Add(this.addPermissionButton);
            this.layoutControl1.Controls.Add(this.cancelButton);
            this.layoutControl1.Controls.Add(this.saveButton);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(455, 150, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(400, 348);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // permissionGridControl
            // 
            this.permissionGridControl.Location = new System.Drawing.Point(12, 64);
            this.permissionGridControl.MainView = this.permissionGridView;
            this.permissionGridControl.Name = "permissionGridControl";
            this.permissionGridControl.Size = new System.Drawing.Size(376, 236);
            this.permissionGridControl.TabIndex = 8;
            this.permissionGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.permissionGridView});
            // 
            // permissionGridView
            // 
            this.permissionGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.permissionGridColumn});
            this.permissionGridView.GridControl = this.permissionGridControl;
            this.permissionGridView.Name = "permissionGridView";
            this.permissionGridView.OptionsView.ShowGroupPanel = false;
            // 
            // permissionGridColumn
            // 
            this.permissionGridColumn.Caption = "Title";
            this.permissionGridColumn.FieldName = "Title";
            this.permissionGridColumn.Name = "permissionGridColumn";
            this.permissionGridColumn.Visible = true;
            this.permissionGridColumn.VisibleIndex = 0;
            // 
            // deletePermissionButton
            // 
            this.deletePermissionButton.Location = new System.Drawing.Point(283, 17);
            this.deletePermissionButton.Name = "deletePermissionButton";
            this.deletePermissionButton.Size = new System.Drawing.Size(100, 22);
            this.deletePermissionButton.StyleController = this.layoutControl1;
            this.deletePermissionButton.TabIndex = 7;
            this.deletePermissionButton.Text = "Delete";
            // 
            // addPermissionButton
            // 
            this.addPermissionButton.Location = new System.Drawing.Point(165, 17);
            this.addPermissionButton.Name = "addPermissionButton";
            this.addPermissionButton.Size = new System.Drawing.Size(104, 22);
            this.addPermissionButton.StyleController = this.layoutControl1;
            this.addPermissionButton.TabIndex = 6;
            this.addPermissionButton.Text = "Add";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(308, 309);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 22);
            this.cancelButton.StyleController = this.layoutControl1;
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancele";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(211, 309);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(83, 22);
            this.saveButton.StyleController = this.layoutControl1;
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.permissionGridControlLayoutControlItem,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(400, 348);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.saveButton;
            this.layoutControlItem1.Location = new System.Drawing.Point(194, 292);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(97, 36);
            this.layoutControlItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cancelButton;
            this.layoutControlItem2.Location = new System.Drawing.Point(291, 292);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(89, 36);
            this.layoutControlItem2.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // permissionGridControlLayoutControlItem
            // 
            this.permissionGridControlLayoutControlItem.Control = this.permissionGridControl;
            this.permissionGridControlLayoutControlItem.Location = new System.Drawing.Point(0, 36);
            this.permissionGridControlLayoutControlItem.Name = "permissionGridControlLayoutControlItem";
            this.permissionGridControlLayoutControlItem.Size = new System.Drawing.Size(380, 256);
            this.permissionGridControlLayoutControlItem.Text = "Permission";
            this.permissionGridControlLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.permissionGridControlLayoutControlItem.TextSize = new System.Drawing.Size(50, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.addPermissionButton;
            this.layoutControlItem3.Location = new System.Drawing.Point(148, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(118, 36);
            this.layoutControlItem3.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.deletePermissionButton;
            this.layoutControlItem4.Location = new System.Drawing.Point(266, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(114, 36);
            this.layoutControlItem4.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 292);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(194, 36);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(148, 36);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // mvvmPermissionContext
            // 
            this.mvvmPermissionContext.ContainerControl = this;
            // 
            // EditPermissionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 348);
            this.Controls.Add(this.layoutControl1);
            this.Name = "EditPermissionForm";
            this.Text = "EditPermissionForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.permissionGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissionGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissionGridControlLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmPermissionContext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton deletePermissionButton;
        private DevExpress.XtraEditors.SimpleButton addPermissionButton;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.GridControl permissionGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView permissionGridView;
        private DevExpress.XtraLayout.LayoutControlItem permissionGridControlLayoutControlItem;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraGrid.Columns.GridColumn permissionGridColumn;
        private DevExpress.Utils.MVVM.MVVMContext mvvmPermissionContext;
    }
}