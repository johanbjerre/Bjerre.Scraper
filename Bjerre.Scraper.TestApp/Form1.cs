using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bjerre.Scraper.TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void runkeeperTest_Click(object sender, EventArgs e)
        {
            var scraper = new Scraper();

            var urlStart = "https://runkeeper.com";
            AddLog(string.Format("Scrapes url:'{0}'", urlStart));
            var lastContent = scraper.PerformRequest(urlStart);
            AddLog(string.Format("Scraped:'{0}', got:", urlStart));
            AddLog(lastContent);

            var urlLogin = "https://runkeeper.com/login";
            AddLog(string.Format("Scrapes url:'{0}'", urlLogin));
            var postdata = "_eventName=submit&email=" + userNameBox.Text + "&password=" + passwordBox.Text;
            lastContent = scraper.PerformRequest(urlLogin, postdata);
            AddLog(string.Format("Scraped:'{0}', got:", urlLogin));
            AddLog(lastContent);

            var urlInloggad = "http://runkeeper.com/home";
            AddLog(string.Format("Scrapes url:'{0}'", urlInloggad));
            lastContent = scraper.PerformRequest(urlInloggad, null);
            AddLog(string.Format("Scraped:'{0}', got:", urlInloggad));
            AddLog(lastContent);
        }

        private delegate void AddLogDelegate(string text);
        private void AddLog(string text)
        {
            if (_log.InvokeRequired)
            {
                var addLogDelegate = new AddLogDelegate(AddLog);
                Invoke(addLogDelegate, new object[] { text });
            }
            else
            {
                _log.Text += text + Environment.NewLine;
                _log.Select(_log.Text.Length, 0);
                _log.ScrollToCaret();
            }
        }

        private void _log_TextChanged(object sender, EventArgs e)
        {

        }

        private void Scrape_Click(object sender, EventArgs e)
        {
            var url = urlBox.Text;

            AddLog(string.Format("Scrapes url:'{0}'", url));
            var scraper = new Scraper();
            var lastContent = scraper.PerformRequest(url);
            AddLog(string.Format("Scraped:'{0}', got:",url));
            AddLog(lastContent);
        }
    }
}
