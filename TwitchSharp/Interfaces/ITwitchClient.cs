using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using TwitchSharp.Events;

namespace TwitchSharp.Interfaces
{
	public interface ITwitchClient
	{
		/// <summary> Allows the subscriber to see when a channel is added to the list</summary>
		event EventHandler<ChannelAddedEventArgs> OnChannelAdded;

		/// <summary> Channellist </summary>
		ObservableCollection<IChannel> ChannelList { get; }

		/// <summary> adds a channel to observe local </summary>
		/// <param name="p_channel">channel to observe</param>
		void AddChannel(IChannel p_channel);

		/// <summary> loads the list of following channels </summary>
		void LoadFollowingChannels(string p_channelName);

		/// <summary> returns a channel with all needed information </summary>
		/// <param name="p_channelName">channel name</param>
		/// <returns>channel</returns>
		IChannel GetChannel(string p_channelName);

		/// <summary> updates all channels in channelList</summary>
		void UpdateChannels();

		/// <summary> updates a Channel </summary>
		/// <param name="p_channel">Channel to update</param>
		void UpdateChannel(IChannel p_channel);

		/// <summary> Search for channel which contains searchParm </summary>
		/// <param name="p_channelName"></param>
		/// <returns></returns>
		List<IChannel> SearchChannel(string p_channelName);
	}
}