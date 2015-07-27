using System.Windows.Forms;
using TwitchChecker.UI;
using TwitchChecker.UI.Interfaces;
using TwitchSharp.Factories;
using TwitchSharp.Interfaces;

namespace TwitchChecker
{
	public class Controller : IController
	{
		//==============================================Fields/Constants

		public IUIProvider UiProvider { get; private set; }

		private string m_test;

		//==============================================IController

		public void Init()
		{
			TwitchClient = TwitchClientFactory.GetTwitchClient();
			UiProvider = new Form1();
			UiProvider.Init(this);
		}

		public void LoadFollowingChannel(string p_username)
		{
			try
			{
				if (TwitchClient != null)
				{
					TwitchClient.ChannelList.Clear();
					TwitchClient.LoadFollowingChannels(p_username);
				}
			}
			catch (System.Exception)
			{
				//NONONONO DIRTY
			}
		}

		public void Run()
		{
			Application.Run((Form1)UiProvider);
		}

		public ITwitchClient TwitchClient { get; set; }
	}
}