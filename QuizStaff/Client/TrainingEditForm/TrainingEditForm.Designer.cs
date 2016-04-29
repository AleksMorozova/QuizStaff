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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.gridQuestions = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.QuestionText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.buttonLoadQuestion = new System.Windows.Forms.Button();
            this.buttonEditQuestion = new System.Windows.Forms.Button();
            this.buttonAddQuestion = new System.Windows.Forms.Button();
            this.textTrainingName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.buttonAddControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.buttonEditControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.buttonLoadControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.questionsControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.buttonCancelControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.buttonSaveControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTrainingName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonAddControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLoadControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCancelControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSaveControlItem)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.buttonCancel);
            this.layoutControl1.Controls.Add(this.buttonSave);
            this.layoutControl1.Controls.Add(this.gridQuestions);
            this.layoutControl1.Controls.Add(this.buttonLoadQuestion);
            this.layoutControl1.Controls.Add(this.buttonEditQuestion);
            this.layoutControl1.Controls.Add(this.buttonAddQuestion);
            this.layoutControl1.Controls.Add(this.textTrainingName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(618, 132, 674, 544);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(776, 416);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(653, 381);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(111, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(543, 381);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(106, 23);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // gridQuestions
            // 
            this.gridQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridQuestions.Location = new System.Drawing.Point(12, 79);
            this.gridQuestions.MainView = this.gridView1;
            this.gridQuestions.Name = "gridQuestions";
            this.gridQuestions.Size = new System.Drawing.Size(752, 298);
            this.gridQuestions.TabIndex = 9;
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
            this.QuestionText.OptionsColumn.AllowEdit = false;
            this.QuestionText.OptionsColumn.AllowFocus = false;
            this.QuestionText.OptionsColumn.ReadOnly = true;
            this.QuestionText.Visible = true;
            this.QuestionText.VisibleIndex = 0;
            // 
            // buttonLoadQuestion
            // 
            this.buttonLoadQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadQuestion.Location = new System.Drawing.Point(653, 52);
            this.buttonLoadQuestion.Name = "buttonLoadQuestion";
            this.buttonLoadQuestion.Size = new System.Drawing.Size(111, 23);
            this.buttonLoadQuestion.TabIndex = 8;
            this.buttonLoadQuestion.Text = "Load Question";
            this.buttonLoadQuestion.UseVisualStyleBackColor = true;
            this.buttonLoadQuestion.Click += new System.EventHandler(this.buttonLoadQuestion_Click);
            // 
            // buttonEditQuestion
            // 
            this.buttonEditQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditQuestion.Location = new System.Drawing.Point(543, 52);
            this.buttonEditQuestion.Name = "buttonEditQuestion";
            this.buttonEditQuestion.Size = new System.Drawing.Size(106, 23);
            this.buttonEditQuestion.TabIndex = 7;
            this.buttonEditQuestion.Text = "Edit Question";
            this.buttonEditQuestion.UseVisualStyleBackColor = true;
            this.buttonEditQuestion.Click += new System.EventHandler(this.buttonEditQuestion_Click);
            // 
            // buttonAddQuestion
            // 
            this.buttonAddQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddQuestion.Location = new System.Drawing.Point(434, 52);
            this.buttonAddQuestion.Name = "buttonAddQuestion";
            this.buttonAddQuestion.Size = new System.Drawing.Size(105, 23);
            this.buttonAddQuestion.TabIndex = 6;
            this.buttonAddQuestion.Text = "Add Question";
            this.buttonAddQuestion.UseVisualStyleBackColor = true;
            this.buttonAddQuestion.Click += new System.EventHandler(this.buttonAddQuestion_Click);
            // 
            // textTrainingName
            // 
            this.textTrainingName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textTrainingName.EditValue = "";
            this.textTrainingName.Location = new System.Drawing.Point(12, 28);
            this.textTrainingName.Name = "textTrainingName";
            this.textTrainingName.Size = new System.Drawing.Size(752, 20);
            this.textTrainingName.StyleController = this.layoutControl1;
            this.textTrainingName.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem2,
            this.layoutControlItem1,
            this.emptySpaceItem3,
            this.buttonAddControlItem,
            this.buttonEditControlItem,
            this.buttonLoadControlItem,
            this.questionsControlItem,
            this.buttonCancelControlItem,
            this.buttonSaveControlItem});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(776, 416);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 369);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(531, 27);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textTrainingName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(756, 40);
            this.layoutControlItem1.Text = "Training Name";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(68, 13);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 40);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(422, 27);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // buttonAddControlItem
            // 
            this.buttonAddControlItem.Control = this.buttonAddQuestion;
            this.buttonAddControlItem.Location = new System.Drawing.Point(422, 40);
            this.buttonAddControlItem.MaxSize = new System.Drawing.Size(109, 27);
            this.buttonAddControlItem.MinSize = new System.Drawing.Size(109, 27);
            this.buttonAddControlItem.Name = "buttonAddControlItem";
            this.buttonAddControlItem.Size = new System.Drawing.Size(109, 27);
            this.buttonAddControlItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.buttonAddControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.buttonAddControlItem.TextVisible = false;
            // 
            // buttonEditControlItem
            // 
            this.buttonEditControlItem.Control = this.buttonEditQuestion;
            this.buttonEditControlItem.Location = new System.Drawing.Point(531, 40);
            this.buttonEditControlItem.MaxSize = new System.Drawing.Size(110, 27);
            this.buttonEditControlItem.MinSize = new System.Drawing.Size(110, 27);
            this.buttonEditControlItem.Name = "buttonEditControlItem";
            this.buttonEditControlItem.Size = new System.Drawing.Size(110, 27);
            this.buttonEditControlItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.buttonEditControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.buttonEditControlItem.TextVisible = false;
            // 
            // buttonLoadControlItem
            // 
            this.buttonLoadControlItem.Control = this.buttonLoadQuestion;
            this.buttonLoadControlItem.Location = new System.Drawing.Point(641, 40);
            this.buttonLoadControlItem.MaxSize = new System.Drawing.Size(115, 27);
            this.buttonLoadControlItem.MinSize = new System.Drawing.Size(115, 27);
            this.buttonLoadControlItem.Name = "buttonLoadControlItem";
            this.buttonLoadControlItem.Size = new System.Drawing.Size(115, 27);
            this.buttonLoadControlItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.buttonLoadControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.buttonLoadControlItem.TextVisible = false;
            // 
            // questionsControlItem
            // 
            this.questionsControlItem.Control = this.gridQuestions;
            this.questionsControlItem.Location = new System.Drawing.Point(0, 67);
            this.questionsControlItem.Name = "questionsControlItem";
            this.questionsControlItem.Size = new System.Drawing.Size(756, 302);
            this.questionsControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.questionsControlItem.TextVisible = false;
            // 
            // buttonCancelControlItem
            // 
            this.buttonCancelControlItem.Control = this.buttonCancel;
            this.buttonCancelControlItem.Location = new System.Drawing.Point(641, 369);
            this.buttonCancelControlItem.MaxSize = new System.Drawing.Size(115, 27);
            this.buttonCancelControlItem.MinSize = new System.Drawing.Size(115, 27);
            this.buttonCancelControlItem.Name = "buttonCancelControlItem";
            this.buttonCancelControlItem.Size = new System.Drawing.Size(115, 27);
            this.buttonCancelControlItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.buttonCancelControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.buttonCancelControlItem.TextVisible = false;
            // 
            // buttonSaveControlItem
            // 
            this.buttonSaveControlItem.Control = this.buttonSave;
            this.buttonSaveControlItem.Location = new System.Drawing.Point(531, 369);
            this.buttonSaveControlItem.MaxSize = new System.Drawing.Size(110, 27);
            this.buttonSaveControlItem.MinSize = new System.Drawing.Size(110, 27);
            this.buttonSaveControlItem.Name = "buttonSaveControlItem";
            this.buttonSaveControlItem.Size = new System.Drawing.Size(110, 27);
            this.buttonSaveControlItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.buttonSaveControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.buttonSaveControlItem.TextVisible = false;
            // 
            // TrainingEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 416);
            this.Controls.Add(this.layoutControl1);
            this.Name = "TrainingEditForm";
            this.Text = "Training: ";
            this.Load += new System.EventHandler(this.TrainingEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTrainingName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonAddControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLoadControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCancelControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSaveControlItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.TextEdit textTrainingName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private System.Windows.Forms.Button buttonLoadQuestion;
        private System.Windows.Forms.Button buttonEditQuestion;
        private System.Windows.Forms.Button buttonAddQuestion;
        private DevExpress.XtraLayout.LayoutControlItem buttonAddControlItem;
        private DevExpress.XtraLayout.LayoutControlItem buttonEditControlItem;
        private DevExpress.XtraLayout.LayoutControlItem buttonLoadControlItem;
        private DevExpress.XtraGrid.GridControl gridQuestions;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn QuestionText;
        private DevExpress.XtraLayout.LayoutControlItem questionsControlItem;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private DevExpress.XtraLayout.LayoutControlItem buttonCancelControlItem;
        private DevExpress.XtraLayout.LayoutControlItem buttonSaveControlItem;
    }
}