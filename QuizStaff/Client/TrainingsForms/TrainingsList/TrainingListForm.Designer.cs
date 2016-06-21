namespace Client.TrainingsListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainingListForm));
            this.layoutControlTrainingListForm = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlButAdd = new DevExpress.XtraLayout.LayoutControlItem();
            this.buttonAddTraining = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.deleteTrainingButton = new DevExpress.XtraEditors.SimpleButton();
            this.trainingsGridControl = new DevExpress.XtraGrid.GridControl();
            this.trainingsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.titleGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.buttonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.buttonSave = new DevExpress.XtraEditors.SimpleButton();
            this.buttonLoadTraining = new DevExpress.XtraEditors.SimpleButton();
            this.buttonEditTraining = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlButLoad = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlButEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlButCancel = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlButSave = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.trainingsLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.deleteButtonLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.mvvmTrainingsContext = new DevExpress.Utils.MVVM.MVVMContext();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlTrainingListForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlButAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlButLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlButEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlButCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlButSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteButtonLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmTrainingsContext)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControlTrainingListForm
            // 
            this.layoutControlTrainingListForm.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlTrainingListForm.GroupBordersVisible = false;
            this.layoutControlTrainingListForm.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlButAdd,
            this.layoutControlButLoad,
            this.layoutControlButEdit,
            this.layoutControlButCancel,
            this.layoutControlButSave,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.trainingsLayoutControlItem,
            this.deleteButtonLayoutControlItem});
            this.layoutControlTrainingListForm.Location = new System.Drawing.Point(0, 0);
            this.layoutControlTrainingListForm.Name = "Root";
            this.layoutControlTrainingListForm.Size = new System.Drawing.Size(830, 439);
            this.layoutControlTrainingListForm.TextVisible = false;
            // 
            // layoutControlButAdd
            // 
            this.layoutControlButAdd.Control = this.buttonAddTraining;
            this.layoutControlButAdd.Location = new System.Drawing.Point(390, 0);
            this.layoutControlButAdd.Name = "layoutControlButAdd";
            this.layoutControlButAdd.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlButAdd.Size = new System.Drawing.Size(105, 28);
            this.layoutControlButAdd.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlButAdd.TextVisible = false;
            // 
            // buttonAddTraining
            // 
            resources.ApplyResources(this.buttonAddTraining, "buttonAddTraining");
            this.buttonAddTraining.Name = "buttonAddTraining";
            this.buttonAddTraining.StyleController = this.layoutControl1;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.deleteTrainingButton);
            this.layoutControl1.Controls.Add(this.trainingsGridControl);
            this.layoutControl1.Controls.Add(this.buttonCancel);
            this.layoutControl1.Controls.Add(this.buttonSave);
            this.layoutControl1.Controls.Add(this.buttonLoadTraining);
            this.layoutControl1.Controls.Add(this.buttonEditTraining);
            this.layoutControl1.Controls.Add(this.buttonAddTraining);
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(270, 111, 634, 530);
            this.layoutControl1.Root = this.layoutControlTrainingListForm;
            // 
            // deleteTrainingButton
            // 
            resources.ApplyResources(this.deleteTrainingButton, "deleteTrainingButton");
            this.deleteTrainingButton.Name = "deleteTrainingButton";
            this.deleteTrainingButton.StyleController = this.layoutControl1;
            // 
            // trainingsGridControl
            // 
            resources.ApplyResources(this.trainingsGridControl, "trainingsGridControl");
            this.trainingsGridControl.MainView = this.trainingsGridView;
            this.trainingsGridControl.Name = "trainingsGridControl";
            this.trainingsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.trainingsGridView});
            // 
            // trainingsGridView
            // 
            this.trainingsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.titleGridColumn});
            this.trainingsGridView.GridControl = this.trainingsGridControl;
            this.trainingsGridView.Name = "trainingsGridView";
            this.trainingsGridView.OptionsDetail.EnableMasterViewMode = false;
            this.trainingsGridView.OptionsView.ShowGroupPanel = false;
            this.trainingsGridView.DoubleClick += new System.EventHandler(this.trainingsGridView_DoubleClick);
            // 
            // titleGridColumn
            // 
            resources.ApplyResources(this.titleGridColumn, "titleGridColumn");
            this.titleGridColumn.FieldName = "TrainingTitle";
            this.titleGridColumn.Name = "titleGridColumn";
            // 
            // buttonCancel
            // 
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.StyleController = this.layoutControl1;
            // 
            // buttonSave
            // 
            resources.ApplyResources(this.buttonSave, "buttonSave");
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.StyleController = this.layoutControl1;
            // 
            // buttonLoadTraining
            // 
            resources.ApplyResources(this.buttonLoadTraining, "buttonLoadTraining");
            this.buttonLoadTraining.Name = "buttonLoadTraining";
            this.buttonLoadTraining.StyleController = this.layoutControl1;
            // 
            // buttonEditTraining
            // 
            resources.ApplyResources(this.buttonEditTraining, "buttonEditTraining");
            this.buttonEditTraining.Name = "buttonEditTraining";
            this.buttonEditTraining.StyleController = this.layoutControl1;
            // 
            // layoutControlButLoad
            // 
            this.layoutControlButLoad.Control = this.buttonLoadTraining;
            this.layoutControlButLoad.Location = new System.Drawing.Point(705, 0);
            this.layoutControlButLoad.Name = "layoutControlButLoad";
            this.layoutControlButLoad.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlButLoad.Size = new System.Drawing.Size(105, 28);
            this.layoutControlButLoad.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlButLoad.TextVisible = false;
            // 
            // layoutControlButEdit
            // 
            this.layoutControlButEdit.Control = this.buttonEditTraining;
            this.layoutControlButEdit.Location = new System.Drawing.Point(495, 0);
            this.layoutControlButEdit.Name = "layoutControlButEdit";
            this.layoutControlButEdit.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlButEdit.Size = new System.Drawing.Size(105, 28);
            this.layoutControlButEdit.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlButEdit.TextVisible = false;
            // 
            // layoutControlButCancel
            // 
            this.layoutControlButCancel.Control = this.buttonCancel;
            this.layoutControlButCancel.Location = new System.Drawing.Point(646, 391);
            this.layoutControlButCancel.Name = "layoutControlButCancel";
            this.layoutControlButCancel.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlButCancel.Size = new System.Drawing.Size(164, 28);
            this.layoutControlButCancel.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlButCancel.TextVisible = false;
            // 
            // layoutControlButSave
            // 
            this.layoutControlButSave.Control = this.buttonSave;
            this.layoutControlButSave.Location = new System.Drawing.Point(479, 391);
            this.layoutControlButSave.Name = "layoutControlButSave";
            this.layoutControlButSave.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlButSave.Size = new System.Drawing.Size(167, 28);
            this.layoutControlButSave.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlButSave.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 391);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(479, 28);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 10, 3);
            this.emptySpaceItem2.Size = new System.Drawing.Size(390, 28);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // trainingsLayoutControlItem
            // 
            this.trainingsLayoutControlItem.Control = this.trainingsGridControl;
            this.trainingsLayoutControlItem.Location = new System.Drawing.Point(0, 28);
            this.trainingsLayoutControlItem.Name = "trainingsLayoutControlItem";
            this.trainingsLayoutControlItem.Size = new System.Drawing.Size(810, 363);
            this.trainingsLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 5);
            resources.ApplyResources(this.trainingsLayoutControlItem, "trainingsLayoutControlItem");
            this.trainingsLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.trainingsLayoutControlItem.TextSize = new System.Drawing.Size(43, 13);
            // 
            // deleteButtonLayoutControlItem
            // 
            this.deleteButtonLayoutControlItem.Control = this.deleteTrainingButton;
            this.deleteButtonLayoutControlItem.Location = new System.Drawing.Point(600, 0);
            this.deleteButtonLayoutControlItem.Name = "deleteButtonLayoutControlItem";
            this.deleteButtonLayoutControlItem.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.deleteButtonLayoutControlItem.Size = new System.Drawing.Size(105, 28);
            this.deleteButtonLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.deleteButtonLayoutControlItem.TextVisible = false;
            // 
            // mvvmTrainingsContext
            // 
            this.mvvmTrainingsContext.ContainerControl = this;
            // 
            // TrainingListForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "TrainingListForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlTrainingListForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlButAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trainingsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlButLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlButEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlButCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlButSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteButtonLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmTrainingsContext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControlGroup layoutControlTrainingListForm;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlButAdd;
        private DevExpress.XtraEditors.SimpleButton buttonAddTraining;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton buttonLoadTraining;
        private DevExpress.XtraEditors.SimpleButton buttonEditTraining;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlButLoad;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlButEdit;
        private DevExpress.XtraEditors.SimpleButton buttonCancel;
        private DevExpress.XtraEditors.SimpleButton buttonSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlButCancel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlButSave;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraGrid.GridControl trainingsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView trainingsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn titleGridColumn;
        private DevExpress.XtraLayout.LayoutControlItem trainingsLayoutControlItem;
        private DevExpress.Utils.MVVM.MVVMContext mvvmTrainingsContext;
        private DevExpress.XtraEditors.SimpleButton deleteTrainingButton;
        private DevExpress.XtraLayout.LayoutControlItem deleteButtonLayoutControlItem;
    }
}