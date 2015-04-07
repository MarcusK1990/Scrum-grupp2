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
        public frmSystem()
        {
            InitializeComponent();
        }

        private void btnGeMigCash_Click(object sender, EventArgs e){
            MessageBox.Show("Cluck cluck");
            System.Diagnostics.Process.Start("http://i.imgur.com/8N79SPD.png");
        }

    }
}
