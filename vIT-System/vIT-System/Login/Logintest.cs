﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace vIT_System
{
    public partial class Logintest : Form
    {
        public Logintest(ApplicationMode.Mode mode)
        {
            InitializeComponent();
            if (mode == ApplicationMode.Mode.OFFLINE)
            {
                MessageBox.Show(@"Offline");
                textBox1.Enabled = false;
                textBox2.Enabled = false;
            }
            if (mode == ApplicationMode.Mode.ADMINISTRATOR)
            {
                textBox1.BackColor = Color.Aqua;
            }
        }

        private void Logintest_Load(object sender, EventArgs e)
        {

        }

        private void Logintest_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        

    }
}
