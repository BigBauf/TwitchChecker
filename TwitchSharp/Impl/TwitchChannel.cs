using System;
using System.Diagnostics;
using System.Threading;
using TwitchSharp.Enums;
using TwitchSharp.Events;
using TwitchSharp.Interfaces;

namespace TwitchSharp.Impl
{
	internal class TwitchChannel : IChannel
	{
		//==============================================Fields

		public event EventHandler<ChannelChangedEventArgs> OnPropertyChanged = delegate { };

		public event EventHandler OnUpdate = delegate { };

		public event EventHandler OnRemove = delegate { };

		private ITwitchClient m_streamProvider;
		private string m_channelName;
		private string m_title;
		private string m_game;
		private string m_url;
		private string m_logo;
		private int? m_viewers;
		private Status m_status = Status.Offline;

		private const string POPOUT_STREAM = "/popout";
		private const string PAST_BROADCASTS = "http://www.twitch.tv/{0}/profile/past_broadcasts";

		//==============================================Konstruktor

		public TwitchChannel(ITwitchClient p_streamProvider, string p_channelName)
		{
			StreamProvider = p_streamProvider;
			Username = p_channelName;
		}

		//==============================================Methoden

		public void Update()
		{
			Thread thread = new Thread(x => StreamProvider.UpdateChannel(this));
			thread.Start();
			//StreamProvider.UpdateChannel(this);
			OnUpdate(this, null);
		}

		public void Remove()
		{
			OnRemove(this, null);
		}

		public void OpenFullpage()
		{
			string url = Url;
			Process.Start(url);
		}

		public void OpenPopout()
		{
			string url = Url + POPOUT_STREAM;
			Process.Start(url);
		}

		public void OpenChat()
		{
			Process.Start(Url + "/chat?popout=");
		}

		public void OpenPastBroadcasts()
		{
			Process.Start(String.Format(PAST_BROADCASTS, Username));
		}

		private void TriggerOnPropertyChanged(ChannelProperties p_properties)
		{
			OnPropertyChanged(this, new ChannelChangedEventArgs(p_properties));
		}

		//==============================================Properties

		public ITwitchClient StreamProvider
		{
			get { return m_streamProvider; }
			private set { if (value == null) throw new ArgumentNullException("Streamprovider is null"); m_streamProvider = value; }
		}

		public string Username
		{
			get { return m_channelName; }
			set { if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("No channel name"); string oldValue = m_channelName; m_channelName = value; if (oldValue != value) TriggerOnPropertyChanged(ChannelProperties.ChannelName); }
		}

		public string Title
		{
			get { return m_title; }
			set { string oldValue = m_title; m_title = value; if (oldValue != value) TriggerOnPropertyChanged(ChannelProperties.Title); }
		}

		public string Game
		{
			get { return m_game; }
			set { string oldValue = m_game; m_game = value; if (oldValue != value) TriggerOnPropertyChanged(ChannelProperties.Game); }
		}

		public string Url
		{
			get { return m_url; }
			set { string oldValue = m_url; m_url = value; if (oldValue != value) TriggerOnPropertyChanged(ChannelProperties.Url); }
		}

		public int? Viewers
		{
			get { return m_viewers; }
			set { int? oldValue = m_viewers; m_viewers = value; if (oldValue != value) TriggerOnPropertyChanged(ChannelProperties.Viewer); }
		}

		public Status Status
		{
			get { return m_status; }
			set { Status oldValue = m_status; m_status = value; if (oldValue != value) TriggerOnPropertyChanged(ChannelProperties.Status); }
		}

		public string Logo
		{
			get { return m_logo; }
			set { string oldValue = m_logo; m_logo = value; if (oldValue != value) TriggerOnPropertyChanged(ChannelProperties.Logo); }
		}
	}
}