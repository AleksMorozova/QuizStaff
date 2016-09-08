namespace AdminApplication.AdminSettings
{
    partial class EditTesteesTrainingsForm
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
            this.trainingListLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.applyButton = new DevExpress.XtraEditors.SimpleButton();
            this.testeesTrainingsGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridViewTesteesTrainings = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IsSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.isSelectRepositoryItemCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.Trainings = new DevExpress.XtraGrid.Columns.GridColumn();
            this.trainingsGridLayoutControl = new DevExpress.XtraLayout.LayoutControlGroup();
            this.testeeTraingLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.applyButtonLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.cancelButtonLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.mvvmEditTesteesTrainingsContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trainingListLayoutControl)).BeginInit();
            this.trainingListLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testeesTrainingsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTesteesTrainings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isSelectRepositoryItemCheckEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsGridLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testeeTraingLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applyButtonLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButtonLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmEditTesteesTrainingsContext)).BeginInit();
            this.SuspendLayout();
            // 
            // trainingListLayoutControl
            // 
            this.trainingListLayoutControl.Controls.Add(this.cancelButton);
            this.trainingListLayoutControl.Controls.Add(this.applyButton);
            this.trainingListLayoutControl.Controls.Add(this.testeesTrainingsGridControl);
            this.trainingListLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trainingListLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.trainingListLayoutControl.Name = "trainingListLayoutControl";
            this.trainingListLayoutControl.Root = this.trainingsGridLayoutControl;
            this.trainingListLayoutControl.Size = new System.Drawing.Size(579, 416);
            this.trainingListLayoutControl.TabIndex = 0;
            this.trainingListLayoutControl.Text = "layoutControl1";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(417, 382);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(150, 22);
            this.cancelButton.StyleController = this.trainingListLayoutControl;
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            // 
            // applyButton
            // 
            this.applyButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.applyButton.Location = new System.Drawing.Point(265, 382);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(138, 22);
            this.applyButton.StyleController = this.trainingListLayoutControl;
            this.applyButton.TabIndex = 5;
            this.applyButton.Text = "Apply";
            // 
            // testeesTrainingsGridControl
            // 
            this.testeesTrainingsGridControl.Location = new System.Drawing.Point(12, 28);
            this.testeesTrainingsGridControl.MainView = this.gridViewTesteesTrainings;
            this.testeesTrainingsGridControl.Name = "testeesTrainingsGridControl";
            this.testeesTrainingsGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.isSelectRepositoryItemCheckEdit});
            this.testeesTrainingsGridControl.Size = new System.Drawing.Size(555, 345);
            this.testeesTrainingsGridControl.TabIndex = 4;
            this.testeesTrainingsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTesteesTrainings});
            // 
            // gridViewTesteesTrainings
            // 
            this.gridViewTesteesTrainings.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IsSelected,
            this.Trainings});
            this.gridViewTesteesTrainings.GridControl = this.testeesTrainingsGridControl;
            this.gridViewTesteesTrainings.Name = "gridViewTesteesTrainings";
            this.gridViewTesteesTrainings.OptionsView.ShowGroupPanel = false;
            // 
            // IsSelected
            // 
            this.IsSelected.Caption = "Is select";
            this.IsSelected.ColumnEdit = this.isSelectRepositoryItemCheckEdit;
            this.IsSelected.FieldName = "IsSelect";
            this.IsSelected.Name = "IsSelected";
            this.IsSelected.Visible = true;
            this.IsSelected.VisibleIndex = 1;
            // 
            // isSelectRepositoryItemCheckEdit
            // 
            this.isSelectRepositoryItemCheckEdit.AutoHeight = false;
            this.isSelectRepositoryItemCheckEdit.Name = "isSelectRepositoryItemCheckEdit";
            // 
            // Trainings
            // 
            this.Trainings.Caption = "Training title";
            this.Trainings.FieldName = "Training.TrainingTitle";
            this.Trainings.Name = "Trainings";
            this.Trainings.Visible = true;
            this.Trainings.VisibleIndex = 0;
            // 
            // trainingsGridLayoutControl
            // 
            this.trainingsGridLayoutControl.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.trainingsGridLayoutControl.GroupBordersVisible = false;
            this.trainingsGridLayoutControl.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.testeeTraingLayoutControlItem,
            this.emptySpaceItem1,
            this.applyButtonLayoutControlItem,
            this.cancelButtonLayoutControlItem});
            this.trainingsGridLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.trainingsGridLayoutControl.Name = "trainingsGridLayoutControl";
            this.trainingsGridLayoutControl.Size = new System.Drawing.Size(579, 416);
            this.trainingsGridLayoutControl.TextVisible = false;
            // 
            // testeeTraingLayoutControlItem
            // 
            this.testeeTraingLayoutControlItem.Control = this.testeesTrainingsGridControl;
            this.testeeTraingLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.testeeTraingLayoutControlItem.Name = "testeeTraingLayoutControlItem";
            this.testeeTraingLayoutControlItem.Size = new System.Drawing.Size(559, 365);
            this.testeeTraingLayoutControlItem.Text = "Training list";
            this.testeeTraingLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.testeeTraingLayoutControlItem.TextSize = new System.Drawing.Size(54, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 365);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(253, 31);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // applyButtonLayoutControlItem
            // 
            this.applyButtonLayoutControlItem.Control = this.applyButton;
            this.applyButtonLayoutControlItem.Location = new System.Drawing.Point(253, 365);
            this.applyButtonLayoutControlItem.Name = "applyButtonLayoutControlItem";
            this.applyButtonLayoutControlItem.Size = new System.Drawing.Size(147, 31);
            this.applyButtonLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 5, 5, 0);
            this.applyButtonLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.applyButtonLayoutControlItem.TextVisible = false;
            // 
            // cancelButtonLayoutControlItem
            // 
            this.cancelButtonLayoutControlItem.Control = this.cancelButton;
            this.cancelButtonLayoutControlItem.Location = new System.Drawing.Point(400, 365);
            this.cancelButtonLayoutControlItem.Name = "cancelButtonLayoutControlItem";
            this.cancelButtonLayoutControlItem.Size = new System.Drawing.Size(159, 31);
            this.cancelButtonLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 0, 5, 0);
            this.cancelButtonLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.cancelButtonLayoutControlItem.TextVisible = false;
            // 
            // mvvmEditTesteesTrainingsContext
            // 
            this.mvvmEditTesteesTrainingsContext.ContainerControl = this;
            // 
            // EditTesteesTrainingsForm
            // 
            this.AcceptButton = this.applyButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 416);
            this.Controls.Add(this.trainingListLayoutControl);
            this.Name = "EditTesteesTrainingsForm";
            this.Text = "Edit testees and trainings";
            ((System.ComponentModel.ISupportInitialize)(this.trainingListLayoutControl)).EndInit();
            this.trainingListLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testeesTrainingsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTesteesTrainings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isSelectRepositoryItemCheckEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsGridLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testeeTraingLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applyButtonLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButtonLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmEditTesteesTrainingsContext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl trainingListLayoutControl;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.SimpleButton applyButton;
        private DevExpress.XtraGrid.GridControl testeesTrainingsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTesteesTrainings;
        private DevExpress.XtraGrid.Columns.GridColumn Trainings;
        private DevExpress.XtraLayout.LayoutControlGroup trainingsGridLayoutControl;
        private DevExpress.XtraLayout.LayoutControlItem testeeTraingLayoutControlItem;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem applyButtonLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem cancelButtonLayoutControlItem;
        private DevExpress.Utils.MVVM.MVVMContext mvvmEditTesteesTrainingsContext;
        private DevExpress.XtraGrid.Columns.GridColumn IsSelected;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit isSelectRepositoryItemCheckEdit;

    }
}