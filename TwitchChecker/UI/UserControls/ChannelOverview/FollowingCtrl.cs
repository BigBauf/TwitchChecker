using System;
using System.Collections.Specialized;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using TwitchChecker.Helper;
using TwitchChecker.UI.UserControls.Common;
using TwitchSharp.Enums;
using TwitchSharp.Interfaces;

namespace TwitchChecker.UI.UserControls
{
	public partial class FollowingCtrl : UserControlEx
	{
		//==============================================Ctor

		public FollowingCtrl()
		{
			InitializeComponent();
		}

		//==============================================EventHandler

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			SetBackColor(this, SkinManager.ColorProvider.ChannelBackground);
		}

		protected override void OnInvalidated(InvalidateEventArgs e)
		{
			base.OnInvalidated(e);
		}

		private void Channel_StatusChanged(object sender, EventArgs e)
		{
			//Move Channel to the right Panel (Online/Offline)
			ChannelCtrl channel = sender as ChannelCtrl;
			if (channel.Channel.Status == Status.Online)
			{
				ThreadSafe(delegate { statusPnlOffline.Channels.Controls.Remove(channel); });
				ThreadSafe(delegate { statusPnlOnline.Channels.Controls.Add(channel); });
			}
			else if (channel.Channel.Status == Status.Offline)
			{
				ThreadSafe(delegate { statusPnlOnline.Channels.Controls.Remove(channel); });
				ThreadSafe(delegate { statusPnlOffline.Channels.Controls.Add(channel); });
			}
		}

		private void ChannelList_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			switch (e.Action)
			{
				case NotifyCollectionChangedAction.Add:
					ChannelCtrl ctrl = new ChannelCtrl();
					ctrl.Dock = DockStyle.Top;
					ctrl.StatusChanged += Channel_StatusChanged;
					ctrl.Init((IChannel)e.NewItems[0]);
					ThreadSafe(delegate { statusPnlOffline.Channels.Controls.Add(ctrl); });
					break;

				case NotifyCollectionChangedAction.Reset:
					break;

				case NotifyCollectionChangedAction.Remove:
				case NotifyCollectionChangedAction.Move:
				case NotifyCollectionChangedAction.Replace:
				default:
					break;
			}
		}

		//==============================================Methods

		internal void Init(IController m_controller)
		{
			statusPnlOnline.Init(Status.Online);
			statusPnlOffline.Init(Status.Offline);
			Controller = m_controller;
			Controller.TwitchClient.ChannelList.CollectionChanged += ChannelList_CollectionChanged;
			notificationManager.Init(Controller);
			Properties.Settings.Default.PropertyChanged += Default_PropertyChanged;
			try
			{
				if (Properties.Settings.Default.Username != String.Empty)
				{
					Thread thread = new Thread(() => Controller.LoadFollowingChannel(Properties.Settings.Default.Username));
					thread.Start();
				}
			}
			catch (Exception ex)
			{
				Utility.LogTrace(ex.Message + " in " + MethodBase.GetCurrentMethod());
			}
		}

		private void Default_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "UserName")
			{
			}
		}

		internal void Reload()
		{
			statusPnlOnline.Channels.Controls.Clear();
			statusPnlOffline.Channels.Controls.Clear();

			try
			{
				if (Properties.Settings.Default.Username != String.Empty)
				{
					Thread thread = new Thread(() => Controller.LoadFollowingChannel(Properties.Settings.Default.Username));
					thread.Start();
				}
			}
			catch (Exception ex)
			{
				Utility.LogTrace(ex.Message + " in " + MethodBase.GetCurrentMethod());
			}
		}
	}
}