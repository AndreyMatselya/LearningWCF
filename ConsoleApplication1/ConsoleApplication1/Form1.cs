using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			if (e.Url.ToString().IndexOf("af") != -1)
			{
				string accessToken = "";
				int userId = 0;
				Regex myReg = new Regex(@"(?<name>[\w\d\x5f]+)=(?<value>[^\x26\s]+)", RegexOptions.IgnoreCase | RegexOptions.Singleline);
				foreach (Match m in myReg.Matches(e.Url.ToString()))
				{
					if (m.Groups["name"].Value == "af")
					{
						accessToken = m.Groups["value"].Value;
					}
					//else if (m.Groups["name"].Value == "user_id")
					//{
					//	userId = Convert.ToInt32(m.Groups["value"].Value);
					//}
					// еще можно запомнить срок жизни access_token - expires_in,
					// если нужно
				}
				MessageBox.Show(String.Format("Ключ доступа: {0}\nUserID:", accessToken));
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			webBrowser1.Navigate(String.Format("http://google.com?af=144"));
		}
	}
}
