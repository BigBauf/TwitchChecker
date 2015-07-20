using System;
using System.Windows.Forms;
using TwitchChecker.Helper;
using TwitchChecker.Theme;
using TwitchChecker.UI.Dlg;
using TwitchChecker.UI.UserControls.Common;
using TwitchSharp.Enums;

namespace TwitchChecker.UI.UserControls
{
	public partial class SettingsCtrl : UserControlEx
	{
		//==============================================Fields
		public bool UsernameChanged { get; set; }

		//==============================================Ctor

		public SettingsCtrl()
		{
			InitializeComponent();
		}

		//==============================================Events

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			BackColor = SkinManager.ColorProvider.ChannelBackground;
			SetForeColor(this, SkinManager.ColorProvider.TextUsername);
		}

		private void _Load(object sender, EventArgs e)
		{
			//Twitch
			txtUsername.Text = Properties.Settings.Default.Username;
			//Stream

			SetViewMode((ViewMode)Enum.Parse(typeof(ViewMode), Properties.Settings.Default.ViewMode));
			cbxQuality.DataSource = Enum.GetValues(typeof(Quality));
			cbxQuality.Enabled = rdbLivestreamer.Checked ? true : false;
			cbxQuality.SelectedItem = (Quality)Enum.Parse(typeof(Quality), Properties.Settings.Default.Quality);
			//Livestreamer
			cbKeepConsoleOpen.Checked = Properties.Settings.Default.KeepConsoleOpen;
			cbHideConsole.Checked = Properties.Settings.Default.HideConsole;
			//Misc
			cbStartWithWindows.Checked = Properties.Settings.Default.StartWithWindows;
			cbShowNotification.Checked = Properties.Settings.Default.ShowNotification;
			cbxThemes.DataSource = Enum.GetValues(typeof(ThemeStyle));
			cbxThemes.SelectedItem = ThemeManager.Instance.ColorProvider.Theme;
		}

		private void Username_TextChanged(object sender, EventArgs e)
		{
			UsernameChanged = Properties.Settings.Default.Username != txtUsername.Text;
			Properties.Settings.Default.Username = txtUsername.Text;
		}

		private void ViewMode_CheckedChanged(object sender, EventArgs e)
		{
			ViewMode viewMode;
			if (sender == rbFullPage)
			{
				viewMode = ViewMode.Fullpage;
			}
			else if (sender == rdbPopout)
			{
				viewMode = ViewMode.Popout;
			}
			else if (sender == rdbLivestreamer)
			{
				viewMode = ViewMode.Livestreamer;
			}
			else
				throw new ArgumentException();

			cbxQuality.Enabled = rdbLivestreamer.Checked ? true : false;
			Properties.Settings.Default.ViewMode = viewMode.ToString();
		}

		private void Livestreamer_CheckedChanged(object sender, EventArgs e)
		{
			//Livestreamer
			if (sender == cbKeepConsoleOpen)
			{
				Properties.Settings.Default.KeepConsoleOpen = cbKeepConsoleOpen.Checked;
			}
			else if (sender == cbHideConsole)
			{
				Properties.Settings.Default.HideConsole = cbHideConsole.Checked;
			}
			else
				throw new ArgumentException();
		}

		private void Misc_CheckedChanged(object sender, EventArgs e)
		{
			//Misc
			if (sender == cbStartWithWindows)
			{
				Properties.Settings.Default.StartWithWindows = cbStartWithWindows.Checked;
				Utility.SetStartup(Application.ExecutablePath, Properties.Settings.Default.StartWithWindows);
			}
			else if (sender == cbShowNotification)
				Properties.Settings.Default.ShowNotification = cbShowNotification.Checked;
			else
				throw new ArgumentException();
		}

		private void Quality_SelectionChangeCommitted(object sender, EventArgs e)
		{
			Properties.Settings.Default.Quality = cbxQuality.SelectedItem.ToString();
		}

		private void Themes_SelectionChangeCommitted(object sender, EventArgs e)
		{
			ThemeStyle selectedTheme = (ThemeStyle)Enum.Parse(typeof(ThemeStyle), cbxThemes.SelectedItem.ToString());
			SkinManager.Init(selectedTheme);
			Properties.Settings.Default.Theme = cbxThemes.SelectedItem.ToString();
			if (ParentForm != null)
				ParentForm.Invalidate(true);
		}

		private void TestNotifcation_Click(object sender, EventArgs e)
		{
			NotificationDlg dlg = new NotificationDlg();
			dlg.Show();
		}

		//==============================================Methods

		internal void Init(IController m_controller)
		{
			Controller = m_controller;
		}

		private void SetViewMode(ViewMode p_viewMode)
		{
			switch (p_viewMode)
			{
				case ViewMode.Fullpage:
					rbFullPage.Checked = true;
					break;

				case ViewMode.Popout:
					rdbPopout.Checked = true;
					break;

				case ViewMode.Livestreamer:
					rdbLivestreamer.Checked = true;
					break;

				default:
					throw new ArgumentException("Unknown ViewMode in SetViewMode");
			}
		}
	}
}