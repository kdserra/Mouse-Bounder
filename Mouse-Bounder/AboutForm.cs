using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string link = linkLabel1.Text;
            AboutForm.OpenLink(link);
        }
    }
}
