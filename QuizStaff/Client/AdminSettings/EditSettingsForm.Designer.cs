namespace Client.AdminSettings
{
    partial class EditSettingsForm
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
            this.showAnswerToggleSwitch = new DevExpress.XtraEditors.ToggleSwitch();
            this.canEditToggleSwitch = new DevExpress.XtraEditors.ToggleSwitch();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.applyButton = new DevExpress.XtraEditors.SimpleButton();
            this.timeOfAskingEditTime = new DevExpress.XtraEditors.TimeEdit();
            this.frequencySpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.questionAmountTextEdit = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.frequencyLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.questionAmountLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.timeOfAskingLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.applyButtonLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.canEditToggleSwitchLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.showAnswerToggleSwitchLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.cancelButtonLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.mvvmSettingsContext = new DevExpress.Utils.MVVM.MVVMContext();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showAnswerToggleSwitch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canEditToggleSwitch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeOfAskingEditTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencySpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionAmountTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionAmountLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeOfAskingLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applyButtonLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canEditToggleSwitchLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showAnswerToggleSwitchLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButtonLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmSettingsContext)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.showAnswerToggleSwitch);
            this.layoutControl1.Controls.Add(this.canEditToggleSwitch);
            this.layoutControl1.Controls.Add(this.cancelButton);
            this.layoutControl1.Controls.Add(this.applyButton);
            this.layoutControl1.Controls.Add(this.timeOfAskingEditTime);
            this.layoutControl1.Controls.Add(this.frequencySpinEdit);
            this.layoutControl1.Controls.Add(this.questionAmountTextEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.UseDefaultDragAndDropRendering = false;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(469, 247);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // showAnswerToggleSwitch
            // 
            this.showAnswerToggleSwitch.Location = new System.Drawing.Point(118, 148);
            this.showAnswerToggleSwitch.Name = "showAnswerToggleSwitch";
            this.showAnswerToggleSwitch.Properties.OffText = "Off";
            this.showAnswerToggleSwitch.Properties.OnText = "On";
            this.showAnswerToggleSwitch.Size = new System.Drawing.Size(337, 24);
            this.showAnswerToggleSwitch.StyleController = this.layoutControl1;
            this.showAnswerToggleSwitch.TabIndex = 25;
            // 
            // canEditToggleSwitch
            // 
            this.canEditToggleSwitch.Location = new System.Drawing.Point(118, 116);
            this.canEditToggleSwitch.Name = "canEditToggleSwitch";
            this.canEditToggleSwitch.Properties.OffText = "Off";
            this.canEditToggleSwitch.Properties.OnText = "On";
            this.canEditToggleSwitch.Size = new System.Drawing.Size(337, 24);
            this.canEditToggleSwitch.StyleController = this.layoutControl1;
            this.canEditToggleSwitch.TabIndex = 25;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(241, 183);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(211, 22);
            this.cancelButton.StyleController = this.layoutControl1;
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            // 
            // applyButton
            // 
            this.applyButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.applyButton.Location = new System.Drawing.Point(17, 183);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(210, 22);
            this.applyButton.StyleController = this.layoutControl1;
            this.applyButton.TabIndex = 7;
            this.applyButton.Text = "Apply";
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // timeOfAskingEditTime
            // 
            this.timeOfAskingEditTime.EditValue = new System.DateTime(2016, 6, 13, 0, 0, 0, 0);
            this.timeOfAskingEditTime.Location = new System.Drawing.Point(121, 85);
            this.timeOfAskingEditTime.Name = "timeOfAskingEditTime";
            this.timeOfAskingEditTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeOfAskingEditTime.Size = new System.Drawing.Size(331, 20);
            this.timeOfAskingEditTime.StyleController = this.layoutControl1;
            this.timeOfAskingEditTime.TabIndex = 6;
            // 
            // frequencySpinEdit
            // 
            this.frequencySpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.frequencySpinEdit.Location = new System.Drawing.Point(121, 51);
            this.frequencySpinEdit.Name = "frequencySpinEdit";
            this.frequencySpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.frequencySpinEdit.Size = new System.Drawing.Size(331, 20);
            this.frequencySpinEdit.StyleController = this.layoutControl1;
            this.frequencySpinEdit.TabIndex = 5;
            // 
            // questionAmountTextEdit
            // 
            this.questionAmountTextEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.questionAmountTextEdit.Location = new System.Drawing.Point(121, 17);
            this.questionAmountTextEdit.Name = "questionAmountTextEdit";
            this.questionAmountTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.questionAmountTextEdit.Size = new System.Drawing.Size(331, 20);
            this.questionAmountTextEdit.StyleController = this.layoutControl1;
            this.questionAmountTextEdit.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.frequencyLayoutControlItem,
            this.questionAmountLayoutControlItem,
            this.timeOfAskingLayoutControlItem,
            this.applyButtonLayoutControlItem,
            this.canEditToggleSwitchLayoutControlItem,
            this.showAnswerToggleSwitchLayoutControlItem,
            this.cancelButtonLayoutControlItem});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(469, 247);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // frequencyLayoutControlItem
            // 
            this.frequencyLayoutControlItem.Control = this.frequencySpinEdit;
            this.frequencyLayoutControlItem.Location = new System.Drawing.Point(0, 34);
            this.frequencyLayoutControlItem.Name = "frequencyLayoutControlItem";
            this.frequencyLayoutControlItem.Size = new System.Drawing.Size(449, 34);
            this.frequencyLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.frequencyLayoutControlItem.Text = "Frequency";
            this.frequencyLayoutControlItem.TextSize = new System.Drawing.Size(101, 13);
            // 
            // questionAmountLayoutControlItem
            // 
            this.questionAmountLayoutControlItem.Control = this.questionAmountTextEdit;
            this.questionAmountLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.questionAmountLayoutControlItem.Name = "questionAmountLayoutControlItem";
            this.questionAmountLayoutControlItem.Size = new System.Drawing.Size(449, 34);
            this.questionAmountLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.questionAmountLayoutControlItem.Text = "Question amount";
            this.questionAmountLayoutControlItem.TextSize = new System.Drawing.Size(101, 13);
            // 
            // timeOfAskingLayoutControlItem
            // 
            this.timeOfAskingLayoutControlItem.Control = this.timeOfAskingEditTime;
            this.timeOfAskingLayoutControlItem.Location = new System.Drawing.Point(0, 68);
            this.timeOfAskingLayoutControlItem.Name = "timeOfAskingLayoutControlItem";
            this.timeOfAskingLayoutControlItem.Size = new System.Drawing.Size(449, 34);
            this.timeOfAskingLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.timeOfAskingLayoutControlItem.Text = "Time of asking";
            this.timeOfAskingLayoutControlItem.TextSize = new System.Drawing.Size(101, 13);
            // 
            // applyButtonLayoutControlItem
            // 
            this.applyButtonLayoutControlItem.Control = this.applyButton;
            this.applyButtonLayoutControlItem.Location = new System.Drawing.Point(0, 166);
            this.applyButtonLayoutControlItem.Name = "applyButtonLayoutControlItem";
            this.applyButtonLayoutControlItem.Size = new System.Drawing.Size(224, 61);
            this.applyButtonLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.applyButtonLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.applyButtonLayoutControlItem.TextVisible = false;
            // 
            // canEditToggleSwitchLayoutControlItem
            // 
            this.canEditToggleSwitchLayoutControlItem.Control = this.canEditToggleSwitch;
            this.canEditToggleSwitchLayoutControlItem.Location = new System.Drawing.Point(0, 102);
            this.canEditToggleSwitchLayoutControlItem.Name = "canEditToggleSwitchLayoutControlItem";
            this.canEditToggleSwitchLayoutControlItem.Size = new System.Drawing.Size(449, 32);
            this.canEditToggleSwitchLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.canEditToggleSwitchLayoutControlItem.Text = "Can user edit";
            this.canEditToggleSwitchLayoutControlItem.TextSize = new System.Drawing.Size(101, 13);
            // 
            // showAnswerToggleSwitchLayoutControlItem
            // 
            this.showAnswerToggleSwitchLayoutControlItem.Control = this.showAnswerToggleSwitch;
            this.showAnswerToggleSwitchLayoutControlItem.Location = new System.Drawing.Point(0, 134);
            this.showAnswerToggleSwitchLayoutControlItem.Name = "showAnswerToggleSwitchLayoutControlItem";
            this.showAnswerToggleSwitchLayoutControlItem.Size = new System.Drawing.Size(449, 32);
            this.showAnswerToggleSwitchLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.showAnswerToggleSwitchLayoutControlItem.Text = "Show correct answer";
            this.showAnswerToggleSwitchLayoutControlItem.TextSize = new System.Drawing.Size(101, 13);
            // 
            // cancelButtonLayoutControlItem
            // 
            this.cancelButtonLayoutControlItem.Control = this.cancelButton;
            this.cancelButtonLayoutControlItem.Location = new System.Drawing.Point(224, 166);
            this.cancelButtonLayoutControlItem.Name = "cancelButtonLayoutControlItem";
            this.cancelButtonLayoutControlItem.Size = new System.Drawing.Size(225, 61);
            this.cancelButtonLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.cancelButtonLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.cancelButtonLayoutControlItem.TextVisible = false;
            // 
            // mvvmSettingsContext
            // 
            this.mvvmSettingsContext.ContainerControl = this;
            this.mvvmSettingsContext.ViewModelType = typeof(Client.AdminSettings.AdminSettingsViewModel);
            // 
            // EditSettingsForm
            // 
            this.AcceptButton = this.applyButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(469, 247);
            this.Controls.Add(this.layoutControl1);
            this.Name = "EditSettingsForm";
            this.Text = "EditSettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showAnswerToggleSwitch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canEditToggleSwitch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeOfAskingEditTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencySpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionAmountTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionAmountLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeOfAskingLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applyButtonLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canEditToggleSwitchLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showAnswerToggleSwitchLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButtonLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmSettingsContext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SpinEdit frequencySpinEdit;
        private DevExpress.XtraEditors.SpinEdit questionAmountTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem questionAmountLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem frequencyLayoutControlItem;
        private DevExpress.XtraEditors.TimeEdit timeOfAskingEditTime;
        private DevExpress.XtraLayout.LayoutControlItem timeOfAskingLayoutControlItem;
        private DevExpress.Utils.MVVM.MVVMContext mvvmSettingsContext;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.SimpleButton applyButton;
        private DevExpress.XtraLayout.LayoutControlItem applyButtonLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem cancelButtonLayoutControlItem;
        private DevExpress.XtraEditors.ToggleSwitch showAnswerToggleSwitch;
        private DevExpress.XtraEditors.ToggleSwitch canEditToggleSwitch;
        private DevExpress.XtraLayout.LayoutControlItem canEditToggleSwitchLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem showAnswerToggleSwitchLayoutControlItem;
    }
}