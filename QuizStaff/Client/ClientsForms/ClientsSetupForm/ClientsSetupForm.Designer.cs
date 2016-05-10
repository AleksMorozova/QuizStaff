namespace Client.ClientsForms
{
    partial class ClientsSetupForm
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
            this.MainLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.spinEditFrequency = new DevExpress.XtraEditors.SpinEdit();
            this.timeEditTimeOfStart = new DevExpress.XtraEditors.TimeEdit();
            this.spinEditAmount = new DevExpress.XtraEditors.SpinEdit();
            this.butSave = new DevExpress.XtraEditors.SimpleButton();
            this.butCancel = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlCancelButton = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlSaveButton = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlTimeOfStart = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlFrequency = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.MainLayoutControl)).BeginInit();
            this.MainLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditFrequency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEditTimeOfStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCancelButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlSaveButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlTimeOfStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlFrequency)).BeginInit();
            this.SuspendLayout();
            // 
            // MainLayoutControl
            // 
            this.MainLayoutControl.Controls.Add(this.spinEditFrequency);
            this.MainLayoutControl.Controls.Add(this.timeEditTimeOfStart);
            this.MainLayoutControl.Controls.Add(this.spinEditAmount);
            this.MainLayoutControl.Controls.Add(this.butSave);
            this.MainLayoutControl.Controls.Add(this.butCancel);
            this.MainLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.MainLayoutControl.Name = "MainLayoutControl";
            this.MainLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(457, 42, 580, 350);
            this.MainLayoutControl.Root = this.layoutControlGroup1;
            this.MainLayoutControl.Size = new System.Drawing.Size(411, 270);
            this.MainLayoutControl.TabIndex = 0;
            this.MainLayoutControl.Text = "MainLayoutControl";
            // 
            // spinEditFrequency
            // 
            this.spinEditFrequency.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditFrequency.Location = new System.Drawing.Point(12, 99);
            this.spinEditFrequency.Name = "spinEditFrequency";
            this.spinEditFrequency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditFrequency.Properties.IsFloatValue = false;
            this.spinEditFrequency.Properties.Mask.EditMask = "N00";
            this.spinEditFrequency.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spinEditFrequency.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditFrequency.Size = new System.Drawing.Size(387, 20);
            this.spinEditFrequency.StyleController = this.MainLayoutControl;
            this.spinEditFrequency.TabIndex = 11;
            // 
            // timeEditTimeOfStart
            // 
            this.timeEditTimeOfStart.EditValue = new System.DateTime(2016, 4, 28, 0, 0, 0, 0);
            this.timeEditTimeOfStart.Location = new System.Drawing.Point(12, 167);
            this.timeEditTimeOfStart.Name = "timeEditTimeOfStart";
            this.timeEditTimeOfStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEditTimeOfStart.Properties.Mask.BeepOnError = true;
            this.timeEditTimeOfStart.Properties.Mask.EditMask = "t";
            this.timeEditTimeOfStart.Size = new System.Drawing.Size(387, 20);
            this.timeEditTimeOfStart.StyleController = this.MainLayoutControl;
            this.timeEditTimeOfStart.TabIndex = 10;
            // 
            // spinEditAmount
            // 
            this.spinEditAmount.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditAmount.Location = new System.Drawing.Point(12, 53);
            this.spinEditAmount.Name = "spinEditAmount";
            this.spinEditAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditAmount.Properties.IsFloatValue = false;
            this.spinEditAmount.Properties.Mask.EditMask = "N00";
            this.spinEditAmount.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinEditAmount.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditAmount.Size = new System.Drawing.Size(387, 20);
            this.spinEditAmount.StyleController = this.MainLayoutControl;
            this.spinEditAmount.TabIndex = 9;
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(12, 236);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(113, 22);
            this.butSave.StyleController = this.MainLayoutControl;
            this.butSave.TabIndex = 5;
            this.butSave.Text = "Save";
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(285, 236);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(114, 22);
            this.butCancel.StyleController = this.MainLayoutControl;
            this.butCancel.TabIndex = 4;
            this.butCancel.Text = "Cancel";
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem3,
            this.layoutControlCancelButton,
            this.layoutControlSaveButton,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.layoutControlItem4,
            this.emptySpaceItem4,
            this.layoutControlTimeOfStart,
            this.layoutControlFrequency});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(411, 270);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(117, 224);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(156, 26);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlCancelButton
            // 
            this.layoutControlCancelButton.Control = this.butCancel;
            this.layoutControlCancelButton.Location = new System.Drawing.Point(273, 224);
            this.layoutControlCancelButton.MaxSize = new System.Drawing.Size(118, 0);
            this.layoutControlCancelButton.MinSize = new System.Drawing.Size(118, 26);
            this.layoutControlCancelButton.Name = "layoutControlCancelButton";
            this.layoutControlCancelButton.Size = new System.Drawing.Size(118, 26);
            this.layoutControlCancelButton.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlCancelButton.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlCancelButton.TextVisible = false;
            // 
            // layoutControlSaveButton
            // 
            this.layoutControlSaveButton.Control = this.butSave;
            this.layoutControlSaveButton.Location = new System.Drawing.Point(0, 224);
            this.layoutControlSaveButton.MaxSize = new System.Drawing.Size(117, 26);
            this.layoutControlSaveButton.MinSize = new System.Drawing.Size(117, 26);
            this.layoutControlSaveButton.Name = "layoutControlSaveButton";
            this.layoutControlSaveButton.Size = new System.Drawing.Size(117, 26);
            this.layoutControlSaveButton.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlSaveButton.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlSaveButton.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 179);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(391, 45);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(391, 25);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.spinEditAmount;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 25);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(105, 40);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(391, 46);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "Question amount:";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(101, 13);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 121);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(391, 18);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlTimeOfStart
            // 
            this.layoutControlTimeOfStart.Control = this.timeEditTimeOfStart;
            this.layoutControlTimeOfStart.CustomizationFormText = "TimeOfStart:";
            this.layoutControlTimeOfStart.Location = new System.Drawing.Point(0, 139);
            this.layoutControlTimeOfStart.Name = "layoutControlTimeOfStart";
            this.layoutControlTimeOfStart.Size = new System.Drawing.Size(391, 40);
            this.layoutControlTimeOfStart.Text = "TimeOfStart:";
            this.layoutControlTimeOfStart.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlTimeOfStart.TextSize = new System.Drawing.Size(101, 13);
            // 
            // layoutControlFrequency
            // 
            this.layoutControlFrequency.Control = this.spinEditFrequency;
            this.layoutControlFrequency.CustomizationFormText = "Frequency of asking:";
            this.layoutControlFrequency.Location = new System.Drawing.Point(0, 71);
            this.layoutControlFrequency.MinSize = new System.Drawing.Size(105, 40);
            this.layoutControlFrequency.Name = "layoutControlFrequency";
            this.layoutControlFrequency.Size = new System.Drawing.Size(391, 50);
            this.layoutControlFrequency.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlFrequency.Text = "Frequency of asking:";
            this.layoutControlFrequency.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlFrequency.TextSize = new System.Drawing.Size(101, 13);
            // 
            // ClientsSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 270);
            this.Controls.Add(this.MainLayoutControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ClientsSetupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set up";
            ((System.ComponentModel.ISupportInitialize)(this.MainLayoutControl)).EndInit();
            this.MainLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spinEditFrequency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEditTimeOfStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCancelButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlSaveButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlTimeOfStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlFrequency)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl MainLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton butSave;
        private DevExpress.XtraEditors.SimpleButton butCancel;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlCancelButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlSaveButton;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.SpinEdit spinEditAmount;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.TimeEdit timeEditTimeOfStart;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlTimeOfStart;
        private DevExpress.XtraEditors.SpinEdit spinEditFrequency;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlFrequency;
    }
}