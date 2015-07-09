using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using TwitchChecker.Theme;

namespace TwitchChecker
{
	internal static class Program
	{
		private static readonly Mutex mutex = new Mutex(true, "{8F6F0AC4-B9A1-45fd-A8CF-72F04E6BDE8F}");

		[STAThread]
		private static void Main()
		{
			if (mutex.WaitOne(TimeSpan.Zero, true))
			{
				ThemeStyle theme = (ThemeStyle)Enum.Parse(typeof(ThemeStyle), Properties.Settings.Default.Theme);
				ThemeManager.Instance.Init(theme);
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				IController controller = new Controller();
				controller.Init();
				controller.Run();
				mutex.ReleaseMutex();
			}
			else
			{
				// send our Win32 message to make the currently running instance
				// jump on top of all the other windows
				NativeMethods.PostMessage(
					 (IntPtr)NativeMethods.HWND_BROADCAST,
					 NativeMethods.WM_SHOWME,
					 IntPtr.Zero,
					 IntPtr.Zero);
			}
		}
	}

	internal static class NativeMethods
	{
		public const int HWND_BROADCAST = 0xffff;
		public static readonly int WM_SHOWME = RegisterWindowMessage("WM_SHOWME");

		[DllImport("user32")]
		public static extern bool PostMessage(IntPtr hwnd, int msg, IntPtr wparam, IntPtr lparam);

		[DllImport("user32")]
		public static extern int RegisterWindowMessage(string message);
	}
}