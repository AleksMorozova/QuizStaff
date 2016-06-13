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
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.questionAmountTextEdit = new DevExpress.XtraEditors.SpinEdit();
            this.questionAmountLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.frequencySpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.frequencyLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.timeOfAskingEditTime = new DevExpress.XtraEditors.TimeEdit();
            this.timeOfAskingLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.mvvmSettingsContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.applyButton = new DevExpress.XtraEditors.SimpleButton();
            this.applyButtonLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButtonLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionAmountTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionAmountLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencySpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeOfAskingEditTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeOfAskingLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmSettingsContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applyButtonLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButtonLayoutControlItem)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
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
            this.layoutControl1.Size = new System.Drawing.Size(397, 310);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
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
            this.cancelButtonLayoutControlItem});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(397, 310);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // questionAmountTextEdit
            // 
            this.questionAmountTextEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.questionAmountTextEdit.Location = new System.Drawing.Point(103, 17);
            this.questionAmountTextEdit.Name = "questionAmountTextEdit";
            this.questionAmountTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.questionAmountTextEdit.Size = new System.Drawing.Size(277, 20);
            this.questionAmountTextEdit.StyleController = this.layoutControl1;
            this.questionAmountTextEdit.TabIndex = 4;
            // 
            // questionAmountLayoutControlItem
            // 
            this.questionAmountLayoutControlItem.Control = this.questionAmountTextEdit;
            this.questionAmountLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.questionAmountLayoutControlItem.Name = "questionAmountLayoutControlItem";
            this.questionAmountLayoutControlItem.Size = new System.Drawing.Size(377, 34);
            this.questionAmountLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.questionAmountLayoutControlItem.Text = "Question amount";
            this.questionAmountLayoutControlItem.TextSize = new System.Drawing.Size(82, 13);
            // 
            // frequencySpinEdit
            // 
            this.frequencySpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.frequencySpinEdit.Location = new System.Drawing.Point(103, 51);
            this.frequencySpinEdit.Name = "frequencySpinEdit";
            this.frequencySpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.frequencySpinEdit.Size = new System.Drawing.Size(277, 20);
            this.frequencySpinEdit.StyleController = this.layoutControl1;
            this.frequencySpinEdit.TabIndex = 5;
            // 
            // frequencyLayoutControlItem
            // 
            this.frequencyLayoutControlItem.Control = this.frequencySpinEdit;
            this.frequencyLayoutControlItem.Location = new System.Drawing.Point(0, 34);
            this.frequencyLayoutControlItem.Name = "frequencyLayoutControlItem";
            this.frequencyLayoutControlItem.Size = new System.Drawing.Size(377, 34);
            this.frequencyLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.frequencyLayoutControlItem.Text = "Frequency";
            this.frequencyLayoutControlItem.TextSize = new System.Drawing.Size(82, 13);
            // 
            // timeOfAskingEditTime
            // 
            this.timeOfAskingEditTime.EditValue = new System.DateTime(2016, 6, 13, 0, 0, 0, 0);
            this.timeOfAskingEditTime.Location = new System.Drawing.Point(103, 85);
            this.timeOfAskingEditTime.Name = "timeOfAskingEditTime";
            this.timeOfAskingEditTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeOfAskingEditTime.Size = new System.Drawing.Size(277, 20);
            this.timeOfAskingEditTime.StyleController = this.layoutControl1;
            this.timeOfAskingEditTime.TabIndex = 6;
            // 
            // timeOfAskingLayoutControlItem
            // 
            this.timeOfAskingLayoutControlItem.Control = this.timeOfAskingEditTime;
            this.timeOfAskingLayoutControlItem.Location = new System.Drawing.Point(0, 68);
            this.timeOfAskingLayoutControlItem.Name = "timeOfAskingLayoutControlItem";
            this.timeOfAskingLayoutControlItem.Size = new System.Drawing.Size(377, 34);
            this.timeOfAskingLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.timeOfAskingLayoutControlItem.Text = "Time of asking";
            this.timeOfAskingLayoutControlItem.TextSize = new System.Drawing.Size(82, 13);
            // 
            // mvvmSettingsContext
            // 
            this.mvvmSettingsContext.ContainerControl = this;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(17, 119);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(174, 22);
            this.applyButton.StyleController = this.layoutControl1;
            this.applyButton.TabIndex = 7;
            this.applyButton.Text = "Apply";
            // 
            // applyButtonLayoutControlItem
            // 
            this.applyButtonLayoutControlItem.Control = this.applyButton;
            this.applyButtonLayoutControlItem.Location = new System.Drawing.Point(0, 102);
            this.applyButtonLayoutControlItem.Name = "applyButtonLayoutControlItem";
            this.applyButtonLayoutControlItem.Size = new System.Drawing.Size(188, 188);
            this.applyButtonLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.applyButtonLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.applyButtonLayoutControlItem.TextVisible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(205, 119);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(175, 22);
            this.cancelButton.StyleController = this.layoutControl1;
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            // 
            // cancelButtonLayoutControlItem
            // 
            this.cancelButtonLayoutControlItem.Control = this.cancelButton;
            this.cancelButtonLayoutControlItem.Location = new System.Drawing.Point(188, 102);
            this.cancelButtonLayoutControlItem.Name = "cancelButtonLayoutControlItem";
            this.cancelButtonLayoutControlItem.Size = new System.Drawing.Size(189, 188);
            this.cancelButtonLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.cancelButtonLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.cancelButtonLayoutControlItem.TextVisible = false;
            // 
            // EditSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 310);
            this.Controls.Add(this.layoutControl1);
            this.Name = "EditSettingsForm";
            this.Text = "EditSettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionAmountTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionAmountLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencySpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeOfAskingEditTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeOfAskingLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmSettingsContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applyButtonLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButtonLayoutControlItem)).EndInit();
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
    }
}