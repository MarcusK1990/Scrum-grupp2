using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vITSystem
{
    public partial class frmSystem : Form
    {
        Random rnd;

        public frmSystem()
        {
            InitializeComponent();
            timer1.Start();
            rnd = new Random();
        }

        private void btnGeMigCash_Click(object sender, EventArgs e){
            MessageBox.Show("Cluck cluck");
            System.Diagnostics.Process.Start("http://i.imgur.com/8N79SPD.png");
        }

        private void frmSystem_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "" + timer1.Interval;
            if (timer1.Interval > 50)
            {
                timer1.Stop();
                timer1.Start();
                tabPage3.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            }
        }

    }
}
