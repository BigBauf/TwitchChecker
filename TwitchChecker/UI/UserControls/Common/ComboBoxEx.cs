///The ComboBoxCustom Control:

using System.Drawing;
using System.Windows.Forms;
using TwitchChecker.Theme;

namespace TwitchChecker.UI.UserControls.Common
{
	public class ComboBoxEx : ComboBox
	{
		new public System.Windows.Forms.DrawMode DrawMode { get; set; }

		public ComboBoxEx()
		{
			this.DropDownStyle = ComboBoxStyle.DropDownList;
			this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			base.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.DrawItem += new DrawItemEventHandler(AdvancedComboBox_DrawItem);
		}

		private void AdvancedComboBox_DrawItem(object sender, DrawItemEventArgs e)
		{
			if (e.Index < 0)
				return;

			ComboBox combo = sender as ComboBox;
			Color background;
			Color text;
			if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
			{
				background = Color.LightBlue;
				text = SkinManager.Instance.ColorProvider.TextContextMenuHighlight;
			}
			else
			{
				background = Color.White;
				text = SkinManager.Instance.ColorProvider.TextContextMenu;
			}

			text = Color.Black;

			e.Graphics.FillRectangle(new SolidBrush(background),
											 e.Bounds);
			e.Graphics.DrawString(combo.Items[e.Index].ToString(), e.Font,
										 new SolidBrush(text),
										 new Point(e.Bounds.X, e.Bounds.Y));

			e.DrawFocusRectangle();
		}
	}
}