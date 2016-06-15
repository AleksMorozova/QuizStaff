namespace Client.TesteeSettings
{
    partial class TesteeSettingsForm
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
            this.frequencySpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.timeOfAskingEditTime = new DevExpress.XtraEditors.TimeEdit();
            this.questionAmountSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlCancelButton = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlSaveButton = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.questionAmountSpinEditLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.timeOfAskingEditTimeLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.frequencySpinEditLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.mvvmTesteeSettingsContext = new DevExpress.Utils.MVVM.MVVMContext();
            ((System.ComponentModel.ISupportInitialize)(this.MainLayoutControl)).BeginInit();
            this.MainLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frequencySpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeOfAskingEditTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionAmountSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCancelButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlSaveButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionAmountSpinEditLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeOfAskingEditTimeLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencySpinEditLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmTesteeSettingsContext)).BeginInit();
            this.SuspendLayout();
            // 
            // MainLayoutControl
            // 
            this.MainLayoutControl.Controls.Add(this.frequencySpinEdit);
            this.MainLayoutControl.Controls.Add(this.timeOfAskingEditTime);
            this.MainLayoutControl.Controls.Add(this.questionAmountSpinEdit);
            this.MainLayoutControl.Controls.Add(this.saveButton);
            this.MainLayoutControl.Controls.Add(this.cancelButton);
            this.MainLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.MainLayoutControl.Name = "MainLayoutControl";
            this.MainLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(457, 42, 580, 350);
            this.MainLayoutControl.Root = this.layoutControlGroup1;
            this.MainLayoutControl.Size = new System.Drawing.Size(411, 270);
            this.MainLayoutControl.TabIndex = 0;
            this.MainLayoutControl.Text = "MainLayoutControl";
            // 
            // frequencySpinEdit
            // 
            this.frequencySpinEdit.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.frequencySpinEdit.Location = new System.Drawing.Point(12, 99);
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
            this.frequencySpinEdit.Size = new System.Drawing.Size(387, 20);
            this.frequencySpinEdit.StyleController = this.MainLayoutControl;
            this.frequencySpinEdit.TabIndex = 11;
            // 
            // timeOfAskingEditTime
            // 
            this.timeOfAskingEditTime.EditValue = new System.DateTime(2016, 4, 28, 0, 0, 0, 0);
            this.timeOfAskingEditTime.Location = new System.Drawing.Point(12, 167);
            this.timeOfAskingEditTime.Name = "timeOfAskingEditTime";
            this.timeOfAskingEditTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeOfAskingEditTime.Properties.Mask.BeepOnError = true;
            this.timeOfAskingEditTime.Properties.Mask.EditMask = "t";
            this.timeOfAskingEditTime.Size = new System.Drawing.Size(387, 20);
            this.timeOfAskingEditTime.StyleController = this.MainLayoutControl;
            this.timeOfAskingEditTime.TabIndex = 10;
            // 
            // questionAmountSpinEdit
            // 
            this.questionAmountSpinEdit.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.questionAmountSpinEdit.Location = new System.Drawing.Point(12, 53);
            this.questionAmountSpinEdit.Name = "questionAmountSpinEdit";
            this.questionAmountSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.questionAmountSpinEdit.Properties.IsFloatValue = false;
            this.questionAmountSpinEdit.Properties.Mask.EditMask = "N00";
            this.questionAmountSpinEdit.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.questionAmountSpinEdit.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.questionAmountSpinEdit.Size = new System.Drawing.Size(387, 20);
            this.questionAmountSpinEdit.StyleController = this.MainLayoutControl;
            this.questionAmountSpinEdit.TabIndex = 9;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 236);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(113, 22);
            this.saveButton.StyleController = this.MainLayoutControl;
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(285, 236);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(114, 22);
            this.cancelButton.StyleController = this.MainLayoutControl;
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
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
            this.questionAmountSpinEditLayoutControlItem,
            this.emptySpaceItem4,
            this.timeOfAskingEditTimeLayoutControlItem,
            this.frequencySpinEditLayoutControlItem});
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
            this.layoutControlCancelButton.Control = this.cancelButton;
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
            this.layoutControlSaveButton.Control = this.saveButton;
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
            // questionAmountSpinEditLayoutControlItem
            // 
            this.questionAmountSpinEditLayoutControlItem.Control = this.questionAmountSpinEdit;
            this.questionAmountSpinEditLayoutControlItem.Location = new System.Drawing.Point(0, 25);
            this.questionAmountSpinEditLayoutControlItem.MinSize = new System.Drawing.Size(105, 40);
            this.questionAmountSpinEditLayoutControlItem.Name = "questionAmountSpinEditLayoutControlItem";
            this.questionAmountSpinEditLayoutControlItem.Size = new System.Drawing.Size(391, 46);
            this.questionAmountSpinEditLayoutControlItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.questionAmountSpinEditLayoutControlItem.Text = "Question amount:";
            this.questionAmountSpinEditLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.questionAmountSpinEditLayoutControlItem.TextSize = new System.Drawing.Size(101, 13);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 121);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(391, 18);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // timeOfAskingEditTimeLayoutControlItem
            // 
            this.timeOfAskingEditTimeLayoutControlItem.Control = this.timeOfAskingEditTime;
            this.timeOfAskingEditTimeLayoutControlItem.CustomizationFormText = "TimeOfStart:";
            this.timeOfAskingEditTimeLayoutControlItem.Location = new System.Drawing.Point(0, 139);
            this.timeOfAskingEditTimeLayoutControlItem.Name = "timeOfAskingEditTimeLayoutControlItem";
            this.timeOfAskingEditTimeLayoutControlItem.Size = new System.Drawing.Size(391, 40);
            this.timeOfAskingEditTimeLayoutControlItem.Text = "TimeOfStart:";
            this.timeOfAskingEditTimeLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.timeOfAskingEditTimeLayoutControlItem.TextSize = new System.Drawing.Size(101, 13);
            // 
            // frequencySpinEditLayoutControlItem
            // 
            this.frequencySpinEditLayoutControlItem.Control = this.frequencySpinEdit;
            this.frequencySpinEditLayoutControlItem.CustomizationFormText = "Frequency of asking:";
            this.frequencySpinEditLayoutControlItem.Location = new System.Drawing.Point(0, 71);
            this.frequencySpinEditLayoutControlItem.MinSize = new System.Drawing.Size(105, 40);
            this.frequencySpinEditLayoutControlItem.Name = "frequencySpinEditLayoutControlItem";
            this.frequencySpinEditLayoutControlItem.Size = new System.Drawing.Size(391, 50);
            this.frequencySpinEditLayoutControlItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.frequencySpinEditLayoutControlItem.Text = "Frequency of asking:";
            this.frequencySpinEditLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.frequencySpinEditLayoutControlItem.TextSize = new System.Drawing.Size(101, 13);
            // 
            // mvvmTesteeSettingsContext
            // 
            this.mvvmTesteeSettingsContext.ContainerControl = this;
            // 
            // TesteeSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 270);
            this.Controls.Add(this.MainLayoutControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TesteeSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set up";
            ((System.ComponentModel.ISupportInitialize)(this.MainLayoutControl)).EndInit();
            this.MainLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.frequencySpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeOfAskingEditTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionAmountSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCancelButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlSaveButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionAmountSpinEditLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeOfAskingEditTimeLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencySpinEditLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmTesteeSettingsContext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl MainLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlCancelButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlSaveButton;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.SpinEdit questionAmountSpinEdit;
        private DevExpress.XtraLayout.LayoutControlItem questionAmountSpinEditLayoutControlItem;
        private DevExpress.XtraEditors.TimeEdit timeOfAskingEditTime;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.LayoutControlItem timeOfAskingEditTimeLayoutControlItem;
        private DevExpress.XtraEditors.SpinEdit frequencySpinEdit;
        private DevExpress.XtraLayout.LayoutControlItem frequencySpinEditLayoutControlItem;
        private DevExpress.Utils.MVVM.MVVMContext mvvmTesteeSettingsContext;
    }
}