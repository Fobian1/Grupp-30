﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Assignment1._1 {
    public partial class MainForm : Form {
        MP3_Player musicPlayer = new MP3_Player();

        DateTime newTime = DateTime.Now;
        Clock clock;

        public MainForm() {
            InitializeComponent();
            clock = new Clock(newTime.Hour, newTime.Minute, newTime.Second);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e) {
            label1.Text = openFileDialog1.FileName;

            musicPlayer.Open(openFileDialog1.FileName);
        }

        private void btn_Open_Click(object sender, EventArgs e) {
            openFileDialog1.ShowDialog();
            //Skapar open file dialog
        }

        private void btn_Play_Click(object sender, EventArgs e) {
            musicPlayer.Play();
        }

        private void btn_Stop_Click(object sender, EventArgs e) {
            musicPlayer.Stop();
        }

        StartClockThread startClock;
        private void btn_StartClock_Click(object sender, EventArgs e) {
            clock.IsRunning = true;
            startClock = new StartClockThread(clock, lblClock);

            Thread t1 = new Thread(startClock.StartClock);
            t1.Name = "World Clock";
            t1.Start();
        }

        private void btn_StopClock_Click(object sender, EventArgs e) {
            clock.IsRunning = false;
        }

        
    }
}
