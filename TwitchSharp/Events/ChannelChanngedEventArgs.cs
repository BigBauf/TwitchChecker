using System;
using TwitchSharp.Enums;

namespace TwitchSharp.Events
{
	public class ChannelChangedEventArgs : EventArgs
	{
		public ChannelProperties ChannelProperties { get; set; }

		public ChannelChangedEventArgs(ChannelProperties p_propertie)
		{
			ChannelProperties = p_propertie;
		}
	}
}