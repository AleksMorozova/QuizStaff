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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionForm));
            this.flow = new System.Windows.Forms.FlowLayoutPanel();
            this.labelQuestion = new TesteeApplication.WrappingLabel();
            this.buttonSend = new DevExpress.XtraEditors.SimpleButton();
            this.mvvmQuestionContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.flow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmQuestionContext)).BeginInit();
            this.SuspendLayout();
            // 
            // flow
            // 
            this.flow.Controls.Add(this.labelQuestion);
            resources.ApplyResources(this.flow, "flow");
            this.flow.Name = "flow";
            // 
            // labelQuestion
            // 
            resources.ApplyResources(this.labelQuestion, "labelQuestion");
            this.labelQuestion.Name = "labelQuestion";
            // 
            // buttonSend
            // 
            this.buttonSend.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("buttonSend.Appearance.Font")));
            this.buttonSend.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.buttonSend, "buttonSend");
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // mvvmQuestionContext
            // 
            this.mvvmQuestionContext.ContainerControl = this;
            // 
            // QuestionForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.flow);
            this.Name = "QuestionForm";
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