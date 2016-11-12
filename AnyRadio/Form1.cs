using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnyRadio
{
    public partial class BackgroundRadio : Form
    {
        public BackgroundRadio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadUrl(urlbox.Text);
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            urlbox.Text = Properties.Settings.Default.LastUrl; // Load url from resources

            if (urlbox.Text != "")
            {
                loadUrl(urlbox.Text);
            }
        }

        public void loadUrl(String url)
        {
            try
            {
                webBrowser1.Url = new Uri(url);
                Properties.Settings.Default.LastUrl = url;
            }
            catch
            {
                MessageBox.Show("Invalid url");
            }
        }
    }
}
