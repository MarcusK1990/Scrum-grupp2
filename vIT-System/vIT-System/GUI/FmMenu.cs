using System;
using System.Windows.Forms;
using System.Drawing;
using vIT_System.Formulärhantering;


namespace vIT_System.GUI
{
    public partial class FrmMenu : Form
    {
        private string MenyForNamn { get; set; }
        private string MenyEfterNamn { get; set; }
        private string MenyEmail { get; set; }
        private ApplicationMode.Mode MenyMode { get; set; }
        private Form form;
        private Point place;


        public FrmMenu(ApplicationMode.Mode mode)
        {
            InitializeComponent();
            place = new Point(0, 0);
            if (mode == ApplicationMode.Mode.OFFLINE)
            {
                //lblStatus.Text = @"Offline";
                MenyMode = ApplicationMode.Mode.OFFLINE;
            }
        }

        public FrmMenu(string namn, string efternamn, string email, ApplicationMode.Mode mode)
        {
            InitializeComponent();
            place = new Point(0, 0);
            
            if (mode == ApplicationMode.Mode.ADMINISTRATOR)
            {
                //lblStatus.Text = @"Admin";
                chefToolStripMenuItem.Visible = true;
            }
            if (mode == ApplicationMode.Mode.STANDARD)
            {
                //lblStatus.Text = @"Konsult";
            }
            MenyForNamn = namn;
            MenyEfterNamn = efternamn;
            MenyEmail = email;
            MenyMode = mode;

        }

        private void skapaFörskottsansökanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteForm();
            form = new frmPreShooting();
            form.Location = place;
            form.MdiParent = this;
            form.Show();
        }
      

        private void mItemTravel_Click(object sender, EventArgs e)
        {
        
            FrmCompensation form;
            if (MenyMode == ApplicationMode.Mode.STANDARD){
                deleteForm();
                form = new FrmCompensation(MenyEmail, MenyForNamn, MenyEfterNamn, MenyMode);
                form.Location = place;
                form.MdiParent = this;
                form.Show();
            }
            else if (MenyMode == ApplicationMode.Mode.ADMINISTRATOR)
            {
                MessageBox.Show("Som chef kan du inte skapa en reseansökan.");
                return;
            }
            else
            {
                deleteForm();
                form = new FrmCompensation(MenyMode);
                form.Location = place;
                form.MdiParent = this;
                form.Show();
            }
        }

        private void mItemMyAppli_Click(object sender, EventArgs e)
        {
            deleteForm();
            form = new FrmMyApplications();
            form.Location = place;
            form.MdiParent = this;
            form.Show();
        }

        private void hanteraKonsulterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteForm();
          
            form = new Konsulthantering();
            form.Location = place;
            form.MdiParent = this;
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
                form.Location = place;
                form.MdiParent = this;
                form.Show();
            }
            else if (MenyMode == ApplicationMode.Mode.ADMINISTRATOR)
            {
                MessageBox.Show("Som chef kan du inte skapa en reseorder.");
                return;
            }
            else
            {
                form = new FrmTravelorderr(MenyMode);
                form.Location = place;
                form.MdiParent = this;
                form.Show();
            }
        }

        private void sammanställKvartalsrapporterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteForm();
            form = new frmFinancialStatement();
            form.Location = place;
            form.MdiParent = this;
            form.Show();
        }
        private void deleteForm()
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
                activeChild.Dispose();
            }
        }

        private void hanteraReseersättningsansökanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteForm();
            form = new Ansökningshantering();
            form.Location = place;
            form.MdiParent = this;
            form.Show();
        }

        private void hanteraFörskottsansökanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteForm();
            form = new Forskottshantering();
            form.Location = place;
            form.MdiParent = this;
            form.Show();
        }
    }
}
