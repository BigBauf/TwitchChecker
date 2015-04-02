using System;
using System.Windows.Forms;
using TwitchChecker.Stream.Enums;

namespace TwitchChecker.UI.Dlg
{
	public partial class SettingsDlg : Form
	{
		public SettingsDlg()
		{
			InitializeComponent();
			cbQuality.DataSource = Enum.GetValues(typeof(Quality));
			cbViewMode.DataSource = Enum.GetValues(typeof(ViewMode));
		}

		private void SettingsDlg_Load(object sender, EventArgs e)
		{
			txtUsername.Text = Properties.Settings.Default.Username;
			//txtPassword.Text = Properties.Settings.Default.Password;
			cbQuality.SelectedItem = (Quality)Enum.Parse(typeof(Quality), Properties.Settings.Default.Quality);
			cbViewMode.SelectedItem = (ViewMode)Enum.Parse(typeof(ViewMode), Properties.Settings.Default.ViewMode);
			cbOnlineNotification.Checked = Properties.Settings.Default.ShowIsOnlineNotification;
			cbOfflineNotification.Checked = Properties.Settings.Default.ShowIsOfflineNotification;
			SetQualityBox();
		}

		private void SettingsDlg_FormClosing(object sender, FormClosingEventArgs e)
		{
			Properties.Settings.Default.Username = txtUsername.Text;
			//Properties.Settings.Default.Password = txtPassword.Text;
			Properties.Settings.Default.Quality = cbQuality.SelectedItem.ToString();
			Properties.Settings.Default.ViewMode = cbViewMode.SelectedItem.ToString();
			Properties.Settings.Default.ShowIsOnlineNotification = cbOnlineNotification.Checked;
			Properties.Settings.Default.ShowIsOfflineNotification = cbOfflineNotification.Checked;
			Properties.Settings.Default.Save();
		}

		private void cbViewMode_SelectionChangeCommitted(object sender, EventArgs e)
		{
			SetQualityBox();
		}

		private void SetQualityBox()
		{
			cbQuality.Enabled = (ViewMode)Enum.Parse(typeof(ViewMode), cbViewMode.SelectedItem.ToString()) == ViewMode.Livestreamer ? true : false;
		}
	}
}