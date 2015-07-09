using System.Windows.Forms;
using TwitchChecker.UI.UserControls.Common;
using TwitchSharp.Enums;

namespace TwitchChecker.UI.UserControls.ChannelOverview
{
	public partial class StatusPanelCtrl : UserControlEx
	{
		private Status m_status;

		//==============================================Ctor

		public StatusPanelCtrl()
		{
			InitializeComponent();
		}

		//==============================================Events

		protected override void OnInvalidated(InvalidateEventArgs e)
		{
			base.OnInvalidated(e);
			SetBackColor(this, SkinManager.ColorProvider.ChannelBackground);
			SetForeColor(this, SkinManager.ColorProvider.TextCommon);
		}

		private void pnlHeader_Click(object sender, System.EventArgs e)
		{
			pnlChannelView.Visible = !pnlChannelView.Visible;
			if (m_status == Status.Online)
			{
				Properties.Settings.Default.OnlineCollapsed = !pnlChannelView.Visible;
				pnlHeader.Collapsed = Properties.Settings.Default.OnlineCollapsed;
			}
			else
			{
				Properties.Settings.Default.OfflineCollapsed = !pnlChannelView.Visible;
				pnlHeader.Collapsed = Properties.Settings.Default.OfflineCollapsed;
			}
			Invalidate(true);
		}

		//==============================================Methods

		public void Init(Status p_status)
		{
			m_status = p_status;
			lblStatus.Text = m_status.ToString();
			pnlChannelView.Visible = p_status == Status.Online ? !Properties.Settings.Default.OnlineCollapsed : !Properties.Settings.Default.OfflineCollapsed;
			pnlHeader.Collapsed = p_status == Status.Online ? Properties.Settings.Default.OnlineCollapsed : Properties.Settings.Default.OfflineCollapsed;
		}

		private void SetVisibility()
		{
			if (m_status == Status.Online)
				pnlChannelView.Visible = Properties.Settings.Default.OnlineCollapsed;
			else
				pnlChannelView.Visible = Properties.Settings.Default.OfflineCollapsed;
		}

		private void SortControls()
		{
			//ChannelCtrl[] controls = new ChannelCtrl[pnlChannelView.Controls.Count];
			//pnlChannelView.Controls.CopyTo(controls, 0);
			//Array.Sort(controls, new ControlComparer());
			//ThreadSafe(delegate { pnlChannelView.Controls.Clear(); });
			//ThreadSafe(delegate { pnlChannelView.Controls.AddRange(controls); });
		}

		public Panel Channels { get { SortControls(); return pnlChannelView; } }
	}
}