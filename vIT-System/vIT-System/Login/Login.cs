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
using vIT_System.GUI;

namespace vIT_System
{
    public partial class Login : Form
    {
        public string email { get; set; }
        public string namn { get; set; }
        public string efterNamn { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        private DataTable createTestDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.Clear();
            dataTable.Columns.Add("id");
            dataTable.Columns.Add("username");
            dataTable.Columns.Add("password");

            DataRow foo = dataTable.NewRow();
            foo["id"] = "0";
            foo["username"] = "admin";
            foo["password"] = "pass123";
            dataTable.Rows.Add(foo);

            foo = dataTable.NewRow();
            foo["id"] = "1";
            foo["username"] = "chefen22";
            foo["password"] = "qwerty";
            dataTable.Rows.Add(foo);

            return dataTable;
        }
        private DataTable createChefDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.Clear();
            dataTable.Columns.Add("id");

            DataRow foo = dataTable.NewRow();
            foo["id"] = "1";
            dataTable.Rows.Add(foo);

            return dataTable;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 1: validera inmatning
            // 2: hämta rader från tabellen Konsulter i databasen
            // 3: kontrollera om inmatat användarnamn existerar i raderna
            // -- 3.1: om nej, avbryt
            // 4: kontrollera om inmatat lösen stämmer med lösenordet i raden med användarnamnet
            // -- 4.1: om nej, avbryt
            // 5: hämta rader från tabellen Chefer i databasen
            // 6: kontrollera om det finns ett userID i Chef-tabellen med samma värde som i raden med anv.namnet
            // -- 6.1: om ja, aktivera admin-läge
            // -- 6.2: om nej, aktivera basic-läge
            // 7: godkänn inloggning och öppna huvudmeny. passa vidare lägesvärdet som parameter

            // Skapa en test-DataTable
            DataTable dt = createTestDataTable();

            // Hitta matchande användarnamn i DataTable
            string username = "";
            string password = "";
            string id = "";
            int mode = 0;

            bool foundMatch = false;

            bool foundError = false;
            string felMeddelande = "Följande fel har uppstått ";

            if (txtUsername.Text.Equals(""))
            {
                felMeddelande = felMeddelande + "\n Fältet för användarnamn är tomt!";
                foundError = true;
            }
            if (txtPassword.Text.Equals(""))
            {
                felMeddelande = felMeddelande + "\n Fältet för lösenord är tomt!";
                foundError = true;
            }
            if (foundError)
            {
                MessageBox.Show(felMeddelande);
                return;
            }

            foreach (DataRow dr in dt.Rows)
            {
                if (dr["username"].ToString().Equals(txtUsername.Text))
                {
                    id = dr["id"].ToString();
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

            //checka om det är en chef som loggar in
            DataTable chefDt = createChefDataTable();

            bool foundChef = false;

            foreach (DataRow dr in chefDt.Rows)
            {
                if (dr["id"].Equals(id))
                {
                    foundChef = true;
                    // sätt igång chef-läge
                    mode = 2;
                }
            }
            Logintest form = new Logintest(mode);
            form.Visible = true;
            Visible = false;

            namn = username.Substring(0, 2);
            efterNamn = username.Substring(2, 5);
            email = username + "@email.com";

            var menyn = new frmMenu(namn, efterNamn, email);
            menyn.Visible = true;
            this.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form logintest = new frmMenu();
            logintest.Visible = true;
            Visible = false;
        }


    }
}
