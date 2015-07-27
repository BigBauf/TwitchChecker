using System;
using TwitchChecker.Theme.Themes;

namespace TwitchChecker.Theme
{
	public class ThemeManager
	{
		//==============================================Fields

		private static ThemeManager instance;

		public IThemeProvider ColorProvider { get; private set; }

		//==============================================Ctor

		private ThemeManager()
		{
			//When the ColorProvider isn't set here it's imposible to show UserControls in the designer
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
					throw new ArgumentException();
			}
		}

		//==============================================Properties

		public static ThemeManager Instance
		{
			get
			{
				if (instance == null)
					instance = new ThemeManager();
				return instance;
			}
		}
	}
}