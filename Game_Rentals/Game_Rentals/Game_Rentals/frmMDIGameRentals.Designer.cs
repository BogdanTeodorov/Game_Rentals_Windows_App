
namespace Game_Rentals
{
    partial class frmMDIGameRentals
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDIGameRentals));
            menuStrip = new MenuStrip();
            cataloguesToolStripMenuItem = new ToolStripMenuItem();
            gameCatalogueToolStripMenuItem = new ToolStripMenuItem();
            usersListsToolStripMenuItem = new ToolStripMenuItem();
            myRentalsToolStripMenuItem = new ToolStripMenuItem();
            windowsMenu = new ToolStripMenuItem();
            newWindowToolStripMenuItem = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            tileVerticalToolStripMenuItem = new ToolStripMenuItem();
            tileHorizontalToolStripMenuItem = new ToolStripMenuItem();
            closeAllToolStripMenuItem = new ToolStripMenuItem();
            arrangeIconsToolStripMenuItem = new ToolStripMenuItem();
            browseGamesToolStripMenuItem = new ToolStripMenuItem();
            browseClientsToolStripMenuItem = new ToolStripMenuItem();
            toolStrip = new ToolStrip();
            newToolStripButton = new ToolStripButton();
            openToolStripButton = new ToolStripButton();
            saveToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            printToolStripButton = new ToolStripButton();
            printPreviewToolStripButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            helpToolStripButton = new ToolStripButton();
            statusStrip = new StatusStrip();
            StatusLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            browseRentalsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            toolStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { cataloguesToolStripMenuItem, windowsMenu, browseGamesToolStripMenuItem, browseClientsToolStripMenuItem, browseRentalsToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.MdiWindowListItem = windowsMenu;
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 2, 0, 2);
            menuStrip.Size = new Size(1177, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // cataloguesToolStripMenuItem
            // 
            cataloguesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gameCatalogueToolStripMenuItem, usersListsToolStripMenuItem, myRentalsToolStripMenuItem });
            cataloguesToolStripMenuItem.Name = "cataloguesToolStripMenuItem";
            cataloguesToolStripMenuItem.Size = new Size(78, 20);
            cataloguesToolStripMenuItem.Text = "Catalogues";
            // 
            // gameCatalogueToolStripMenuItem
            // 
            gameCatalogueToolStripMenuItem.Name = "gameCatalogueToolStripMenuItem";
            gameCatalogueToolStripMenuItem.Size = new Size(162, 22);
            gameCatalogueToolStripMenuItem.Tag = "games";
            gameCatalogueToolStripMenuItem.Text = "Game Catalogue";
            gameCatalogueToolStripMenuItem.Click += ShowNewForm;
            // 
            // usersListsToolStripMenuItem
            // 
            usersListsToolStripMenuItem.Name = "usersListsToolStripMenuItem";
            usersListsToolStripMenuItem.Size = new Size(162, 22);
            usersListsToolStripMenuItem.Tag = "users";
            usersListsToolStripMenuItem.Text = "Users Lists";
            usersListsToolStripMenuItem.Click += ShowNewForm;
            // 
            // myRentalsToolStripMenuItem
            // 
            myRentalsToolStripMenuItem.Name = "myRentalsToolStripMenuItem";
            myRentalsToolStripMenuItem.Size = new Size(162, 22);
            myRentalsToolStripMenuItem.Tag = "rentals";
            myRentalsToolStripMenuItem.Text = "MyRentals";
            myRentalsToolStripMenuItem.Click += ShowNewForm;
            // 
            // windowsMenu
            // 
            windowsMenu.DropDownItems.AddRange(new ToolStripItem[] { newWindowToolStripMenuItem, cascadeToolStripMenuItem, tileVerticalToolStripMenuItem, tileHorizontalToolStripMenuItem, closeAllToolStripMenuItem, arrangeIconsToolStripMenuItem });
            windowsMenu.Name = "windowsMenu";
            windowsMenu.Size = new Size(68, 20);
            windowsMenu.Text = "&Windows";
            // 
            // newWindowToolStripMenuItem
            // 
            newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            newWindowToolStripMenuItem.Size = new Size(150, 22);
            newWindowToolStripMenuItem.Text = "&New Window";
            newWindowToolStripMenuItem.Click += ShowNewForm;
            // 
            // cascadeToolStripMenuItem
            // 
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new Size(150, 22);
            cascadeToolStripMenuItem.Text = "&Cascade";
            cascadeToolStripMenuItem.Click += CascadeToolStripMenuItem_Click;
            // 
            // tileVerticalToolStripMenuItem
            // 
            tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            tileVerticalToolStripMenuItem.Size = new Size(150, 22);
            tileVerticalToolStripMenuItem.Text = "Tile &Vertical";
            tileVerticalToolStripMenuItem.Click += TileVerticalToolStripMenuItem_Click;
            // 
            // tileHorizontalToolStripMenuItem
            // 
            tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            tileHorizontalToolStripMenuItem.Size = new Size(150, 22);
            tileHorizontalToolStripMenuItem.Text = "Tile &Horizontal";
            tileHorizontalToolStripMenuItem.Click += TileHorizontalToolStripMenuItem_Click;
            // 
            // closeAllToolStripMenuItem
            // 
            closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            closeAllToolStripMenuItem.Size = new Size(150, 22);
            closeAllToolStripMenuItem.Text = "C&lose All";
            closeAllToolStripMenuItem.Click += CloseAllToolStripMenuItem_Click;
            // 
            // arrangeIconsToolStripMenuItem
            // 
            arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            arrangeIconsToolStripMenuItem.Size = new Size(150, 22);
            arrangeIconsToolStripMenuItem.Text = "&Arrange Icons";
            arrangeIconsToolStripMenuItem.Click += ArrangeIconsToolStripMenuItem_Click;
            // 
            // browseGamesToolStripMenuItem
            // 
            browseGamesToolStripMenuItem.Name = "browseGamesToolStripMenuItem";
            browseGamesToolStripMenuItem.Size = new Size(96, 20);
            browseGamesToolStripMenuItem.Tag = "BrowseGames";
            browseGamesToolStripMenuItem.Text = "Browse Games";
            browseGamesToolStripMenuItem.Click += ShowNewForm;
            // 
            // browseClientsToolStripMenuItem
            // 
            browseClientsToolStripMenuItem.Name = "browseClientsToolStripMenuItem";
            browseClientsToolStripMenuItem.Size = new Size(117, 20);
            browseClientsToolStripMenuItem.Tag = "BrowseCustomers";
            browseClientsToolStripMenuItem.Text = "Browse Customers";
            browseClientsToolStripMenuItem.Click += ShowNewForm;
            // 
            // toolStrip
            // 
            toolStrip.Items.AddRange(new ToolStripItem[] { newToolStripButton, openToolStripButton, saveToolStripButton, toolStripSeparator1, printToolStripButton, printPreviewToolStripButton, toolStripSeparator2, helpToolStripButton });
            toolStrip.Location = new Point(0, 24);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(1177, 25);
            toolStrip.TabIndex = 1;
            toolStrip.Text = "ToolStrip";
            // 
            // newToolStripButton
            // 
            newToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            newToolStripButton.Image = (Image)resources.GetObject("newToolStripButton.Image");
            newToolStripButton.ImageTransparentColor = Color.Black;
            newToolStripButton.Name = "newToolStripButton";
            newToolStripButton.Size = new Size(23, 22);
            newToolStripButton.Text = "New";
            newToolStripButton.Click += ShowNewForm;
            // 
            // openToolStripButton
            // 
            openToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            openToolStripButton.Image = (Image)resources.GetObject("openToolStripButton.Image");
            openToolStripButton.ImageTransparentColor = Color.Black;
            openToolStripButton.Name = "openToolStripButton";
            openToolStripButton.Size = new Size(23, 22);
            openToolStripButton.Text = "Open";
            openToolStripButton.Click += OpenFile;
            // 
            // saveToolStripButton
            // 
            saveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveToolStripButton.Image = (Image)resources.GetObject("saveToolStripButton.Image");
            saveToolStripButton.ImageTransparentColor = Color.Black;
            saveToolStripButton.Name = "saveToolStripButton";
            saveToolStripButton.Size = new Size(23, 22);
            saveToolStripButton.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // printToolStripButton
            // 
            printToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            printToolStripButton.Image = (Image)resources.GetObject("printToolStripButton.Image");
            printToolStripButton.ImageTransparentColor = Color.Black;
            printToolStripButton.Name = "printToolStripButton";
            printToolStripButton.Size = new Size(23, 22);
            printToolStripButton.Text = "Print";
            // 
            // printPreviewToolStripButton
            // 
            printPreviewToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            printPreviewToolStripButton.Image = (Image)resources.GetObject("printPreviewToolStripButton.Image");
            printPreviewToolStripButton.ImageTransparentColor = Color.Black;
            printPreviewToolStripButton.Name = "printPreviewToolStripButton";
            printPreviewToolStripButton.Size = new Size(23, 22);
            printPreviewToolStripButton.Text = "Print Preview";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // helpToolStripButton
            // 
            helpToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            helpToolStripButton.Image = (Image)resources.GetObject("helpToolStripButton.Image");
            helpToolStripButton.ImageTransparentColor = Color.Black;
            helpToolStripButton.Name = "helpToolStripButton";
            helpToolStripButton.Size = new Size(23, 22);
            helpToolStripButton.Text = "Help";
            // 
            // statusStrip
            // 
            statusStrip.BackColor = Color.LightSteelBlue;
            statusStrip.Items.AddRange(new ToolStripItem[] { StatusLabel });
            statusStrip.Location = new Point(0, 498);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(1177, 23);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // StatusLabel
            // 
            StatusLabel.Font = new Font("Roboto Slab", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(54, 18);
            StatusLabel.Text = "Status";
            // 
            // browseRentalsToolStripMenuItem
            // 
            browseRentalsToolStripMenuItem.Name = "browseRentalsToolStripMenuItem";
            browseRentalsToolStripMenuItem.Size = new Size(98, 20);
            browseRentalsToolStripMenuItem.Tag = "BrowseRentals";
            browseRentalsToolStripMenuItem.Text = "Browse Rentals";
            browseRentalsToolStripMenuItem.Click += ShowNewForm;
            // 
            // frmMDIGameRentals
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.mdiBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1177, 521);
            Controls.Add(statusStrip);
            Controls.Add(toolStrip);
            Controls.Add(menuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmMDIGameRentals";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game Rentals (Admin) Main Window";
            WindowState = FormWindowState.Maximized;
            Load += frmMDIParent_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton printPreviewToolStripButton;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStripMenuItem cataloguesToolStripMenuItem;
        private ToolStripMenuItem gameCatalogueToolStripMenuItem;
        private ToolStripMenuItem usersListsToolStripMenuItem;
        private ToolStripMenuItem myRentalsToolStripMenuItem;
        private ToolStripStatusLabel StatusLabel;
        private ToolStripMenuItem browseGamesToolStripMenuItem;
        private ToolStripMenuItem browseClientsToolStripMenuItem;
        private ToolStripMenuItem browseRentalsToolStripMenuItem;
    }
}



