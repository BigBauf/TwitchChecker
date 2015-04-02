namespace TwitchChecker.UI.UserControls
{
	partial class ChannelCtrl
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
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblViewer = new System.Windows.Forms.Label();
			this.lblGame = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblUsername = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pbProfileImg = new System.Windows.Forms.PictureBox();
			this.contextMenu = new TwitchChecker.UI.UserControls.ChannelOverview.ChannelContextMenu(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbProfileImg)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.lblViewer);
			this.panel1.Controls.Add(this.lblGame);
			this.panel1.Controls.Add(this.lblTitle);
			this.panel1.Controls.Add(this.lblUsername);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(59, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(269, 40);
			this.panel1.TabIndex = 20;
			this.panel1.MouseEnter += new System.EventHandler(this._MouseEnter);
			this.panel1.MouseLeave += new System.EventHandler(this._MouseLeave);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.Image = global::TwitchChecker.Properties.Resources.Viewer;
			this.pictureBox1.Location = new System.Drawing.Point(215, 27);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(11, 10);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 22;
			this.pictureBox1.TabStop = false;
			// 
			// lblViewer
			// 
			this.lblViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblViewer.AutoSize = true;
			this.lblViewer.Location = new System.Drawing.Point(232, 24);
			this.lblViewer.Name = "lblViewer";
			this.lblViewer.Size = new System.Drawing.Size(35, 13);
			this.lblViewer.TabIndex = 21;
			this.lblViewer.Text = "label1";
			this.lblViewer.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// lblGame
			// 
			this.lblGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblGame.AutoSize = true;
			this.lblGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGame.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblGame.Location = new System.Drawing.Point(9, 22);
			this.lblGame.Name = "lblGame";
			this.lblGame.Size = new System.Drawing.Size(39, 15);
			this.lblGame.TabIndex = 19;
			this.lblGame.Text = "game";
			this.lblGame.MouseEnter += new System.EventHandler(this._MouseEnter);
			this.lblGame.MouseLeave += new System.EventHandler(this._MouseLeave);
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblTitle.Location = new System.Drawing.Point(144, 8);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(23, 13);
			this.lblTitle.TabIndex = 20;
			this.lblTitle.Text = "title";
			this.lblTitle.Visible = false;
			this.lblTitle.MouseEnter += new System.EventHandler(this._MouseEnter);
			this.lblTitle.MouseLeave += new System.EventHandler(this._MouseLeave);
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsername.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblUsername.Location = new System.Drawing.Point(8, 6);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(103, 16);
			this.lblUsername.TabIndex = 18;
			this.lblUsername.Text = "channelName";
			this.lblUsername.MouseEnter += new System.EventHandler(this._MouseEnter);
			this.lblUsername.MouseLeave += new System.EventHandler(this._MouseLeave);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Control;
			this.panel2.Controls.Add(this.pbProfileImg);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(19, 5);
			this.panel2.Margin = new System.Windows.Forms.Padding(0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(40, 40);
			this.panel2.TabIndex = 21;
			// 
			// pbProfileImg
			// 
			this.pbProfileImg.BackColor = System.Drawing.SystemColors.Control;
			this.pbProfileImg.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbProfileImg.InitialImage = global::TwitchChecker.Properties.Resources.Twitch;
			this.pbProfileImg.Location = new System.Drawing.Point(0, 0);
			this.pbProfileImg.Name = "pbProfileImg";
			this.pbProfileImg.Padding = new System.Windows.Forms.Padding(3);
			this.pbProfileImg.Size = new System.Drawing.Size(40, 40);
			this.pbProfileImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbProfileImg.TabIndex = 17;
			this.pbProfileImg.TabStop = false;
			this.pbProfileImg.MouseEnter += new System.EventHandler(this._MouseEnter);
			this.pbProfileImg.MouseLeave += new System.EventHandler(this._MouseLeave);
			// 
			// contextMenu
			// 
			this.contextMenu.Name = "channelContextMenu1";
			this.contextMenu.ShowImageMargin = false;
			this.contextMenu.Size = new System.Drawing.Size(132, 114);
			// 
			// ChannelCtrl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ContextMenuStrip = this.contextMenu;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.DoubleBuffered = true;
			this.MaximumSize = new System.Drawing.Size(401, 66);
			this.Name = "ChannelCtrl";
			this.Padding = new System.Windows.Forms.Padding(19, 5, 11, 5);
			this.Size = new System.Drawing.Size(339, 50);
			this.MouseEnter += new System.EventHandler(this._MouseEnter);
			this.MouseLeave += new System.EventHandler(this._MouseLeave);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbProfileImg)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblGame;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pbProfileImg;
		private System.Windows.Forms.Label lblViewer;
		private System.Windows.Forms.PictureBox pictureBox1;
		private ChannelOverview.ChannelContextMenu contextMenu;
	}
}
