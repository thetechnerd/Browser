using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void aboutNerdyBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
           AboutBox1 ab1 = new AboutBox1();
           ab1.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string WebPage = textBox1.Text.Trim();
            webBrowser1.Navigate(WebPage);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Print();

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.ShowDialog();
        }
    }
}
