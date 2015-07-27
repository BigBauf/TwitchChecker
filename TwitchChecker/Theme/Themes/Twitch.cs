using System.Drawing;

namespace TwitchChecker.Theme.Themes
{
	internal class Twitch : IThemeProvider
	{
		public Color ChannelBackground { get { return Color.FromArgb(242, 242, 242); } }

		public Color ChannelHighlighted { get { return Color.FromArgb(228, 228, 228); } }

		public Color ContextMenuBackground { get { return Color.White; } }

		public Color ContextMenuBorder { get { return Color.FromArgb(203, 203, 203); } }

		public Color ContextMenuHighlighted { get { return Color.FromArgb(100, 65, 165); } }

		public Color None { get { return Color.Transparent; } }

		public Color SidebarBackground { get { return Color.FromArgb(25, 25, 31); } }

		public Color SidebarHighlighted { get { return Color.FromArgb(16, 16, 16); } }

		public Color TextUsername { get { return Color.FromArgb(50, 50, 62); } }

		public Color TextCommon { get { return Color.FromArgb(140, 140, 140); } }

		public Color TextContextMenu { get { return Color.FromArgb(100, 65, 165); } }

		public Color TextContextMenuHighlight { get { return Color.White; } }

		public ThemeStyle Theme { get { return ThemeStyle.Twitch; } }
	}
}