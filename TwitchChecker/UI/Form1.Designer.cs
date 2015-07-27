namespace TwitchChecker.UI
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.notificationTray = new System.Windows.Forms.NotifyIcon(this.components);
			this.ctmTray = new TwitchChecker.UI.UserControls.Common.ContextMenuStripEx(this.components);
			this.ctmOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.ctmClose = new System.Windows.Forms.ToolStripMenuItem();
			this.asdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pnlMain = new System.Windows.Forms.Panel();
			this.sidebarCtrl1 = new TwitchChecker.UI.UserControls.SidebarCtrl();
			this.ctmTray.SuspendLayout();
			this.SuspendLayout();
			// 
			// notificationTray
			// 
			this.notificationTray.BalloonTipText = "Test";
			this.notificationTray.BalloonTipTitle = "Test";
			this.notificationTray.ContextMenuStrip = this.ctmTray;
			this.notificationTray.Icon = ((System.Drawing.Icon)(resources.GetObject("notificationTray.Icon")));
			this.notificationTray.Text = "TwitchChecker";
			this.notificationTray.Visible = true;
			this.notificationTray.DoubleClick += new System.EventHandler(this.notificationTray_DoubleClick);
			// 
			// ctmTray
			// 
			this.ctmTray.DropShadowEnabled = false;
			this.ctmTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctmOpen,
            this.ctmClose});
			this.ctmTray.Name = "ctmTray";
			this.ctmTray.ShowImageMargin = false;
			this.ctmTray.Size = new System.Drawing.Size(166, 48);
			this.ctmTray.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ctmTray_ItemClicked);
			// 
			// ctmOpen
			// 
			this.ctmOpen.Name = "ctmOpen";
			this.ctmOpen.Size = new System.Drawing.Size(165, 22);
			this.ctmOpen.Text = "TwitchChecker öffnen";
			// 
			// ctmClose
			// 
			this.ctmClose.Name = "ctmClose";
			this.ctmClose.Size = new System.Drawing.Size(165, 22);
			this.ctmClose.Text = "Beenden";
			// 
			// asdToolStripMenuItem
			// 
			this.asdToolStripMenuItem.Name = "asdToolStripMenuItem";
			this.asdToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.asdToolStripMenuItem.Text = "asd";
			// 
			// pnlMain
			// 
			this.pnlMain.AutoScroll = true;
			this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMain.Location = new System.Drawing.Point(40, 0);
			this.pnlMain.Name = "pnlMain";
			this.pnlMain.Size = new System.Drawing.Size(339, 661);
			this.pnlMain.TabIndex = 8;
			// 
			// sidebarCtrl1
			// 
			this.sidebarCtrl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.sidebarCtrl1.Dock = System.Windows.Forms.DockStyle.Left;
			this.sidebarCtrl1.Location = new System.Drawing.Point(0, 0);
			this.sidebarCtrl1.Name = "sidebarCtrl1";
			this.sidebarCtrl1.Size = new System.Drawing.Size(40, 661);
			this.sidebarCtrl1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(379, 661);
			this.Controls.Add(this.pnlMain);
			this.Controls.Add(this.sidebarCtrl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Twitch Checker";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
			this.Load += new System.EventHandler(this.Main_Load);
			this.ctmTray.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.NotifyIcon notificationTray;
		private TwitchChecker.UI.UserControls.Common.ContextMenuStripEx ctmTray;
		private System.Windows.Forms.ToolStripMenuItem ctmOpen;
		private System.Windows.Forms.ToolStripMenuItem ctmClose;
		private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem;
		private System.Windows.Forms.Panel pnlMain;
		private TwitchChecker.UI.UserControls.SidebarCtrl sidebarCtrl1;

	}
}

