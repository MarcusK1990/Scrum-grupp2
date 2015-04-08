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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string testString = tbUsername.Text;
            
            MessageBox.Show(testString.Length > 0 ? "Välkommen, " + testString + "!\n\n:)" : "Var det för jobbigt att fylla i användarnamnet? ;)");
            this.Hide();

            frmSystem form = new frmSystem();
            form.Show();
         
        }
    }
}
