using TwitchSharp.Interfaces;

namespace TwitchChecker
{
	public interface IController
	{
		ITwitchClient TwitchClient { get; set; }

		void Init();

		void LoadFollowingChannel(string p_channelName);

		void Run();
	}
}