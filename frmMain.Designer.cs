/*
 *    Warcraft 3 Loader Form - A C# forms application modification upon the original W3L by Acid and Keres
 *	Copyright (C) 2011  MusicDemon
 *
 *	This program is free software: you can redistribute it and/or modify
 *	it under the terms of the GNU General Public License as published by
 *	the Free Software Foundation, either version 3 of the License, or
 *	(at your option) any later version.
 *
 *	This program is distributed in the hope that it will be useful,
 *	but WITHOUT ANY WARRANTY; without even the implied warranty of
 *	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *	GNU General Public License for more details.
 *
 *	You should have received a copy of the GNU General Public License
 *	along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

﻿namespace Intcon.W3LF
 {
     /// <summary>
     /// The main form of W3LF
     /// </summary>
     partial class frmMain
     {
         /// <summary>
         /// Required designer variable.
         /// </summary>
         private System.ComponentModel.IContainer components = null;

         /// <summary>
         /// Clean up any resources being used.
         /// </summary>
         /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
         protected override void Dispose(bool disposing)
         {
             if (disposing && (components != null))
             {
                 components.Dispose();
             }
             base.Dispose(disposing);
         }

         #region Windows Form Designer generated code

         /// <summary>
         /// Required method for Designer support - do not modify
         /// the contents of this method with the code editor.
         /// </summary>
         private void InitializeComponent()
         {
             System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
             this.gbStartup = new System.Windows.Forms.GroupBox();
             this.cbClassic = new Intcon.W3LF.CheckBoxC();
             this.cbSWTNL = new Intcon.W3LF.CheckBoxC();
             this.cbOpenGL = new Intcon.W3LF.CheckBoxC();
             this.cbWindow = new Intcon.W3LF.CheckBoxC();
             this.lblCreatedByMusicDemon = new System.Windows.Forms.Label();
             this.pbIcon = new System.Windows.Forms.PictureBox();
             this.wbNews = new System.Windows.Forms.WebBrowser();
             this.lblStatus = new System.Windows.Forms.Label();
             this.tcMain = new System.Windows.Forms.TabControl();
             this.tpMainMenu = new System.Windows.Forms.TabPage();
             this.wbtnWarGP = new Intcon.W3LF.WarButton();
             this.wbtnWar3 = new Intcon.W3LF.WarButton();
             this.tpOptions = new System.Windows.Forms.TabPage();
             this.gbGProxy = new System.Windows.Forms.GroupBox();
             this.lblNoGP = new System.Windows.Forms.Label();
             this.cbConsole = new Intcon.W3LF.CheckBoxC();
             this.txtHostport = new System.Windows.Forms.TextBox();
             this.lblGPHostport = new System.Windows.Forms.Label();
             this.cbSounds = new Intcon.W3LF.CheckBoxC();
             this.pictureBox2 = new System.Windows.Forms.PictureBox();
             this.tpGPLog = new System.Windows.Forms.TabPage();
             this.txtGPLog = new System.Windows.Forms.TextBox();
             this.tpUpdate = new System.Windows.Forms.TabPage();
             this.pictureBox1 = new System.Windows.Forms.PictureBox();
             this.btnELUpdRef = new System.Windows.Forms.Button();
             this.gbGPUpdate = new System.Windows.Forms.GroupBox();
             this.btnELUpdDL = new System.Windows.Forms.Button();
             this.lblELUpd = new System.Windows.Forms.Label();
             this.gbWarUpd = new System.Windows.Forms.GroupBox();
             this.btnWarUpdDL = new System.Windows.Forms.Button();
             this.lblWarUpd = new System.Windows.Forms.Label();
             this.gbGPUpd = new System.Windows.Forms.GroupBox();
             this.btnGPUpdDL = new System.Windows.Forms.Button();
             this.lblGPUpd = new System.Windows.Forms.Label();
             this.tpAbout = new System.Windows.Forms.TabPage();
             this.gbLinks = new System.Windows.Forms.GroupBox();
             this.llblXPAM = new System.Windows.Forms.LinkLabel();
             this.llblProject = new System.Windows.Forms.LinkLabel();
             this.llblW3L = new System.Windows.Forms.LinkLabel();
             this.llblIntcon = new System.Windows.Forms.LinkLabel();
             this.llblPvPGN = new System.Windows.Forms.LinkLabel();
             this.txtLicence = new System.Windows.Forms.TextBox();
             this.lblAbout = new System.Windows.Forms.Label();
             this.lblSaveNote = new System.Windows.Forms.Label();
             this.gbStartup.SuspendLayout();
             ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
             this.tcMain.SuspendLayout();
             this.tpMainMenu.SuspendLayout();
             this.tpOptions.SuspendLayout();
             this.gbGProxy.SuspendLayout();
             ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
             this.tpGPLog.SuspendLayout();
             this.tpUpdate.SuspendLayout();
             ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
             this.gbGPUpdate.SuspendLayout();
             this.gbWarUpd.SuspendLayout();
             this.gbGPUpd.SuspendLayout();
             this.tpAbout.SuspendLayout();
             this.gbLinks.SuspendLayout();
             this.SuspendLayout();
             // 
             // gbStartup
             // 
             this.gbStartup.BackColor = System.Drawing.Color.Transparent;
             this.gbStartup.Controls.Add(this.cbClassic);
             this.gbStartup.Controls.Add(this.cbSWTNL);
             this.gbStartup.Controls.Add(this.cbOpenGL);
             this.gbStartup.Controls.Add(this.cbWindow);
             this.gbStartup.ForeColor = System.Drawing.Color.White;
             this.gbStartup.Location = new System.Drawing.Point(62, 161);
             this.gbStartup.Name = "gbStartup";
             this.gbStartup.Size = new System.Drawing.Size(257, 146);
             this.gbStartup.TabIndex = 3;
             this.gbStartup.TabStop = false;
             this.gbStartup.Text = "Startup options";
             // 
             // cbClassic
             // 
             this.cbClassic.AutoSize = true;
             this.cbClassic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
             this.cbClassic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
             this.cbClassic.Checked = false;
             this.cbClassic.Location = new System.Drawing.Point(6, 115);
             this.cbClassic.Name = "cbClassic";
             this.cbClassic.Size = new System.Drawing.Size(178, 27);
             this.cbClassic.TabIndex = 3;
             this.cbClassic.Text = "Classic mode (Reign of Chaos)";
             // 
             // cbSWTNL
             // 
             this.cbSWTNL.AutoSize = true;
             this.cbSWTNL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
             this.cbSWTNL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
             this.cbSWTNL.Checked = false;
             this.cbSWTNL.Location = new System.Drawing.Point(6, 82);
             this.cbSWTNL.Name = "cbSWTNL";
             this.cbSWTNL.Size = new System.Drawing.Size(246, 27);
             this.cbSWTNL.TabIndex = 2;
             this.cbSWTNL.Text = "Software Transform and Lighting Video mode";
             // 
             // cbOpenGL
             // 
             this.cbOpenGL.AutoSize = true;
             this.cbOpenGL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
             this.cbOpenGL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
             this.cbOpenGL.Checked = false;
             this.cbOpenGL.Location = new System.Drawing.Point(6, 49);
             this.cbOpenGL.Name = "cbOpenGL";
             this.cbOpenGL.Size = new System.Drawing.Size(103, 27);
             this.cbOpenGL.TabIndex = 1;
             this.cbOpenGL.Text = "OpenGL mode";
             // 
             // cbWindow
             // 
             this.cbWindow.AutoSize = true;
             this.cbWindow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
             this.cbWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
             this.cbWindow.Checked = false;
             this.cbWindow.Location = new System.Drawing.Point(6, 16);
             this.cbWindow.Name = "cbWindow";
             this.cbWindow.Size = new System.Drawing.Size(114, 27);
             this.cbWindow.TabIndex = 0;
             this.cbWindow.Text = "Windowed mode";
             // 
             // lblCreatedByMusicDemon
             // 
             this.lblCreatedByMusicDemon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
             this.lblCreatedByMusicDemon.AutoSize = true;
             this.lblCreatedByMusicDemon.BackColor = System.Drawing.Color.Transparent;
             this.lblCreatedByMusicDemon.Cursor = System.Windows.Forms.Cursors.Hand;
             this.lblCreatedByMusicDemon.ForeColor = System.Drawing.Color.DimGray;
             this.lblCreatedByMusicDemon.Location = new System.Drawing.Point(608, 524);
             this.lblCreatedByMusicDemon.Name = "lblCreatedByMusicDemon";
             this.lblCreatedByMusicDemon.Size = new System.Drawing.Size(116, 13);
             this.lblCreatedByMusicDemon.TabIndex = 4;
             this.lblCreatedByMusicDemon.Text = "Made by: MusicDemon";
             this.lblCreatedByMusicDemon.Click += new System.EventHandler(this.lblCreatedByMusicDemon_Click);
             // 
             // pbIcon
             // 
             this.pbIcon.BackColor = System.Drawing.Color.Transparent;
             this.pbIcon.Cursor = System.Windows.Forms.Cursors.Hand;
             this.pbIcon.Image = global::Intcon.W3LF.Properties.Resources.ico1;
             this.pbIcon.Location = new System.Drawing.Point(340, 6);
             this.pbIcon.Name = "pbIcon";
             this.pbIcon.Size = new System.Drawing.Size(55, 55);
             this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
             this.pbIcon.TabIndex = 8;
             this.pbIcon.TabStop = false;
             this.pbIcon.Click += new System.EventHandler(this.XPAM_Click);
             // 
             // wbNews
             // 
             this.wbNews.AllowWebBrowserDrop = false;
             this.wbNews.IsWebBrowserContextMenuEnabled = false;
             this.wbNews.Location = new System.Drawing.Point(11, 67);
             this.wbNews.MinimumSize = new System.Drawing.Size(20, 20);
             this.wbNews.Name = "wbNews";
             this.wbNews.Size = new System.Drawing.Size(713, 308);
             this.wbNews.TabIndex = 10;
             this.wbNews.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.wbNews_Navigating);
             // 
             // lblStatus
             // 
             this.lblStatus.AutoSize = true;
             this.lblStatus.ForeColor = System.Drawing.Color.DimGray;
             this.lblStatus.Location = new System.Drawing.Point(8, 524);
             this.lblStatus.Name = "lblStatus";
             this.lblStatus.Size = new System.Drawing.Size(144, 13);
             this.lblStatus.TabIndex = 1;
             this.lblStatus.Text = "Server is currently: Loading...";
             // 
             // tcMain
             // 
             this.tcMain.Controls.Add(this.tpMainMenu);
             this.tcMain.Controls.Add(this.tpOptions);
             this.tcMain.Controls.Add(this.tpGPLog);
             this.tcMain.Controls.Add(this.tpUpdate);
             this.tcMain.Controls.Add(this.tpAbout);
             this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
             this.tcMain.Location = new System.Drawing.Point(0, 0);
             this.tcMain.Name = "tcMain";
             this.tcMain.SelectedIndex = 0;
             this.tcMain.Size = new System.Drawing.Size(740, 568);
             this.tcMain.TabIndex = 13;
             this.tcMain.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
             // 
             // tpMainMenu
             // 
             this.tpMainMenu.BackColor = System.Drawing.Color.Transparent;
             this.tpMainMenu.BackgroundImage = global::Intcon.W3LF.Properties.Resources.bg;
             this.tpMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
             this.tpMainMenu.Controls.Add(this.wbtnWarGP);
             this.tpMainMenu.Controls.Add(this.wbtnWar3);
             this.tpMainMenu.Controls.Add(this.wbNews);
             this.tpMainMenu.Controls.Add(this.lblStatus);
             this.tpMainMenu.Controls.Add(this.pbIcon);
             this.tpMainMenu.Controls.Add(this.lblCreatedByMusicDemon);
             this.tpMainMenu.Location = new System.Drawing.Point(4, 22);
             this.tpMainMenu.Name = "tpMainMenu";
             this.tpMainMenu.Padding = new System.Windows.Forms.Padding(3);
             this.tpMainMenu.Size = new System.Drawing.Size(732, 542);
             this.tpMainMenu.TabIndex = 1;
             this.tpMainMenu.Text = "Main Manu";
             // 
             // wbtnWarGP
             // 
             this.wbtnWarGP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wbtnWarGP.BackgroundImage")));
             this.wbtnWarGP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
             this.wbtnWarGP.Location = new System.Drawing.Point(391, 409);
             this.wbtnWarGP.Name = "wbtnWarGP";
             this.wbtnWarGP.Size = new System.Drawing.Size(302, 56);
             this.wbtnWarGP.TabIndex = 14;
             this.wbtnWarGP.Click += new System.EventHandler(this.wbtnWarGP_Click);
             // 
             // wbtnWar3
             // 
             this.wbtnWar3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wbtnWar3.BackgroundImage")));
             this.wbtnWar3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
             this.wbtnWar3.Location = new System.Drawing.Point(41, 409);
             this.wbtnWar3.Name = "wbtnWar3";
             this.wbtnWar3.Size = new System.Drawing.Size(302, 56);
             this.wbtnWar3.TabIndex = 13;
             this.wbtnWar3.Click += new System.EventHandler(this.wbtnWar3_Click);
             // 
             // tpOptions
             // 
             this.tpOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
             this.tpOptions.Controls.Add(this.lblSaveNote);
             this.tpOptions.Controls.Add(this.gbGProxy);
             this.tpOptions.Controls.Add(this.pictureBox2);
             this.tpOptions.Controls.Add(this.gbStartup);
             this.tpOptions.Location = new System.Drawing.Point(4, 22);
             this.tpOptions.Name = "tpOptions";
             this.tpOptions.Padding = new System.Windows.Forms.Padding(3);
             this.tpOptions.Size = new System.Drawing.Size(732, 542);
             this.tpOptions.TabIndex = 0;
             this.tpOptions.Text = "Startup/GProxy options";
             // 
             // gbGProxy
             // 
             this.gbGProxy.BackColor = System.Drawing.Color.Transparent;
             this.gbGProxy.Controls.Add(this.lblNoGP);
             this.gbGProxy.Controls.Add(this.cbConsole);
             this.gbGProxy.Controls.Add(this.txtHostport);
             this.gbGProxy.Controls.Add(this.lblGPHostport);
             this.gbGProxy.Controls.Add(this.cbSounds);
             this.gbGProxy.ForeColor = System.Drawing.Color.White;
             this.gbGProxy.Location = new System.Drawing.Point(383, 161);
             this.gbGProxy.Name = "gbGProxy";
             this.gbGProxy.Size = new System.Drawing.Size(237, 146);
             this.gbGProxy.TabIndex = 4;
             this.gbGProxy.TabStop = false;
             this.gbGProxy.Text = "GProxy options";
             // 
             // lblNoGP
             // 
             this.lblNoGP.AutoSize = true;
             this.lblNoGP.ForeColor = System.Drawing.Color.White;
             this.lblNoGP.Location = new System.Drawing.Point(6, 115);
             this.lblNoGP.Name = "lblNoGP";
             this.lblNoGP.Size = new System.Drawing.Size(160, 26);
             this.lblNoGP.TabIndex = 4;
             this.lblNoGP.Text = "Options disabled because no\r\nGProxy configuration was found.";
             this.lblNoGP.Visible = false;
             // 
             // cbConsole
             // 
             this.cbConsole.AutoSize = true;
             this.cbConsole.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
             this.cbConsole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
             this.cbConsole.Checked = false;
             this.cbConsole.Location = new System.Drawing.Point(6, 82);
             this.cbConsole.Name = "cbConsole";
             this.cbConsole.Size = new System.Drawing.Size(101, 27);
             this.cbConsole.TabIndex = 3;
             this.cbConsole.Text = "Show console";
             // 
             // txtHostport
             // 
             this.txtHostport.Location = new System.Drawing.Point(59, 19);
             this.txtHostport.MaxLength = 5;
             this.txtHostport.Name = "txtHostport";
             this.txtHostport.Size = new System.Drawing.Size(86, 20);
             this.txtHostport.TabIndex = 2;
             // 
             // lblGPHostport
             // 
             this.lblGPHostport.AutoSize = true;
             this.lblGPHostport.Location = new System.Drawing.Point(6, 22);
             this.lblGPHostport.Name = "lblGPHostport";
             this.lblGPHostport.Size = new System.Drawing.Size(47, 13);
             this.lblGPHostport.TabIndex = 1;
             this.lblGPHostport.Text = "Hostport";
             // 
             // cbSounds
             // 
             this.cbSounds.AutoSize = true;
             this.cbSounds.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
             this.cbSounds.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
             this.cbSounds.Checked = false;
             this.cbSounds.Location = new System.Drawing.Point(6, 49);
             this.cbSounds.Name = "cbSounds";
             this.cbSounds.Size = new System.Drawing.Size(104, 27);
             this.cbSounds.TabIndex = 0;
             this.cbSounds.Text = "Enable sounds";
             // 
             // pictureBox2
             // 
             this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
             this.pictureBox2.Image = global::Intcon.W3LF.Properties.Resources.Logo;
             this.pictureBox2.Location = new System.Drawing.Point(193, 6);
             this.pictureBox2.Name = "pictureBox2";
             this.pictureBox2.Size = new System.Drawing.Size(335, 91);
             this.pictureBox2.TabIndex = 12;
             this.pictureBox2.TabStop = false;
             // 
             // tpGPLog
             // 
             this.tpGPLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
             this.tpGPLog.Controls.Add(this.txtGPLog);
             this.tpGPLog.Location = new System.Drawing.Point(4, 22);
             this.tpGPLog.Name = "tpGPLog";
             this.tpGPLog.Padding = new System.Windows.Forms.Padding(3);
             this.tpGPLog.Size = new System.Drawing.Size(732, 542);
             this.tpGPLog.TabIndex = 2;
             this.tpGPLog.Text = "GProxy log";
             this.tpGPLog.UseVisualStyleBackColor = true;
             // 
             // txtGPLog
             // 
             this.txtGPLog.Dock = System.Windows.Forms.DockStyle.Fill;
             this.txtGPLog.Location = new System.Drawing.Point(3, 3);
             this.txtGPLog.Multiline = true;
             this.txtGPLog.Name = "txtGPLog";
             this.txtGPLog.ReadOnly = true;
             this.txtGPLog.Size = new System.Drawing.Size(726, 536);
             this.txtGPLog.TabIndex = 0;
             // 
             // tpUpdate
             // 
             this.tpUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
             this.tpUpdate.Controls.Add(this.pictureBox1);
             this.tpUpdate.Controls.Add(this.btnELUpdRef);
             this.tpUpdate.Controls.Add(this.gbGPUpdate);
             this.tpUpdate.Controls.Add(this.gbWarUpd);
             this.tpUpdate.Controls.Add(this.gbGPUpd);
             this.tpUpdate.Location = new System.Drawing.Point(4, 22);
             this.tpUpdate.Name = "tpUpdate";
             this.tpUpdate.Size = new System.Drawing.Size(732, 542);
             this.tpUpdate.TabIndex = 3;
             this.tpUpdate.Text = "Update";
             // 
             // pictureBox1
             // 
             this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
             this.pictureBox1.Image = global::Intcon.W3LF.Properties.Resources.Logo;
             this.pictureBox1.Location = new System.Drawing.Point(192, 42);
             this.pictureBox1.Name = "pictureBox1";
             this.pictureBox1.Size = new System.Drawing.Size(335, 91);
             this.pictureBox1.TabIndex = 5;
             this.pictureBox1.TabStop = false;
             // 
             // btnELUpdRef
             // 
             this.btnELUpdRef.Enabled = false;
             this.btnELUpdRef.ForeColor = System.Drawing.Color.Black;
             this.btnELUpdRef.Location = new System.Drawing.Point(327, 357);
             this.btnELUpdRef.Name = "btnELUpdRef";
             this.btnELUpdRef.Size = new System.Drawing.Size(75, 23);
             this.btnELUpdRef.TabIndex = 1;
             this.btnELUpdRef.Text = "Refresh";
             this.btnELUpdRef.UseVisualStyleBackColor = true;
             this.btnELUpdRef.Click += new System.EventHandler(this.btnELUpdRef_Click);
             // 
             // gbGPUpdate
             // 
             this.gbGPUpdate.BackColor = System.Drawing.Color.Transparent;
             this.gbGPUpdate.Controls.Add(this.btnELUpdDL);
             this.gbGPUpdate.Controls.Add(this.lblELUpd);
             this.gbGPUpdate.ForeColor = System.Drawing.Color.White;
             this.gbGPUpdate.Location = new System.Drawing.Point(443, 322);
             this.gbGPUpdate.Name = "gbGPUpdate";
             this.gbGPUpdate.Size = new System.Drawing.Size(159, 68);
             this.gbGPUpdate.TabIndex = 4;
             this.gbGPUpdate.TabStop = false;
             this.gbGPUpdate.Text = "Euroloader update";
             // 
             // btnELUpdDL
             // 
             this.btnELUpdDL.Enabled = false;
             this.btnELUpdDL.ForeColor = System.Drawing.Color.Black;
             this.btnELUpdDL.Location = new System.Drawing.Point(42, 35);
             this.btnELUpdDL.Name = "btnELUpdDL";
             this.btnELUpdDL.Size = new System.Drawing.Size(75, 23);
             this.btnELUpdDL.TabIndex = 2;
             this.btnELUpdDL.Text = "Download";
             this.btnELUpdDL.UseVisualStyleBackColor = true;
             this.btnELUpdDL.Click += new System.EventHandler(this.btnELUpdDL_Click);
             // 
             // lblELUpd
             // 
             this.lblELUpd.AutoSize = true;
             this.lblELUpd.Location = new System.Drawing.Point(6, 16);
             this.lblELUpd.Name = "lblELUpd";
             this.lblELUpd.Size = new System.Drawing.Size(90, 13);
             this.lblELUpd.TabIndex = 0;
             this.lblELUpd.Text = "Status: Loading...";
             // 
             // gbWarUpd
             // 
             this.gbWarUpd.BackColor = System.Drawing.Color.Transparent;
             this.gbWarUpd.Controls.Add(this.btnWarUpdDL);
             this.gbWarUpd.Controls.Add(this.lblWarUpd);
             this.gbWarUpd.ForeColor = System.Drawing.Color.White;
             this.gbWarUpd.Location = new System.Drawing.Point(127, 322);
             this.gbWarUpd.Name = "gbWarUpd";
             this.gbWarUpd.Size = new System.Drawing.Size(159, 68);
             this.gbWarUpd.TabIndex = 3;
             this.gbWarUpd.TabStop = false;
             this.gbWarUpd.Text = "Warcraft III update";
             // 
             // btnWarUpdDL
             // 
             this.btnWarUpdDL.Enabled = false;
             this.btnWarUpdDL.ForeColor = System.Drawing.Color.Black;
             this.btnWarUpdDL.Location = new System.Drawing.Point(42, 35);
             this.btnWarUpdDL.Name = "btnWarUpdDL";
             this.btnWarUpdDL.Size = new System.Drawing.Size(75, 23);
             this.btnWarUpdDL.TabIndex = 2;
             this.btnWarUpdDL.Text = "Download";
             this.btnWarUpdDL.UseVisualStyleBackColor = true;
             this.btnWarUpdDL.Click += new System.EventHandler(this.btnWarUpdDL_Click);
             // 
             // lblWarUpd
             // 
             this.lblWarUpd.AutoSize = true;
             this.lblWarUpd.Location = new System.Drawing.Point(6, 16);
             this.lblWarUpd.Name = "lblWarUpd";
             this.lblWarUpd.Size = new System.Drawing.Size(90, 13);
             this.lblWarUpd.TabIndex = 0;
             this.lblWarUpd.Text = "Status: Loading...";
             // 
             // gbGPUpd
             // 
             this.gbGPUpd.BackColor = System.Drawing.Color.Transparent;
             this.gbGPUpd.Controls.Add(this.btnGPUpdDL);
             this.gbGPUpd.Controls.Add(this.lblGPUpd);
             this.gbGPUpd.ForeColor = System.Drawing.Color.White;
             this.gbGPUpd.Location = new System.Drawing.Point(285, 223);
             this.gbGPUpd.Name = "gbGPUpd";
             this.gbGPUpd.Size = new System.Drawing.Size(159, 65);
             this.gbGPUpd.TabIndex = 0;
             this.gbGPUpd.TabStop = false;
             this.gbGPUpd.Text = "GProxy update";
             // 
             // btnGPUpdDL
             // 
             this.btnGPUpdDL.Enabled = false;
             this.btnGPUpdDL.ForeColor = System.Drawing.Color.Black;
             this.btnGPUpdDL.Location = new System.Drawing.Point(42, 32);
             this.btnGPUpdDL.Name = "btnGPUpdDL";
             this.btnGPUpdDL.Size = new System.Drawing.Size(75, 23);
             this.btnGPUpdDL.TabIndex = 2;
             this.btnGPUpdDL.Text = "Download";
             this.btnGPUpdDL.UseVisualStyleBackColor = true;
             this.btnGPUpdDL.Click += new System.EventHandler(this.btnGPUpdDL_Click);
             // 
             // lblGPUpd
             // 
             this.lblGPUpd.AutoSize = true;
             this.lblGPUpd.Location = new System.Drawing.Point(6, 16);
             this.lblGPUpd.Name = "lblGPUpd";
             this.lblGPUpd.Size = new System.Drawing.Size(90, 13);
             this.lblGPUpd.TabIndex = 0;
             this.lblGPUpd.Text = "Status: Loading...";
             // 
             // tpAbout
             // 
             this.tpAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
             this.tpAbout.Controls.Add(this.gbLinks);
             this.tpAbout.Controls.Add(this.txtLicence);
             this.tpAbout.Controls.Add(this.lblAbout);
             this.tpAbout.Location = new System.Drawing.Point(4, 22);
             this.tpAbout.Name = "tpAbout";
             this.tpAbout.Size = new System.Drawing.Size(732, 542);
             this.tpAbout.TabIndex = 4;
             this.tpAbout.Text = "About";
             // 
             // gbLinks
             // 
             this.gbLinks.BackColor = System.Drawing.Color.Transparent;
             this.gbLinks.Controls.Add(this.llblXPAM);
             this.gbLinks.Controls.Add(this.llblProject);
             this.gbLinks.Controls.Add(this.llblW3L);
             this.gbLinks.Controls.Add(this.llblIntcon);
             this.gbLinks.Controls.Add(this.llblPvPGN);
             this.gbLinks.ForeColor = System.Drawing.Color.White;
             this.gbLinks.Location = new System.Drawing.Point(500, 314);
             this.gbLinks.Name = "gbLinks";
             this.gbLinks.Size = new System.Drawing.Size(144, 93);
             this.gbLinks.TabIndex = 8;
             this.gbLinks.TabStop = false;
             this.gbLinks.Text = "Links";
             // 
             // llblXPAM
             // 
             this.llblXPAM.AutoSize = true;
             this.llblXPAM.BackColor = System.Drawing.Color.Transparent;
             this.llblXPAM.LinkColor = System.Drawing.Color.LightGray;
             this.llblXPAM.Location = new System.Drawing.Point(6, 16);
             this.llblXPAM.Name = "llblXPAM";
             this.llblXPAM.Size = new System.Drawing.Size(95, 13);
             this.llblXPAM.TabIndex = 1;
             this.llblXPAM.TabStop = true;
             this.llblXPAM.Text = "Visit Eurobattle.net";
             this.llblXPAM.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.XPAM_Click);
             // 
             // llblProject
             // 
             this.llblProject.AutoSize = true;
             this.llblProject.BackColor = System.Drawing.Color.Transparent;
             this.llblProject.LinkColor = System.Drawing.Color.LightGray;
             this.llblProject.Location = new System.Drawing.Point(6, 29);
             this.llblProject.Name = "llblProject";
             this.llblProject.Size = new System.Drawing.Size(133, 13);
             this.llblProject.TabIndex = 7;
             this.llblProject.TabStop = true;
             this.llblProject.Text = "Visit the Euroloader project";
             this.llblProject.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblProject_LinkClicked);
             // 
             // llblW3L
             // 
             this.llblW3L.AutoSize = true;
             this.llblW3L.BackColor = System.Drawing.Color.Transparent;
             this.llblW3L.LinkColor = System.Drawing.Color.LightGray;
             this.llblW3L.Location = new System.Drawing.Point(6, 68);
             this.llblW3L.Name = "llblW3L";
             this.llblW3L.Size = new System.Drawing.Size(52, 13);
             this.llblW3L.TabIndex = 2;
             this.llblW3L.TabStop = true;
             this.llblW3L.Text = "Visit W3L";
             this.llblW3L.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblW3L_LinkClicked);
             // 
             // llblIntcon
             // 
             this.llblIntcon.AutoSize = true;
             this.llblIntcon.BackColor = System.Drawing.Color.Transparent;
             this.llblIntcon.LinkColor = System.Drawing.Color.LightGray;
             this.llblIntcon.Location = new System.Drawing.Point(6, 42);
             this.llblIntcon.Name = "llblIntcon";
             this.llblIntcon.Size = new System.Drawing.Size(59, 13);
             this.llblIntcon.TabIndex = 6;
             this.llblIntcon.TabStop = true;
             this.llblIntcon.Text = "Visit Intcon";
             this.llblIntcon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblIntcon_LinkClicked);
             // 
             // llblPvPGN
             // 
             this.llblPvPGN.AutoSize = true;
             this.llblPvPGN.BackColor = System.Drawing.Color.Transparent;
             this.llblPvPGN.LinkColor = System.Drawing.Color.LightGray;
             this.llblPvPGN.Location = new System.Drawing.Point(6, 55);
             this.llblPvPGN.Name = "llblPvPGN";
             this.llblPvPGN.Size = new System.Drawing.Size(65, 13);
             this.llblPvPGN.TabIndex = 3;
             this.llblPvPGN.TabStop = true;
             this.llblPvPGN.Text = "Visit PvPGN";
             this.llblPvPGN.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblPvPGN_LinkClicked);
             // 
             // txtLicence
             // 
             this.txtLicence.Location = new System.Drawing.Point(8, 55);
             this.txtLicence.Multiline = true;
             this.txtLicence.Name = "txtLicence";
             this.txtLicence.ReadOnly = true;
             this.txtLicence.ScrollBars = System.Windows.Forms.ScrollBars.Both;
             this.txtLicence.Size = new System.Drawing.Size(430, 352);
             this.txtLicence.TabIndex = 5;
             this.txtLicence.Text = resources.GetString("txtLicence.Text");
             // 
             // lblAbout
             // 
             this.lblAbout.AutoSize = true;
             this.lblAbout.BackColor = System.Drawing.Color.Transparent;
             this.lblAbout.ForeColor = System.Drawing.Color.White;
             this.lblAbout.Location = new System.Drawing.Point(473, 55);
             this.lblAbout.Name = "lblAbout";
             this.lblAbout.Size = new System.Drawing.Size(223, 91);
             this.lblAbout.TabIndex = 0;
             this.lblAbout.Text = resources.GetString("lblAbout.Text");
             // 
             // lblSaveNote
             // 
             this.lblSaveNote.AutoSize = true;
             this.lblSaveNote.ForeColor = System.Drawing.Color.White;
             this.lblSaveNote.Location = new System.Drawing.Point(199, 310);
             this.lblSaveNote.Name = "lblSaveNote";
             this.lblSaveNote.Size = new System.Drawing.Size(320, 13);
             this.lblSaveNote.TabIndex = 13;
             this.lblSaveNote.Text = "Settings are saved automatically after you switched to another tab.";
             // 
             // frmMain
             // 
             this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
             this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
             this.BackColor = System.Drawing.Color.Black;
             this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
             this.ClientSize = new System.Drawing.Size(740, 568);
             this.Controls.Add(this.tcMain);
             this.DoubleBuffered = true;
             this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
             this.HelpButton = true;
             this.Icon = global::Intcon.W3LF.Properties.Resources.ico;
             this.MaximizeBox = false;
             this.Name = "frmMain";
             this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
             this.Text = "EuroLoader - For Eurobattle.net - By Intcon (MusicDemon)";
             this.Load += new System.EventHandler(this.frmMain_Load);
             this.gbStartup.ResumeLayout(false);
             this.gbStartup.PerformLayout();
             ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
             this.tcMain.ResumeLayout(false);
             this.tpMainMenu.ResumeLayout(false);
             this.tpMainMenu.PerformLayout();
             this.tpOptions.ResumeLayout(false);
             this.tpOptions.PerformLayout();
             this.gbGProxy.ResumeLayout(false);
             this.gbGProxy.PerformLayout();
             ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
             this.tpGPLog.ResumeLayout(false);
             this.tpGPLog.PerformLayout();
             this.tpUpdate.ResumeLayout(false);
             ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
             this.gbGPUpdate.ResumeLayout(false);
             this.gbGPUpdate.PerformLayout();
             this.gbWarUpd.ResumeLayout(false);
             this.gbWarUpd.PerformLayout();
             this.gbGPUpd.ResumeLayout(false);
             this.gbGPUpd.PerformLayout();
             this.tpAbout.ResumeLayout(false);
             this.tpAbout.PerformLayout();
             this.gbLinks.ResumeLayout(false);
             this.gbLinks.PerformLayout();
             this.ResumeLayout(false);

         }

         #endregion

         private System.Windows.Forms.GroupBox gbStartup;
         private CheckBoxC cbWindow;
         private CheckBoxC cbSWTNL;
         private CheckBoxC cbOpenGL;
         private CheckBoxC cbClassic;
         private System.Windows.Forms.Label lblCreatedByMusicDemon;
         private System.Windows.Forms.PictureBox pbIcon;
         private System.Windows.Forms.WebBrowser wbNews;
         private System.Windows.Forms.Label lblStatus;
         private System.Windows.Forms.TabControl tcMain;
         private System.Windows.Forms.TabPage tpMainMenu;
         private System.Windows.Forms.TabPage tpOptions;
         private System.Windows.Forms.TabPage tpGPLog;
         private System.Windows.Forms.PictureBox pictureBox2;
         private System.Windows.Forms.GroupBox gbGProxy;
         private CheckBoxC cbConsole;
         private System.Windows.Forms.TextBox txtHostport;
         private System.Windows.Forms.Label lblGPHostport;
         private CheckBoxC cbSounds;
         private System.Windows.Forms.TextBox txtGPLog;
         private System.Windows.Forms.TabPage tpUpdate;
         private System.Windows.Forms.TabPage tpAbout;
         private System.Windows.Forms.GroupBox gbGPUpd;
         private System.Windows.Forms.Label lblGPUpd;
         private System.Windows.Forms.Button btnGPUpdDL;
         private System.Windows.Forms.GroupBox gbWarUpd;
         private System.Windows.Forms.Button btnWarUpdDL;
         private System.Windows.Forms.Label lblWarUpd;
         private System.Windows.Forms.PictureBox pictureBox1;
         private System.Windows.Forms.GroupBox gbGPUpdate;
         private System.Windows.Forms.Button btnELUpdDL;
         private System.Windows.Forms.Button btnELUpdRef;
         private System.Windows.Forms.Label lblELUpd;
         private System.Windows.Forms.LinkLabel llblProject;
         private System.Windows.Forms.LinkLabel llblIntcon;
         private System.Windows.Forms.TextBox txtLicence;
         private System.Windows.Forms.LinkLabel llblPvPGN;
         private System.Windows.Forms.LinkLabel llblW3L;
         private System.Windows.Forms.LinkLabel llblXPAM;
         private System.Windows.Forms.Label lblAbout;
         private System.Windows.Forms.GroupBox gbLinks;
         private System.Windows.Forms.Label lblNoGP;
         private WarButton wbtnWar3;
         private WarButton wbtnWarGP;
         private System.Windows.Forms.Label lblSaveNote;
     }
 }