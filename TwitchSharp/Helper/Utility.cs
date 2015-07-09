using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;

namespace TwitchSharp.Helper
{
	internal static class Utility
	{
		//==============================================Fields/Const

		private const string LOGO_FOLDER = "logo";
		public const string LOG_FILE_NAME = "ErrorLog.txt";
		private const string DATE_TIME_FORMAT = "dd.MM.yy-HH:mm:ss";

		//==============================================Methoden

		/// <summary>
		/// Downloads a page as a string
		/// </summary>
		/// <param name="p_url">URL</param>
		/// <returns> see WebClient.DownloadString</returns>
		public static string GetJson(string p_url)
		{
			string result = null;
			try
			{
				if (Uri.IsWellFormedUriString(p_url, UriKind.Absolute))
				{
					WebClient client = new WebClient();
					result = client.DownloadString(p_url);
				}
				else
					throw new ArgumentException("Uri is not well formed");
			}
			catch (Exception ex)
			{
				result = null;
				Utility.LogTrace(ex.Message + " in " + MethodBase.GetCurrentMethod());
			}
			return result;
		}

		[Conditional("DEBUG")]
		public static void LogTrace(string p_message)
		{
			try
			{
				File.AppendAllText(LogFile, DateStamp + "_" + p_message + "\r\n");
			}
			catch (Exception)
			{
			}
		}

		private static string DateStamp { get { return DateTime.Now.ToString(DATE_TIME_FORMAT); } }

		private static string LogFile { get { return Path.Combine(Environment.CurrentDirectory, LOG_FILE_NAME); } }
	}
}