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
using vIT_System.SQL;

namespace vIT_System
{
    public partial class Login : Form
    {
        public string email { get; set; }
        public string namn { get; set; }
        public string efterNamn { get; set; }
        ApplicationMode.Mode mode { get; set; }

        private SqlHelper sqlHelper;

        public Login()
        {
            InitializeComponent();
            sqlHelper = new SqlHelper("Database\\vITs2.mdf");
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
            foo["username"] = "admin@example.com";
            foo["password"] = "pass123";
            dataTable.Rows.Add(foo);

            foo = dataTable.NewRow();
            foo["id"] = "1";
            foo["username"] = "adam@edumail.org";
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
            DataTable dt = sqlHelper.Fetch("SELECT * FROM ANSTALLDA");

            // Hitta matchande användarnamn i DataTable
            string username = "";
            string password = "";
            string id = "";
            bool isBoss = false;
            

            bool foundMatch = false;

            bool foundError = false;
            string felMeddelande = "Följande fel har uppstått:\n";

            if (Validation.IsEmpty(txtUsername.Text))
            {
                felMeddelande = felMeddelande + "\n• Fältet för användarnamn måste vara ifyllt";
                foundError = true;
            }
            if (Validation.IsLongerThan(txtUsername.Text, 255))
            {
                felMeddelande = felMeddelande + "\n• Användarnamn måste vara kortare än 256 tecken";
                foundError = true;
            }
            if (!Validation.IsEmailAddress(txtUsername.Text))
            {
                felMeddelande = felMeddelande + "\n• Användarnamn måste vara en mailadress";
                foundError = true;
            }
            if (Validation.IsEmpty(txtPassword.Text))
            {
                felMeddelande = felMeddelande + "\n• Fältet för lösenord måste vara ifyllt";
                foundError = true;
            }
            if (Validation.IsLongerThan(txtPassword.Text, 255))
            {
                felMeddelande = felMeddelande + "\n• Lösenord måste vara kortare än 256 tecken";
                foundError = true;
            }
            if (foundError)
            {
                MessageBox.Show(felMeddelande);
                return;
            }



            foreach (DataRow dr in dt.Rows)
            {
                System.Diagnostics.Debug.WriteLine(dr["mail"].ToString());
                if (dr["mail"].ToString().Equals(txtUsername.Text))
                {

                    id = dr["id"].ToString();
                    username = dr["mail"].ToString();
                    password = dr["losenord"].ToString();
                    isBoss = Convert.ToBoolean(dr["chef"].ToString());
                    namn = dr["fnamn"].ToString();
                    efterNamn = dr["enamn"].ToString();
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

            if (isBoss) { mode = ApplicationMode.Mode.ADMINISTRATOR; }

            Logintest form = new Logintest(mode);
            form.Visible = true;
            Visible = false;
            
            email = username;

            var menyn = new frmMenu(namn, efterNamn, email, mode);
            menyn.Visible = true;
            this.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            mode = ApplicationMode.Mode.OFFLINE;
            var menyn = new frmMenu(mode);
            menyn.Visible = true;
            this.Visible = false;
        }


    }
}
