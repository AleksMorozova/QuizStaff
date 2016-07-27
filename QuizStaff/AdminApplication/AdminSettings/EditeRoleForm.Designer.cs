namespace AdminApplication.AdminSettings
{
    partial class EditeRoleForm
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
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.editPermissionButton = new DevExpress.XtraEditors.SimpleButton();
            this.permissionGridControl = new DevExpress.XtraGrid.GridControl();
            this.permissionGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.permissionGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.roleGridControl = new DevExpress.XtraGrid.GridControl();
            this.roleGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.roleGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.descriptionGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.roleGridControlLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.permissionGridControlLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.mvvmRoleContext = new DevExpress.Utils.MVVM.MVVMContext();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.permissionGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissionGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleGridControlLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissionGridControlLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmRoleContext)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cancelButton);
            this.layoutControl1.Controls.Add(this.saveButton);
            this.layoutControl1.Controls.Add(this.editPermissionButton);
            this.layoutControl1.Controls.Add(this.permissionGridControl);
            this.layoutControl1.Controls.Add(this.roleGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(391, 228, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(586, 426);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(484, 387);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(90, 22);
            this.cancelButton.StyleController = this.layoutControl1;
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(391, 387);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(79, 22);
            this.saveButton.StyleController = this.layoutControl1;
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            // 
            // editPermissionButton
            // 
            this.editPermissionButton.Location = new System.Drawing.Point(302, 387);
            this.editPermissionButton.Name = "editPermissionButton";
            this.editPermissionButton.Size = new System.Drawing.Size(85, 22);
            this.editPermissionButton.StyleController = this.layoutControl1;
            this.editPermissionButton.TabIndex = 6;
            this.editPermissionButton.Text = "Edit permissions";
            this.editPermissionButton.Click += new System.EventHandler(this.editPermissionButton_Click);
            // 
            // permissionGridControl
            // 
            this.permissionGridControl.Location = new System.Drawing.Point(352, 28);
            this.permissionGridControl.MainView = this.permissionGridView;
            this.permissionGridControl.Name = "permissionGridControl";
            this.permissionGridControl.Size = new System.Drawing.Size(222, 350);
            this.permissionGridControl.TabIndex = 5;
            this.permissionGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.permissionGridView});
            // 
            // permissionGridView
            // 
            this.permissionGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.permissionGridColumn});
            this.permissionGridView.GridControl = this.permissionGridControl;
            this.permissionGridView.Name = "permissionGridView";
            this.permissionGridView.OptionsDetail.EnableMasterViewMode = false;
            this.permissionGridView.OptionsSelection.MultiSelect = true;
            this.permissionGridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.permissionGridView.OptionsView.ShowGroupPanel = false;
            this.permissionGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.permissionGridView.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.permissionGridView_SelectionChanged);
            // 
            // permissionGridColumn
            // 
            this.permissionGridColumn.Caption = "Title";
            this.permissionGridColumn.FieldName = "Title";
            this.permissionGridColumn.Name = "permissionGridColumn";
            this.permissionGridColumn.Visible = true;
            this.permissionGridColumn.VisibleIndex = 1;
            // 
            // roleGridControl
            // 
            this.roleGridControl.Location = new System.Drawing.Point(12, 28);
            this.roleGridControl.MainView = this.roleGridView;
            this.roleGridControl.Name = "roleGridControl";
            this.roleGridControl.Size = new System.Drawing.Size(321, 350);
            this.roleGridControl.TabIndex = 4;
            this.roleGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.roleGridView});
            // 
            // roleGridView
            // 
            this.roleGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.roleGridColumn,
            this.descriptionGridColumn});
            this.roleGridView.GridControl = this.roleGridControl;
            this.roleGridView.Name = "roleGridView";
            this.roleGridView.OptionsDetail.EnableMasterViewMode = false;
            this.roleGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.roleGridView.OptionsView.ShowGroupPanel = false;
            this.roleGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.roleGridView_InitNewRow);
            this.roleGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.roleGridView_FocusedRowChanged);
            // 
            // roleGridColumn
            // 
            this.roleGridColumn.Caption = "Role";
            this.roleGridColumn.FieldName = "Name";
            this.roleGridColumn.Name = "roleGridColumn";
            this.roleGridColumn.Visible = true;
            this.roleGridColumn.VisibleIndex = 0;
            // 
            // descriptionGridColumn
            // 
            this.descriptionGridColumn.Caption = "Description";
            this.descriptionGridColumn.FieldName = "Description";
            this.descriptionGridColumn.Name = "descriptionGridColumn";
            this.descriptionGridColumn.Visible = true;
            this.descriptionGridColumn.VisibleIndex = 1;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.roleGridControlLayoutControlItem,
            this.permissionGridControlLayoutControlItem,
            this.splitterItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem2,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(586, 426);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // roleGridControlLayoutControlItem
            // 
            this.roleGridControlLayoutControlItem.Control = this.roleGridControl;
            this.roleGridControlLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.roleGridControlLayoutControlItem.Name = "roleGridControlLayoutControlItem";
            this.roleGridControlLayoutControlItem.Size = new System.Drawing.Size(330, 370);
            this.roleGridControlLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 5, 0, 0);
            this.roleGridControlLayoutControlItem.Text = "Role";
            this.roleGridControlLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.roleGridControlLayoutControlItem.TextSize = new System.Drawing.Size(50, 13);
            // 
            // permissionGridControlLayoutControlItem
            // 
            this.permissionGridControlLayoutControlItem.Control = this.permissionGridControl;
            this.permissionGridControlLayoutControlItem.Location = new System.Drawing.Point(335, 0);
            this.permissionGridControlLayoutControlItem.Name = "permissionGridControlLayoutControlItem";
            this.permissionGridControlLayoutControlItem.Size = new System.Drawing.Size(231, 370);
            this.permissionGridControlLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0);
            this.permissionGridControlLayoutControlItem.Text = "Permission";
            this.permissionGridControlLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.permissionGridControlLayoutControlItem.TextSize = new System.Drawing.Size(50, 13);
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.Location = new System.Drawing.Point(330, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(5, 370);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.editPermissionButton;
            this.layoutControlItem1.Location = new System.Drawing.Point(290, 370);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(89, 36);
            this.layoutControlItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 5);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            this.layoutControlItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.saveButton;
            this.layoutControlItem2.Location = new System.Drawing.Point(379, 370);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(88, 36);
            this.layoutControlItem2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 5, 5, 5);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cancelButton;
            this.layoutControlItem3.Location = new System.Drawing.Point(467, 370);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(99, 36);
            this.layoutControlItem3.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 0, 5, 5);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 370);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(290, 36);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // mvvmRoleContext
            // 
            this.mvvmRoleContext.ContainerControl = this;
            // 
            // EditeRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 426);
            this.Controls.Add(this.layoutControl1);
            this.Name = "EditeRoleForm";
            this.Text = "EditeRoleForm";
            this.Load += new System.EventHandler(this.EditeRoleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.permissionGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissionGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleGridControlLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissionGridControlLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmRoleContext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl permissionGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView permissionGridView;
        private DevExpress.XtraGrid.GridControl roleGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView roleGridView;
        private DevExpress.XtraLayout.LayoutControlItem roleGridControlLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem permissionGridControlLayoutControlItem;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.SimpleButton editPermissionButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraGrid.Columns.GridColumn permissionGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn roleGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn descriptionGridColumn;
        private DevExpress.Utils.MVVM.MVVMContext mvvmRoleContext;
    }
}