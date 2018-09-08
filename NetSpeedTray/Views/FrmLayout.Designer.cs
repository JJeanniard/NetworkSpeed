namespace Devoldere.NetSpeedTray.Views
{
    partial class FrmLayout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLayout));
            this.oNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.oContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReload = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReloadNetwork = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInterfaces = new System.Windows.Forms.ToolStripMenuItem();
            this.oMenu = new System.Windows.Forms.MenuStrip();
            this.menuView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewInterface = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewList = new System.Windows.Forms.ToolStripMenuItem();
            this.netView = new Devoldere.NetSpeedTray.Views.UCNetInterface();
            this.oContextMenu.SuspendLayout();
            this.oMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // oNotify
            // 
            this.oNotify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.oNotify.BalloonTipTitle = "Devoldere NetSpeed";
            this.oNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("oNotify.Icon")));
            this.oNotify.Text = "NetSpeedTray";
            this.oNotify.Visible = true;
            this.oNotify.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // oContextMenu
            // 
            this.oContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Exit});
            this.oContextMenu.Name = "contextMenuStrip1";
            this.oContextMenu.Size = new System.Drawing.Size(163, 26);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(162, 22);
            this.Exit.Text = "contextMenuExit";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuReload,
            this.menuReloadNetwork,
            this.menuAbout,
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "File";
            // 
            // menuReload
            // 
            this.menuReload.Image = global::Devoldere.NetSpeedTray.Properties.Resources.Refresh;
            this.menuReload.Name = "menuReload";
            this.menuReload.Size = new System.Drawing.Size(164, 22);
            this.menuReload.Text = "Reload";
            this.menuReload.Click += new System.EventHandler(this.ReloadApp);
            // 
            // menuReloadNetwork
            // 
            this.menuReloadNetwork.Image = global::Devoldere.NetSpeedTray.Properties.Resources.scroll_up_png;
            this.menuReloadNetwork.Name = "menuReloadNetwork";
            this.menuReloadNetwork.Size = new System.Drawing.Size(164, 22);
            this.menuReloadNetwork.Text = "Reload Interfaces";
            this.menuReloadNetwork.Click += new System.EventHandler(this.ReloadNetwork);
            // 
            // menuAbout
            // 
            this.menuAbout.Image = global::Devoldere.NetSpeedTray.Properties.Resources._2bs;
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(164, 22);
            this.menuAbout.Text = "About";
            this.menuAbout.Click += new System.EventHandler(this.AboutApp);
            // 
            // menuExit
            // 
            this.menuExit.Image = global::Devoldere.NetSpeedTray.Properties.Resources.Close;
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(164, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.CloseApp);
            // 
            // menuInterfaces
            // 
            this.menuInterfaces.Name = "menuInterfaces";
            this.menuInterfaces.Size = new System.Drawing.Size(70, 20);
            this.menuInterfaces.Text = "Interfaces";
            // 
            // oMenu
            // 
            this.oMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuView,
            this.menuInterfaces});
            this.oMenu.Location = new System.Drawing.Point(0, 0);
            this.oMenu.Name = "oMenu";
            this.oMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.oMenu.Size = new System.Drawing.Size(234, 24);
            this.oMenu.TabIndex = 12;
            // 
            // menuView
            // 
            this.menuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuViewInterface,
            this.menuViewList});
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(44, 20);
            this.menuView.Text = "View";
            // 
            // menuViewInterface
            // 
            this.menuViewInterface.Image = global::Devoldere.NetSpeedTray.Properties.Resources.single;
            this.menuViewInterface.Name = "menuViewInterface";
            this.menuViewInterface.Size = new System.Drawing.Size(180, 22);
            this.menuViewInterface.Text = "Single";
            this.menuViewInterface.Click += new System.EventHandler(this.menuViewInterface_Click);
            // 
            // menuViewList
            // 
            this.menuViewList.Image = global::Devoldere.NetSpeedTray.Properties.Resources.multi;
            this.menuViewList.Name = "menuViewList";
            this.menuViewList.Size = new System.Drawing.Size(180, 22);
            this.menuViewList.Text = "Multi";
            this.menuViewList.Click += new System.EventHandler(this.menuViewList_Click);
            // 
            // netView
            // 
            this.netView.Location = new System.Drawing.Point(11, 27);
            this.netView.Name = "netView";
            this.netView.Notify = false;
            this.netView.Size = new System.Drawing.Size(211, 150);
            this.netView.TabIndex = 13;
            // 
            // FrmLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 182);
            this.Controls.Add(this.netView);
            this.Controls.Add(this.oMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::Devoldere.NetSpeedTray.Properties.Resources.scroll;
            this.MainMenuStrip = this.oMenu;
            this.MaximizeBox = false;
            this.Name = "FrmLayout";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NetSpeed";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLayout_FormClosing);
            this.oContextMenu.ResumeLayout(false);
            this.oMenu.ResumeLayout(false);
            this.oMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NotifyIcon oNotify;
        private System.Windows.Forms.ContextMenuStrip oContextMenu;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuReload;
        private System.Windows.Forms.ToolStripMenuItem menuReloadNetwork;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuInterfaces;
        internal System.Windows.Forms.MenuStrip oMenu;
        private System.Windows.Forms.ToolStripMenuItem menuView;
        private System.Windows.Forms.ToolStripMenuItem menuViewInterface;
        private UCNetInterface netView;
        private System.Windows.Forms.ToolStripMenuItem menuViewList;
    }
}
