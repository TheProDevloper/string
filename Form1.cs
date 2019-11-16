using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace RandomString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gen_Click(object sender, EventArgs e)
        {
            var accounts = new WebClient().DownloadString("http://localhost/xd.txt").Split('\n'); 
            printer.Text = accounts[new Random().Next(0, accounts.Length)];
        }
    }
}
