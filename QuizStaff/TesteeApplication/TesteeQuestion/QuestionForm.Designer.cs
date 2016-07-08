﻿namespace TesteeApplication
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
            this.buttonSend = new DevExpress.XtraEditors.SimpleButton();
            this.mvvmQuestionContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.labelQuestion = new TesteeApplication.WrappingLabel();
            this.flow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmQuestionContext)).BeginInit();
            this.SuspendLayout();
            // 
            // flow
            // 
            this.flow.Controls.Add(this.labelQuestion);
            this.flow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.flow.Location = new System.Drawing.Point(0, 0);
            this.flow.Name = "flow";
            this.flow.Size = new System.Drawing.Size(308, 338);
            this.flow.TabIndex = 1;
            // 
            // buttonSend
            // 
            this.buttonSend.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.buttonSend.Appearance.Options.UseFont = true;
            this.buttonSend.Location = new System.Drawing.Point(222, 344);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 0;
            this.buttonSend.Text = "Send";
            // 
            // mvvmQuestionContext
            // 
            this.mvvmQuestionContext.ContainerControl = this;
            // 
            // labelQuestion
            // 
            this.labelQuestion.Location = new System.Drawing.Point(3, 0);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(100, 0);
            this.labelQuestion.TabIndex = 0;
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 372);
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