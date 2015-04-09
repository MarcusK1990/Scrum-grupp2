using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vIT_System.GUI
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void skapaFörskottsansökanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPreShooting form = new frmPreShooting();
            form.Show();
        }

        private void mItemTravel_Click(object sender, EventArgs e)
        {
            frmCompensation form = new frmCompensation();
            form.Show();
        }

        private void mItemMyAppli_Click(object sender, EventArgs e)
        {
            frmMyApplications form = new frmMyApplications();
            form.Show();
        }
    }
}
