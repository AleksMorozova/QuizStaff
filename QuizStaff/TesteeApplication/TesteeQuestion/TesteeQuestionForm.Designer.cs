namespace TesteeApplication.TesteeQuestion
{
    partial class TesteeQuestionForm
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
            this.questionLabel = new DevExpress.XtraEditors.LabelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.OKButton = new DevExpress.XtraEditors.SimpleButton();
            this.answersCheckedList = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.answersCheckedListLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.questionLabelLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.OKButtonLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.mvvmQuestionContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.answersCheckedList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answersCheckedListLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionLabelLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OKButtonLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmQuestionContext)).BeginInit();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionLabel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.questionLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.questionLabel.Location = new System.Drawing.Point(12, 12);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(282, 16);
            this.questionLabel.StyleController = this.layoutControl1;
            this.questionLabel.TabIndex = 5;
            this.questionLabel.Text = "labelControl1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.OKButton);
            this.layoutControl1.Controls.Add(this.answersCheckedList);
            this.layoutControl1.Controls.Add(this.questionLabel);
            this.layoutControl1.Location = new System.Drawing.Point(2, -1);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(306, 470);
            this.layoutControl1.TabIndex = 6;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // OKButton
            // 
            this.OKButton.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OKButton.Appearance.Options.UseFont = true;
            this.OKButton.Location = new System.Drawing.Point(112, 430);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(82, 23);
            this.OKButton.StyleController = this.layoutControl1;
            this.OKButton.TabIndex = 6;
            this.OKButton.Text = "OK";
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // answersCheckedList
            // 
            this.answersCheckedList.AllowDrop = true;
            this.answersCheckedList.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.answersCheckedList.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answersCheckedList.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.answersCheckedList.Appearance.Options.UseBackColor = true;
            this.answersCheckedList.Appearance.Options.UseFont = true;
            this.answersCheckedList.Appearance.Options.UseForeColor = true;
            this.answersCheckedList.Appearance.Options.UseTextOptions = true;
            this.answersCheckedList.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.answersCheckedList.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.answersCheckedList.CheckOnClick = true;
            this.answersCheckedList.DisplayMember = "AnswerText";
            this.answersCheckedList.ItemAutoHeight = true;
            this.answersCheckedList.Location = new System.Drawing.Point(12, 32);
            this.answersCheckedList.Name = "answersCheckedList";
            this.answersCheckedList.Size = new System.Drawing.Size(282, 389);
            this.answersCheckedList.StyleController = this.layoutControl1;
            this.answersCheckedList.TabIndex = 4;
            this.answersCheckedList.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.answersCheckedList_ItemCheck);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.answersCheckedListLayoutControlItem,
            this.questionLabelLayoutControlItem,
            this.OKButtonLayoutControlItem,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(306, 470);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // answersCheckedListLayoutControlItem
            // 
            this.answersCheckedListLayoutControlItem.Control = this.answersCheckedList;
            this.answersCheckedListLayoutControlItem.Location = new System.Drawing.Point(0, 20);
            this.answersCheckedListLayoutControlItem.Name = "answersCheckedListLayoutControlItem";
            this.answersCheckedListLayoutControlItem.Size = new System.Drawing.Size(286, 393);
            this.answersCheckedListLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.answersCheckedListLayoutControlItem.TextVisible = false;
            // 
            // questionLabelLayoutControlItem
            // 
            this.questionLabelLayoutControlItem.AppearanceItemCaption.Options.UseTextOptions = true;
            this.questionLabelLayoutControlItem.AppearanceItemCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.questionLabelLayoutControlItem.Control = this.questionLabel;
            this.questionLabelLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.questionLabelLayoutControlItem.Name = "questionLabelLayoutControlItem";
            this.questionLabelLayoutControlItem.Size = new System.Drawing.Size(286, 20);
            this.questionLabelLayoutControlItem.StartNewLine = true;
            this.questionLabelLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.questionLabelLayoutControlItem.TextVisible = false;
            // 
            // OKButtonLayoutControlItem
            // 
            this.OKButtonLayoutControlItem.Control = this.OKButton;
            this.OKButtonLayoutControlItem.Location = new System.Drawing.Point(95, 413);
            this.OKButtonLayoutControlItem.Name = "OKButtonLayoutControlItem";
            this.OKButtonLayoutControlItem.Size = new System.Drawing.Size(96, 37);
            this.OKButtonLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.OKButtonLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.OKButtonLayoutControlItem.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 413);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(95, 37);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(191, 413);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(95, 37);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // mvvmQuestionContext
            // 
            this.mvvmQuestionContext.ContainerControl = this;
            // 
            // TesteeQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 470);
            this.Controls.Add(this.layoutControl1);
            this.Name = "TesteeQuestionForm";
            this.Text = "TesteeQuestionForm";
            this.Load += new System.EventHandler(this.TesteeQuestionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.answersCheckedList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answersCheckedListLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionLabelLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OKButtonLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmQuestionContext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl questionLabel;
        private DevExpress.XtraEditors.CheckedListBoxControl answersCheckedList;
        private DevExpress.Utils.MVVM.MVVMContext mvvmQuestionContext;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem answersCheckedListLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem questionLabelLayoutControlItem;
        private DevExpress.XtraEditors.SimpleButton OKButton;
        private DevExpress.XtraLayout.LayoutControlItem OKButtonLayoutControlItem;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}