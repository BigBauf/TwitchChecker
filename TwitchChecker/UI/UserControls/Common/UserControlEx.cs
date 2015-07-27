using System.Drawing;
using System.Windows.Forms;
using TwitchChecker.Theme;

namespace TwitchChecker.UI.UserControls.Common
{
	public class UserControlEx : UserControl
	{
		//==============================================Fields

		protected IController Controller { get; set; }

		protected ThemeManager SkinManager { get { return ThemeManager.Instance; } }

		//==============================================Ctor

		public UserControlEx()
			: base()
		{
		}

		//==============================================Methods

		//Allows to safely change controls from another thread
		public void ThreadSafe(MethodInvoker p_method)
		{
			if (InvokeRequired)
				BeginInvoke(p_method);
			else
				p_method();
		}

		protected void SetBackColor(Control p_control, Color p_color)
		{
			p_control.BackColor = p_color;
			foreach (Control item in p_control.Controls)
			{
				SetBackColor(item, p_color);
			}
		}

		protected void SetForeColor(Control p_control, Color p_color)
		{
			if (!(p_control is TextBox))
				p_control.ForeColor = p_color;
			foreach (Control item in p_control.Controls)
			{
				SetForeColor(item, p_color);
			}
		}
	}
}