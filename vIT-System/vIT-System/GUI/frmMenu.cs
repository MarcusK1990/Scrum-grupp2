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
        private string MenyForNamn { get; set; }
        private string MenyEfterNamn { get; set; }
        private string MenyEmail { get; set; }
        public frmMenu()
        {
            InitializeComponent();
        }

        public frmMenu(string Namn, string Efternamn, string Email)
        {
            InitializeComponent();
            MenyForNamn = Namn;
            MenyEfterNamn = Efternamn;
            MenyEmail = Email;
        }

        private void skapaFörskottsansökanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPreShooting form = new frmPreShooting();
            form.Show();
        }

        private void mItemTravel_Click(object sender, EventArgs e)
        {
            frmCompensation form = new frmCompensation(MenyEmail, MenyForNamn, MenyEfterNamn);
            form.Show();
        }

        private void mItemMyAppli_Click(object sender, EventArgs e)
        {
            frmMyApplications form = new frmMyApplications();
            form.Show();
        }
    }
}
