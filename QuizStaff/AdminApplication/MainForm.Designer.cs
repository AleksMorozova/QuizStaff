namespace AdminApplication
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
            this.adminSettingsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.roleBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.aboutBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.reportBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.languageBarSubItem = new DevExpress.XtraBars.BarSubItem();
            this.russianBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.englishBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.statusBar = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.settingsBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.testBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.loginBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.questionBarButton = new DevExpress.XtraBars.BarButtonItem();
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
            this.russianBarButtonItem,
            this.englishBarButtonItem,
            this.adminSettingsBarButtonItem,
            this.roleBarButton,
            this.aboutBarButtonItem,
            this.reportBarButton,
            this.barButtonItem2});
            this.mainMenuManager.MainMenu = this.mainMenu;
            this.mainMenuManager.MaxItemId = 14;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.adminSettingsBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.roleBarButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.aboutBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.reportBarButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.languageBarSubItem, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
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
            // adminSettingsBarButtonItem
            // 
            resources.ApplyResources(this.adminSettingsBarButtonItem, "adminSettingsBarButtonItem");
            this.adminSettingsBarButtonItem.Id = 9;
            this.adminSettingsBarButtonItem.Name = "adminSettingsBarButtonItem";
            this.adminSettingsBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.adminSettingsBarButtonItem_ItemClick);
            // 
            // roleBarButton
            // 
            resources.ApplyResources(this.roleBarButton, "roleBarButton");
            this.roleBarButton.Id = 10;
            this.roleBarButton.Name = "roleBarButton";
            this.roleBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.roleBarButton_ItemClick);
            // 
            // aboutBarButtonItem
            // 
            resources.ApplyResources(this.aboutBarButtonItem, "aboutBarButtonItem");
            this.aboutBarButtonItem.Id = 11;
            this.aboutBarButtonItem.Name = "aboutBarButtonItem";
            this.aboutBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.aboutBarButtonItem_ItemClick);
            // 
            // reportBarButton
            // 
            resources.ApplyResources(this.reportBarButton, "reportBarButton");
            this.reportBarButton.Id = 12;
            this.reportBarButton.Name = "reportBarButton";
            this.reportBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.reportBarButton_ItemClick);
            // 
            // languageBarSubItem
            // 
            resources.ApplyResources(this.languageBarSubItem, "languageBarSubItem");
            this.languageBarSubItem.Id = 6;
            this.languageBarSubItem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.russianBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.englishBarButtonItem)});
            this.languageBarSubItem.Name = "languageBarSubItem";
            // 
            // russianBarButtonItem
            // 
            resources.ApplyResources(this.russianBarButtonItem, "russianBarButtonItem");
            this.russianBarButtonItem.Id = 7;
            this.russianBarButtonItem.Name = "russianBarButtonItem";
            this.russianBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.russianBarButtonItem_ItemClick);
            // 
            // englishBarButtonItem
            // 
            resources.ApplyResources(this.englishBarButtonItem, "englishBarButtonItem");
            this.englishBarButtonItem.Id = 8;
            this.englishBarButtonItem.Name = "englishBarButtonItem";
            this.englishBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.englishBarButtonItem_ItemClick);
            // 
            // barButtonItem2
            // 
            resources.ApplyResources(this.barButtonItem2, "barButtonItem2");
            this.barButtonItem2.Id = 13;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
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
            // settingsBarButton
            // 
            resources.ApplyResources(this.settingsBarButton, "settingsBarButton");
            this.settingsBarButton.Id = 2;
            this.settingsBarButton.Name = "settingsBarButton";
            this.settingsBarButton.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // testBarButton
            // 
            resources.ApplyResources(this.testBarButton, "testBarButton");
            this.testBarButton.Id = 3;
            this.testBarButton.Name = "testBarButton";
            this.testBarButton.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // loginBarButton
            // 
            resources.ApplyResources(this.loginBarButton, "loginBarButton");
            this.loginBarButton.Id = 4;
            this.loginBarButton.Name = "loginBarButton";
            this.loginBarButton.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // questionBarButton
            // 
            resources.ApplyResources(this.questionBarButton, "questionBarButton");
            this.questionBarButton.Id = 5;
            this.questionBarButton.Name = "questionBarButton";
            this.questionBarButton.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
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
        private DevExpress.XtraBars.BarButtonItem russianBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem englishBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem adminSettingsBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem roleBarButton;
        private DevExpress.XtraBars.BarButtonItem aboutBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem reportBarButton;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    }
}