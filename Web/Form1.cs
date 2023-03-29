using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnUrl_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(TxtUrl.Text);
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            TxtUrl.Text = webBrowser1.Url.ToString();
        }

        private void BtnForw_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void BtnRefr_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("Google.com");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Bookmarks.Items.Add(webBrowser1.Url.ToString());
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Bookmarks.Items.Clear();
        }

        private void Bookmarks_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(Bookmarks.SelectedItem.ToString());
        }
    }
}
