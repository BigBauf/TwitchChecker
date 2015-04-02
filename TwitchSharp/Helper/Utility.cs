using System;
using System.Diagnostics;
using System.Drawing;
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
		/// Gets the image from URL.
		/// </summary>
		/// <param name="p_url">The url</param>
		/// <returns>Image/null on exception etc...</returns>
		public static Image GetImageFromURL(string p_url)
		{
			Image result = null;
			try
			{
				if (!String.IsNullOrWhiteSpace(p_url))
				{
					HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(p_url);
					HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse();
					System.IO.Stream stream = httpWebReponse.GetResponseStream();
					result = Image.FromStream(stream);
				}
				else
					throw new ArgumentException();
			}
			catch (Exception ex)
			{
				result = null;
				Utility.LogTrace(DateStamp + "_" + ex.Message + " in " + MethodBase.GetCurrentMethod());
			}
			return result;
		}

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

		//gets the image filename from the url
		private static string GetImageNameFromUrl(string p_url)
		{
			string result = String.Empty;
			if (!String.IsNullOrWhiteSpace(p_url))
			{
				int start = p_url.LastIndexOf("/") + 1;
				int length = p_url.Length - start;
				result = p_url.Substring(start, length);
			}
			return result;
		}

		public static void SetStartup(string p_executablePath, bool enable)
		{
			string runKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
			string AppName = "TwitchChecker";

			Microsoft.Win32.RegistryKey startupKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(runKey);

			if (enable)
			{
				if (startupKey.GetValue(AppName) == null)
				{
					startupKey.Close();
					startupKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(runKey, true);
					// Add startup reg key
					startupKey.SetValue(AppName, p_executablePath);
					startupKey.Close();
				}
			}
			else
			{
				// remove startup
				startupKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(runKey, true);
				startupKey.DeleteValue(AppName, false);
				startupKey.Close();
			}
		}

		/// <summary> deletes old chanel logos</summary>
		/// <param name="p_channelName">channel </param>
		/// <param name="p_imageName">new logo filename</param>
		private static void DeleteOldLogo(string p_channelName, string p_imageName)
		{
			try
			{
				DirectoryInfo info = new DirectoryInfo(LogoFolder);
				foreach (var item in info.GetFiles(p_channelName.ToLower() + "*"))
				{
					if (item.Name != p_imageName)
					{
						File.Delete(item.FullName);
					}
				}
			}
			catch (Exception ex)
			{
				Utility.LogTrace(p_channelName + "_" + ex.Message + " in " + MethodBase.GetCurrentMethod());
			}
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

		private static string LogoFolder { get { return Path.Combine(Environment.CurrentDirectory, LOGO_FOLDER); } }
	}
}