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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.mainMenuManager = new DevExpress.XtraBars.BarManager(this.components);
            this.mainMenu = new DevExpress.XtraBars.Bar();
            this.testeesBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.trainingsBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.settingsBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.testBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.loginBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.questionBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.languageBarSubItem = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.statusBar = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
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
            this.loginBarButton,
            this.questionBarButton,
            this.languageBarSubItem,
            this.barButtonItem1,
            this.barButtonItem2});
            this.mainMenuManager.MainMenu = this.mainMenu;
            this.mainMenuManager.MaxItemId = 9;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.loginBarButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.questionBarButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.languageBarSubItem, true)});
            this.mainMenu.OptionsBar.MultiLine = true;
            this.mainMenu.OptionsBar.UseWholeRow = true;
            resources.ApplyResources(this.mainMenu, "mainMenu");
            // 
            // testeesBarButton
            // 
            resources.ApplyResources(this.testeesBarButton, "testeesBarButton");
            this.testeesBarButton.Id = 0;
            this.testeesBarButton.Name = "testeesBarButton";
            this.testeesBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.testeesBarButton_ItemClick);
            // 
            // trainingsBarButton
            // 
            resources.ApplyResources(this.trainingsBarButton, "trainingsBarButton");
            this.trainingsBarButton.Id = 1;
            this.trainingsBarButton.Name = "trainingsBarButton";
            this.trainingsBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.trainingsBarButton_ItemClick);
            // 
            // settingsBarButton
            // 
            resources.ApplyResources(this.settingsBarButton, "settingsBarButton");
            this.settingsBarButton.Id = 2;
            this.settingsBarButton.Name = "settingsBarButton";
            // 
            // testBarButton
            // 
            resources.ApplyResources(this.testBarButton, "testBarButton");
            this.testBarButton.Id = 3;
            this.testBarButton.Name = "testBarButton";
            this.testBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.testBarButton_ItemClick);
            // 
            // loginBarButton
            // 
            resources.ApplyResources(this.loginBarButton, "loginBarButton");
            this.loginBarButton.Id = 4;
            this.loginBarButton.Name = "loginBarButton";
            this.loginBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.loginBarButton_ItemClick);
            // 
            // questionBarButton
            // 
            resources.ApplyResources(this.questionBarButton, "questionBarButton");
            this.questionBarButton.Id = 5;
            this.questionBarButton.Name = "questionBarButton";
            this.questionBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.questionBarButton_ItemClick);
            // 
            // languageBarSubItem
            // 
            resources.ApplyResources(this.languageBarSubItem, "languageBarSubItem");
            this.languageBarSubItem.Id = 6;
            this.languageBarSubItem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.languageBarSubItem.Name = "languageBarSubItem";
            // 
            // barButtonItem1
            // 
            resources.ApplyResources(this.barButtonItem1, "barButtonItem1");
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            resources.ApplyResources(this.barButtonItem2, "barButtonItem2");
            this.barButtonItem2.Id = 8;
            this.barButtonItem2.Name = "barButtonItem2";
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
            resources.ApplyResources(this.statusBar, "statusBar");
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            resources.ApplyResources(this.barDockControlTop, "barDockControlTop");
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            resources.ApplyResources(this.barDockControlBottom, "barDockControlBottom");
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            resources.ApplyResources(this.barDockControlLeft, "barDockControlLeft");
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            resources.ApplyResources(this.barDockControlRight, "barDockControlRight");
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
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
        private DevExpress.XtraBars.BarButtonItem questionBarButton;
        private DevExpress.XtraBars.BarSubItem languageBarSubItem;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;


    }
}