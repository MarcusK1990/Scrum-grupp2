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
    public partial class frmPreShooting : Form
    {
        public frmPreShooting()
        {
            InitializeComponent();
        }

        private void frmPreShooting_Load(object sender, EventArgs e)
        {
             //Ladda in chefer från databasen i comboboxen 
        }

        //Posta innehållet i formuläret till databasen
        private void btnSendPre_Click(object sender, EventArgs e)
        {
           var anst = TestaLiteSql.Q1();
           tbSum.Text = anst.Fnamn.ToString();
        }
    }
}
