using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using TwitchChecker.Theme;
using TwitchChecker.UI.Dlg.Common;
using TwitchChecker.UI.UserControls;
using TwitchSharp.Interfaces;

namespace TwitchChecker.UI.Dlg
{
	public partial class NotificationDlg : FormEx
	{
		//==============================================Fields/Constants

		private const int AW_SLIDE = 0X40000;

		private const int AW_HOR_POSITIVE = 0X1;
		private const int AW_HOR_NEGATIVE = 0X2;
		private const int AW_BLEND = 0X80000;

		[DllImport("user32")]
		private static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);

		//==============================================Ctor

		public NotificationDlg()
		{
			InitializeComponent();
			TopMost = true;
			SetLocation();
			ControlRemoved += NotificationDlg_ControlRemoved;
			ControlAdded += NotificationDlg_ControlAdded;
		}

		private void NotificationDlg_ControlAdded(object sender, ControlEventArgs e)
		{
			Visible = true;
			SetSize();
			SetLocation();
		}

		private void NotificationDlg_ControlRemoved(object sender, ControlEventArgs e)
		{
			Visible = Controls.Count > 0;
			SetSize();
			SetLocation();
		}

		private void SetSize()
		{
			int height = 0;
			foreach (Control item in Controls)
			{
				height += item.Height;
			}
			this.Height = height;
		}

		//==============================================Methods

		private void Observer()
		{
			//while (Controls.Count > 0)
			//{
			//}
		}

		private static ReaderWriterLockSlim methodLock = new ReaderWriterLockSlim();

		public void AddNotification(IChannel p_channel)
		{
			methodLock.EnterWriteLock();
			try
			{
				NotificationCtrl ctrl = new NotificationCtrl();
				ctrl.Dock = DockStyle.Bottom;
				ctrl.Init(p_channel);
				ThreadSafe(delegate { Controls.Add(ctrl); });
			}
			finally
			{
				methodLock.ExitWriteLock();
			}
		}

		private void SetLocation()
		{
			Screen screen = Screen.FromPoint(Location);

			Console.WriteLine(Controls.Count);
			Point newLocation = new Point(screen.WorkingArea.Right - this.Width, screen.WorkingArea.Bottom - this.Height - 10);
			ThreadSafe(delegate { Location = newLocation; });
		}

		//==============================================Events

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			SetBackColor(this, SkinManager.Instance.ColorProvider.ChannelBackground);
			SetForeColor(this, SkinManager.Instance.ColorProvider.TextCommon);
		}

		protected override void OnLoad(EventArgs e)
		{
			ThreadSafe(delegate { AnimateWindow(this.Handle, 900, AW_BLEND | AW_HOR_POSITIVE); });
		}
	}
}