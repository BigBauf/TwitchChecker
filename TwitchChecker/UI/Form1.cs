using System;
using System.Windows.Forms;
using TwitchChecker.Theme;
using TwitchChecker.UI.Dlg.Common;
using TwitchChecker.UI.Interfaces;
using TwitchChecker.UI.UserControls;

namespace TwitchChecker.UI
{
	public partial class Form1 : FormEx, IUIProvider
	{
		//==============================================Fields

		private IController Controller { get; set; }

		private SettingsCtrl settingsCtrl;

		private MultiCastCtrl multicastCtrl;

		private FollowingCtrl followingCtrl;

		private bool m_realClose = false;

		private UiView m_currentView;

		//==============================================Konstruktor

		public Form1()
		{
			InitializeComponent();
			this.SetStyle(
								ControlStyles.UserPaint |
								ControlStyles.AllPaintingInWmPaint |
								ControlStyles.ResizeRedraw |
								ControlStyles.ContainerControl |
								ControlStyles.OptimizedDoubleBuffer |
								ControlStyles.SupportsTransparentBackColor
							  , true);
		}

		//==============================================EventHandler

		protected override void WndProc(ref Message m)
		{
			if (m.Msg == NativeMethods.WM_SHOWME)
			{
				ShowInTaskbar = true;
				ShowMe();
			}
			base.WndProc(ref m);
		}

		private void Main_Load(object sender, EventArgs e)
		{
			Location = Properties.Settings.Default.Location;
			Size = Properties.Settings.Default.Size;
			WindowState = Properties.Settings.Default.WindowState;
			SetBackColor(pnlMain, SkinManager.Instance.ColorProvider.ChannelBackground);
		}

		private void Main_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!m_realClose)
			{
				e.Cancel = true;
				this.Hide();
				this.ShowInTaskbar = false;
			}
			else
			{
				Properties.Settings.Default.Location = Location;
				Properties.Settings.Default.Size = Size;
				Properties.Settings.Default.WindowState = WindowState;
				Properties.Settings.Default.Save();
			}
		}

		private void tsbClose_Click(object sender, EventArgs e)
		{
			m_realClose = true;
			this.Close();
		}

		private void ctmTray_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			if (e.ClickedItem == ctmClose)
			{
				m_realClose = true;
				this.Close();
			}
			else if (e.ClickedItem == ctmOpen)
				this.Show();
		}

		private void notificationTray_DoubleClick(object sender, EventArgs e)
		{
			ShowInTaskbar = true;
			this.Show();
			this.Activate();
		}

		//==============================================Methods

		private void ShowMe()
		{
			if (WindowState == FormWindowState.Minimized)
				WindowState = FormWindowState.Normal;
			// get our current "TopMost" value (ours will always be false though)
			bool top = TopMost;
			// make our form jump to the top of everything
			TopMost = true;
			// set it back to whatever it was
			TopMost = top;
		}

		//==============================================UiProvider Interface

		public void Init(IController p_controller)
		{
			Controller = p_controller;
			followingCtrl = new FollowingCtrl();
			multicastCtrl = new MultiCastCtrl();
			settingsCtrl = new SettingsCtrl();
			followingCtrl.Dock = DockStyle.Fill;
			multicastCtrl.Dock = DockStyle.Fill;
			settingsCtrl.Dock = DockStyle.Fill;
			followingCtrl.Init(Controller);
			multicastCtrl.Init(Controller);
			settingsCtrl.Init(Controller);
			sidebarCtrl1.Init(this);
		}

		public void SetView(UiView p_view)
		{
			if (m_currentView != p_view)
			{
				Control result;
				pnlMain.Controls.Clear();
				switch (p_view)
				{
					case UiView.Following:
						result = followingCtrl;
						break;

					case UiView.Multicast:
						result = multicastCtrl;
						multicastCtrl.PopulateGrouboxTop(Controller.TwitchClient.ChannelList);
						break;

					case UiView.Settings:
						result = settingsCtrl;
						settingsCtrl.UsernameChanged = false;
						break;

					default:
						throw new NotImplementedException();
				}
				pnlMain.Controls.Add(result);
			}
			m_currentView = p_view;
		}
	}
}