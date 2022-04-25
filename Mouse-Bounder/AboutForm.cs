using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Mouse_Bounder
{
    public partial class AboutForm : Form
    {
        public static bool OpenLink(string link)
        {
            try { Process.Start(new ProcessStartInfo(link) { UseShellExecute = true }); return true; }
            catch { return false; }
        }

        public AboutForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, EventArgs e)
        {
            string link = linkLabel1.Text;
            AboutForm.OpenLink(link);
        }
    }
}
