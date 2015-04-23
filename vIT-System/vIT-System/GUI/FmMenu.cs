using System;
using System.Windows.Forms;

namespace vIT_System.GUI
{
    public partial class FrmMenu : Form
    {
        private string MenyForNamn { get; set; }
        private string MenyEfterNamn { get; set; }
        private string MenyEmail { get; set; }
        private ApplicationMode.Mode MenyMode { get; set; }


        public FrmMenu(ApplicationMode.Mode mode)
        {
            InitializeComponent();
            if (mode == ApplicationMode.Mode.OFFLINE)
            {
                lblStatus.Text = @"Offline";
                MenyMode = ApplicationMode.Mode.OFFLINE;
            }
        }

        public FrmMenu(string namn, string efternamn, string email, ApplicationMode.Mode mode)
        {
            InitializeComponent();
            
            if (mode == ApplicationMode.Mode.ADMINISTRATOR)
            {
                lblStatus.Text = @"Admin";
                chefToolStripMenuItem.Visible = true;
            }
            if (mode == ApplicationMode.Mode.STANDARD)
            {
                lblStatus.Text = @"Konsult";
            }
            MenyForNamn = namn;
            MenyEfterNamn = efternamn;
            MenyEmail = email;
            MenyMode = mode;

        }

        private void skapaFörskottsansökanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmPreShooting();
            form.Show();
        }
      

        private void mItemTravel_Click(object sender, EventArgs e)
        {
            FrmCompensation form;
            if (MenyMode == ApplicationMode.Mode.STANDARD){
                form = new FrmCompensation(MenyEmail, MenyForNamn, MenyEfterNamn, MenyMode);
                form.Show();
            }
            if (MenyMode != ApplicationMode.Mode.OFFLINE){
                return;
            }
            form = new FrmCompensation(MenyMode);
            form.Show();
        }

        private void mItemMyAppli_Click(object sender, EventArgs e)
        {
            var form = new FrmMyApplications();
            form.Show();
        }

        private void hanteraKonsulterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Konsulthantering();
            form.Show();
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void reseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTravelorderr form;
            if (MenyMode == ApplicationMode.Mode.STANDARD)
            {
                form = new FrmTravelorderr(MenyEmail, MenyForNamn, MenyEfterNamn, MenyMode);
                form.Show();
            }
            if (MenyMode != ApplicationMode.Mode.OFFLINE)
            {
                return;
            }
            form = new FrmTravelorderr(MenyMode);
            form.Show();
        }
    }
}
