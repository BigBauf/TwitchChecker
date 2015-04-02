using System.Drawing;

namespace TwitchChecker.Theme.Themes
{
	public interface IThemeProvider
	{
		Color ChannelBackground { get; }

		Color ChannelHighlighted { get; }

		Color ContextMenuBackground { get; }

		Color ContextMenuBorder { get; }

		Color ContextMenuHighlighted { get; }

		Color None { get; }

		Color SidebarBackground { get; }

		Color SidebarHighlighted { get; }

		Color TextUsername { get; }

		Color TextCommon { get; }

		Color TextContextMenu { get; }

		Color TextContextMenuHighlight { get; }

		ThemeStyle Theme { get; }
	}
}