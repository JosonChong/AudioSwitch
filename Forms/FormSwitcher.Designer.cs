using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using AudioSwitch.Controls;
using AudioSwitch.Properties;

namespace AudioSwitch.Forms
{
    partial class FormSwitcher
    {
        private CustomListView listDevices;
        private NotifyIcon notifyIcon;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            Environment.Exit(0);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.audioDevicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volumeMixerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MuteButton = new System.Windows.Forms.PictureBox();
            this.pictureShadow = new System.Windows.Forms.PictureBox();
            this.pictureItemsBack = new System.Windows.Forms.PictureBox();
            this.VolBar = new AudioSwitch.Controls.VolumeBar();
            this.ledRight = new AudioSwitch.Controls.LedBar();
            this.ledLeft = new AudioSwitch.Controls.LedBar();
            this.listDevices = new AudioSwitch.Controls.CustomListView();
            this.trayMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MuteButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureShadow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureItemsBack)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "AudioSwitch";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDown);
            this.notifyIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseMove);
            this.notifyIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseUp);
            // 
            // trayMenu
            // 
            this.trayMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.audioDevicesToolStripMenuItem,
            this.volumeMixerToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.trayMenu.Name = "trayMenu";
            this.trayMenu.Size = new System.Drawing.Size(174, 106);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // audioDevicesToolStripMenuItem
            // 
            this.audioDevicesToolStripMenuItem.Name = "audioDevicesToolStripMenuItem";
            this.audioDevicesToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.audioDevicesToolStripMenuItem.Text = "Audio Devices";
            this.audioDevicesToolStripMenuItem.Click += new System.EventHandler(this.audioDevicesToolStripMenuItem_Click);
            // 
            // volumeMixerToolStripMenuItem
            // 
            this.volumeMixerToolStripMenuItem.Name = "volumeMixerToolStripMenuItem";
            this.volumeMixerToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.volumeMixerToolStripMenuItem.Text = "Volume Mixer";
            this.volumeMixerToolStripMenuItem.Click += new System.EventHandler(this.volumeMixerToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(170, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MuteButton
            // 
            this.MuteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MuteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MuteButton.Image = global::AudioSwitch.Properties.Resources.mute_highDPI;
            this.MuteButton.Location = new System.Drawing.Point(253, 193);
            this.MuteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MuteButton.Name = "MuteButton";
            this.MuteButton.Size = new System.Drawing.Size(27, 23);
            this.MuteButton.TabIndex = 11;
            this.MuteButton.TabStop = false;
            this.MuteButton.Click += new System.EventHandler(this.muteButton_Click);
            // 
            // pictureShadow
            // 
            this.pictureShadow.BackgroundImage = global::AudioSwitch.Properties.Resources.shadow;
            this.pictureShadow.Location = new System.Drawing.Point(0, 178);
            this.pictureShadow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureShadow.Name = "pictureShadow";
            this.pictureShadow.Size = new System.Drawing.Size(296, 6);
            this.pictureShadow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureShadow.TabIndex = 10;
            this.pictureShadow.TabStop = false;
            // 
            // pictureItemsBack
            // 
            this.pictureItemsBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureItemsBack.Location = new System.Drawing.Point(-1, 181);
            this.pictureItemsBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureItemsBack.Name = "pictureItemsBack";
            this.pictureItemsBack.Size = new System.Drawing.Size(381, 47);
            this.pictureItemsBack.TabIndex = 2;
            this.pictureItemsBack.TabStop = false;
            // 
            // VolBar
            // 
            this.VolBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.VolBar.Location = new System.Drawing.Point(16, 201);
            this.VolBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VolBar.Name = "VolBar";
            this.VolBar.Size = new System.Drawing.Size(235, 10);
            this.VolBar.TabIndex = 7;
            this.VolBar.TabStop = false;
            // 
            // ledRight
            // 
            this.ledRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ledRight.BackColor = System.Drawing.SystemColors.Control;
            this.ledRight.Location = new System.Drawing.Point(15, 211);
            this.ledRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ledRight.Name = "ledRight";
            this.ledRight.OldStyle = false;
            this.ledRight.Size = new System.Drawing.Size(235, 7);
            this.ledRight.TabIndex = 9;
            this.ledRight.TabStop = false;
            // 
            // ledLeft
            // 
            this.ledLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ledLeft.BackColor = System.Drawing.SystemColors.Control;
            this.ledLeft.Location = new System.Drawing.Point(15, 194);
            this.ledLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ledLeft.Name = "ledLeft";
            this.ledLeft.OldStyle = false;
            this.ledLeft.Size = new System.Drawing.Size(235, 7);
            this.ledLeft.TabIndex = 8;
            this.ledLeft.TabStop = false;
            // 
            // listDevices
            // 
            this.listDevices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listDevices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listDevices.FullRowSelect = true;
            this.listDevices.HideSelection = false;
            this.listDevices.Location = new System.Drawing.Point(1, -1);
            this.listDevices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listDevices.MultiSelect = false;
            this.listDevices.Name = "listDevices";
            this.listDevices.Scrollable = false;
            this.listDevices.Size = new System.Drawing.Size(292, 404);
            this.listDevices.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listDevices.TabIndex = 0;
            this.listDevices.TileSize = new System.Drawing.Size(222, 40);
            this.listDevices.UseCompatibleStateImageBehavior = false;
            this.listDevices.View = System.Windows.Forms.View.Tile;
            this.listDevices.Click += new System.EventHandler(this.listDevices_Click);
            // 
            // FormSwitcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 227);
            this.ControlBox = false;
            this.Controls.Add(this.VolBar);
            this.Controls.Add(this.MuteButton);
            this.Controls.Add(this.pictureShadow);
            this.Controls.Add(this.ledRight);
            this.Controls.Add(this.ledLeft);
            this.Controls.Add(this.pictureItemsBack);
            this.Controls.Add(this.listDevices);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSwitcher";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Deactivate += new System.EventHandler(this.FormSwitcher_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSwitcher_FormClosing);
            this.trayMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MuteButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureShadow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureItemsBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureItemsBack;
        private Timer timer1;
        private VolumeBar VolBar;
        private PictureBox MuteButton;
        private LedBar ledLeft;
        private LedBar ledRight;
        private ContextMenuStrip trayMenu;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem volumeMixerToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem audioDevicesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private PictureBox pictureShadow;
    }
}