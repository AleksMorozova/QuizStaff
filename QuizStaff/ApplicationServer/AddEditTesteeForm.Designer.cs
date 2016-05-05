namespace ApplicationServer
{
    partial class AddEditTesteeForm
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
            this.buttonAddTraining = new DevExpress.XtraEditors.SimpleButton();
            this.textEditFirstName = new DevExpress.XtraEditors.TextEdit();
            this.textEditLastName = new DevExpress.XtraEditors.TextEdit();
            this.labelFirstName = new DevExpress.XtraEditors.LabelControl();
            this.labelLastName = new DevExpress.XtraEditors.LabelControl();
            this.labelEmail = new DevExpress.XtraEditors.LabelControl();
            this.labelLogin = new DevExpress.XtraEditors.LabelControl();
            this.textEditEmail = new DevExpress.XtraEditors.TextEdit();
            this.textEditLogin = new DevExpress.XtraEditors.TextEdit();
            this.labelTranings = new DevExpress.XtraEditors.LabelControl();
            this.gridControlTrainings = new DevExpress.XtraGrid.GridControl();
            this.gridViewTrainings = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.spinEditQuestAmountValue = new DevExpress.XtraEditors.SpinEdit();
            this.labelQuestionAmount = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.spinEditFreqOfAskingValue = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTrainings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTrainings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditQuestAmountValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditFreqOfAskingValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddTraining
            // 
            this.buttonAddTraining.Location = new System.Drawing.Point(437, 119);
            this.buttonAddTraining.Name = "buttonAddTraining";
            this.buttonAddTraining.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTraining.TabIndex = 0;
            this.buttonAddTraining.Text = "Add training";
            // 
            // textEditFirstName
            // 
            this.textEditFirstName.Location = new System.Drawing.Point(12, 36);
            this.textEditFirstName.Name = "textEditFirstName";
            this.textEditFirstName.Size = new System.Drawing.Size(254, 20);
            this.textEditFirstName.TabIndex = 1;
            // 
            // textEditLastName
            // 
            this.textEditLastName.Location = new System.Drawing.Point(272, 36);
            this.textEditLastName.Name = "textEditLastName";
            this.textEditLastName.Size = new System.Drawing.Size(241, 20);
            this.textEditLastName.TabIndex = 2;
            // 
            // labelFirstName
            // 
            this.labelFirstName.Location = new System.Drawing.Point(13, 13);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(54, 13);
            this.labelFirstName.TabIndex = 3;
            this.labelFirstName.Text = "First name:";
            // 
            // labelLastName
            // 
            this.labelLastName.Location = new System.Drawing.Point(272, 17);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(53, 13);
            this.labelLastName.TabIndex = 4;
            this.labelLastName.Text = "Last name:";
            // 
            // labelEmail
            // 
            this.labelEmail.Location = new System.Drawing.Point(271, 66);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "E-mail:";
            // 
            // labelLogin
            // 
            this.labelLogin.Location = new System.Drawing.Point(12, 62);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(29, 13);
            this.labelLogin.TabIndex = 7;
            this.labelLogin.Text = "Login:";
            // 
            // textEditEmail
            // 
            this.textEditEmail.Location = new System.Drawing.Point(271, 85);
            this.textEditEmail.Name = "textEditEmail";
            this.textEditEmail.Size = new System.Drawing.Size(241, 20);
            this.textEditEmail.TabIndex = 6;
            // 
            // textEditLogin
            // 
            this.textEditLogin.Location = new System.Drawing.Point(11, 85);
            this.textEditLogin.Name = "textEditLogin";
            this.textEditLogin.Size = new System.Drawing.Size(254, 20);
            this.textEditLogin.TabIndex = 5;
            // 
            // labelTranings
            // 
            this.labelTranings.Location = new System.Drawing.Point(11, 129);
            this.labelTranings.Name = "labelTranings";
            this.labelTranings.Size = new System.Drawing.Size(45, 13);
            this.labelTranings.TabIndex = 9;
            this.labelTranings.Text = "Tranings:";
            // 
            // gridControlTrainings
            // 
            this.gridControlTrainings.Location = new System.Drawing.Point(11, 148);
            this.gridControlTrainings.MainView = this.gridViewTrainings;
            this.gridControlTrainings.Name = "gridControlTrainings";
            this.gridControlTrainings.Size = new System.Drawing.Size(501, 142);
            this.gridControlTrainings.TabIndex = 10;
            this.gridControlTrainings.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTrainings});
            // 
            // gridViewTrainings
            // 
            this.gridViewTrainings.GridControl = this.gridControlTrainings;
            this.gridViewTrainings.Name = "gridViewTrainings";
            // 
            // spinEditQuestAmountValue
            // 
            this.spinEditQuestAmountValue.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditQuestAmountValue.Location = new System.Drawing.Point(103, 306);
            this.spinEditQuestAmountValue.Name = "spinEditQuestAmountValue";
            this.spinEditQuestAmountValue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditQuestAmountValue.Size = new System.Drawing.Size(50, 20);
            this.spinEditQuestAmountValue.TabIndex = 11;
            // 
            // labelQuestionAmount
            // 
            this.labelQuestionAmount.Location = new System.Drawing.Point(11, 309);
            this.labelQuestionAmount.Name = "labelQuestionAmount";
            this.labelQuestionAmount.Size = new System.Drawing.Size(86, 13);
            this.labelQuestionAmount.TabIndex = 12;
            this.labelQuestionAmount.Text = "Question amount:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(174, 309);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(101, 13);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Frequency of asking:";
            // 
            // spinEditFreqOfAskingValue
            // 
            this.spinEditFreqOfAskingValue.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditFreqOfAskingValue.Location = new System.Drawing.Point(281, 306);
            this.spinEditFreqOfAskingValue.Name = "spinEditFreqOfAskingValue";
            this.spinEditFreqOfAskingValue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditFreqOfAskingValue.Size = new System.Drawing.Size(50, 20);
            this.spinEditFreqOfAskingValue.TabIndex = 13;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(344, 309);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 13);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "User can edit:";
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.Location = new System.Drawing.Point(417, 304);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Properties.OffText = "Off";
            this.toggleSwitch1.Properties.OnText = "On";
            this.toggleSwitch1.Size = new System.Drawing.Size(95, 24);
            this.toggleSwitch1.TabIndex = 16;
            // 
            // AddEditTesteeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 343);
            this.Controls.Add(this.toggleSwitch1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.spinEditFreqOfAskingValue);
            this.Controls.Add(this.labelQuestionAmount);
            this.Controls.Add(this.spinEditQuestAmountValue);
            this.Controls.Add(this.gridControlTrainings);
            this.Controls.Add(this.labelTranings);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textEditEmail);
            this.Controls.Add(this.textEditLogin);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textEditLastName);
            this.Controls.Add(this.textEditFirstName);
            this.Controls.Add(this.buttonAddTraining);
            this.Name = "AddEditTesteeForm";
            this.Text = "Add/Edit testee";
            ((System.ComponentModel.ISupportInitialize)(this.textEditFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTrainings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTrainings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditQuestAmountValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditFreqOfAskingValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton buttonAddTraining;
        private DevExpress.XtraEditors.TextEdit textEditFirstName;
        private DevExpress.XtraEditors.TextEdit textEditLastName;
        private DevExpress.XtraEditors.LabelControl labelFirstName;
        private DevExpress.XtraEditors.LabelControl labelLastName;
        private DevExpress.XtraEditors.LabelControl labelEmail;
        private DevExpress.XtraEditors.LabelControl labelLogin;
        private DevExpress.XtraEditors.TextEdit textEditEmail;
        private DevExpress.XtraEditors.TextEdit textEditLogin;
        private DevExpress.XtraEditors.LabelControl labelTranings;
        private DevExpress.XtraGrid.GridControl gridControlTrainings;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTrainings;
        private DevExpress.XtraEditors.SpinEdit spinEditQuestAmountValue;
        private DevExpress.XtraEditors.LabelControl labelQuestionAmount;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SpinEdit spinEditFreqOfAskingValue;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;

    }
}