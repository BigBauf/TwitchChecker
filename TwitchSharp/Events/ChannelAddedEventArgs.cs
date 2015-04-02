using TwitchSharp.Interfaces;

namespace TwitchSharp.Events
{
	public class ChannelAddedEventArgs
	{
		public IChannel AddedChannel { get; set; }

		public ChannelAddedEventArgs(IChannel p_addedChannel)
		{
			AddedChannel = p_addedChannel;
		}
	}
}