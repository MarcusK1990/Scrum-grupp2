using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vIT_System.SQL;
using vIT_System.Förskott;

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
            //Fyll upp combobox med alla chefer som finns
            var lista = DataPreShooting.FillCbBoss();
            foreach (var chef in lista)
            {
                cbBoss.Items.Add(chef);
            }

        }

        //Posta innehållet i formuläret till databasen
        private void btnSendPre_Click(object sender, EventArgs e)
        {
            var sqldb = new SqlConnection("Data Source=(localdb)\\v11.0;AttachDbFilename=C:\\Users\\sofia\\Source\\Repos\\Scrum-grupp2\\vIT-System\\vIT-System\\Database\\vITs.mdf;Integrated Security=True");
            var query = "select id from anstallda where fnamn = '" + cbBoss.SelectedItem + "'";

            SqlCommand sqlSelect = new SqlCommand(query, sqldb);
            SqlDataReader myReader;
            var idhamtat = 0;
            try
            {
                sqldb.Open();
                myReader = sqlSelect.ExecuteReader();
                while (myReader.Read())
                {
                    idhamtat = myReader.GetInt32(0);
                }
                myReader.Close();
            }
            catch (FormatException)
            {

            }
            var query2 = ("insert into forskott values (" + Convert.ToInt32(tbSum.Text) + ", '" + tbMotivation.Text + "', " + idhamtat + ")");
            SqlCommand sqlInsert = new SqlCommand(query2, sqldb);

            sqldb.Close();
        }
    }
}
