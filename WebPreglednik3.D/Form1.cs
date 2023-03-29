using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebPreglednik3.D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtBoxAdresa.Text);
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("Google.com");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listBox.Items.Add(webBrowser1.Url.ToString());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void listBox_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(listBox.SelectedItems.ToString());
        }
    }
}
