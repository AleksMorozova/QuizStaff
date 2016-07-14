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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonApply = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlTesteesTrainings = new DevExpress.XtraGrid.GridControl();
            this.gridViewTesteesTrainings = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IsSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.isSelectRepositoryItemCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.Trainings = new DevExpress.XtraGrid.Columns.GridColumn();
            this.trainingsGridLayoutControl = new DevExpress.XtraLayout.LayoutControlGroup();
            this.testeeTraingsGridlayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.mvvmEditTesteesTrainingsContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTesteesTrainings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTesteesTrainings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isSelectRepositoryItemCheckEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsGridLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testeeTraingsGridlayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmEditTesteesTrainingsContext)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButtonCancel);
            this.layoutControl1.Controls.Add(this.simpleButtonApply);
            this.layoutControl1.Controls.Add(this.gridControlTesteesTrainings);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.trainingsGridLayoutControl;
            this.layoutControl1.Size = new System.Drawing.Size(579, 416);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.Location = new System.Drawing.Point(428, 382);
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new System.Drawing.Size(139, 22);
            this.simpleButtonCancel.StyleController = this.layoutControl1;
            this.simpleButtonCancel.TabIndex = 6;
            this.simpleButtonCancel.Text = "Cancel";
            this.simpleButtonCancel.Click += new System.EventHandler(this.simpleButtonCancel_Click);
            // 
            // simpleButtonApply
            // 
            this.simpleButtonApply.Location = new System.Drawing.Point(265, 382);
            this.simpleButtonApply.Name = "simpleButtonApply";
            this.simpleButtonApply.Size = new System.Drawing.Size(143, 22);
            this.simpleButtonApply.StyleController = this.layoutControl1;
            this.simpleButtonApply.TabIndex = 5;
            this.simpleButtonApply.Text = "Apply";
            // 
            // gridControlTesteesTrainings
            // 
            this.gridControlTesteesTrainings.Location = new System.Drawing.Point(12, 28);
            this.gridControlTesteesTrainings.MainView = this.gridViewTesteesTrainings;
            this.gridControlTesteesTrainings.Name = "gridControlTesteesTrainings";
            this.gridControlTesteesTrainings.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.isSelectRepositoryItemCheckEdit});
            this.gridControlTesteesTrainings.Size = new System.Drawing.Size(555, 350);
            this.gridControlTesteesTrainings.TabIndex = 4;
            this.gridControlTesteesTrainings.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTesteesTrainings});
            // 
            // gridViewTesteesTrainings
            // 
            this.gridViewTesteesTrainings.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IsSelected,
            this.Trainings});
            this.gridViewTesteesTrainings.GridControl = this.gridControlTesteesTrainings;
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
            this.testeeTraingsGridlayoutControl,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem2});
            this.trainingsGridLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.trainingsGridLayoutControl.Name = "trainingsGridLayoutControl";
            this.trainingsGridLayoutControl.Size = new System.Drawing.Size(579, 416);
            this.trainingsGridLayoutControl.TextVisible = false;
            // 
            // testeeTraingsGridlayoutControl
            // 
            this.testeeTraingsGridlayoutControl.Control = this.gridControlTesteesTrainings;
            this.testeeTraingsGridlayoutControl.Location = new System.Drawing.Point(0, 0);
            this.testeeTraingsGridlayoutControl.Name = "testeeTraingsGridlayoutControl";
            this.testeeTraingsGridlayoutControl.Size = new System.Drawing.Size(559, 370);
            this.testeeTraingsGridlayoutControl.Text = "Training list";
            this.testeeTraingsGridlayoutControl.TextLocation = DevExpress.Utils.Locations.Top;
            this.testeeTraingsGridlayoutControl.TextSize = new System.Drawing.Size(54, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 370);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(253, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.simpleButtonApply;
            this.layoutControlItem2.Location = new System.Drawing.Point(253, 370);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(147, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButtonCancel;
            this.layoutControlItem3.Location = new System.Drawing.Point(416, 370);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(143, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(400, 370);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(16, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // mvvmEditTesteesTrainingsContext
            // 
            this.mvvmEditTesteesTrainingsContext.ContainerControl = this;
            // 
            // EditTesteesTrainingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 416);
            this.Controls.Add(this.layoutControl1);
            this.Name = "EditTesteesTrainingsForm";
            this.Text = "Edit testees and trainings";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTesteesTrainings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTesteesTrainings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isSelectRepositoryItemCheckEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsGridLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testeeTraingsGridlayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmEditTesteesTrainingsContext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
        private DevExpress.XtraEditors.SimpleButton simpleButtonApply;
        private DevExpress.XtraGrid.GridControl gridControlTesteesTrainings;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTesteesTrainings;
        private DevExpress.XtraGrid.Columns.GridColumn Trainings;
        private DevExpress.XtraLayout.LayoutControlGroup trainingsGridLayoutControl;
        private DevExpress.XtraLayout.LayoutControlItem testeeTraingsGridlayoutControl;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.Utils.MVVM.MVVMContext mvvmEditTesteesTrainingsContext;
        private DevExpress.XtraGrid.Columns.GridColumn IsSelected;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit isSelectRepositoryItemCheckEdit;

    }
}