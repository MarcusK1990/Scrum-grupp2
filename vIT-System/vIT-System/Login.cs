using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vIT_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string passWord = txtPassword.Text;
            string sql = "Select password from anstalld where username = '" + userName + "'";
            //Plats för databaskoppling

            if (!userName.Equals("username"))
            {
                MessageBox.Show("Fel användarnamn!");
                txtUsername.Clear();
                txtPassword.Clear();
                return;
            }
            if (!passWord.Equals("password"))
            {
                MessageBox.Show("Fel lösenord!");
                txtPassword.Clear();
                return;
            }
            if (userName.Equals("username") && passWord.Equals("password"))
            {
                Form1 form = new Form1();
                form.Visible = true;
                Visible = false;
            }

        }


    }
}
