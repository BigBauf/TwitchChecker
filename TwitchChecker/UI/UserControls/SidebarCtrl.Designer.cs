namespace TwitchChecker.UI.UserControls
{
	partial class SidebarCtrl
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
			this.pbSettings = new System.Windows.Forms.PictureBox();
			this.pbMulitCast = new System.Windows.Forms.PictureBox();
			this.pbFollowing = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pbSettings)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbMulitCast)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbFollowing)).BeginInit();
			this.SuspendLayout();
			// 
			// pbSettings
			// 
			this.pbSettings.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbSettings.Image = global::TwitchChecker.Properties.Resources.Settings;
			this.pbSettings.Location = new System.Drawing.Point(0, 68);
			this.pbSettings.Name = "pbSettings";
			this.pbSettings.Size = new System.Drawing.Size(42, 34);
			this.pbSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbSettings.TabIndex = 2;
			this.pbSettings.TabStop = false;
			this.pbSettings.Click += new System.EventHandler(this.PictureBox_Clicked);
			this.pbSettings.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnter);
			this.pbSettings.MouseLeave += new System.EventHandler(this.PictureBox_MouseLeave);
			// 
			// pbMulitCast
			// 
			this.pbMulitCast.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbMulitCast.Image = global::TwitchChecker.Properties.Resources.Multicast;
			this.pbMulitCast.Location = new System.Drawing.Point(0, 34);
			this.pbMulitCast.Name = "pbMulitCast";
			this.pbMulitCast.Size = new System.Drawing.Size(42, 34);
			this.pbMulitCast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbMulitCast.TabIndex = 1;
			this.pbMulitCast.TabStop = false;
			this.pbMulitCast.Click += new System.EventHandler(this.PictureBox_Clicked);
			this.pbMulitCast.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnter);
			this.pbMulitCast.MouseLeave += new System.EventHandler(this.PictureBox_MouseLeave);
			// 
			// pbFollowing
			// 
			this.pbFollowing.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbFollowing.Image = global::TwitchChecker.Properties.Resources.Following;
			this.pbFollowing.Location = new System.Drawing.Point(0, 0);
			this.pbFollowing.Name = "pbFollowing";
			this.pbFollowing.Size = new System.Drawing.Size(42, 34);
			this.pbFollowing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbFollowing.TabIndex = 0;
			this.pbFollowing.TabStop = false;
			this.pbFollowing.Click += new System.EventHandler(this.PictureBox_Clicked);
			this.pbFollowing.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnter);
			this.pbFollowing.MouseLeave += new System.EventHandler(this.PictureBox_MouseLeave);
			// 
			// SidebarCtrl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pbSettings);
			this.Controls.Add(this.pbMulitCast);
			this.Controls.Add(this.pbFollowing);
			this.Name = "SidebarCtrl";
			this.Size = new System.Drawing.Size(42, 501);
			this.DockChanged += new System.EventHandler(this._DockChanged);
			((System.ComponentModel.ISupportInitialize)(this.pbSettings)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbMulitCast)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbFollowing)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pbFollowing;
		private System.Windows.Forms.PictureBox pbMulitCast;
		private System.Windows.Forms.PictureBox pbSettings;
	}
}
