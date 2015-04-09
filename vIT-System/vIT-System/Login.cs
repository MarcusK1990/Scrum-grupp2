using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace vIT_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private DataTable createTestDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.Clear();
            dataTable.Columns.Add("username");
            dataTable.Columns.Add("password");

            DataRow foo = dataTable.NewRow();
            foo["username"] = "admin";
            foo["password"] = "pass123";
            dataTable.Rows.Add(foo);

            foo = dataTable.NewRow();
            foo["username"] = "chefen22";
            foo["password"] = "qwerty";
            dataTable.Rows.Add(foo);

            return dataTable;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //string userName = txtUsername.Text;
            //string passWord = txtPassword.Text;

            // Skapa en test-DataTable
            DataTable dt = createTestDataTable();

            // Hitta matchande användarnamn i DataTable
            string username = "";
            string password = "";

            bool foundMatch = false;

            foreach (DataRow dr in dt.Rows)
            {
                if (dr["username"].ToString().Equals(txtUsername.Text))
                {
                    username = dr["username"].ToString();
                    password = dr["password"].ToString();
                    foundMatch = true;
                    break;
                }
            }
            if (!foundMatch)
            {
                MessageBox.Show("Fel användarnamn!");
                txtUsername.Clear();
                txtPassword.Clear();
                return;
            }
            if (!txtPassword.Text.Equals(password))
            {
                MessageBox.Show("Fel lösenord!");
                txtPassword.Clear();
                return;
            }
            Form1 form = new Form1();
            form.Visible = true;
            Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


    }
}
