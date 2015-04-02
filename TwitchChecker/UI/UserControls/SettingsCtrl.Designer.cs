namespace TwitchChecker.UI.UserControls
{
	partial class SettingsCtrl
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
			this.pnlMain = new System.Windows.Forms.Panel();
			this.splitter4 = new System.Windows.Forms.Splitter();
			this.grbMisc = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.labelEx1 = new System.Windows.Forms.Label();
			this.cbStartWithWindows = new System.Windows.Forms.CheckBox();
			this.cbShowOfflineChannels = new System.Windows.Forms.CheckBox();
			this.cbShowNotification = new System.Windows.Forms.CheckBox();
			this.cbPlayNotificationSound = new System.Windows.Forms.CheckBox();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.grbLivestreamer = new System.Windows.Forms.Panel();
			this.labelEx2 = new System.Windows.Forms.Label();
			this.cbHideConsole = new System.Windows.Forms.CheckBox();
			this.cbKeepConsoleOpen = new System.Windows.Forms.CheckBox();
			this.splitter2 = new System.Windows.Forms.Splitter();
			this.grbStreamOptions = new System.Windows.Forms.Panel();
			this.labelEx3 = new System.Windows.Forms.Label();
			this.rdbLivestreamer = new System.Windows.Forms.RadioButton();
			this.rdbPopout = new System.Windows.Forms.RadioButton();
			this.rbFullPage = new System.Windows.Forms.RadioButton();
			this.lblQuality = new System.Windows.Forms.Label();
			this.splitter3 = new System.Windows.Forms.Splitter();
			this.grbTwitch = new System.Windows.Forms.Panel();
			this.btnTestNotifcation = new System.Windows.Forms.Button();
			this.labelEx4 = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.lblUsername = new System.Windows.Forms.Label();
			this.cbxThemes = new TwitchChecker.UI.UserControls.Common.ComboBoxEx();
			this.cbxQuality = new TwitchChecker.UI.UserControls.Common.ComboBoxEx();
			this.pnlMain.SuspendLayout();
			this.grbMisc.SuspendLayout();
			this.grbLivestreamer.SuspendLayout();
			this.grbStreamOptions.SuspendLayout();
			this.grbTwitch.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlMain
			// 
			this.pnlMain.AutoScroll = true;
			this.pnlMain.Controls.Add(this.splitter4);
			this.pnlMain.Controls.Add(this.grbMisc);
			this.pnlMain.Controls.Add(this.splitter1);
			this.pnlMain.Controls.Add(this.grbLivestreamer);
			this.pnlMain.Controls.Add(this.splitter2);
			this.pnlMain.Controls.Add(this.grbStreamOptions);
			this.pnlMain.Controls.Add(this.splitter3);
			this.pnlMain.Controls.Add(this.grbTwitch);
			this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMain.Location = new System.Drawing.Point(0, 0);
			this.pnlMain.Name = "pnlMain";
			this.pnlMain.Size = new System.Drawing.Size(328, 533);
			this.pnlMain.TabIndex = 31;
			// 
			// splitter4
			// 
			this.splitter4.BackColor = System.Drawing.SystemColors.ControlDark;
			this.splitter4.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.splitter4.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter4.Location = new System.Drawing.Point(0, 419);
			this.splitter4.Name = "splitter4";
			this.splitter4.Size = new System.Drawing.Size(328, 2);
			this.splitter4.TabIndex = 33;
			this.splitter4.TabStop = false;
			// 
			// grbMisc
			// 
			this.grbMisc.AutoSize = true;
			this.grbMisc.Controls.Add(this.cbxThemes);
			this.grbMisc.Controls.Add(this.label1);
			this.grbMisc.Controls.Add(this.labelEx1);
			this.grbMisc.Controls.Add(this.cbStartWithWindows);
			this.grbMisc.Controls.Add(this.cbShowOfflineChannels);
			this.grbMisc.Controls.Add(this.cbShowNotification);
			this.grbMisc.Controls.Add(this.cbPlayNotificationSound);
			this.grbMisc.Dock = System.Windows.Forms.DockStyle.Top;
			this.grbMisc.ForeColor = System.Drawing.SystemColors.ControlText;
			this.grbMisc.Location = new System.Drawing.Point(0, 256);
			this.grbMisc.Name = "grbMisc";
			this.grbMisc.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
			this.grbMisc.Size = new System.Drawing.Size(328, 163);
			this.grbMisc.TabIndex = 28;
			this.grbMisc.Text = "Misc.";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(5, 115);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 31;
			this.label1.Text = "Theme";
			// 
			// labelEx1
			// 
			this.labelEx1.AutoSize = true;
			this.labelEx1.Location = new System.Drawing.Point(3, 3);
			this.labelEx1.Name = "labelEx1";
			this.labelEx1.Size = new System.Drawing.Size(29, 13);
			this.labelEx1.TabIndex = 30;
			this.labelEx1.Text = "Misc";
			// 
			// cbStartWithWindows
			// 
			this.cbStartWithWindows.AutoSize = true;
			this.cbStartWithWindows.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cbStartWithWindows.Location = new System.Drawing.Point(8, 24);
			this.cbStartWithWindows.Name = "cbStartWithWindows";
			this.cbStartWithWindows.Size = new System.Drawing.Size(115, 17);
			this.cbStartWithWindows.TabIndex = 29;
			this.cbStartWithWindows.Text = "start with Windows";
			this.cbStartWithWindows.UseVisualStyleBackColor = true;
			this.cbStartWithWindows.CheckedChanged += new System.EventHandler(this.Misc_CheckedChanged);
			// 
			// cbShowOfflineChannels
			// 
			this.cbShowOfflineChannels.AutoSize = true;
			this.cbShowOfflineChannels.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cbShowOfflineChannels.Location = new System.Drawing.Point(8, 48);
			this.cbShowOfflineChannels.Name = "cbShowOfflineChannels";
			this.cbShowOfflineChannels.Size = new System.Drawing.Size(128, 17);
			this.cbShowOfflineChannels.TabIndex = 28;
			this.cbShowOfflineChannels.Text = "show offline channels";
			this.cbShowOfflineChannels.UseVisualStyleBackColor = true;
			this.cbShowOfflineChannels.CheckedChanged += new System.EventHandler(this.Misc_CheckedChanged);
			// 
			// cbShowNotification
			// 
			this.cbShowNotification.AutoSize = true;
			this.cbShowNotification.Enabled = false;
			this.cbShowNotification.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cbShowNotification.Location = new System.Drawing.Point(8, 71);
			this.cbShowNotification.Name = "cbShowNotification";
			this.cbShowNotification.Size = new System.Drawing.Size(105, 17);
			this.cbShowNotification.TabIndex = 23;
			this.cbShowNotification.Text = "show notification";
			this.cbShowNotification.UseVisualStyleBackColor = true;
			this.cbShowNotification.Visible = false;
			this.cbShowNotification.CheckedChanged += new System.EventHandler(this.Misc_CheckedChanged);
			// 
			// cbPlayNotificationSound
			// 
			this.cbPlayNotificationSound.AutoSize = true;
			this.cbPlayNotificationSound.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cbPlayNotificationSound.Location = new System.Drawing.Point(8, 95);
			this.cbPlayNotificationSound.Name = "cbPlayNotificationSound";
			this.cbPlayNotificationSound.Size = new System.Drawing.Size(77, 17);
			this.cbPlayNotificationSound.TabIndex = 24;
			this.cbPlayNotificationSound.Text = "play sound";
			this.cbPlayNotificationSound.UseVisualStyleBackColor = true;
			this.cbPlayNotificationSound.Visible = false;
			this.cbPlayNotificationSound.CheckedChanged += new System.EventHandler(this.Misc_CheckedChanged);
			// 
			// splitter1
			// 
			this.splitter1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.splitter1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter1.Location = new System.Drawing.Point(0, 254);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(328, 2);
			this.splitter1.TabIndex = 30;
			this.splitter1.TabStop = false;
			// 
			// grbLivestreamer
			// 
			this.grbLivestreamer.AutoSize = true;
			this.grbLivestreamer.Controls.Add(this.labelEx2);
			this.grbLivestreamer.Controls.Add(this.cbHideConsole);
			this.grbLivestreamer.Controls.Add(this.cbKeepConsoleOpen);
			this.grbLivestreamer.Dock = System.Windows.Forms.DockStyle.Top;
			this.grbLivestreamer.ForeColor = System.Drawing.SystemColors.ControlText;
			this.grbLivestreamer.Location = new System.Drawing.Point(0, 178);
			this.grbLivestreamer.Name = "grbLivestreamer";
			this.grbLivestreamer.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
			this.grbLivestreamer.Size = new System.Drawing.Size(328, 76);
			this.grbLivestreamer.TabIndex = 29;
			this.grbLivestreamer.Text = "Livestreamer";
			// 
			// labelEx2
			// 
			this.labelEx2.AutoSize = true;
			this.labelEx2.Location = new System.Drawing.Point(3, 3);
			this.labelEx2.Name = "labelEx2";
			this.labelEx2.Size = new System.Drawing.Size(67, 13);
			this.labelEx2.TabIndex = 31;
			this.labelEx2.Text = "Livestreamer";
			// 
			// cbHideConsole
			// 
			this.cbHideConsole.AutoSize = true;
			this.cbHideConsole.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cbHideConsole.Location = new System.Drawing.Point(8, 48);
			this.cbHideConsole.Name = "cbHideConsole";
			this.cbHideConsole.Size = new System.Drawing.Size(86, 17);
			this.cbHideConsole.TabIndex = 30;
			this.cbHideConsole.Text = "hide console";
			this.cbHideConsole.UseVisualStyleBackColor = true;
			this.cbHideConsole.CheckedChanged += new System.EventHandler(this.Livestreamer_CheckedChanged);
			// 
			// cbKeepConsoleOpen
			// 
			this.cbKeepConsoleOpen.AutoSize = true;
			this.cbKeepConsoleOpen.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cbKeepConsoleOpen.Location = new System.Drawing.Point(8, 24);
			this.cbKeepConsoleOpen.Name = "cbKeepConsoleOpen";
			this.cbKeepConsoleOpen.Size = new System.Drawing.Size(117, 17);
			this.cbKeepConsoleOpen.TabIndex = 29;
			this.cbKeepConsoleOpen.Text = "keep console open";
			this.cbKeepConsoleOpen.UseVisualStyleBackColor = true;
			this.cbKeepConsoleOpen.CheckedChanged += new System.EventHandler(this.Livestreamer_CheckedChanged);
			// 
			// splitter2
			// 
			this.splitter2.BackColor = System.Drawing.SystemColors.ControlDark;
			this.splitter2.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter2.Location = new System.Drawing.Point(0, 176);
			this.splitter2.Name = "splitter2";
			this.splitter2.Size = new System.Drawing.Size(328, 2);
			this.splitter2.TabIndex = 31;
			this.splitter2.TabStop = false;
			// 
			// grbStreamOptions
			// 
			this.grbStreamOptions.AutoSize = true;
			this.grbStreamOptions.Controls.Add(this.labelEx3);
			this.grbStreamOptions.Controls.Add(this.rdbLivestreamer);
			this.grbStreamOptions.Controls.Add(this.rdbPopout);
			this.grbStreamOptions.Controls.Add(this.cbxQuality);
			this.grbStreamOptions.Controls.Add(this.rbFullPage);
			this.grbStreamOptions.Controls.Add(this.lblQuality);
			this.grbStreamOptions.Dock = System.Windows.Forms.DockStyle.Top;
			this.grbStreamOptions.ForeColor = System.Drawing.SystemColors.ControlText;
			this.grbStreamOptions.Location = new System.Drawing.Point(0, 73);
			this.grbStreamOptions.Name = "grbStreamOptions";
			this.grbStreamOptions.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
			this.grbStreamOptions.Size = new System.Drawing.Size(328, 103);
			this.grbStreamOptions.TabIndex = 25;
			this.grbStreamOptions.Text = "open stream in";
			// 
			// labelEx3
			// 
			this.labelEx3.AutoSize = true;
			this.labelEx3.Location = new System.Drawing.Point(3, 3);
			this.labelEx3.Name = "labelEx3";
			this.labelEx3.Size = new System.Drawing.Size(59, 13);
			this.labelEx3.TabIndex = 32;
			this.labelEx3.Text = "View mode";
			// 
			// rdbLivestreamer
			// 
			this.rdbLivestreamer.AutoSize = true;
			this.rdbLivestreamer.ForeColor = System.Drawing.SystemColors.ControlText;
			this.rdbLivestreamer.Location = new System.Drawing.Point(8, 72);
			this.rdbLivestreamer.Name = "rdbLivestreamer";
			this.rdbLivestreamer.Size = new System.Drawing.Size(85, 17);
			this.rdbLivestreamer.TabIndex = 2;
			this.rdbLivestreamer.TabStop = true;
			this.rdbLivestreamer.Text = "Livestreamer";
			this.rdbLivestreamer.UseVisualStyleBackColor = true;
			this.rdbLivestreamer.CheckedChanged += new System.EventHandler(this.ViewMode_CheckedChanged);
			// 
			// rdbPopout
			// 
			this.rdbPopout.AutoSize = true;
			this.rdbPopout.ForeColor = System.Drawing.SystemColors.ControlText;
			this.rdbPopout.Location = new System.Drawing.Point(8, 48);
			this.rdbPopout.Name = "rdbPopout";
			this.rdbPopout.Size = new System.Drawing.Size(59, 17);
			this.rdbPopout.TabIndex = 1;
			this.rdbPopout.TabStop = true;
			this.rdbPopout.Text = "Popout";
			this.rdbPopout.UseVisualStyleBackColor = true;
			this.rdbPopout.CheckedChanged += new System.EventHandler(this.ViewMode_CheckedChanged);
			// 
			// rbFullPage
			// 
			this.rbFullPage.AutoSize = true;
			this.rbFullPage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.rbFullPage.Location = new System.Drawing.Point(8, 24);
			this.rbFullPage.Name = "rbFullPage";
			this.rbFullPage.Size = new System.Drawing.Size(50, 17);
			this.rbFullPage.TabIndex = 0;
			this.rbFullPage.TabStop = true;
			this.rbFullPage.Text = "Page";
			this.rbFullPage.UseVisualStyleBackColor = true;
			this.rbFullPage.CheckedChanged += new System.EventHandler(this.ViewMode_CheckedChanged);
			// 
			// lblQuality
			// 
			this.lblQuality.AutoSize = true;
			this.lblQuality.Location = new System.Drawing.Point(104, 50);
			this.lblQuality.Name = "lblQuality";
			this.lblQuality.Size = new System.Drawing.Size(39, 13);
			this.lblQuality.TabIndex = 17;
			this.lblQuality.Text = "Quality";
			// 
			// splitter3
			// 
			this.splitter3.BackColor = System.Drawing.SystemColors.ControlDark;
			this.splitter3.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.splitter3.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter3.Location = new System.Drawing.Point(0, 71);
			this.splitter3.Name = "splitter3";
			this.splitter3.Size = new System.Drawing.Size(328, 2);
			this.splitter3.TabIndex = 32;
			this.splitter3.TabStop = false;
			// 
			// grbTwitch
			// 
			this.grbTwitch.AutoSize = true;
			this.grbTwitch.Controls.Add(this.btnTestNotifcation);
			this.grbTwitch.Controls.Add(this.labelEx4);
			this.grbTwitch.Controls.Add(this.txtUsername);
			this.grbTwitch.Controls.Add(this.lblUsername);
			this.grbTwitch.Dock = System.Windows.Forms.DockStyle.Top;
			this.grbTwitch.ForeColor = System.Drawing.SystemColors.ControlText;
			this.grbTwitch.Location = new System.Drawing.Point(0, 0);
			this.grbTwitch.Name = "grbTwitch";
			this.grbTwitch.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
			this.grbTwitch.Size = new System.Drawing.Size(328, 71);
			this.grbTwitch.TabIndex = 26;
			this.grbTwitch.Text = "Twitch";
			// 
			// btnTestNotifcation
			// 
			this.btnTestNotifcation.Location = new System.Drawing.Point(174, 37);
			this.btnTestNotifcation.Name = "btnTestNotifcation";
			this.btnTestNotifcation.Size = new System.Drawing.Size(75, 23);
			this.btnTestNotifcation.TabIndex = 34;
			this.btnTestNotifcation.Text = "textNotifcation";
			this.btnTestNotifcation.UseVisualStyleBackColor = true;
			this.btnTestNotifcation.Visible = false;
			this.btnTestNotifcation.Click += new System.EventHandler(this.TestNotifcation_Click);
			// 
			// labelEx4
			// 
			this.labelEx4.AutoSize = true;
			this.labelEx4.Location = new System.Drawing.Point(3, 3);
			this.labelEx4.Name = "labelEx4";
			this.labelEx4.Size = new System.Drawing.Size(39, 13);
			this.labelEx4.TabIndex = 33;
			this.labelEx4.Text = "Twitch";
			// 
			// txtUsername
			// 
			this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtUsername.Location = new System.Drawing.Point(8, 40);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(160, 20);
			this.txtUsername.TabIndex = 18;
			this.txtUsername.TextChanged += new System.EventHandler(this.Username_TextChanged);
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Location = new System.Drawing.Point(8, 24);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(55, 13);
			this.lblUsername.TabIndex = 15;
			this.lblUsername.Text = "Username";
			// 
			// cbxThemes
			// 
			this.cbxThemes.BackColor = System.Drawing.SystemColors.Control;
			this.cbxThemes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxThemes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbxThemes.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cbxThemes.FormattingEnabled = true;
			this.cbxThemes.Location = new System.Drawing.Point(8, 131);
			this.cbxThemes.Name = "cbxThemes";
			this.cbxThemes.Size = new System.Drawing.Size(120, 21);
			this.cbxThemes.TabIndex = 32;
			this.cbxThemes.SelectionChangeCommitted += new System.EventHandler(this.Themes_SelectionChangeCommitted);
			// 
			// cbxQuality
			// 
			this.cbxQuality.BackColor = System.Drawing.SystemColors.Control;
			this.cbxQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxQuality.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbxQuality.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cbxQuality.FormattingEnabled = true;
			this.cbxQuality.Location = new System.Drawing.Point(107, 71);
			this.cbxQuality.Name = "cbxQuality";
			this.cbxQuality.Size = new System.Drawing.Size(120, 21);
			this.cbxQuality.TabIndex = 20;
			this.cbxQuality.SelectionChangeCommitted += new System.EventHandler(this.Quality_SelectionChangeCommitted);
			// 
			// SettingsCtrl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.Controls.Add(this.pnlMain);
			this.Name = "SettingsCtrl";
			this.Size = new System.Drawing.Size(328, 533);
			this.Load += new System.EventHandler(this._Load);
			this.pnlMain.ResumeLayout(false);
			this.pnlMain.PerformLayout();
			this.grbMisc.ResumeLayout(false);
			this.grbMisc.PerformLayout();
			this.grbLivestreamer.ResumeLayout(false);
			this.grbLivestreamer.PerformLayout();
			this.grbStreamOptions.ResumeLayout(false);
			this.grbStreamOptions.PerformLayout();
			this.grbTwitch.ResumeLayout(false);
			this.grbTwitch.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.CheckBox cbShowNotification;
		private TwitchChecker.UI.UserControls.Common.ComboBoxEx cbxQuality;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label lblQuality;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.RadioButton rdbLivestreamer;
		private System.Windows.Forms.RadioButton rdbPopout;
		private System.Windows.Forms.RadioButton rbFullPage;
		private System.Windows.Forms.Panel grbTwitch;
		private System.Windows.Forms.CheckBox cbPlayNotificationSound;
		private System.Windows.Forms.CheckBox cbShowOfflineChannels;
		private System.Windows.Forms.CheckBox cbKeepConsoleOpen;
		private System.Windows.Forms.Panel pnlMain;
		private System.Windows.Forms.CheckBox cbStartWithWindows;
		private System.Windows.Forms.CheckBox cbHideConsole;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Splitter splitter4;
		private System.Windows.Forms.Panel grbMisc;
		private System.Windows.Forms.Panel grbLivestreamer;
		private System.Windows.Forms.Splitter splitter2;
		private System.Windows.Forms.Panel grbStreamOptions;
		private System.Windows.Forms.Splitter splitter3;
		private System.Windows.Forms.Label labelEx1;
		private System.Windows.Forms.Label labelEx2;
		private System.Windows.Forms.Label labelEx3;
		private System.Windows.Forms.Label labelEx4;
		private TwitchChecker.UI.UserControls.Common.ComboBoxEx cbxThemes;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnTestNotifcation;

	}
}
