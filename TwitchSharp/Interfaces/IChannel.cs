using System;
using TwitchSharp.Enums;
using TwitchSharp.Events;

namespace TwitchSharp.Interfaces
{
	public interface IChannel
	{
		/// <summary> Allows the Object to user certain functions from the StreamProvider </summary>
		ITwitchClient StreamProvider { get; }

		/// <summary> allows a subscriber to see when a Property gets Changed </summary>
		event EventHandler<ChannelChangedEventArgs> OnPropertyChanged;

		/// <summary> allows a subscriber to see when the Object gets Updated </summary>
		event EventHandler OnUpdate;

		/// <summary> allows a subscriber to see when the Object gets Removed </summary>
		event EventHandler OnRemove;

		/// <summary> Channel name /// </summary>
		string Username { get; set; }

		/// <summary> Channel title </summary>
		string Title { get; set; }

		/// <summary> played Game </summary>
		string Game { get; set; }

		/// <summary>  Channel url </summary>
		string Url { get; set; }

		/// <summary> Logo from the Channel </summary>
		string Logo { get; set; }

		/// <summary> Anzahl der Viewer /// </summary>
		int? Viewers { get; set; }

		/// <summary> Stream Online/Offline /// </summary>
		Status Status { get; set; }

		/// <summary> Starts a stream on the fullpage</summary>
		void OpenFullpage();

		/// <summary> Open stream in popout mode</summary>
		void OpenPopout();

		/// <summary> Opens the Chat</summary>
		/// <param name="p_channel"></param>
		void OpenChat();

		void OpenPastBroadcasts();

		/// <summary> Update des Channels / Should use OnUpdate /// </summary>
		void Update();

		/// <summary> Removes the Channel / Should use OnRemove /// </summary>
		void Remove();
	}
}