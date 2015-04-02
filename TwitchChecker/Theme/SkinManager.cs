using System;
using TwitchChecker.Theme.Themes;

namespace TwitchChecker.Theme
{
	public class SkinManager
	{
		//==============================================Fields

		private static SkinManager instance;

		public IThemeProvider ColorProvider { get; private set; }

		//==============================================Ctor

		private SkinManager()
		{
			//When the Provider isnt set here its imposible to Show UserControls in the Designer
			ColorProvider = new Dark();
		}

		//==============================================Methods

		public void Init(ThemeStyle p_theme)
		{
			switch (p_theme)
			{
				case ThemeStyle.Dark:
					ColorProvider = new Dark();
					break;

				case ThemeStyle.Light:
					ColorProvider = new Light();
					break;

				case ThemeStyle.Twitch:
					ColorProvider = new TwitchChecker.Theme.Themes.Twitch();
					break;

				case ThemeStyle.TwitchNow:
					ColorProvider = new TwitchNow();
					break;

				default:
					throw new NotImplementedException();
			}
		}

		//==============================================Properties

		public static SkinManager Instance
		{
			get
			{
				if (instance == null)
					instance = new SkinManager();
				return instance;
			}
		}
	}
}