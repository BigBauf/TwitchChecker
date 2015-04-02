using System;
using System.ComponentModel;
using TwitchChecker.UI.Dlg;
using TwitchSharp.Enums;
using TwitchSharp.Interfaces;

namespace TwitchChecker.UI.UserComponent
{
	public partial class NotificationManager : Component
	{
		private IController Controller { get; set; }

		private bool m_isShowwingNotification;
		private NotificationDlg notificationDlg;

		//==============================================Ctor

		public NotificationManager(IContainer container)
		{
			InitializeComponent();
			container.Add(this);
		}

		//==============================================Methods

		public void Init(IController p_controller)
		{
			if (p_controller == null)
				throw new ArgumentNullException();
			m_isShowwingNotification = false;
			m_isShowwingNotification = false;
			Controller = p_controller;
			Controller.TwitchClient.OnChannelAdded += StreamProvider_OnChannelAdded;
			notificationDlg = new NotificationDlg();
			notificationDlg.Visible = false;
			notificationDlg.Show();
		}

		private void StreamProvider_OnChannelAdded(object sender, TwitchSharp.Events.ChannelAddedEventArgs e)
		{
			e.AddedChannel.OnPropertyChanged += AddedChannel_OnPropertyChanged;
		}

		private void AddedChannel_OnPropertyChanged(object sender, TwitchSharp.Events.ChannelChangedEventArgs e)
		{
			IChannel channel = sender as IChannel;
			switch (e.ChannelProperties)
			{
				case ChannelProperties.ChannelName:
					break;

				case ChannelProperties.Title:
					break;

				case ChannelProperties.Game:
					break;

				case ChannelProperties.Url:
					break;

				case ChannelProperties.Viewer:
					break;

				case ChannelProperties.Status:
					if (channel.Status == Status.Online)
					{
						try
						{
							notificationDlg.AddNotification(channel);
						}
						catch (Exception ex)
						{
							throw;
						}
					}
					break;

				case ChannelProperties.Logo:
					break;

				default:
					break;
			}
		}
	}
}