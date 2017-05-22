namespace AdminApplication.TrainingsListForm
{
    partial class TrainingListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainingListForm));
            this.mvvmTrainingsContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.addTrainingButton = new DevExpress.XtraEditors.SimpleButton();
            this.editTrainingButton = new DevExpress.XtraEditors.SimpleButton();
            this.loadTrainingButton = new DevExpress.XtraEditors.SimpleButton();
            this.trainingsGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.trainingsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.titleGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.deleteTrainingButton = new DevExpress.XtraEditors.SimpleButton();
            this.loadQuestionsButton = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlTrainingListForm = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.deleteButtonLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlButEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlButAdd = new DevExpress.XtraLayout.LayoutControlItem();
            this.trainingsLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlButLoad = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItemLoadQuestionButton = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmTrainingsContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlTrainingListForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteButtonLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlButEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlButAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlButLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemLoadQuestionButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mvvmTrainingsContext
            // 
            this.mvvmTrainingsContext.ContainerControl = this;
            // 
            // addTrainingButton
            // 
            resources.ApplyResources(this.addTrainingButton, "addTrainingButton");
            this.addTrainingButton.Name = "addTrainingButton";
            this.addTrainingButton.StyleController = this.layoutControl1;
            // 
            // editTrainingButton
            // 
            resources.ApplyResources(this.editTrainingButton, "editTrainingButton");
            this.editTrainingButton.Name = "editTrainingButton";
            this.editTrainingButton.StyleController = this.layoutControl1;
            // 
            // loadTrainingButton
            // 
            resources.ApplyResources(this.loadTrainingButton, "loadTrainingButton");
            this.loadTrainingButton.Name = "loadTrainingButton";
            this.loadTrainingButton.StyleController = this.layoutControl1;
            // 
            // trainingsGridControl
            // 
            resources.ApplyResources(this.trainingsGridControl, "trainingsGridControl");
            this.trainingsGridControl.MainView = this.trainingsGridView;
            this.trainingsGridControl.Name = "trainingsGridControl";
            this.trainingsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.trainingsGridView});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.trainingsGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // trainingsGridView
            // 
            this.trainingsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.titleGridColumn});
            this.trainingsGridView.GridControl = this.trainingsGridControl;
            this.trainingsGridView.Name = "trainingsGridView";
            this.trainingsGridView.OptionsBehavior.Editable = false;
            this.trainingsGridView.OptionsDetail.EnableMasterViewMode = false;
            this.trainingsGridView.OptionsView.ShowAutoFilterRow = true;
            this.trainingsGridView.OptionsView.ShowGroupPanel = false;
            this.trainingsGridView.DoubleClick += new System.EventHandler(this.trainingsGridView_DoubleClick);
            // 
            // titleGridColumn
            // 
            resources.ApplyResources(this.titleGridColumn, "titleGridColumn");
            this.titleGridColumn.FieldName = "TrainingTitle";
            this.titleGridColumn.Name = "titleGridColumn";
            // 
            // deleteTrainingButton
            // 
            resources.ApplyResources(this.deleteTrainingButton, "deleteTrainingButton");
            this.deleteTrainingButton.Name = "deleteTrainingButton";
            this.deleteTrainingButton.StyleController = this.layoutControl1;
            // 
            // loadQuestionsButton
            // 
            resources.ApplyResources(this.loadQuestionsButton, "loadQuestionsButton");
            this.loadQuestionsButton.Name = "loadQuestionsButton";
            this.loadQuestionsButton.StyleController = this.layoutControl1;
            // 
            // layoutControlTrainingListForm
            // 
            this.layoutControlTrainingListForm.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlTrainingListForm.GroupBordersVisible = false;
            this.layoutControlTrainingListForm.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemLoadQuestionButton,
            this.emptySpaceItem3,
            this.layoutControlButLoad,
            this.layoutControlGroup1});
            this.layoutControlTrainingListForm.Location = new System.Drawing.Point(0, 0);
            this.layoutControlTrainingListForm.Name = "Root";
            this.layoutControlTrainingListForm.Size = new System.Drawing.Size(830, 439);
            this.layoutControlTrainingListForm.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.trainingsLayoutControlItem,
            this.layoutControlButAdd,
            this.emptySpaceItem2,
            this.layoutControlButEdit,
            this.deleteButtonLayoutControlItem});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 28);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup1.Size = new System.Drawing.Size(810, 391);
            resources.ApplyResources(this.layoutControlGroup1, "layoutControlGroup1");
            // 
            // deleteButtonLayoutControlItem
            // 
            this.deleteButtonLayoutControlItem.Control = this.deleteTrainingButton;
            this.deleteButtonLayoutControlItem.Location = new System.Drawing.Point(645, 0);
            this.deleteButtonLayoutControlItem.Name = "deleteButtonLayoutControlItem";
            this.deleteButtonLayoutControlItem.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 6, 3);
            this.deleteButtonLayoutControlItem.Size = new System.Drawing.Size(155, 31);
            this.deleteButtonLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.deleteButtonLayoutControlItem.TextVisible = false;
            // 
            // layoutControlButEdit
            // 
            this.layoutControlButEdit.Control = this.editTrainingButton;
            this.layoutControlButEdit.Location = new System.Drawing.Point(478, 0);
            this.layoutControlButEdit.Name = "layoutControlButEdit";
            this.layoutControlButEdit.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 6, 3);
            this.layoutControlButEdit.Size = new System.Drawing.Size(167, 31);
            this.layoutControlButEdit.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlButEdit.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 10, 3);
            this.emptySpaceItem2.Size = new System.Drawing.Size(317, 31);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlButAdd
            // 
            this.layoutControlButAdd.Control = this.addTrainingButton;
            this.layoutControlButAdd.Location = new System.Drawing.Point(317, 0);
            this.layoutControlButAdd.Name = "layoutControlButAdd";
            this.layoutControlButAdd.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 6, 3);
            this.layoutControlButAdd.Size = new System.Drawing.Size(161, 31);
            this.layoutControlButAdd.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlButAdd.TextVisible = false;
            // 
            // trainingsLayoutControlItem
            // 
            this.trainingsLayoutControlItem.Control = this.trainingsGridControl;
            this.trainingsLayoutControlItem.Location = new System.Drawing.Point(0, 31);
            this.trainingsLayoutControlItem.Name = "trainingsLayoutControlItem";
            this.trainingsLayoutControlItem.Size = new System.Drawing.Size(800, 332);
            this.trainingsLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 5);
            resources.ApplyResources(this.trainingsLayoutControlItem, "trainingsLayoutControlItem");
            this.trainingsLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.trainingsLayoutControlItem.TextSize = new System.Drawing.Size(59, 13);
            // 
            // layoutControlButLoad
            // 
            this.layoutControlButLoad.Control = this.loadTrainingButton;
            this.layoutControlButLoad.Location = new System.Drawing.Point(530, 0);
            this.layoutControlButLoad.Name = "layoutControlButLoad";
            this.layoutControlButLoad.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlButLoad.Size = new System.Drawing.Size(140, 28);
            this.layoutControlButLoad.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlButLoad.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(530, 28);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItemLoadQuestionButton
            // 
            this.layoutControlItemLoadQuestionButton.Control = this.loadQuestionsButton;
            this.layoutControlItemLoadQuestionButton.Location = new System.Drawing.Point(670, 0);
            this.layoutControlItemLoadQuestionButton.Name = "layoutControlItemLoadQuestionButton";
            this.layoutControlItemLoadQuestionButton.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlItemLoadQuestionButton.Size = new System.Drawing.Size(140, 28);
            this.layoutControlItemLoadQuestionButton.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemLoadQuestionButton.TextVisible = false;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.loadQuestionsButton);
            this.layoutControl1.Controls.Add(this.deleteTrainingButton);
            this.layoutControl1.Controls.Add(this.trainingsGridControl);
            this.layoutControl1.Controls.Add(this.loadTrainingButton);
            this.layoutControl1.Controls.Add(this.editTrainingButton);
            this.layoutControl1.Controls.Add(this.addTrainingButton);
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(270, 111, 634, 530);
            this.layoutControl1.Root = this.layoutControlTrainingListForm;
            // 
            // TrainingListForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "TrainingListForm";
            ((System.ComponentModel.ISupportInitialize)(this.mvvmTrainingsContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlTrainingListForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteButtonLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlButEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlButAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlButLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemLoadQuestionButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.MVVM.MVVMContext mvvmTrainingsContext;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton loadQuestionsButton;
        private DevExpress.XtraEditors.SimpleButton deleteTrainingButton;
        private DevExpress.XtraGrid.GridControl trainingsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView trainingsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn titleGridColumn;
        private DevExpress.XtraEditors.SimpleButton loadTrainingButton;
        private DevExpress.XtraEditors.SimpleButton editTrainingButton;
        private DevExpress.XtraEditors.SimpleButton addTrainingButton;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlTrainingListForm;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemLoadQuestionButton;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlButLoad;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem trainingsLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlButAdd;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlButEdit;
        private DevExpress.XtraLayout.LayoutControlItem deleteButtonLayoutControlItem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}