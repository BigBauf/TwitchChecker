using TwitchSharp.Impl;
using TwitchSharp.Interfaces;

namespace TwitchSharp.Factories
{
	public static class TwitchClientFactory
	{
		//==============================================Methoden

		public static ITwitchClient GetTwitchClient()
		{
			return new TwitchClient();
		}
	}
}