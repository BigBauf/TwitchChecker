using System.Windows.Forms;
using TwitchChecker.Helper;
using TwitchChecker.UI.UserControls.Common;
using TwitchSharp.Interfaces;

namespace TwitchChecker.UI.UserControls
{
	public partial class NotificationCtrl : UserControlEx
	{
		private System.Timers.Timer m_timer;

		public NotificationCtrl()
		{
			InitializeComponent();
			lblUsername.ForeColor = SkinManager.ColorProvider.TextUsername;
			lblGame.ForeColor = SkinManager.ColorProvider.TextCommon;
			m_timer = new System.Timers.Timer(6000);
			m_timer.Elapsed += m_timer_Elapsed;
			m_timer.Start();
		}

		public void Init(IChannel p_channel)
		{
			lblUsername.Text = p_channel.Username;
			lblGame.Text = p_channel.Game;
			pictureBox1.Image = Utility.LoadChannelLogo(p_channel.Username, p_channel.Logo);
			SetCloseEvent(this);
		}

		private void SetCloseEvent(Control p_control)
		{
			p_control.MouseClick += p_control_MouseClick;
			foreach (Control item in p_control.Controls)
			{
				SetCloseEvent(item);
			}
		}

		private void p_control_MouseClick(object sender, MouseEventArgs e)
		{
			ThreadSafe(delegate { Parent.Controls.Remove(this); });
		}

		private void m_timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			if (Parent != null)
				ThreadSafe(delegate { Parent.Controls.Remove(this); });
		}
	}
}