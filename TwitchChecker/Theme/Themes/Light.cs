using System.Drawing;

namespace TwitchChecker.Theme.Themes
{
	internal class Light : IThemeProvider
	{
		public Color ChannelBackground { get { return Color.FromArgb(255, 255, 255); } }

		public Color ChannelHighlighted { get { return Color.FromArgb(238, 238, 238); } }

		public Color ContextMenuBackground { get { return Color.FromArgb(246, 246, 246); } }

		public Color ContextMenuBorder { get { return Color.FromArgb(204, 206, 219); } }

		public Color ContextMenuHighlighted { get { return Color.FromArgb(201, 222, 245); } }

		public Color None { get { return Color.FromArgb(0, 0, 0, 0); } }

		public Color SidebarBackground { get { return Color.FromArgb(245, 245, 245); } }

		public Color SidebarHighlighted { get { return Color.FromArgb(173, 214, 255); } }

		public Color TextUsername { get { return ColorProvider.VSLightText; } }

		public Color TextCommon { get { return Color.FromArgb(68, 68, 68); } }

		public Color TextContextMenu { get { return ColorProvider.VSLightText; } }

		public Color TextContextMenuHighlight { get { return ColorProvider.VSLightText; } }

		public ThemeStyle Theme { get { return ThemeStyle.Light; } }
	}
}