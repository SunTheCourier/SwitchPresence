using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SwitchPresence
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        //links
        private void LinkLabel_twitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://twitter.com/random666_kys");
        }
        private void LinkLabel_github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/random0666");
        }
        private void LinkLabel_youtube_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCYjhNcCjH9XXf77VtW8pTng");
        }

        private void Button_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://twitter.com/Sun_Courier");
        }

        private void SGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/SunTheCourier");
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCuhdQw_BibXDqPimSQn4iQg");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://twitter.com/exentiostep");
        }

        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/exentio");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://exentio.sexy");
        }
    }
}
