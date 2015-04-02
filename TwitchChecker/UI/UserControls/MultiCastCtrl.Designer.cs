namespace TwitchChecker.UI.UserControls
{
	partial class MultiCastCtrl
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
			this.gbTop = new System.Windows.Forms.GroupBox();
			this.gbBottom = new System.Windows.Forms.GroupBox();
			this.btnStartMultiCast = new System.Windows.Forms.Button();
			this.gbBottom.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbTop
			// 
			this.gbTop.AutoSize = true;
			this.gbTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.gbTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
			this.gbTop.Location = new System.Drawing.Point(0, 0);
			this.gbTop.Name = "gbTop";
			this.gbTop.Padding = new System.Windows.Forms.Padding(8);
			this.gbTop.Size = new System.Drawing.Size(408, 29);
			this.gbTop.TabIndex = 0;
			this.gbTop.TabStop = false;
			this.gbTop.Text = "Channel";
			// 
			// gbBottom
			// 
			this.gbBottom.Controls.Add(this.btnStartMultiCast);
			this.gbBottom.Dock = System.Windows.Forms.DockStyle.Top;
			this.gbBottom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
			this.gbBottom.Location = new System.Drawing.Point(0, 29);
			this.gbBottom.Name = "gbBottom";
			this.gbBottom.Padding = new System.Windows.Forms.Padding(8);
			this.gbBottom.Size = new System.Drawing.Size(408, 51);
			this.gbBottom.TabIndex = 1;
			this.gbBottom.TabStop = false;
			// 
			// btnStartMultiCast
			// 
			this.btnStartMultiCast.AutoSize = true;
			this.btnStartMultiCast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStartMultiCast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
			this.btnStartMultiCast.Location = new System.Drawing.Point(8, 16);
			this.btnStartMultiCast.Name = "btnStartMultiCast";
			this.btnStartMultiCast.Size = new System.Drawing.Size(86, 25);
			this.btnStartMultiCast.TabIndex = 0;
			this.btnStartMultiCast.Text = "Start Multicast";
			this.btnStartMultiCast.UseVisualStyleBackColor = true;
			this.btnStartMultiCast.Click += new System.EventHandler(this.btnStartMultiCast_Click);
			// 
			// MultiCastCtrl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.AutoSize = true;
			this.Controls.Add(this.gbBottom);
			this.Controls.Add(this.gbTop);
			this.Name = "MultiCastCtrl";
			this.Size = new System.Drawing.Size(408, 247);
			this.gbBottom.ResumeLayout(false);
			this.gbBottom.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox gbTop;
		private System.Windows.Forms.GroupBox gbBottom;
		private System.Windows.Forms.Button btnStartMultiCast;

	}
}
