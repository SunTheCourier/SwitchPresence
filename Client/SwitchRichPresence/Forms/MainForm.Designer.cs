﻿namespace SwitchPresence
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox_icon = new System.Windows.Forms.PictureBox();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_connect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_game = new System.Windows.Forms.Label();
            this.checkBox_showUser = new System.Windows.Forms.CheckBox();
            this.checkBox_showTime = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBox_clientId = new System.Windows.Forms.TextBox();
            this.textBox_overridesicon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_overridelicon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.utilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_overridedetail = new System.Windows.Forms.TextBox();
            this.warn = new System.Windows.Forms.Label();
            this.AFS = new System.Windows.Forms.CheckBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_icon
            // 
            this.pictureBox_icon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_icon.Location = new System.Drawing.Point(14, 329);
            this.pictureBox_icon.Name = "pictureBox_icon";
            this.pictureBox_icon.Size = new System.Drawing.Size(100, 100);
            this.pictureBox_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_icon.TabIndex = 0;
            this.pictureBox_icon.TabStop = false;
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(120, 37);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(118, 20);
            this.textBox_ip.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(139, 89);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(75, 23);
            this.button_connect.TabIndex = 3;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.Button_connect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Playing :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_game
            // 
            this.label_game.AutoSize = true;
            this.label_game.Location = new System.Drawing.Point(121, 351);
            this.label_game.Name = "label_game";
            this.label_game.Size = new System.Drawing.Size(16, 13);
            this.label_game.TabIndex = 5;
            this.label_game.Text = "...";
            this.label_game.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBox_showUser
            // 
            this.checkBox_showUser.AutoSize = true;
            this.checkBox_showUser.Checked = true;
            this.checkBox_showUser.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_showUser.Location = new System.Drawing.Point(14, 254);
            this.checkBox_showUser.Name = "checkBox_showUser";
            this.checkBox_showUser.Size = new System.Drawing.Size(119, 17);
            this.checkBox_showUser.TabIndex = 7;
            this.checkBox_showUser.Text = "Show selected user";
            this.checkBox_showUser.UseVisualStyleBackColor = true;
            this.checkBox_showUser.CheckedChanged += new System.EventHandler(this.CheckBox_showUser_CheckedChanged);
            // 
            // checkBox_showTime
            // 
            this.checkBox_showTime.AutoSize = true;
            this.checkBox_showTime.Checked = true;
            this.checkBox_showTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_showTime.Location = new System.Drawing.Point(14, 219);
            this.checkBox_showTime.Name = "checkBox_showTime";
            this.checkBox_showTime.Size = new System.Drawing.Size(78, 17);
            this.checkBox_showTime.TabIndex = 8;
            this.checkBox_showTime.Text = "Show timer";
            this.checkBox_showTime.UseVisualStyleBackColor = true;
            this.checkBox_showTime.CheckedChanged += new System.EventHandler(this.CheckBox_showTime_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(291, 416);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(35, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "About";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // textBox_clientId
            // 
            this.textBox_clientId.Location = new System.Drawing.Point(120, 63);
            this.textBox_clientId.Name = "textBox_clientId";
            this.textBox_clientId.Size = new System.Drawing.Size(118, 20);
            this.textBox_clientId.TabIndex = 10;
            // 
            // textBox_overridesicon
            // 
            this.textBox_overridesicon.Location = new System.Drawing.Point(208, 235);
            this.textBox_overridesicon.Name = "textBox_overridesicon";
            this.textBox_overridesicon.Size = new System.Drawing.Size(118, 20);
            this.textBox_overridesicon.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Small Icon override";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_overridelicon
            // 
            this.textBox_overridelicon.Location = new System.Drawing.Point(208, 194);
            this.textBox_overridelicon.Name = "textBox_overridelicon";
            this.textBox_overridelicon.Size = new System.Drawing.Size(118, 20);
            this.textBox_overridelicon.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Big Icon override";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // utilsToolStripMenuItem
            // 
            this.utilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportIconsToolStripMenuItem});
            this.utilsToolStripMenuItem.Name = "utilsToolStripMenuItem";
            this.utilsToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.utilsToolStripMenuItem.Text = "Utils";
            this.utilsToolStripMenuItem.Visible = false;
            // 
            // exportIconsToolStripMenuItem
            // 
            this.exportIconsToolStripMenuItem.Name = "exportIconsToolStripMenuItem";
            this.exportIconsToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.exportIconsToolStripMenuItem.Text = "Export icons";
            this.exportIconsToolStripMenuItem.Click += new System.EventHandler(this.ExportIconsToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(338, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Detail override";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_overridedetail
            // 
            this.textBox_overridedetail.Location = new System.Drawing.Point(208, 274);
            this.textBox_overridedetail.Name = "textBox_overridedetail";
            this.textBox_overridedetail.Size = new System.Drawing.Size(118, 20);
            this.textBox_overridedetail.TabIndex = 18;
            // 
            // warn
            // 
            this.warn.AutoSize = true;
            this.warn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warn.ForeColor = System.Drawing.Color.Red;
            this.warn.Location = new System.Drawing.Point(11, 144);
            this.warn.Name = "warn";
            this.warn.Size = new System.Drawing.Size(320, 15);
            this.warn.TabIndex = 20;
            this.warn.Text = "Abort connection before putting console to sleep!\r\n";
            this.warn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.warn.Visible = false;
            // 
            // AFS
            // 
            this.AFS.AutoSize = true;
            this.AFS.Location = new System.Drawing.Point(120, 118);
            this.AFS.Name = "AFS";
            this.AFS.Size = new System.Drawing.Size(108, 17);
            this.AFS.TabIndex = 21;
            this.AFS.Text = "Away from switch";
            this.AFS.UseVisualStyleBackColor = true;
            this.AFS.Visible = false;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(59, 66);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(50, 13);
            this.linkLabel2.TabIndex = 22;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Client ID:";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel2_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 440);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.AFS);
            this.Controls.Add(this.warn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_overridedetail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_overridelicon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_overridesicon);
            this.Controls.Add(this.textBox_clientId);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.checkBox_showTime);
            this.Controls.Add(this.checkBox_showUser);
            this.Controls.Add(this.label_game);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_ip);
            this.Controls.Add(this.pictureBox_icon);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "SwitchPresence Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_icon;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_game;
        private System.Windows.Forms.CheckBox checkBox_showUser;
        private System.Windows.Forms.CheckBox checkBox_showTime;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox textBox_clientId;
        private System.Windows.Forms.TextBox textBox_overridesicon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_overridelicon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem utilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportIconsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_overridedetail;
        private System.Windows.Forms.Label warn;
        private System.Windows.Forms.CheckBox AFS;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

