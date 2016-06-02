namespace Client
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
            this.components = new System.ComponentModel.Container();
            this.flow = new System.Windows.Forms.FlowLayoutPanel();
            this.labelQuestion = new Client.WrappingLabel();
            this.buttonSend = new DevExpress.XtraEditors.SimpleButton();
            this.mvvmQuestionContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.flow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmQuestionContext)).BeginInit();
            this.SuspendLayout();
            // 
            // flow
            // 
            this.flow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flow.AutoScroll = true;
            this.flow.Controls.Add(this.labelQuestion);
            this.flow.Location = new System.Drawing.Point(0, 0);
            this.flow.Name = "flow";
            this.flow.Padding = new System.Windows.Forms.Padding(20, 20, 20, 2);
            this.flow.Size = new System.Drawing.Size(383, 410);
            this.flow.TabIndex = 0;
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelQuestion.Location = new System.Drawing.Point(23, 20);
            this.labelQuestion.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(72, 19);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "Question";
            // 
            // buttonSend
            // 
            this.buttonSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSend.Location = new System.Drawing.Point(276, 416);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(96, 33);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Text = "Send";
            // 
            // mvvmQuestionContext
            // 
            this.mvvmQuestionContext.ContainerControl = this;
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.flow);
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "QuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Question";
            this.Load += new System.EventHandler(this.QuestionForm_Load);
            this.flow.ResumeLayout(false);
            this.flow.PerformLayout();
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