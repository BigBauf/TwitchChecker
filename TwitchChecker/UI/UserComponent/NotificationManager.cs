using System;
using System.ComponentModel;
using TwitchChecker.Helper;
using TwitchSharp.Enums;
using TwitchSharp.Interfaces;
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;

namespace TwitchChecker.UI.UserComponent
{
	public partial class NotificationManager : Component
	{
		private IController Controller { get; set; }

		private const String APP_ID = "TwitchChecker";

		//==============================================Ctor

		public NotificationManager(IContainer container)
		{
			InitializeComponent();
			container.Add(this);
		}

		//==============================================Events

		private void StreamProvider_OnChannelAdded(object sender, TwitchSharp.Events.ChannelAddedEventArgs e)
		{
			e.AddedChannel.OnPropertyChanged += AddedChannel_OnPropertyChanged;
		}

		private void AddedChannel_OnPropertyChanged(object sender, TwitchSharp.Events.ChannelChangedEventArgs e)
		{
			IChannel channel = sender as IChannel;
			if (e.ChannelProperties == ChannelProperties.Status && channel.Status == Status.Online && Properties.Settings.Default.ShowNotification)
			{
				//The called function contains code that only works on OS > Windows 8.
				//When i check for this inside the functions it is to late and it does not run well
				if (Environment.OSVersion.Version.Major >= 6 && Environment.OSVersion.Version.Minor >= 2)
					ShowNotification(channel);
			}
		}

		//==============================================Methods

		public void Init(IController p_controller)
		{
			if (p_controller == null)
				throw new ArgumentNullException();
			Controller = p_controller;
			Controller.TwitchClient.OnChannelAdded += StreamProvider_OnChannelAdded;
		}

		public void ShowNotification(IChannel p_channel)
		{
			try
			{
				XmlDocument notificationNode = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastImageAndText04);

				//Text
				XmlNodeList nodeList = notificationNode.GetElementsByTagName("text");
				nodeList[0].AppendChild(notificationNode.CreateTextNode(p_channel.Username));
				nodeList[1].AppendChild(notificationNode.CreateTextNode(p_channel.Game));
				nodeList[2].AppendChild(notificationNode.CreateTextNode(p_channel.Title));

				//Play Notification true/false
				IXmlNode audioNode = notificationNode.SelectSingleNode("/toast");
				XmlElement audioElement = notificationNode.CreateElement("audio");
				audioElement.SetAttribute("silent", !Properties.Settings.Default.PlayNotificationSound ? "true" : "false");
				audioNode.AppendChild(audioElement);

				//Channel Logo
				string logoPath = "file:///" + Utility.GetLogoPath(p_channel.Username, p_channel.Logo);
				XmlNodeList imageElements = notificationNode.GetElementsByTagName("image");
				imageElements[0].Attributes.GetNamedItem("src").NodeValue = logoPath;

				//Show
				ToastNotification toast = new ToastNotification(notificationNode);
				ToastNotificationManager.CreateToastNotifier(APP_ID).Show(toast);
			}
			catch (Exception ex)
			{
				Utility.LogTrace(ex.Message);
			}
		}

		//private void InstallShortcut(String shortcutPath)
		//{
		//	// Find the path to the current executable
		//	String exePath = Process.GetCurrentProcess().MainModule.FileName;
		//	IShellLinkW newShortcut = (IShellLinkW)new CShellLink();

		//	// Create a shortcut to the exe
		//	ErrorHelper.VerifySucceeded(newShortcut.SetPath(exePath));
		//	ErrorHelper.VerifySucceeded(newShortcut.SetArguments(""));

		//	// Open the shortcut property store, set the AppUserModelId property
		//	IPropertyStore newShortcutProperties = (IPropertyStore)newShortcut;

		//	using (PropVariant appId = new PropVariant(APP_ID))
		//	{
		//		ErrorHelper.VerifySucceeded(newShortcutProperties.SetValue(SystemProperties.System.AppUserModel.ID, appId));
		//		ErrorHelper.VerifySucceeded(newShortcutProperties.Commit());
		//	}

		//	// Commit the shortcut to disk
		//	IPersistFile newShortcutSave = (IPersistFile)newShortcut;

		//	ErrorHelper.VerifySucceeded(newShortcutSave.Save(shortcutPath, true));
		//}
	}
}