namespace TesteeApplication
{
    partial class QuestionForm
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
            this.flow = new System.Windows.Forms.FlowLayoutPanel();
            this.labelQuestion = new TesteeApplication.WrappingLabel();
            this.buttonSend = new DevExpress.XtraEditors.SimpleButton();
            this.mvvmQuestionContext = new DevExpress.Utils.MVVM.MVVMContext();
            this.flow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmQuestionContext)).BeginInit();
            this.SuspendLayout();
            // 
            // flow
            // 
            this.flow.Controls.Add(this.labelQuestion);
            this.flow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.flow.Location = new System.Drawing.Point(0, 3);
            this.flow.Name = "flow";
            this.flow.Size = new System.Drawing.Size(308, 321);
            this.flow.TabIndex = 1;
            // 
            // labelQuestion
            // 
            this.labelQuestion.Location = new System.Drawing.Point(3, 0);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(372, 0);
            this.labelQuestion.TabIndex = 0;
            // 
            // buttonSend
            // 
            this.buttonSend.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.buttonSend.Appearance.Options.UseFont = true;
            this.buttonSend.Location = new System.Drawing.Point(113, 330);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(89, 37);
            this.buttonSend.TabIndex = 0;
            this.buttonSend.Text = "OK";
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // mvvmQuestionContext
            // 
            this.mvvmQuestionContext.ContainerControl = this;
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 372);
            this.ControlBox = false;
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.flow);
            this.Name = "QuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuestionForm_FormClosing);
            this.Load += new System.EventHandler(this.QuestionForm_Load);
            this.flow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmQuestionContext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flow;
        private DevExpress.XtraEditors.SimpleButton buttonSend;
        private WrappingLabel labelQuestion;
        private DevExpress.Utils.MVVM.MVVMContext mvvmQuestionContext;






    }
}