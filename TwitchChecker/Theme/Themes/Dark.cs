using System.Drawing;

namespace TwitchChecker.Theme.Themes
{
	internal class Dark : IThemeProvider
	{
		public Color ChannelBackground { get { return Color.FromArgb(30, 30, 30); } }

		public Color ChannelHighlighted { get { return Color.FromArgb(36, 36, 36); } }

		public Color ContextMenuBackground { get { return Color.FromArgb(27, 27, 28); } }

		public Color ContextMenuBorder { get { return Color.FromArgb(51, 51, 52); } }

		public Color ContextMenuHighlighted { get { return Color.FromArgb(51, 51, 52); } }

		public Color None { get { return Color.Transparent; } }

		public Color SidebarBackground { get { return Color.FromArgb(37, 37, 38); } }

		public Color SidebarHighlighted { get { return Color.FromArgb(63, 63, 70); } }

		public Color TextUsername { get { return Color.FromArgb(139, 139, 142); } }

		public Color TextCommon { get { return Color.FromArgb(139, 139, 142); } }

		public Color TextContextMenu { get { return Color.FromArgb(139, 139, 142); } }

		public Color TextContextMenuHighlight { get { return Color.FromArgb(139, 139, 142); } }

		public ThemeStyle Theme { get { return ThemeStyle.Dark; } }
	}
}