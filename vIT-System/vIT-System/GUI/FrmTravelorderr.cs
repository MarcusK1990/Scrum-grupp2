using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vIT_System.Data;
using vIT_System.XmlRelaterat;
using vIT_System.Validering;

namespace vIT_System.GUI
{
    public partial class FrmTravelorderr : Form
    {

        public ApplicationMode.Mode CompMode { get; set; }

        public FrmTravelorderr(ApplicationMode.Mode inMode)
        {
            InitializeComponent();
          
            CompMode = inMode;


        }

        public FrmTravelorderr(string email, string namn, string efternamn, ApplicationMode.Mode inMode)
        {
            InitializeComponent();
           
            tbTravelEmal.Text = email;
            tbTravelNamn.Text = namn;
            tbTravelEnamn.Text = efternamn;
            CompMode = inMode;

           
        }

        public FrmTravelorderr()
        {
            InitializeComponent();
        }

        public static List<string> cbFyll(string query)
        {
            var path = Helpers.getSourcePath();
            var sqldb = new SqlConnection(path);
            var sqlC = new SqlCommand(query, sqldb);
            SqlDataReader myReader;
            var lista = new List<string>();
            try
            {
                sqldb.Open();
                myReader = sqlC.ExecuteReader();
                while (myReader.Read())
                {
                    var namn = myReader.GetString(0);
                    lista.Add(namn);
                }
                sqldb.Close();
                myReader.Close();
            }
            catch (Exception)
            {
            }
            return lista;
        }
        private void HämtaLänder()
        {
            var länder = Traktamentestabell.Traktamentestabell.HämtaLänderOchBelopp();

            cmbLand.Items.Clear();

            for (var i = 0; i < länder.GetLength(0); i++)
            {
                //System.Diagnostics.Debug.WriteLine(länder[i, 0] + " + " + länder[i, 1]);
                cmbLand.Items.Add(new ComboboxItem { Text = länder[i, 0], Value = Convert.ToDouble(länder[i, 1]) });
            }

            cmbLand.SelectedIndex = 0;
        }

        private void FrmTravelorder_Load(object sender, EventArgs e)
        {
            HämtaLänder();
            var getUppd = "select namn from uppdrag";
     

            var uppList = FrmTravelorderr.cbFyll(getUppd);

            foreach (var upp in uppList)
            {
                cmbTravelUppdrag.Items.Add(upp);
            }


        }

        private void btnLaggTillLand_Click(object sender, EventArgs e)
        {
            //var valtItem = (ComboBox)cmbLand.SelectedItem;
            //var valtLand = Convert.ToString(valItem.Text);
            LbxLand.Items.Add(cmbLand.Text);
        }

        private void btnTaBortLand_Click(object sender, EventArgs e)
        {
            LbxLand.Items.Clear();
        }

        private void btnSkickaReseOrder_Click(object sender, EventArgs e)
        {
            if (!Validera())
            {
                return;
            }
            MessageBox.Show("Din Reseorder är skickad");
        }
        private bool Validera()
        {
            ValidationCheck.checkValidering(tbTravelNamn, "tom", "förnamn");
            ValidationCheck.checkValidering(tbTravelNamn, "innehållerInt", "förnamn");
            ValidationCheck.checkValidering(tbTravelNamn, "längre255", "förnamn");

            ValidationCheck.checkValidering(tbTravelEnamn, "tom", "efternamn");
            ValidationCheck.checkValidering(tbTravelEnamn, "innehållerInt", "efternamn");
            ValidationCheck.checkValidering(tbTravelEnamn, "längre255", "efternamn");

            ValidationCheck.checkValidering(tbTravelEmal, "tom", "email");
            ValidationCheck.checkValidering(tbTravelEmal, "email", "email");

            ValidationCheck.CheckCombox(cmbTravelUppdrag, "uppdrag");

            var felmeddelanden = ValidationCheck.felString;

            if (felmeddelanden.Length > 0)
            {
                MessageBox.Show(string.Format(@"Följande fel har uppstått: {0}", felmeddelanden));
                ValidationCheck.felString = "";
                return false;
            }
            return true;
        }
    }
}