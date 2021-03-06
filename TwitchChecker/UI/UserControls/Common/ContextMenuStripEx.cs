﻿using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TwitchChecker.Theme;

namespace TwitchChecker.UI.UserControls.Common
{
	public partial class ContextMenuStripEx : ContextMenuStrip
	{
		//==============================================Ctor

		public ContextMenuStripEx(IContainer container)
			: base(container)
		{
			base.Renderer = new CustomRenderer();
			ShowImageMargin = false;
		}

		//==============================================Events

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			if (!DesignMode)
			{
				BackColor = ThemeManager.Instance.ColorProvider.ContextMenuBackground;
				foreach (ToolStripMenuItem item in Items)
				{
					item.ForeColor = item.Selected ?
						ThemeManager.Instance.ColorProvider.TextContextMenuHighlight :
						ThemeManager.Instance.ColorProvider.TextContextMenu;
				}
			}
		}

		//==============================================Misc

		private class CustomRenderer : ToolStripProfessionalRenderer
		{
			public CustomRenderer()
				: base(new ContextMenuColors())
			{
			}
		}

		private class ContextMenuColors : ProfessionalColorTable
		{
			public override Color MenuItemSelected { get { return ThemeManager.Instance.ColorProvider.ContextMenuHighlighted; } }

			public override Color MenuItemBorder { get { return ThemeManager.Instance.ColorProvider.None; } }

			public override Color MenuBorder { get { return ThemeManager.Instance.ColorProvider.ContextMenuBorder; } }
		}
	}
}