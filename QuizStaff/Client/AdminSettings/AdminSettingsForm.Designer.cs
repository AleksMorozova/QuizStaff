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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.usersListGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.usersListLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.questionAmountTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.questionAmountLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.frequencySpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.frequencyLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.timeOfAskingEditTime = new DevExpress.XtraEditors.TimeEdit();
            this.timeOfAskingLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersListGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersListLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionAmountTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionAmountLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencySpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeOfAskingEditTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeOfAskingLayoutControlItem)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.timeOfAskingEditTime);
            this.layoutControl1.Controls.Add(this.frequencySpinEdit);
            this.layoutControl1.Controls.Add(this.questionAmountTextEdit);
            this.layoutControl1.Controls.Add(this.usersListGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.UseDefaultDragAndDropRendering = false;
            this.layoutControl1.Root = this.layoutControlGroup;
            this.layoutControl1.Size = new System.Drawing.Size(614, 369);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.usersListLayoutControlItem,
            this.frequencyLayoutControlItem,
            this.questionAmountLayoutControlItem,
            this.timeOfAskingLayoutControlItem});
            this.layoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup.Name = "layoutControlGroup";
            this.layoutControlGroup.Size = new System.Drawing.Size(614, 369);
            this.layoutControlGroup.TextVisible = false;
            // 
            // usersListGridControl
            // 
            this.usersListGridControl.Location = new System.Drawing.Point(12, 28);
            this.usersListGridControl.MainView = this.gridView1;
            this.usersListGridControl.Name = "usersListGridControl";
            this.usersListGridControl.Size = new System.Drawing.Size(283, 329);
            this.usersListGridControl.TabIndex = 4;
            this.usersListGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.usersListGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // usersListLayoutControlItem
            // 
            this.usersListLayoutControlItem.Control = this.usersListGridControl;
            this.usersListLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.usersListLayoutControlItem.Name = "usersListLayoutControlItem";
            this.usersListLayoutControlItem.Size = new System.Drawing.Size(297, 349);
            this.usersListLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 10, 0, 0);
            this.usersListLayoutControlItem.Text = "Users list:";
            this.usersListLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.usersListLayoutControlItem.TextSize = new System.Drawing.Size(82, 13);
            // 
            // questionAmountTextEdit
            // 
            this.questionAmountTextEdit.Location = new System.Drawing.Point(395, 12);
            this.questionAmountTextEdit.Name = "questionAmountTextEdit";
            this.questionAmountTextEdit.Size = new System.Drawing.Size(207, 20);
            this.questionAmountTextEdit.StyleController = this.layoutControl1;
            this.questionAmountTextEdit.TabIndex = 5;
            // 
            // questionAmountLayoutControlItem
            // 
            this.questionAmountLayoutControlItem.Control = this.questionAmountTextEdit;
            this.questionAmountLayoutControlItem.Location = new System.Drawing.Point(297, 0);
            this.questionAmountLayoutControlItem.Name = "questionAmountLayoutControlItem";
            this.questionAmountLayoutControlItem.Size = new System.Drawing.Size(297, 29);
            this.questionAmountLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 5);
            this.questionAmountLayoutControlItem.Text = "Question amount";
            this.questionAmountLayoutControlItem.TextSize = new System.Drawing.Size(82, 13);
            // 
            // frequencySpinEdit
            // 
            this.frequencySpinEdit.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.frequencySpinEdit.Location = new System.Drawing.Point(395, 46);
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
            this.frequencySpinEdit.Size = new System.Drawing.Size(207, 20);
            this.frequencySpinEdit.StyleController = this.layoutControl1;
            this.frequencySpinEdit.TabIndex = 12;
            // 
            // frequencyLayoutControlItem
            // 
            this.frequencyLayoutControlItem.Control = this.frequencySpinEdit;
            this.frequencyLayoutControlItem.Location = new System.Drawing.Point(297, 29);
            this.frequencyLayoutControlItem.Name = "frequencyLayoutControlItem";
            this.frequencyLayoutControlItem.Size = new System.Drawing.Size(297, 34);
            this.frequencyLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 5);
            this.frequencyLayoutControlItem.Text = "Frequency";
            this.frequencyLayoutControlItem.TextSize = new System.Drawing.Size(82, 13);
            // 
            // timeOfAskingEditTime
            // 
            this.timeOfAskingEditTime.EditValue = new System.DateTime(2016, 4, 28, 0, 0, 0, 0);
            this.timeOfAskingEditTime.Location = new System.Drawing.Point(395, 75);
            this.timeOfAskingEditTime.Name = "timeOfAskingEditTime";
            this.timeOfAskingEditTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeOfAskingEditTime.Properties.Mask.BeepOnError = true;
            this.timeOfAskingEditTime.Properties.Mask.EditMask = "t";
            this.timeOfAskingEditTime.Size = new System.Drawing.Size(207, 20);
            this.timeOfAskingEditTime.StyleController = this.layoutControl1;
            this.timeOfAskingEditTime.TabIndex = 13;
            // 
            // timeOfAskingLayoutControlItem
            // 
            this.timeOfAskingLayoutControlItem.Control = this.timeOfAskingEditTime;
            this.timeOfAskingLayoutControlItem.Location = new System.Drawing.Point(297, 63);
            this.timeOfAskingLayoutControlItem.Name = "timeOfAskingLayoutControlItem";
            this.timeOfAskingLayoutControlItem.Size = new System.Drawing.Size(297, 286);
            this.timeOfAskingLayoutControlItem.Text = "Time of asking";
            this.timeOfAskingLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Left;
            this.timeOfAskingLayoutControlItem.TextSize = new System.Drawing.Size(82, 13);
            // 
            // AdminSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 369);
            this.Controls.Add(this.layoutControl1);
            this.Name = "AdminSettingsForm";
            this.Text = "AdminSettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersListGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersListLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionAmountTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionAmountLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencySpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeOfAskingEditTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeOfAskingLayoutControlItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private DevExpress.XtraGrid.GridControl usersListGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem usersListLayoutControlItem;
        private DevExpress.XtraEditors.TextEdit questionAmountTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem questionAmountLayoutControlItem;
        private DevExpress.XtraEditors.SpinEdit frequencySpinEdit;
        private DevExpress.XtraLayout.LayoutControlItem frequencyLayoutControlItem;
        private DevExpress.XtraEditors.TimeEdit timeOfAskingEditTime;
        private DevExpress.XtraLayout.LayoutControlItem timeOfAskingLayoutControlItem;
    }
}