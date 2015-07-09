using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using TwitchSharp.Enums;
using TwitchSharp.Events;
using TwitchSharp.Factories;
using TwitchSharp.Helper;
using TwitchSharp.Interfaces;
using TwitchSharp.Model;

namespace TwitchSharp.Impl
{
	internal class TwitchClient : ITwitchClient
	{
		//==============================================Events

		public event EventHandler<ChannelAddedEventArgs> OnChannelAdded = delegate { };

		//==============================================Fields

		private readonly ObservableCollection<IChannel> m_channelList;

		private const string SEARCH_CHANNEL = StringProvider.TwitchApi + "search/channels?q={}";
		private const string GET_FOLLOWING_CHANNEL = StringProvider.TwitchApi + "users/{0}/follows/channels?limit=100";
		private const string Get_STREAM_RESULT = StringProvider.TwitchApi + "streams/{0}";
		private const string GET_CHANNEL = StringProvider.TwitchApi + "channels/{0}";

		//==============================================Konstruktor

		public TwitchClient()
		{
			m_channelList = new ObservableCollection<IChannel>();
			m_channelList.CollectionChanged += ChanneList_CollectionChanged;
		}

		//==============================================EventHandler

		private void ChanneList_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			switch (e.Action)
			{
				case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
					OnChannelAdded(sender, new ChannelAddedEventArgs((IChannel)e.NewItems[0]));
					break;

				case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
					((IChannel)e.OldItems[0]).Remove();
					break;

				case System.Collections.Specialized.NotifyCollectionChangedAction.Reset:

				case System.Collections.Specialized.NotifyCollectionChangedAction.Move:
				case System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
					break;

				default:
					throw new ArgumentException("Unkwnon CollectionChanged Action in ChannelList_CollectionChanged");
			}
		}

		//==============================================Methoden

		private IChannel GetIChannel(Channel p_channel)
		{
			IChannel result = null;
			if (p_channel != null)
			{
				result = new TwitchChannel(this, p_channel.display_name);
				result.Logo = p_channel.logo;
				result.Url = p_channel.url;
			}
			return result;
		}

		//==============================================InterfaceImpl

		public IChannel GetChannel(string p_channelName)
		{
			IChannel result = null;
			try
			{
				string uri = String.Format(GET_CHANNEL, p_channelName);
				string json = Utility.GetJson(uri);

				Channel channel = ModelFactory.GetChannel(json);
				result = GetIChannel(channel);
			}
			catch (Exception ex)
			{
				Utility.LogTrace(ex.Message + " in " + MethodBase.GetCurrentMethod());
			}

			return result;
		}

		public void AddChannel(IChannel p_channel)
		{
			if (m_channelList.FirstOrDefault(x => x.Username == p_channel.Username) == null)
				m_channelList.Add(p_channel);
		}

		public void UpdateChannels()
		{
			foreach (IChannel channel in ChannelList)
				channel.Update();
		}

		public void UpdateChannel(IChannel p_channel)
		{
			string uri = String.Format(Get_STREAM_RESULT, p_channel.Username);
			string json = Utility.GetJson(uri);
			StreamResult result = ModelFactory.GetStreamResult(json);
			try
			{
				if (result != null && result.stream != null)
				{
					p_channel.Game = result.stream.game;
					p_channel.Title = result.stream.channel.status;
					p_channel.Viewers = result.stream.viewers;
					p_channel.Status = Status.Online;
				}
				else
				{
					p_channel.Game = String.Empty;
					p_channel.Title = String.Empty;
					p_channel.Viewers = null;
					p_channel.Status = Status.Offline;
				}
			}
			catch (Exception ex)
			{
				Utility.LogTrace(ex.Message + " in " + MethodBase.GetCurrentMethod());
			}
		}

		public void RemoveChannel(IChannel p_channel)
		{
			if (m_channelList.Contains(p_channel))
			{
				m_channelList.Remove(p_channel);
			}
		}

		public void LoadFollowingChannels(string p_channelname)
		{
			List<IChannel> result = new List<IChannel>();
			string uri = String.Format(GET_FOLLOWING_CHANNEL, p_channelname);
			FollowResult followResult = ModelFactory.GetFollowResult(Utility.GetJson(uri));
			foreach (Follow follow in followResult.follows)
			{
				IChannel ichannel = GetIChannel(follow.channel);
				ChannelList.Add(ichannel);
			}
		}

		public List<IChannel> SearchChannel(string p_channelName)
		{
			string uri = String.Format(SEARCH_CHANNEL, p_channelName);
			SearchResult searchResult = ModelFactory.GetSearchResult(Utility.GetJson(uri));
			List<IChannel> result = new List<IChannel>();
			foreach (Channel channel in searchResult.channels)
			{
				result.Add(GetIChannel(channel));
			}

			return result;
		}

		public ObservableCollection<IChannel> ChannelList { get { return m_channelList; } }
	}
}