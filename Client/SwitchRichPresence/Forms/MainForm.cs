﻿using System;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace SwitchRichPresence
{
    public partial class MainForm : Form
    {
        public static string TEMP_PATH = Path.GetTempPath() + @"\SwitchRichPresence\";

        string appID;
        DiscordController discord = new DiscordController();
        Thread UpdatePlaying;
        SwitchApps apps = null;
        TitleInfo CurrentPlaying = null;
        ulong CurrentTid = 0;
        long startTime;
        string CurrentUser = null;


        private void UpdateInfo()
        {
            bool newTitle = (CurrentPlaying != null && CurrentPlaying.TitleID != CurrentTid);

            if (CurrentPlaying != null)
            {
                if (newTitle)
                {
                    if (pictureBox_icon.Image != null)
                        pictureBox_icon.Image.Dispose();
                    pictureBox_icon.Image = new Bitmap(CurrentPlaying.Icon);

                    startTime = (long)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
                    CurrentTid = CurrentPlaying.TitleID;

                        discord.presence = new DiscordRpc.RichPresence()
                    {
                        details = "Playing " + CurrentPlaying.Metadata.GetLanguage().ApplicationName,
                        smallImageKey = "icon",
                        smallImageText = "SwitchPresence Sysmodule",
                        largeImageKey = CurrentPlaying.TitleID.ToString("x16"),
                        largeImageText = CurrentPlaying.Metadata.GetLanguage().ApplicationName,
                        startTimestamp = startTime,
                    };
                    OverrideDetail();
                    OverrideLargeIcon();
                    OverrideSmallIcon();
                }
                    //update user
                    checkBox_showUser_CheckedChanged(null, null);
                //update time
                checkBox_showTime_CheckedChanged(null, null);

                //layout
                label_game.Text = string.Format("Game : {0}\r\nTitle ID : {1}\r\nVersion : {2}\r\n{3}",
                    CurrentPlaying.Metadata.GetLanguage().ApplicationName,
                    CurrentPlaying.Metadata.TitleId,
                    CurrentPlaying.Metadata.AppVersion,
                    discord.presence.state
                    );

            }
            else
            {
                if (pictureBox_icon.Image != null)
                    pictureBox_icon.Image.Dispose();
                pictureBox_icon.Image = null;

                discord.presence = new DiscordRpc.RichPresence()
                {
                    details = "Not Playing",
                    state = "",
                    smallImageKey = "",
                    smallImageText = "",
                    largeImageKey = "",
                    largeImageText = "",
                };
                label_game.Text = "Not playing";
                CurrentTid = 0;
            }
            DiscordRpc.UpdatePresence(discord.presence);
        }


        private void SaveConfig()
        {
            Config config = new Config()
            {
                IP = textBox_ip.Text,
                ClientID = textBox_clientId.Text,
                ShowTimer = checkBox_showTime.Checked,
                ShowUser = checkBox_showUser.Checked,
                SIcon = textBox_overridesicon.Text,
                LIcon = textBox_overridelicon.Text,
                //Detail = textBox_overridedetail.Text
            };
            config.Save();
        }
        private void LoadConfig()
        {
            Config config = new Config();
            appID = config.ClientID;
            textBox_ip.Text = config.IP;
            textBox_clientId.Text = config.ClientID;
            checkBox_showTime.Checked = config.ShowTimer;
            checkBox_showUser.Checked = config.ShowUser;
            textBox_overridesicon.Text = config.SIcon;
            textBox_overridelicon.Text = config.LIcon;
            //textBox_overridedetail.Text = config.Detail;
        }

        public MainForm()
        {
            InitializeComponent();

            LoadConfig();

            Updater.GetUpdate();

            if (!Directory.Exists(TEMP_PATH))
            {
                Directory.CreateDirectory(TEMP_PATH);
            }

            discord.Initialize(appID);
            DiscordRpc.UpdatePresence(discord.presence);

            textBox_overridedetail.TextChanged += (o, e) => OverrideDetail();
            textBox_overridelicon.TextChanged += (o, e) => OverrideLargeIcon();
            textBox_overridesicon.TextChanged += (o, e) => OverrideSmallIcon();

        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (button_connect.Text != "Connect")
            {
                //close safely
                button_connect_Click(null, null);
            }

            DiscordRpc.Shutdown();
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            if (button_connect.Text == "Connect")
            {
                try
                {
                    apps = new SwitchApps(textBox_ip.Text);
                }
                catch (SocketException)
                {
                    MessageBox.Show("No switch found !\r\nMake sure that the ip you entered is correct.");
                    return;
                }
                catch (ServerVersionException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                SaveConfig();

                warn.Visible = true;
                textBox_ip.Enabled = false;
                textBox_clientId.Enabled = false;
                utilsToolStripMenuItem.Visible = true;
                button_connect.Text = "Abort";

                UpdatePlaying = new Thread(() => {
                    while (true)
                    {
                        CurrentPlaying = apps.GetPlaying();
                        CurrentUser = apps.GetCurrentUser();
                        Invoke(new Action(() => UpdateInfo()));

                        Thread.Sleep(1000 * 2);
                    }
                });
                UpdatePlaying.IsBackground = true;
                UpdatePlaying.Start();
            }
            else //abort
            {
                warn.Visible = false;
                textBox_ip.Enabled = true;
                textBox_clientId.Enabled = true;
                utilsToolStripMenuItem.Visible = false;
                button_connect.Text = "Connect";

                UpdatePlaying.Abort();
                apps.Dispose();
                UpdatePlaying = null;
                CurrentPlaying = null;
                apps = null;
                UpdateInfo();
            }
        }

        private void exportIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderSelectDialog fbox = new FolderSelectDialog();
            if (fbox.ShowDialog() == DialogResult.OK)
            {
                foreach (var app in apps.Applications)
                {
                    using (Bitmap bmp = new Bitmap(app.Icon, 512, 512))
                    {
                        bmp.Save(fbox.SelectedPath + @"\" + app.TitleID.ToString("X16") + ".png");
                    }
                }

                MessageBox.Show("Done!");
            }
        }

        private void checkBox_showUser_CheckedChanged(object sender, EventArgs e)
        {
            if (apps != null)
            {

                if (checkBox_showUser.Checked)
                    discord.presence.state = (CurrentUser == null)
                        ? "No user selected."
                        : "User : " + CurrentUser;

                else
                    discord.presence.state = "";

                DiscordRpc.UpdatePresence(discord.presence);
            }
        }

        private void OverrideDetail()
        {
            if (string.IsNullOrWhiteSpace(textBox_overridedetail.Text) && (CurrentPlaying != null))
            {
                discord.presence.details = "Playing " + CurrentPlaying.Metadata.GetLanguage().ApplicationName;
            }
            else if (CurrentPlaying != null)
            {
                discord.presence.details = textBox_overridedetail.Text;
            }
            SaveConfig();
        }

        private void OverrideSmallIcon()
        {
            if (string.IsNullOrWhiteSpace(textBox_overridesicon.Text))
            {
                discord.presence.smallImageKey = "icon";
            }
            else
            {
                discord.presence.smallImageKey = textBox_overridesicon.Text;
            }
            SaveConfig();
        }

        private void OverrideLargeIcon()
        {
            if (string.IsNullOrWhiteSpace(textBox_overridelicon.Text) && (CurrentPlaying != null))
            {
                discord.presence.largeImageKey = CurrentPlaying.TitleID.ToString("x16");
            }
            else if (CurrentPlaying != null)
            {
                discord.presence.largeImageKey = textBox_overridelicon.Text;
            }
            SaveConfig();
        }

        private void checkBox_showTime_CheckedChanged(object sender, EventArgs e)
        {
            if (apps != null)
            {
                discord.presence.startTimestamp = (checkBox_showTime.Checked) ? startTime : 0;
                DiscordRpc.UpdatePresence(discord.presence);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutForm form = new AboutForm();
            form.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox_ip_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_overridebicon_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_overridesicon_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }

 }
