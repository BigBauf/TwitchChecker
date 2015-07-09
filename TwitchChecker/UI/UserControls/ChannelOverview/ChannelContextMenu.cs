using System;
using System.ComponentModel;
using System.Windows.Forms;
using TwitchChecker.Livestreamer;
using TwitchChecker.UI.UserControls.Common;
using TwitchSharp.Interfaces;

namespace TwitchChecker.UI.UserControls.ChannelOverview
{
	internal class ChannelContextMenu : ContextMenuStripEx
	{
		public IChannel Channel { get; private set; }

		private readonly ToolStripMenuItem btnLivestreamer = new System.Windows.Forms.ToolStripMenuItem();
		private readonly ToolStripMenuItem btnOpenStream = new System.Windows.Forms.ToolStripMenuItem();
		private readonly ToolStripMenuItem btnPopout = new System.Windows.Forms.ToolStripMenuItem();
		private readonly ToolStripMenuItem btnChat = new System.Windows.Forms.ToolStripMenuItem();
		private readonly ToolStripMenuItem btnPastBroadcasts = new System.Windows.Forms.ToolStripMenuItem();
		public bool m_isContextMenuOpen;

		public ChannelContextMenu(IContainer container)
			: base(container)
		{
			btnLivestreamer.Text = "Livestreamer";
			btnOpenStream.Text = "open Stream";
			btnPopout.Text = "Popout";
			btnChat.Text = "Chat";
			btnPastBroadcasts.Text = "Past Broadcasts";

			Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
				btnLivestreamer,
				btnOpenStream,
				btnPopout,
				btnChat,
				btnPastBroadcasts});
		}

		public void Init(IChannel p_channel)
		{
			if (p_channel == null)
				throw new ArgumentNullException();
			Channel = p_channel;
			ItemClicked += _ItemClicked;
			Opening += _Opening;
			Closing += _Closing;
		}

		private void _Closing(object sender, ToolStripDropDownClosingEventArgs e)
		{
			m_isContextMenuOpen = false;
			Invalidate(true);
		}

		private void _Opening(object sender, CancelEventArgs e)
		{
			m_isContextMenuOpen = true;
		}

		private void _ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			if (e.ClickedItem == btnChat)
				Channel.OpenChat();
			else if (e.ClickedItem == btnLivestreamer)
				LiveStreamer.RunBatch(Channel.Username, Properties.Settings.Default.Quality, Properties.Settings.Default.HideConsole, Properties.Settings.Default.KeepConsoleOpen);
			else if (e.ClickedItem == btnOpenStream)
				Channel.OpenFullpage();
			else if (e.ClickedItem == btnPopout)
				Channel.OpenPopout();
			else if (e.ClickedItem == btnPastBroadcasts)
				Channel.OpenPastBroadcasts();
			else
				throw new NotImplementedException();
		}
	}
}