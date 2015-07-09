namespace TwitchChecker.UI.UserControls.ChannelOverview
{
	partial class StatusPanelCtrl
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
			this.pnlChannelView = new System.Windows.Forms.Panel();
			pnlHeader = new TwitchChecker.UI.UserControls.ChannelOverview.StatusHeaderCtrl();
			this.lblStatus = new System.Windows.Forms.Label();
			this.pnlHeader.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlChannelView
			// 
			this.pnlChannelView.AutoSize = true;
			this.pnlChannelView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlChannelView.Location = new System.Drawing.Point(0, 41);
			this.pnlChannelView.Name = "pnlChannelView";
			this.pnlChannelView.Size = new System.Drawing.Size(360, 293);
			this.pnlChannelView.TabIndex = 1;
			// 
			// pnlHeader
			// 
			this.pnlHeader.Controls.Add(this.lblStatus);
			this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlHeader.Location = new System.Drawing.Point(0, 0);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new System.Drawing.Size(360, 41);
			this.pnlHeader.TabIndex = 0;
			this.pnlHeader.Click += new System.EventHandler(this.pnlHeader_Click);
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStatus.Location = new System.Drawing.Point(16, 8);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(55, 20);
			this.lblStatus.TabIndex = 0;
			this.lblStatus.Text = "status";
			// 
			// StatusPanelCtrl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pnlChannelView);
			this.Controls.Add(this.pnlHeader);
			this.DoubleBuffered = true;
			this.Name = "StatusPanelCtrl";
			this.Size = new System.Drawing.Size(360, 334);
			this.pnlHeader.ResumeLayout(false);
			this.pnlHeader.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private StatusHeaderCtrl pnlHeader;
		private System.Windows.Forms.Panel pnlChannelView;
		private System.Windows.Forms.Label lblStatus;
	}
}
