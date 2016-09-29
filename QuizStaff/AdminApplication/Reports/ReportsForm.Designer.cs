namespace AdminApplication.Reports
{
    partial class ReportsForm
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
            this.previewButton = new DevExpress.XtraEditors.SimpleButton();
            this.createButton = new DevExpress.XtraEditors.SimpleButton();
            this.loginTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.toDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.dateRangeLabel = new DevExpress.XtraEditors.LabelControl();
            this.fromDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.previewReportDocument = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.reportTypeRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.createReportaLyoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.reportTypeRadioGroupLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.fromDateLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.dateRangeLabelLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.toDateLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.loginLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.previewLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.mvvmContextForReports = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportTypeRadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createReportaLyoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportTypeRadioGroupLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRangeLabelLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDateLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContextForReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.previewButton);
            this.layoutControl1.Controls.Add(this.createButton);
            this.layoutControl1.Controls.Add(this.loginTextEdit);
            this.layoutControl1.Controls.Add(this.toDateEdit);
            this.layoutControl1.Controls.Add(this.dateRangeLabel);
            this.layoutControl1.Controls.Add(this.fromDateEdit);
            this.layoutControl1.Controls.Add(this.previewReportDocument);
            this.layoutControl1.Controls.Add(this.reportTypeRadioGroup);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(847, 611);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // previewButton
            // 
            this.previewButton.Location = new System.Drawing.Point(677, 78);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(146, 22);
            this.previewButton.StyleController = this.layoutControl1;
            this.previewButton.TabIndex = 16;
            this.previewButton.Text = "Preview";
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(677, 42);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(146, 22);
            this.createButton.StyleController = this.layoutControl1;
            this.createButton.TabIndex = 15;
            this.createButton.Text = "Create";
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // loginTextEdit
            // 
            this.loginTextEdit.Location = new System.Drawing.Point(377, 68);
            this.loginTextEdit.Name = "loginTextEdit";
            this.loginTextEdit.Size = new System.Drawing.Size(152, 20);
            this.loginTextEdit.StyleController = this.layoutControl1;
            this.loginTextEdit.TabIndex = 14;
            // 
            // toDateEdit
            // 
            this.toDateEdit.EditValue = null;
            this.toDateEdit.Location = new System.Drawing.Point(278, 69);
            this.toDateEdit.Name = "toDateEdit";
            this.toDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.toDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.toDateEdit.Size = new System.Drawing.Size(85, 20);
            this.toDateEdit.StyleController = this.layoutControl1;
            this.toDateEdit.TabIndex = 13;
            // 
            // dateRangeLabel
            // 
            this.dateRangeLabel.Location = new System.Drawing.Point(139, 42);
            this.dateRangeLabel.Name = "dateRangeLabel";
            this.dateRangeLabel.Size = new System.Drawing.Size(209, 23);
            this.dateRangeLabel.StyleController = this.layoutControl1;
            this.dateRangeLabel.TabIndex = 12;
            this.dateRangeLabel.Text = "Date range";
            // 
            // fromDateEdit
            // 
            this.fromDateEdit.EditValue = null;
            this.fromDateEdit.Location = new System.Drawing.Point(166, 69);
            this.fromDateEdit.Name = "fromDateEdit";
            this.fromDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fromDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fromDateEdit.Size = new System.Drawing.Size(93, 20);
            this.fromDateEdit.StyleController = this.layoutControl1;
            this.fromDateEdit.TabIndex = 11;
            // 
            // previewReportDocument
            // 
            this.previewReportDocument.IsMetric = false;
            this.previewReportDocument.Location = new System.Drawing.Point(24, 176);
            this.previewReportDocument.Name = "previewReportDocument";
            this.previewReportDocument.Size = new System.Drawing.Size(799, 411);
            this.previewReportDocument.TabIndex = 9;
            // 
            // reportTypeRadioGroup
            // 
            this.reportTypeRadioGroup.Location = new System.Drawing.Point(29, 63);
            this.reportTypeRadioGroup.Name = "reportTypeRadioGroup";
            this.reportTypeRadioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.reportTypeRadioGroup.Properties.Appearance.Options.UseBackColor = true;
            this.reportTypeRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("General", "General"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("ByLogin", "By login")});
            this.reportTypeRadioGroup.Size = new System.Drawing.Size(101, 62);
            this.reportTypeRadioGroup.StyleController = this.layoutControl1;
            this.reportTypeRadioGroup.TabIndex = 4;
            this.reportTypeRadioGroup.SelectedIndexChanged += new System.EventHandler(this.reportTypeRadioGroup_SelectedIndexChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.createReportaLyoutGroup,
            this.previewLayoutGroup});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(847, 611);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // createReportaLyoutGroup
            // 
            this.createReportaLyoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.reportTypeRadioGroupLayoutControlItem,
            this.toDateLayoutControlItem,
            this.loginLayoutControlItem,
            this.layoutControlItem1,
            this.emptySpaceItem2,
            this.layoutControlItem3,
            this.dateRangeLabelLayoutControlItem,
            this.emptySpaceItem1,
            this.fromDateLayoutControlItem});
            this.createReportaLyoutGroup.Location = new System.Drawing.Point(0, 0);
            this.createReportaLyoutGroup.Name = "createReportaLyoutGroup";
            this.createReportaLyoutGroup.Size = new System.Drawing.Size(827, 134);
            // 
            // reportTypeRadioGroupLayoutControlItem
            // 
            this.reportTypeRadioGroupLayoutControlItem.Control = this.reportTypeRadioGroup;
            this.reportTypeRadioGroupLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.reportTypeRadioGroupLayoutControlItem.MaxSize = new System.Drawing.Size(115, 92);
            this.reportTypeRadioGroupLayoutControlItem.MinSize = new System.Drawing.Size(115, 92);
            this.reportTypeRadioGroupLayoutControlItem.Name = "reportTypeRadioGroupLayoutControlItem";
            this.reportTypeRadioGroupLayoutControlItem.Size = new System.Drawing.Size(115, 92);
            this.reportTypeRadioGroupLayoutControlItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.reportTypeRadioGroupLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.reportTypeRadioGroupLayoutControlItem.Text = "Report type";
            this.reportTypeRadioGroupLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.reportTypeRadioGroupLayoutControlItem.TextSize = new System.Drawing.Size(58, 13);
            // 
            // fromDateLayoutControlItem
            // 
            this.fromDateLayoutControlItem.Control = this.fromDateEdit;
            this.fromDateLayoutControlItem.Location = new System.Drawing.Point(115, 27);
            this.fromDateLayoutControlItem.Name = "fromDateLayoutControlItem";
            this.fromDateLayoutControlItem.Size = new System.Drawing.Size(124, 24);
            this.fromDateLayoutControlItem.Text = "from";
            this.fromDateLayoutControlItem.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.fromDateLayoutControlItem.TextSize = new System.Drawing.Size(22, 13);
            this.fromDateLayoutControlItem.TextToControlDistance = 5;
            // 
            // dateRangeLabelLayoutControlItem
            // 
            this.dateRangeLabelLayoutControlItem.Control = this.dateRangeLabel;
            this.dateRangeLabelLayoutControlItem.Location = new System.Drawing.Point(115, 0);
            this.dateRangeLabelLayoutControlItem.MinSize = new System.Drawing.Size(1, 1);
            this.dateRangeLabelLayoutControlItem.Name = "dateRangeLabelLayoutControlItem";
            this.dateRangeLabelLayoutControlItem.Size = new System.Drawing.Size(228, 27);
            this.dateRangeLabelLayoutControlItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.dateRangeLabelLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 15, 0, 0);
            this.dateRangeLabelLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.dateRangeLabelLayoutControlItem.TextVisible = false;
            // 
            // toDateLayoutControlItem
            // 
            this.toDateLayoutControlItem.Control = this.toDateEdit;
            this.toDateLayoutControlItem.Location = new System.Drawing.Point(239, 27);
            this.toDateLayoutControlItem.Name = "toDateLayoutControlItem";
            this.toDateLayoutControlItem.Size = new System.Drawing.Size(104, 24);
            this.toDateLayoutControlItem.Text = "to";
            this.toDateLayoutControlItem.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.toDateLayoutControlItem.TextSize = new System.Drawing.Size(10, 13);
            this.toDateLayoutControlItem.TextToControlDistance = 5;
            // 
            // loginLayoutControlItem
            // 
            this.loginLayoutControlItem.Control = this.loginTextEdit;
            this.loginLayoutControlItem.Location = new System.Drawing.Point(343, 0);
            this.loginLayoutControlItem.MinSize = new System.Drawing.Size(82, 40);
            this.loginLayoutControlItem.Name = "loginLayoutControlItem";
            this.loginLayoutControlItem.Size = new System.Drawing.Size(176, 92);
            this.loginLayoutControlItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.loginLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 0);
            this.loginLayoutControlItem.Text = "Login";
            this.loginLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.loginLayoutControlItem.TextSize = new System.Drawing.Size(58, 13);
            this.loginLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.createButton;
            this.layoutControlItem1.Location = new System.Drawing.Point(653, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(150, 36);
            this.layoutControlItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 10);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(519, 0);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(104, 24);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(134, 92);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.previewButton;
            this.layoutControlItem3.Location = new System.Drawing.Point(653, 36);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(150, 56);
            this.layoutControlItem3.Text = "Preview";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // previewLayoutGroup
            // 
            this.previewLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.previewLayoutGroup.Location = new System.Drawing.Point(0, 134);
            this.previewLayoutGroup.Name = "previewLayoutGroup";
            this.previewLayoutGroup.Size = new System.Drawing.Size(827, 457);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.previewReportDocument;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(803, 415);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // mvvmContextForReports
            // 
            this.mvvmContextForReports.ContainerControl = this;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(115, 51);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(104, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(228, 41);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 611);
            this.Controls.Add(this.layoutControl1);
            this.Name = "ReportsForm";
            this.Text = "ReportsForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loginTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportTypeRadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createReportaLyoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportTypeRadioGroupLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRangeLabelLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDateLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContextForReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.RadioGroup reportTypeRadioGroup;
        private DevExpress.XtraLayout.LayoutControlGroup createReportaLyoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem reportTypeRadioGroupLayoutControlItem;
        private DevExpress.XtraPrinting.Preview.DocumentViewer previewReportDocument;
        private DevExpress.XtraLayout.LayoutControlGroup previewLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.DateEdit toDateEdit;
        private DevExpress.XtraEditors.LabelControl dateRangeLabel;
        private DevExpress.XtraEditors.DateEdit fromDateEdit;
        private DevExpress.XtraLayout.LayoutControlItem fromDateLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem dateRangeLabelLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem toDateLayoutControlItem;
        private DevExpress.XtraEditors.TextEdit loginTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem loginLayoutControlItem;
        private DevExpress.XtraEditors.SimpleButton previewButton;
        private DevExpress.XtraEditors.SimpleButton createButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContextForReports;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}