using System.Drawing;
using System.Windows.Forms;

namespace TwitchChecker.UI.Dlg.Common
{
	public partial class FormEx : Form
	{
		public FormEx()
		{
			InitializeComponent();
		}

		//Allows to safely change controls from another thread
		public void ThreadSafe(MethodInvoker p_method)
		{
			if (InvokeRequired)
			{
				BeginInvoke(p_method);
			}
			else
			{
				p_method();
			}
		}

		protected void SetForeColor(Control p_control, Color p_color)
		{
			p_control.ForeColor = p_color;
			foreach (Control item in p_control.Controls)
			{
				SetForeColor(item, p_color);
			}
		}

		protected void SetBackColor(Control p_control, Color p_color)
		{
			p_control.BackColor = p_color;
			foreach (Control item in p_control.Controls)
			{
				SetBackColor(item, p_color);
			}
		}
	}
}