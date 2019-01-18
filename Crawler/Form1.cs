using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crawler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.Navigate("https://www.facebook.com/");
            while (webBrowser1.ReadyState != WebBrowserReadyState.Complete)
            {
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                Application.DoEvents();
            }
            webBrowser1.Document.GetElementById("email").SetAttribute("value", "teste");
            webBrowser1.Document.GetElementById("pass").SetAttribute("value", "teste");
            //comando para clicar em um botao ( login )
            //webBrowser1.Document.GetElementById("u_0_2").InvokeMember("Click");
            var c = webBrowser1.Document.GetElementById("privacy-link").InnerText;
            MessageBox.Show(c);
        }
    }
}
