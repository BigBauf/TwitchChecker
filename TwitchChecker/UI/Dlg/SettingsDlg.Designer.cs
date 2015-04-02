namespace TwitchChecker.UI.Dlg
{
	partial class SettingsDlg
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
			this.lblUsername = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.lblQuality = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.cbQuality = new System.Windows.Forms.ComboBox();
			this.cbViewMode = new System.Windows.Forms.ComboBox();
			this.lblViewMode = new System.Windows.Forms.Label();
			this.cbOnlineNotification = new System.Windows.Forms.CheckBox();
			this.cbOfflineNotification = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Location = new System.Drawing.Point(12, 9);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(55, 13);
			this.lblUsername.TabIndex = 0;
			this.lblUsername.Text = "Username";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(12, 35);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(53, 13);
			this.lblPassword.TabIndex = 1;
			this.lblPassword.Text = "Password";
			// 
			// lblQuality
			// 
			this.lblQuality.AutoSize = true;
			this.lblQuality.Location = new System.Drawing.Point(12, 88);
			this.lblQuality.Name = "lblQuality";
			this.lblQuality.Size = new System.Drawing.Size(39, 13);
			this.lblQuality.TabIndex = 3;
			this.lblQuality.Text = "Quality";
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(88, 6);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(121, 20);
			this.txtUsername.TabIndex = 4;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(88, 32);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.ReadOnly = true;
			this.txtPassword.Size = new System.Drawing.Size(121, 20);
			this.txtPassword.TabIndex = 5;
			this.txtPassword.Text = "not implemented yet";
			// 
			// cbQuality
			// 
			this.cbQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbQuality.FormattingEnabled = true;
			this.cbQuality.Location = new System.Drawing.Point(88, 85);
			this.cbQuality.Name = "cbQuality";
			this.cbQuality.Size = new System.Drawing.Size(121, 21);
			this.cbQuality.TabIndex = 6;
			// 
			// cbViewMode
			// 
			this.cbViewMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbViewMode.FormattingEnabled = true;
			this.cbViewMode.Location = new System.Drawing.Point(88, 58);
			this.cbViewMode.Name = "cbViewMode";
			this.cbViewMode.Size = new System.Drawing.Size(121, 21);
			this.cbViewMode.TabIndex = 12;
			this.cbViewMode.SelectionChangeCommitted += new System.EventHandler(this.cbViewMode_SelectionChangeCommitted);
			// 
			// lblViewMode
			// 
			this.lblViewMode.AutoSize = true;
			this.lblViewMode.Location = new System.Drawing.Point(12, 61);
			this.lblViewMode.Name = "lblViewMode";
			this.lblViewMode.Size = new System.Drawing.Size(57, 13);
			this.lblViewMode.TabIndex = 11;
			this.lblViewMode.Text = "ViewMode";
			// 
			// cbOnlineNotification
			// 
			this.cbOnlineNotification.AutoSize = true;
			this.cbOnlineNotification.Location = new System.Drawing.Point(12, 112);
			this.cbOnlineNotification.Name = "cbOnlineNotification";
			this.cbOnlineNotification.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cbOnlineNotification.Size = new System.Drawing.Size(140, 17);
			this.cbOnlineNotification.TabIndex = 13;
			this.cbOnlineNotification.Text = "show Online Notification";
			this.cbOnlineNotification.UseVisualStyleBackColor = true;
			// 
			// cbOfflineNotification
			// 
			this.cbOfflineNotification.AutoSize = true;
			this.cbOfflineNotification.Location = new System.Drawing.Point(12, 135);
			this.cbOfflineNotification.Name = "cbOfflineNotification";
			this.cbOfflineNotification.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cbOfflineNotification.Size = new System.Drawing.Size(140, 17);
			this.cbOfflineNotification.TabIndex = 14;
			this.cbOfflineNotification.Text = "show Offline Notification";
			this.cbOfflineNotification.UseVisualStyleBackColor = true;
			// 
			// SettingsDlg
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(213, 156);
			this.Controls.Add(this.cbOfflineNotification);
			this.Controls.Add(this.cbOnlineNotification);
			this.Controls.Add(this.cbViewMode);
			this.Controls.Add(this.lblViewMode);
			this.Controls.Add(this.cbQuality);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.lblQuality);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblUsername);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "SettingsDlg";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "SettingsDlg";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsDlg_FormClosing);
			this.Load += new System.EventHandler(this.SettingsDlg_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Label lblQuality;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.ComboBox cbQuality;
		private System.Windows.Forms.ComboBox cbViewMode;
		private System.Windows.Forms.Label lblViewMode;
        private System.Windows.Forms.CheckBox cbOnlineNotification;
        private System.Windows.Forms.CheckBox cbOfflineNotification;
	}
}