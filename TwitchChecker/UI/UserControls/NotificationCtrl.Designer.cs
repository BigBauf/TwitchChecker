namespace TwitchChecker.UI.UserControls
{
	partial class NotificationCtrl
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
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.lblGame = new System.Windows.Forms.Label();
			this.lblUsername = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblGame
			// 
			this.lblGame.AutoSize = true;
			this.lblGame.Location = new System.Drawing.Point(64, 32);
			this.lblGame.Name = "lblGame";
			this.lblGame.Size = new System.Drawing.Size(35, 13);
			this.lblGame.TabIndex = 3;
			this.lblGame.Text = "label2";
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsername.Location = new System.Drawing.Point(64, 8);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(45, 16);
			this.lblUsername.TabIndex = 2;
			this.lblUsername.Text = "label1";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(19, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(40, 40);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// NotificationCtrl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblGame);
			this.Controls.Add(this.lblUsername);
			this.MinimumSize = new System.Drawing.Size(400, 50);
			this.Name = "NotificationCtrl";
			this.Size = new System.Drawing.Size(400, 50);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lblGame;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
