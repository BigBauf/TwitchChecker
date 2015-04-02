using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using TwitchChecker.Helper;
using TwitchChecker.Theme;
using TwitchChecker.UI.UserControls.Common;
using TwitchSharp.Enums;
using TwitchSharp.Interfaces;

namespace TwitchChecker.UI.UserControls
{
	public partial class MultiCastCtrl : UserControlEx
	{
		//==============================================Fields/Constants

		//Example:http://kbmod.com/multistream/view/?s0=zap55&s1=smitegame&s2=smitegame2&s3=dmbrandon&s4=mogee_&s5=lassiz&s6=purified&layout=17

		private const string MULICAST_URL = "http://kbmod.com/multistream/view/?{0}layout={1}";

		//The numbering for the page 1 Channel == 0, 2 Channel == 3...
		private int[] m_numberMapping = { 0, 3, 6, 9, 12, 15, 17, 20 };

		private int m_channelAmout = 0;

		//==============================================Ctor

		public MultiCastCtrl()
		{
			InitializeComponent();
		}

		//==============================================Events

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			BackColor = SkinManager.ColorProvider.ChannelBackground;
			SetForeColor(this, SkinManager.ColorProvider.TextCommon);
		}

		private void cb_CheckedChanged(object sender, EventArgs e)
		{
			(sender as CheckBox).CheckedChanged -= cb_CheckedChanged;
			if (m_channelAmout < 8 && (sender as CheckBox).Checked || m_channelAmout > 0 && !(sender as CheckBox).Checked)
				m_channelAmout += (sender as CheckBox).Checked ? 1 : -1;
			else
				(sender as CheckBox).Checked = !(sender as CheckBox).Checked;
			(sender as CheckBox).CheckedChanged += cb_CheckedChanged;
		}

		private void btnStartMultiCast_Click(object sender, EventArgs e)
		{
			string channel = String.Empty;
			int count = 0;
			for (int i = 0; i < gbTop.Controls.Count; i++)
			{
				CheckBox cb = gbTop.Controls[i] as CheckBox;
				if (cb.Checked)
				{
					channel += "s" + count + "=" + cb.Text + "&";
					count++;
				}
			}
			if (count > 0)
			{
				int layout = m_numberMapping[count - 1];

				Process.Start(String.Format(MULICAST_URL, channel, layout));
			}
		}

		//==============================================Methods

		internal void Init(IController m_controller)
		{
			Controller = m_controller;
		}

		public void PopulateGrouboxTop(ObservableCollection<IChannel> p_channel)
		{
			try
			{
				gbTop.Controls.Clear();
				foreach (IChannel channel in p_channel)
				{
					if (channel.Status == Status.Online)
					{
						CheckBox cb = new CheckBox();
						cb.Text = channel.Username;
						cb.CheckedChanged += cb_CheckedChanged;
						cb.Dock = DockStyle.Top;
						cb.BringToFront();
						gbTop.Controls.Add(cb);
					}
				}
			}
			catch (Exception ex)
			{
				Utility.LogTrace(ex.Message + " in " + MethodBase.GetCurrentMethod());
			}
		}

		public void StartMulticast()
		{
		}
	}
}