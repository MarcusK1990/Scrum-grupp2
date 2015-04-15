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
        private ApplicationMode.Mode MenyMode { get; set; }


        public frmMenu(ApplicationMode.Mode mode)
        {
            InitializeComponent();
            if (mode == ApplicationMode.Mode.OFFLINE)
            {
                lblStatus.Text = "Offline";
                MenyMode = ApplicationMode.Mode.OFFLINE;
            }
        }

        public frmMenu(string Namn, string Efternamn, string Email, ApplicationMode.Mode mode)
        {
            InitializeComponent();
            
            if (mode == ApplicationMode.Mode.ADMINISTRATOR)
            {
                lblStatus.Text = "Admin";
            }
            if (mode == ApplicationMode.Mode.STANDARD)
            {
                lblStatus.Text = "Konsult";
            }
            MenyForNamn = Namn;
            MenyEfterNamn = Efternamn;
            MenyEmail = Email;
            MenyMode = mode;

        }

        private void skapaFörskottsansökanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPreShooting form = new frmPreShooting();
            form.Show();
        }

        private void mItemTravel_Click(object sender, EventArgs e)
        {
            if (MenyMode == ApplicationMode.Mode.STANDARD) { 
            frmCompensation form = new frmCompensation(MenyEmail, MenyForNamn, MenyEfterNamn, MenyMode);
            form.Show();
        
            }
            if (MenyMode == ApplicationMode.Mode.OFFLINE)
            {
                frmCompensation form = new frmCompensation(MenyMode);
                form.Show();               
            }
        }

        private void mItemMyAppli_Click(object sender, EventArgs e)
        {
            frmMyApplications form = new frmMyApplications();
            form.Show();
        }
    }
}
