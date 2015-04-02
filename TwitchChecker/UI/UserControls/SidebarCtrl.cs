using System;
using System.Drawing;
using System.Windows.Forms;
using TwitchChecker.UI.Interfaces;
using TwitchChecker.UI.UserControls.Common;

namespace TwitchChecker.UI.UserControls
{
	public partial class SidebarCtrl : UserControlEx
	{
		//==============================================Fields

		private IUIProvider m_uiProvider;
		private PictureBox m_selectedPictureBox;

		//==============================================Ctor

		public SidebarCtrl()
		{
			InitializeComponent();
		}

		//==============================================Methods

		public void Init(IUIProvider p_uiProvider)
		{
			m_uiProvider = p_uiProvider;
			PictureBox_Clicked(pbFollowing, null);
		}

		private void LayoutControls()
		{
			if (Dock == DockStyle.Left || Dock == DockStyle.Right)
			{
				foreach (PictureBox item in Controls)
				{
					item.Dock = DockStyle.Top;
				}
			}
			else if (Dock == DockStyle.Top || Dock == DockStyle.Bottom)
			{
				int startPosX = 0;
				int width = Width / Controls.Count;
				for (int i = 0; i < Controls.Count; i++)
				{
					Point startPoint = new Point(startPosX, 0);
					Controls[i].Dock = DockStyle.None;
					Controls[i].Location = startPoint;
					Controls[i].Size = new Size(width, Height);
					startPosX += width;
				}
			}
		}

		//==============================================EventHandler

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			SetBackColor(this, SkinManager.ColorProvider.SidebarBackground);
			if (m_selectedPictureBox != null)
				m_selectedPictureBox.BackColor = SkinManager.ColorProvider.SidebarHighlighted;
		}

		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			LayoutControls();
		}

		private void _DockChanged(object sender, EventArgs e)
		{
			LayoutControls();
		}

		private void PictureBox_Clicked(object sender, EventArgs e)
		{
			//(sender as PictureBox).BackColor = SkinManager.ColorProvider.SidebarHighlighted;
			m_selectedPictureBox = sender as PictureBox;
			foreach (PictureBox item in Controls)
			{
				if (item != m_selectedPictureBox)
					item.BackColor = SkinManager.ColorProvider.SidebarBackground;
			}

			UiView view;
			if (sender == pbFollowing)
				view = UiView.Following;
			else if (sender == pbMulitCast)
				view = UiView.Multicast;
			else if (sender == pbSettings)
				view = UiView.Settings;
			else
				throw new NotImplementedException();
			m_uiProvider.SetView(view);
		}

		private void PictureBox_MouseEnter(object sender, EventArgs e)
		{
			(sender as PictureBox).BackColor = SkinManager.ColorProvider.SidebarHighlighted;
		}

		private void PictureBox_MouseLeave(object sender, EventArgs e)
		{
			if (sender != m_selectedPictureBox)
				(sender as PictureBox).BackColor = SkinManager.ColorProvider.SidebarBackground;
		}

		//==============================================Properties
	}
}