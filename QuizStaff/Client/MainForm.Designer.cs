namespace Client
{
    partial class MainForm
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
            this.tabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.mainMenuManager = new DevExpress.XtraBars.BarManager(this.components);
            this.mainMenu = new DevExpress.XtraBars.Bar();
            this.testeesBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.trainingsBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.settingsBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.testBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.statusBar = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.loginBarButton = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedMdiManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuManager)).BeginInit();
            this.SuspendLayout();
            // 
            // tabbedMdiManager
            // 
            this.tabbedMdiManager.MdiParent = this;
            // 
            // mainMenuManager
            // 
            this.mainMenuManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.mainMenu,
            this.statusBar});
            this.mainMenuManager.DockControls.Add(this.barDockControlTop);
            this.mainMenuManager.DockControls.Add(this.barDockControlBottom);
            this.mainMenuManager.DockControls.Add(this.barDockControlLeft);
            this.mainMenuManager.DockControls.Add(this.barDockControlRight);
            this.mainMenuManager.Form = this;
            this.mainMenuManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.testeesBarButton,
            this.trainingsBarButton,
            this.settingsBarButton,
            this.testBarButton,
            this.loginBarButton});
            this.mainMenuManager.MainMenu = this.mainMenu;
            this.mainMenuManager.MaxItemId = 5;
            this.mainMenuManager.StatusBar = this.statusBar;
            // 
            // mainMenu
            // 
            this.mainMenu.BarName = "Main menu";
            this.mainMenu.DockCol = 0;
            this.mainMenu.DockRow = 0;
            this.mainMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.mainMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.testeesBarButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.trainingsBarButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.settingsBarButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.testBarButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.loginBarButton)});
            this.mainMenu.OptionsBar.MultiLine = true;
            this.mainMenu.OptionsBar.UseWholeRow = true;
            this.mainMenu.Text = "Main menu";
            // 
            // testeesBarButton
            // 
            this.testeesBarButton.Caption = "Testees";
            this.testeesBarButton.Id = 0;
            this.testeesBarButton.Name = "testeesBarButton";
            this.testeesBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.testeesBarButton_ItemClick);
            // 
            // trainingsBarButton
            // 
            this.trainingsBarButton.Caption = "Trainings";
            this.trainingsBarButton.Id = 1;
            this.trainingsBarButton.Name = "trainingsBarButton";
            this.trainingsBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.trainingsBarButton_ItemClick);
            // 
            // settingsBarButton
            // 
            this.settingsBarButton.Caption = "Settings";
            this.settingsBarButton.Id = 2;
            this.settingsBarButton.Name = "settingsBarButton";
            // 
            // testBarButton
            // 
            this.testBarButton.Caption = "Test";
            this.testBarButton.Id = 3;
            this.testBarButton.Name = "testBarButton";
            this.testBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.testBarButton_ItemClick);
            // 
            // statusBar
            // 
            this.statusBar.BarName = "Status bar";
            this.statusBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.statusBar.DockCol = 0;
            this.statusBar.DockRow = 0;
            this.statusBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.statusBar.OptionsBar.AllowQuickCustomization = false;
            this.statusBar.OptionsBar.DrawDragBorder = false;
            this.statusBar.OptionsBar.UseWholeRow = true;
            this.statusBar.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(803, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 511);
            this.barDockControlBottom.Size = new System.Drawing.Size(803, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 489);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(803, 22);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 489);
            // 
            // loginBarButton
            // 
            this.loginBarButton.Caption = "Test Login";
            this.loginBarButton.Id = 4;
            this.loginBarButton.Name = "loginBarButton";
            this.loginBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.loginBarButton_ItemClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 534);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabbedMdiManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager tabbedMdiManager;
        private DevExpress.XtraBars.BarManager mainMenuManager;
        private DevExpress.XtraBars.Bar mainMenu;
        private DevExpress.XtraBars.BarButtonItem testeesBarButton;
        private DevExpress.XtraBars.Bar statusBar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem trainingsBarButton;
        private DevExpress.XtraBars.BarButtonItem settingsBarButton;
        private DevExpress.XtraBars.BarButtonItem testBarButton;
        private DevExpress.XtraBars.BarButtonItem loginBarButton;


    }
}