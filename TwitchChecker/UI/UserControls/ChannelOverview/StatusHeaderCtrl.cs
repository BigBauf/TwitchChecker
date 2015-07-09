using System.Drawing;
using System.Windows.Forms;
using TwitchChecker.Theme;

namespace TwitchChecker.UI.UserControls.ChannelOverview
{
	public partial class StatusHeaderCtrl : Panel
	{
		//==============================================Fields

		public bool Collapsed { get; set; }

		private Pen pen = null;

		//==============================================Ctor

		public StatusHeaderCtrl()
		{
			InitializeComponent();
			ResizeRedraw = true;
			DoubleBuffered = true;

			pen = new Pen(ThemeManager.Instance.ColorProvider.TextCommon, 3);
			pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
		}

		//==============================================Overrides

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			if (Collapsed)
				DrawUpArrow(e);
			else
				DrawDownArrow(e);
		}

		//==============================================Methods

		private void DrawDownArrow(PaintEventArgs e)
		{
			Pen pen = new Pen(ThemeManager.Instance.ColorProvider.TextCommon, 3);
			pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

			//x = 0 bis Width 0 ist links
			//y = 0 bis Height 0 ist oben
			int half = Height / 2;
			//Left Part

			Point leftStart = new Point(Width - 42, half);
			Point leftEnd = new Point(Width - 34, half + 5);

			Point rightStart = new Point(Width - 36, half + 5);
			Point rightEnd = new Point(Width - 28, half);

			e.Graphics.DrawLine(pen, leftEnd, leftStart);
			e.Graphics.DrawLine(pen, rightStart, rightEnd);
		}

		private void DrawUpArrow(PaintEventArgs e)
		{
			//x = 0 bis Width 0 ist links
			//y = 0 bis Height 0 ist oben
			int half = Height / 2;
			//Left Part

			Point leftStart = new Point(Width - 42, half + 5);
			Point leftEnd = new Point(Width - 34, half);

			Point rightStart = new Point(Width - 36, half);
			Point rightEnd = new Point(Width - 28, half + 5);

			e.Graphics.DrawLine(pen, leftEnd, leftStart);
			e.Graphics.DrawLine(pen, rightStart, rightEnd);
		}
	}
}