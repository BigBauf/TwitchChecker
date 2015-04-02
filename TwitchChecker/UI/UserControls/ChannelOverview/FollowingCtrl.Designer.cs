namespace TwitchChecker.UI.UserControls
{
	partial class FollowingCtrl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.statusPnlOnline = new TwitchChecker.UI.UserControls.ChannelOverview.StatusPanelCtrl();
			this.statusPnlOffline = new TwitchChecker.UI.UserControls.ChannelOverview.StatusPanelCtrl();
			this.notificationManager = new TwitchChecker.UI.UserComponent.NotificationManager(this.components);
			this.SuspendLayout();
			// 
			// statusPnlOnline
			// 
			this.statusPnlOnline.AutoSize = true;
			this.statusPnlOnline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.statusPnlOnline.Dock = System.Windows.Forms.DockStyle.Top;
			this.statusPnlOnline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(142)))));
			this.statusPnlOnline.Location = new System.Drawing.Point(0, 0);
			this.statusPnlOnline.Name = "statusPnlOnline";
			this.statusPnlOnline.Size = new System.Drawing.Size(269, 41);
			this.statusPnlOnline.TabIndex = 0;
			// 
			// statusPnlOffline
			// 
			this.statusPnlOffline.AutoSize = true;
			this.statusPnlOffline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.statusPnlOffline.Dock = System.Windows.Forms.DockStyle.Top;
			this.statusPnlOffline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(142)))));
			this.statusPnlOffline.Location = new System.Drawing.Point(0, 41);
			this.statusPnlOffline.Name = "statusPnlOffline";
			this.statusPnlOffline.Size = new System.Drawing.Size(269, 41);
			this.statusPnlOffline.TabIndex = 1;
			// 
			// FollowingCtrl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.AutoSize = true;
			this.Controls.Add(this.statusPnlOffline);
			this.Controls.Add(this.statusPnlOnline);
			this.Name = "FollowingCtrl";
			this.Size = new System.Drawing.Size(269, 445);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ChannelOverview.StatusPanelCtrl statusPnlOnline;
		private ChannelOverview.StatusPanelCtrl statusPnlOffline;
		private UserComponent.NotificationManager notificationManager;
	}
}
