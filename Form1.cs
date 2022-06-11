using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebScraping.Tools;

namespace WebScraping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.ObjectForScripting = new Debbuger();
            webBrowser1.DocumentCompleted += WebBrowser1_DocumentCompleted;
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string javascript = "reloadCaptcha = function(){ return true; }";
            // or any combination of your JavaScript commands
            // (including function calls, variables... etc)

            webBrowser1.Document.InvokeScript("eval", new object[] { javascript });
        }
    }
}
