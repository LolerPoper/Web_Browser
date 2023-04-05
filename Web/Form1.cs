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

        private void TxtUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(TxtUrl.Text);
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolCombo1.Items.Add(TxtUrl.Text);
            toolCombo1.SelectedItem = TxtUrl.Text;
            toolCombo1.Focus();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolCombo1_Click(object sender, EventArgs e)
        {
            try
            {
                if (toolCombo1.SelectedItem == null)
                {
                    MessageBox.Show("Poggers", "Niste dodali niti jedan bookmark!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                webBrowser1.Navigate(toolCombo1.SelectedItem.ToString());
            }
            catch (Exception lmao)
            {
                MessageBox.Show(lmao.Message, "Niste dodali niti jedan bookmark!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolCombo1.Items.Clear();
        }
    }
}
