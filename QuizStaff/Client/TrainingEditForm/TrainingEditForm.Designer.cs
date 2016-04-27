namespace Client
{
    partial class TrainingEditForm
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
            this.labelTraining = new DevExpress.XtraEditors.LabelControl();
            this.gridQuestions = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.QuestionText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textTrainingName = new DevExpress.XtraEditors.TextEdit();
            this.buttonAddQuestion = new System.Windows.Forms.Button();
            this.buttonEditQuestion = new System.Windows.Forms.Button();
            this.buttonLoadQuestion = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTrainingName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTraining
            // 
            this.labelTraining.Location = new System.Drawing.Point(12, 12);
            this.labelTraining.Name = "labelTraining";
            this.labelTraining.Size = new System.Drawing.Size(63, 13);
            this.labelTraining.TabIndex = 0;
            this.labelTraining.Text = "labelControl1";
            // 
            // gridQuestions
            // 
            this.gridQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridQuestions.Location = new System.Drawing.Point(12, 86);
            this.gridQuestions.MainView = this.gridView1;
            this.gridQuestions.Name = "gridQuestions";
            this.gridQuestions.Size = new System.Drawing.Size(430, 200);
            this.gridQuestions.TabIndex = 1;
            this.gridQuestions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridQuestions.DoubleClick += new System.EventHandler(this.gridQuestions_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.QuestionText});
            this.gridView1.GridControl = this.gridQuestions;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // QuestionText
            // 
            this.QuestionText.Caption = "Question";
            this.QuestionText.FieldName = "QuestionText";
            this.QuestionText.Name = "QuestionText";
            this.QuestionText.Visible = true;
            this.QuestionText.VisibleIndex = 0;
            // 
            // textTrainingName
            // 
            this.textTrainingName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textTrainingName.Location = new System.Drawing.Point(12, 31);
            this.textTrainingName.Name = "textTrainingName";
            this.textTrainingName.Size = new System.Drawing.Size(433, 20);
            this.textTrainingName.TabIndex = 2;
            // 
            // buttonAddQuestion
            // 
            this.buttonAddQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddQuestion.Location = new System.Drawing.Point(178, 57);
            this.buttonAddQuestion.Name = "buttonAddQuestion";
            this.buttonAddQuestion.Size = new System.Drawing.Size(85, 23);
            this.buttonAddQuestion.TabIndex = 3;
            this.buttonAddQuestion.Text = "Add Question";
            this.buttonAddQuestion.UseVisualStyleBackColor = true;
            this.buttonAddQuestion.Click += new System.EventHandler(this.buttonAddQuestion_Click);
            // 
            // buttonEditQuestion
            // 
            this.buttonEditQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditQuestion.Location = new System.Drawing.Point(269, 57);
            this.buttonEditQuestion.Name = "buttonEditQuestion";
            this.buttonEditQuestion.Size = new System.Drawing.Size(85, 23);
            this.buttonEditQuestion.TabIndex = 4;
            this.buttonEditQuestion.Text = "Edit Question";
            this.buttonEditQuestion.UseVisualStyleBackColor = true;
            this.buttonEditQuestion.Click += new System.EventHandler(this.buttonEditQuestion_Click);
            // 
            // buttonLoadQuestion
            // 
            this.buttonLoadQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadQuestion.Location = new System.Drawing.Point(360, 57);
            this.buttonLoadQuestion.Name = "buttonLoadQuestion";
            this.buttonLoadQuestion.Size = new System.Drawing.Size(85, 23);
            this.buttonLoadQuestion.TabIndex = 5;
            this.buttonLoadQuestion.Text = "Load Question";
            this.buttonLoadQuestion.UseVisualStyleBackColor = true;
            this.buttonLoadQuestion.Click += new System.EventHandler(this.buttonLoadQuestion_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(269, 292);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(85, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(360, 292);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(85, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // TrainingEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 326);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoadQuestion);
            this.Controls.Add(this.buttonEditQuestion);
            this.Controls.Add(this.buttonAddQuestion);
            this.Controls.Add(this.textTrainingName);
            this.Controls.Add(this.gridQuestions);
            this.Controls.Add(this.labelTraining);
            this.Name = "TrainingEditForm";
            this.Text = "TrainingEditForm";
            this.Load += new System.EventHandler(this.TrainingEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTrainingName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelTraining;
        private DevExpress.XtraGrid.GridControl gridQuestions;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit textTrainingName;
        private System.Windows.Forms.Button buttonAddQuestion;
        private System.Windows.Forms.Button buttonEditQuestion;
        private System.Windows.Forms.Button buttonLoadQuestion;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private DevExpress.XtraGrid.Columns.GridColumn QuestionText;

    }
}