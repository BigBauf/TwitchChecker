using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using TwitchChecker.Helper;

namespace TwitchChecker.Livestreamer
{
	public static class LiveStreamer
	{
		//==============================================Fields

		public const string BATCH_COMMAND = "livestreamer http://www.twitch.tv/{0} {1}\r\n{2}";
		public const string BATCH_FILE = "stream.bat";

		//==============================================Methods

		public static void RunBatch(string p_channel, string p_quality, bool p_hideConsole, bool p_keepConsoleOpen)
		{
			try
			{
				File.WriteAllText(BatchPath, (String.Format(BATCH_COMMAND, p_channel, p_quality, p_keepConsoleOpen ? "pause" : String.Empty)));
				Process proces = new Process();
				proces.StartInfo.FileName = BatchPath;
				if (p_hideConsole)
				{
					proces.StartInfo.UseShellExecute = false;
				}
				proces.Start();
			}
			catch (Exception ex)
			{
				Utility.LogTrace(ex.Message + " in " + MethodBase.GetCurrentMethod());
			}
		}

		private static string BatchPath { get { return Path.Combine(Environment.CurrentDirectory, BATCH_FILE); } }
	}
}