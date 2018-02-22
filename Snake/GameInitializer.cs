﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class GameInitializer : Form
    {
        Form1 form;
        Music music;

        public GameInitializer()
        {
            InitializeComponent();
            music = new Music();
            form = new Form1();
            form.FormClosed += Form_FormClosed;
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (music.IsPlaying)
            {
                music.Stop();
            }
        }

        private void onePlayer_Click(object sender, EventArgs e)
        {
            music.ShuffleMusic();
            music.Play();
            form.ShowDialog();
        }

        private void twoPlayers_Click(object sender, EventArgs e)
        {

        }

        private void threePlayers_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}