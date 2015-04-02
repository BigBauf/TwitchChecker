using System.Windows.Forms;
using TwitchChecker.UI.UserControls.Common;
using TwitchSharp.Enums;

namespace TwitchChecker.UI.UserControls.ChannelOverview
{
	public partial class StatusPanelCtrl : UserControlEx
	{
		public StatusPanelCtrl()
		{
			InitializeComponent();
		}

		public void Init(Status p_status)
		{
			lblStatus.Text = p_status.ToString();
		}

		private void SortControls()
		{
			//ChannelCtrl[] controls = new ChannelCtrl[pnlChannelView.Controls.Count];
			//pnlChannelView.Controls.CopyTo(controls, 0);
			//Array.Sort(controls, new ControlComparer());
			//ThreadSafe(delegate { pnlChannelView.Controls.Clear(); });
			//ThreadSafe(delegate { pnlChannelView.Controls.AddRange(controls); });
		}

		protected override void OnInvalidated(InvalidateEventArgs e)
		{
			base.OnInvalidated(e);
			SetBackColor(this, SkinManager.ColorProvider.ChannelBackground);
			SetForeColor(this, SkinManager.ColorProvider.TextCommon);
		}

		public Panel Channels { get { SortControls(); return pnlChannelView; } }
	}
}