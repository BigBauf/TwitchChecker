using System.Drawing;

namespace TwitchChecker.Theme.Themes
{
	internal class TwitchNow : IThemeProvider
	{
		public Color ChannelBackground { get { return Color.FromArgb(30, 30, 30); } }

		public Color ChannelHighlighted { get { return Color.FromArgb(35, 35, 35); } }

		public Color ContextMenuBackground { get { return Color.FromArgb(18, 18, 18); } }

		public Color ContextMenuBorder { get { return Color.Transparent; } }

		public Color ContextMenuHighlighted { get { return ColorProvider.TwitchPurple; } }

		public Color None { get { return Color.Transparent; } }

		public Color SidebarBackground { get { return Color.FromArgb(18, 18, 18); } }

		public Color SidebarHighlighted { get { return Color.FromArgb(75, 40, 140); } }

		public Color TextUsername { get { return Color.FromArgb(200, 200, 200); } }

		public Color TextCommon { get { return Color.FromArgb(111, 117, 120); } }

		public Color TextContextMenu { get { return Color.FromArgb(221, 221, 221); } }

		public Color TextContextMenuHighlight { get { return Color.White; } }

		public ThemeStyle Theme { get { return ThemeStyle.TwitchNow; } }
	}
}