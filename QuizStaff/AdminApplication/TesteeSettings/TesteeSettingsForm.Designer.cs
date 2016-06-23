namespace AdminApplication.TesteeSettings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TesteeSettingsForm));
            this.MainLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.frequencySpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.timeOfAskingEditTime = new DevExpress.XtraEditors.TimeEdit();
            this.questionAmountSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlSaveButton = new DevExpress.XtraLayout.LayoutControlItem();
            this.questionAmountSpinEditLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.timeOfAskingEditTimeLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlCancelButton = new DevExpress.XtraLayout.LayoutControlItem();
            this.frequencySpinEditLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.mvvmTesteeSettingsContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.languageComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.languageLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.MainLayoutControl)).BeginInit();
            this.MainLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frequencySpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeOfAskingEditTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionAmountSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlSaveButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionAmountSpinEditLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeOfAskingEditTimeLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCancelButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencySpinEditLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmTesteeSettingsContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageLayoutControlItem)).BeginInit();
            this.SuspendLayout();
            // 
            // MainLayoutControl
            // 
            this.MainLayoutControl.Controls.Add(this.languageComboBoxEdit);
            this.MainLayoutControl.Controls.Add(this.frequencySpinEdit);
            this.MainLayoutControl.Controls.Add(this.timeOfAskingEditTime);
            this.MainLayoutControl.Controls.Add(this.questionAmountSpinEdit);
            this.MainLayoutControl.Controls.Add(this.saveButton);
            this.MainLayoutControl.Controls.Add(this.cancelButton);
            resources.ApplyResources(this.MainLayoutControl, "MainLayoutControl");
            this.MainLayoutControl.Name = "MainLayoutControl";
            this.MainLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(457, 42, 580, 350);
            this.MainLayoutControl.Root = this.layoutControlGroup1;
            // 
            // frequencySpinEdit
            // 
            resources.ApplyResources(this.frequencySpinEdit, "frequencySpinEdit");
            this.frequencySpinEdit.Name = "frequencySpinEdit";
            this.frequencySpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("frequencySpinEdit.Properties.Buttons"))))});
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
            this.frequencySpinEdit.StyleController = this.MainLayoutControl;
            // 
            // timeOfAskingEditTime
            // 
            resources.ApplyResources(this.timeOfAskingEditTime, "timeOfAskingEditTime");
            this.timeOfAskingEditTime.Name = "timeOfAskingEditTime";
            this.timeOfAskingEditTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("timeOfAskingEditTime.Properties.Buttons"))))});
            this.timeOfAskingEditTime.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("timeOfAskingEditTime.Properties.Mask.BeepOnError")));
            this.timeOfAskingEditTime.Properties.Mask.EditMask = resources.GetString("timeOfAskingEditTime.Properties.Mask.EditMask");
            this.timeOfAskingEditTime.StyleController = this.MainLayoutControl;
            // 
            // questionAmountSpinEdit
            // 
            resources.ApplyResources(this.questionAmountSpinEdit, "questionAmountSpinEdit");
            this.questionAmountSpinEdit.Name = "questionAmountSpinEdit";
            this.questionAmountSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("questionAmountSpinEdit.Properties.Buttons"))))});
            this.questionAmountSpinEdit.Properties.IsFloatValue = false;
            this.questionAmountSpinEdit.Properties.Mask.EditMask = resources.GetString("questionAmountSpinEdit.Properties.Mask.EditMask");
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
            this.questionAmountSpinEdit.StyleController = this.MainLayoutControl;
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.StyleController = this.MainLayoutControl;
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.StyleController = this.MainLayoutControl;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlSaveButton,
            this.questionAmountSpinEditLayoutControlItem,
            this.timeOfAskingEditTimeLayoutControlItem,
            this.layoutControlCancelButton,
            this.frequencySpinEditLayoutControlItem,
            this.languageLayoutControlItem});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(288, 251);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlSaveButton
            // 
            this.layoutControlSaveButton.Control = this.saveButton;
            this.layoutControlSaveButton.Location = new System.Drawing.Point(0, 200);
            this.layoutControlSaveButton.Name = "layoutControlSaveButton";
            this.layoutControlSaveButton.Size = new System.Drawing.Size(130, 31);
            this.layoutControlSaveButton.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 0);
            this.layoutControlSaveButton.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlSaveButton.TextVisible = false;
            // 
            // questionAmountSpinEditLayoutControlItem
            // 
            this.questionAmountSpinEditLayoutControlItem.Control = this.questionAmountSpinEdit;
            this.questionAmountSpinEditLayoutControlItem.Location = new System.Drawing.Point(0, 50);
            this.questionAmountSpinEditLayoutControlItem.Name = "questionAmountSpinEditLayoutControlItem";
            this.questionAmountSpinEditLayoutControlItem.Size = new System.Drawing.Size(268, 50);
            this.questionAmountSpinEditLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 5);
            resources.ApplyResources(this.questionAmountSpinEditLayoutControlItem, "questionAmountSpinEditLayoutControlItem");
            this.questionAmountSpinEditLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.questionAmountSpinEditLayoutControlItem.TextSize = new System.Drawing.Size(101, 13);
            // 
            // timeOfAskingEditTimeLayoutControlItem
            // 
            this.timeOfAskingEditTimeLayoutControlItem.Control = this.timeOfAskingEditTime;
            resources.ApplyResources(this.timeOfAskingEditTimeLayoutControlItem, "timeOfAskingEditTimeLayoutControlItem");
            this.timeOfAskingEditTimeLayoutControlItem.Location = new System.Drawing.Point(0, 100);
            this.timeOfAskingEditTimeLayoutControlItem.Name = "timeOfAskingEditTimeLayoutControlItem";
            this.timeOfAskingEditTimeLayoutControlItem.Size = new System.Drawing.Size(268, 50);
            this.timeOfAskingEditTimeLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 5);
            this.timeOfAskingEditTimeLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.timeOfAskingEditTimeLayoutControlItem.TextSize = new System.Drawing.Size(101, 13);
            // 
            // layoutControlCancelButton
            // 
            this.layoutControlCancelButton.Control = this.cancelButton;
            this.layoutControlCancelButton.Location = new System.Drawing.Point(130, 200);
            this.layoutControlCancelButton.Name = "layoutControlCancelButton";
            this.layoutControlCancelButton.Size = new System.Drawing.Size(138, 31);
            this.layoutControlCancelButton.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 0);
            this.layoutControlCancelButton.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlCancelButton.TextVisible = false;
            // 
            // frequencySpinEditLayoutControlItem
            // 
            this.frequencySpinEditLayoutControlItem.Control = this.frequencySpinEdit;
            resources.ApplyResources(this.frequencySpinEditLayoutControlItem, "frequencySpinEditLayoutControlItem");
            this.frequencySpinEditLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.frequencySpinEditLayoutControlItem.Name = "frequencySpinEditLayoutControlItem";
            this.frequencySpinEditLayoutControlItem.Size = new System.Drawing.Size(268, 50);
            this.frequencySpinEditLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 5);
            this.frequencySpinEditLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.frequencySpinEditLayoutControlItem.TextSize = new System.Drawing.Size(101, 13);
            // 
            // mvvmTesteeSettingsContext
            // 
            this.mvvmTesteeSettingsContext.ContainerControl = this;
            // 
            // languageComboBoxEdit
            // 
            resources.ApplyResources(this.languageComboBoxEdit, "languageComboBoxEdit");
            this.languageComboBoxEdit.Name = "languageComboBoxEdit";
            this.languageComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("comboBoxEdit1.Properties.Buttons"))))});
            this.languageComboBoxEdit.StyleController = this.MainLayoutControl;
            this.languageComboBoxEdit.SelectedIndexChanged += new System.EventHandler(this.languageComboBoxEdit_SelectedIndexChanged);
            // 
            // languageLayoutControlItem
            // 
            this.languageLayoutControlItem.Control = this.languageComboBoxEdit;
            this.languageLayoutControlItem.Location = new System.Drawing.Point(0, 150);
            this.languageLayoutControlItem.Name = "languageLayoutControlItem";
            this.languageLayoutControlItem.Size = new System.Drawing.Size(268, 50);
            this.languageLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 5);
            resources.ApplyResources(this.languageLayoutControlItem, "languageLayoutControlItem");
            this.languageLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.languageLayoutControlItem.TextSize = new System.Drawing.Size(101, 13);
            // 
            // TesteeSettingsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainLayoutControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TesteeSettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.MainLayoutControl)).EndInit();
            this.MainLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.frequencySpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeOfAskingEditTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionAmountSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlSaveButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionAmountSpinEditLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeOfAskingEditTimeLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCancelButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencySpinEditLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmTesteeSettingsContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageLayoutControlItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl MainLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlCancelButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlSaveButton;
        private DevExpress.XtraEditors.SpinEdit questionAmountSpinEdit;
        private DevExpress.XtraLayout.LayoutControlItem questionAmountSpinEditLayoutControlItem;
        private DevExpress.XtraEditors.TimeEdit timeOfAskingEditTime;
        private DevExpress.XtraLayout.LayoutControlItem timeOfAskingEditTimeLayoutControlItem;
        private DevExpress.Utils.MVVM.MVVMContext mvvmTesteeSettingsContext;
        private DevExpress.XtraEditors.SpinEdit frequencySpinEdit;
        private DevExpress.XtraLayout.LayoutControlItem frequencySpinEditLayoutControlItem;
        private DevExpress.XtraEditors.ComboBoxEdit languageComboBoxEdit;
        private DevExpress.XtraLayout.LayoutControlItem languageLayoutControlItem;
    }
}