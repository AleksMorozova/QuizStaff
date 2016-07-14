namespace AdminApplication.AdminSettings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSettingsForm));
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
            this.mvvmSettingsContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
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
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.UseDefaultDragAndDropRendering = false;
            this.layoutControl1.Root = this.layoutControlGroup1;
            // 
            // showAnswerToggleSwitch
            // 
            resources.ApplyResources(this.showAnswerToggleSwitch, "showAnswerToggleSwitch");
            this.showAnswerToggleSwitch.Name = "showAnswerToggleSwitch";
            this.showAnswerToggleSwitch.Properties.OffText = resources.GetString("showAnswerToggleSwitch.Properties.OffText");
            this.showAnswerToggleSwitch.Properties.OnText = resources.GetString("showAnswerToggleSwitch.Properties.OnText");
            this.showAnswerToggleSwitch.StyleController = this.layoutControl1;
            // 
            // canEditToggleSwitch
            // 
            resources.ApplyResources(this.canEditToggleSwitch, "canEditToggleSwitch");
            this.canEditToggleSwitch.Name = "canEditToggleSwitch";
            this.canEditToggleSwitch.Properties.OffText = resources.GetString("canEditToggleSwitch.Properties.OffText");
            this.canEditToggleSwitch.Properties.OnText = resources.GetString("canEditToggleSwitch.Properties.OnText");
            this.canEditToggleSwitch.StyleController = this.layoutControl1;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.StyleController = this.layoutControl1;
            // 
            // applyButton
            // 
            this.applyButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.applyButton, "applyButton");
            this.applyButton.Name = "applyButton";
            this.applyButton.StyleController = this.layoutControl1;
            // 
            // timeOfAskingEditTime
            // 
            resources.ApplyResources(this.timeOfAskingEditTime, "timeOfAskingEditTime");
            this.timeOfAskingEditTime.Name = "timeOfAskingEditTime";
            this.timeOfAskingEditTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("timeOfAskingEditTime.Properties.Buttons"))))});
            this.timeOfAskingEditTime.Properties.Mask.EditMask = resources.GetString("timeOfAskingEditTime.Properties.Mask.EditMask");
            this.timeOfAskingEditTime.StyleController = this.layoutControl1;
            // 
            // frequencySpinEdit
            // 
            resources.ApplyResources(this.frequencySpinEdit, "frequencySpinEdit");
            this.frequencySpinEdit.Name = "frequencySpinEdit";
            this.frequencySpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("frequencySpinEdit.Properties.Buttons"))))});
            this.frequencySpinEdit.StyleController = this.layoutControl1;
            // 
            // questionAmountTextEdit
            // 
            resources.ApplyResources(this.questionAmountTextEdit, "questionAmountTextEdit");
            this.questionAmountTextEdit.Name = "questionAmountTextEdit";
            this.questionAmountTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("questionAmountTextEdit.Properties.Buttons"))))});
            this.questionAmountTextEdit.StyleController = this.layoutControl1;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(319, 227);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // frequencyLayoutControlItem
            // 
            this.frequencyLayoutControlItem.Control = this.frequencySpinEdit;
            this.frequencyLayoutControlItem.Location = new System.Drawing.Point(0, 34);
            this.frequencyLayoutControlItem.Name = "frequencyLayoutControlItem";
            this.frequencyLayoutControlItem.Size = new System.Drawing.Size(299, 34);
            this.frequencyLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            resources.ApplyResources(this.frequencyLayoutControlItem, "frequencyLayoutControlItem");
            this.frequencyLayoutControlItem.TextSize = new System.Drawing.Size(101, 13);
            // 
            // questionAmountLayoutControlItem
            // 
            this.questionAmountLayoutControlItem.Control = this.questionAmountTextEdit;
            this.questionAmountLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.questionAmountLayoutControlItem.Name = "questionAmountLayoutControlItem";
            this.questionAmountLayoutControlItem.Size = new System.Drawing.Size(299, 34);
            this.questionAmountLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            resources.ApplyResources(this.questionAmountLayoutControlItem, "questionAmountLayoutControlItem");
            this.questionAmountLayoutControlItem.TextSize = new System.Drawing.Size(101, 13);
            // 
            // timeOfAskingLayoutControlItem
            // 
            this.timeOfAskingLayoutControlItem.Control = this.timeOfAskingEditTime;
            this.timeOfAskingLayoutControlItem.Location = new System.Drawing.Point(0, 68);
            this.timeOfAskingLayoutControlItem.Name = "timeOfAskingLayoutControlItem";
            this.timeOfAskingLayoutControlItem.Size = new System.Drawing.Size(299, 34);
            this.timeOfAskingLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            resources.ApplyResources(this.timeOfAskingLayoutControlItem, "timeOfAskingLayoutControlItem");
            this.timeOfAskingLayoutControlItem.TextSize = new System.Drawing.Size(101, 13);
            // 
            // applyButtonLayoutControlItem
            // 
            this.applyButtonLayoutControlItem.Control = this.applyButton;
            this.applyButtonLayoutControlItem.Location = new System.Drawing.Point(0, 166);
            this.applyButtonLayoutControlItem.Name = "applyButtonLayoutControlItem";
            this.applyButtonLayoutControlItem.Size = new System.Drawing.Size(150, 41);
            this.applyButtonLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.applyButtonLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.applyButtonLayoutControlItem.TextVisible = false;
            // 
            // canEditToggleSwitchLayoutControlItem
            // 
            this.canEditToggleSwitchLayoutControlItem.Control = this.canEditToggleSwitch;
            this.canEditToggleSwitchLayoutControlItem.Location = new System.Drawing.Point(0, 102);
            this.canEditToggleSwitchLayoutControlItem.Name = "canEditToggleSwitchLayoutControlItem";
            this.canEditToggleSwitchLayoutControlItem.Size = new System.Drawing.Size(299, 32);
            this.canEditToggleSwitchLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 2, 2, 2);
            resources.ApplyResources(this.canEditToggleSwitchLayoutControlItem, "canEditToggleSwitchLayoutControlItem");
            this.canEditToggleSwitchLayoutControlItem.TextSize = new System.Drawing.Size(101, 13);
            // 
            // showAnswerToggleSwitchLayoutControlItem
            // 
            this.showAnswerToggleSwitchLayoutControlItem.Control = this.showAnswerToggleSwitch;
            this.showAnswerToggleSwitchLayoutControlItem.Location = new System.Drawing.Point(0, 134);
            this.showAnswerToggleSwitchLayoutControlItem.Name = "showAnswerToggleSwitchLayoutControlItem";
            this.showAnswerToggleSwitchLayoutControlItem.Size = new System.Drawing.Size(299, 32);
            this.showAnswerToggleSwitchLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 2, 2, 2);
            resources.ApplyResources(this.showAnswerToggleSwitchLayoutControlItem, "showAnswerToggleSwitchLayoutControlItem");
            this.showAnswerToggleSwitchLayoutControlItem.TextSize = new System.Drawing.Size(101, 13);
            // 
            // cancelButtonLayoutControlItem
            // 
            this.cancelButtonLayoutControlItem.Control = this.cancelButton;
            this.cancelButtonLayoutControlItem.Location = new System.Drawing.Point(150, 166);
            this.cancelButtonLayoutControlItem.Name = "cancelButtonLayoutControlItem";
            this.cancelButtonLayoutControlItem.Size = new System.Drawing.Size(149, 41);
            this.cancelButtonLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.cancelButtonLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.cancelButtonLayoutControlItem.TextVisible = false;
            // 
            // mvvmSettingsContext
            // 
            this.mvvmSettingsContext.ContainerControl = this;
            this.mvvmSettingsContext.ViewModelType = typeof(AdminApplication.AdminSettings.AdminSettingsViewModel);
            // 
            // EditSettingsForm
            // 
            this.AcceptButton = this.applyButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.Controls.Add(this.layoutControl1);
            this.Name = "EditSettingsForm";
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