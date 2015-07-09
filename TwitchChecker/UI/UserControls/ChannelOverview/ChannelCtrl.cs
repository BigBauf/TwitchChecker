using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TwitchChecker.Helper;
using TwitchChecker.Livestreamer;
using TwitchChecker.UI.UserControls.Common;
using TwitchSharp.Enums;
using TwitchSharp.Events;
using TwitchSharp.Interfaces;

namespace TwitchChecker.UI.UserControls
{
	public partial class ChannelCtrl : UserControlEx
	{
		public event EventHandler StatusChanged = delegate { };

		//==============================================Fields

		private const string GAME_FORMAT = "Playing {0}";

		public IChannel Channel { get; private set; }

		private System.Timers.Timer m_timer;
		private bool m_isSeleceted = false;

		//==============================================Konstruktor

		public ChannelCtrl()
		{
			InitializeComponent();
			SetColor();
		}

		//==============================================EventHandler

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			SetColor();
		}

		private void m_timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			Channel.Update();
			SetTimer();
		}

		private void control_DoubleClick(object sender, EventArgs e)
		{
			switch ((ViewMode)Enum.Parse(typeof(ViewMode), Properties.Settings.Default.ViewMode))
			{
				case ViewMode.Fullpage:
					Channel.OpenFullpage();
					break;

				case ViewMode.Popout:
					Channel.OpenPopout();
					break;

				case ViewMode.Livestreamer:
					LiveStreamer.RunBatch(Channel.Username, Properties.Settings.Default.Quality, Properties.Settings.Default.HideConsole, Properties.Settings.Default.KeepConsoleOpen);
					break;

				default:
					break;
			}
		}

		private void _MouseEnter(object sender, EventArgs e)
		{
			if (!contextMenu.m_isContextMenuOpen)
			{
				m_isSeleceted = true;
				Invalidate(true);
			}
		}

		private void _MouseLeave(object sender, EventArgs e)
		{
			if (!contextMenu.m_isContextMenuOpen)
			{
				m_isSeleceted = false;
				Invalidate(true);
			}
		}

		//if anything changes in the channel the gui can update the right property
		private void Channel_PropertyChanged(object sender, ChannelChangedEventArgs e)
		{
			switch (e.ChannelProperties)
			{
				case ChannelProperties.ChannelName:
					SetUsername();
					break;

				case ChannelProperties.Title:
					SetTitle();
					break;

				case ChannelProperties.Game:
					SetGame();
					break;

				case ChannelProperties.Viewer:
					SetViewer();
					break;

				case ChannelProperties.Status:
					StatusChanged(this, new EventArgs());
					Utility.LogTrace(Channel.Username + " went: " + Channel.Status.ToString());
					break;

				case ChannelProperties.Logo:
					SetLogo();
					break;

				case ChannelProperties.Url:
					break;

				default:
					throw new ArgumentException("Unknown ChannelPropertie");
			}
		}

		//==============================================Methods

		public void Init(IChannel p_channel)
		{
			m_timer = new System.Timers.Timer();
			m_timer.Elapsed += m_timer_Elapsed;
			Channel = p_channel;
			Channel.OnPropertyChanged += Channel_PropertyChanged;
			contextMenu.Init(Channel);
			AddDoubleClickEvent(this);
			Channel.Update();
			SetUsername();
			SetGame();
			SetTitle();
			SetViewer();
			SetLogo();
			SetTimer();
		}

		private void AddDoubleClickEvent(Control p_control)
		{
			p_control.DoubleClick += control_DoubleClick;
			foreach (Control item in p_control.Controls)
			{
				AddDoubleClickEvent(item);
			}
		}

		//must be called directly after InitComponents so there is no flickering in the UI
		private void SetColor()
		{
			SetBackColor(this, m_isSeleceted ? SkinManager.ColorProvider.ChannelHighlighted : SkinManager.ColorProvider.ChannelBackground);
			lblUsername.ForeColor = SkinManager.ColorProvider.TextUsername;
			lblGame.ForeColor = SkinManager.ColorProvider.TextCommon;
			lblTitle.ForeColor = SkinManager.ColorProvider.TextCommon;
			lblViewer.ForeColor = SkinManager.ColorProvider.TextCommon;
		}

		private void SetUsername()
		{
			ThreadSafe(delegate { lblUsername.Text = Channel.Username; });
		}

		private void SetGame()
		{
			string result = !String.IsNullOrWhiteSpace(Channel.Game) ? String.Format(GAME_FORMAT, Channel.Game) : Status.Offline.ToString();
			ThreadSafe(delegate { lblGame.Text = result; });
		}

		private void SetViewer()
		{
			string result = Channel.Viewers != null ? Channel.Viewers.ToString() : String.Empty;

			ThreadSafe(delegate { pictureBox1.Visible = result != String.Empty; });

			ThreadSafe(delegate { lblViewer.Text = result; });
		}

		private void SetTitle()
		{
			ThreadSafe(delegate { lblTitle.Text = Channel.Title; });
			ThreadSafe(delegate { toolTip.SetToolTip(lblTitle, Channel.Title); });
			ThreadSafe(delegate { toolTip.SetToolTip(lblUsername, Channel.Title); });
		}

		public void SetTimer()
		{
			m_timer.Stop();
			m_timer.Interval = Properties.Settings.Default.UpdateIntervall * 60000;
			m_timer.Start();
		}

		private void SetLogo()
		{
			ThreadSafe(delegate { pbProfileImg.Image = Utility.LoadChannelLogo(Channel.Username, Channel.Logo); });
		}

		//==============================================Properties
	}

	public class ControlComparer : IComparer<ChannelCtrl>
	{
		public int Compare(ChannelCtrl x, ChannelCtrl y)
		{
			if ((x is ChannelCtrl) && (y is ChannelCtrl))
			{
				//First status then name
				if (x.Channel.Status != y.Channel.Status)
					return y.Channel.Status.CompareTo(x.Channel.Status);
				else
					return y.Channel.Username.CompareTo(x.Channel.Username);
			}
			else
			{
				return 999 + String.Compare(x.Name, y.Name, false);
			}
		}
	}
}