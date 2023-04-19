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

        private void txtBoxAdresa_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(txtBoxAdresa.Text);
            }
        }

        private void bookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem bookmarkItem = new ToolStripMenuItem();
            bookmarkItem.Text = txtBoxAdresa.Text;
            bookmarkItem.Click += BookmarkItem_Click;
            bookmarksToolStripMenuItem.DropDownItems.Add(bookmarkItem);
        }

        private void BookmarkItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            string url = item.Text;
            webBrowser1.Navigate(url);
        }

        private void btnAddBookmark_Click(object sender, EventArgs e)
        {
            bookmarksToolStripMenuItem_Click(sender, e);
        }

    }
}
