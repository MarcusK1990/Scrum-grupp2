using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vIT_System.SQL;

namespace vIT_System.Formulärhantering
{
    public partial class Forskottshantering : Form
    {
        private SqlHelper sqlHelper;
        private string id;

        public Forskottshantering(string Aid)
        {
            InitializeComponent();
            id = Aid;
            sqlHelper = new SqlHelper("Database\\vITs2.mdf");
           
        }
        
        private void Forskottshantering_Load(object sender, EventArgs e)
        {
            Fyllbox();
        }

        private void Fyllbox()
        {
            cbVisaSokande.Items.Clear();
            var chef = sqlHelper.Fetch("select Fnamn from Anstallda where id = " + id);
            if (chef.Rows.Count > 0)
            {
                var cheff = chef.Rows[0]["fnamn"];
                var Dl = sqlHelper.Fetch("select Fid from Forskott where Status = 'Bearbetas' and chef = " + "'" + cheff + "'");
                foreach (DataRow dr in Dl.Rows)
                {
                    var Sokande = dr["Fid"].ToString();
                    cbVisaSokande.Items.Add(Sokande);
                }
            }
            else
            {
                MessageBox.Show("Du har inga nya ansökningar");
                return;
            }
           
        }

        private void cbVisaSokande_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Sokande = cbVisaSokande.SelectedItem.ToString();
            var id = Convert.ToInt32(Sokande);
            var Q = sqlHelper.Fetch("select forskott.Kommentar, forskott.Summa, Anstallda.Fnamn, Anstallda.Enamn, Uppdrag.Namn  from Forskott Join Uppdrag on Uppdrag.UppId = Forskott.UppId Join Anstallda on Anstallda.Id = Forskott.Id where forskott.FId = " + id);

            if (Q.Rows.Count > 0)
            {
                tbMotivering.Text = Q.Rows[0]["Kommentar"].ToString();
                tbSokande.Text = Q.Rows[0]["Fnamn"].ToString() + " " + Q.Rows[0]["Enamn"].ToString();
                tbSumma.Text = Q.Rows[0]["Summa"].ToString();
                tbUppdrag.Text = Q.Rows[0]["Namn"].ToString();
            }
            else
            {
                MessageBox.Show("Något är fel");
            }
        }

       
        private void btnGodkann_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbVisaSokande.Text))
            {
                MessageBox.Show("Välj Förskottsansökning");
            }

            else
            {
                var Sokande = cbVisaSokande.SelectedItem.ToString();
                var id = Convert.ToInt32(Sokande);
                sqlHelper.Modify("Update Forskott set Status ='Godkänd' where Forskott.Fid = " + id);
                MessageBox.Show("Förskottsansökningen är nu godkänd");
                tbMotivering.Clear();
                tbSokande.Clear();
                tbSumma.Clear();
                tbUppdrag.Clear();
                cbVisaSokande.Text = "";
                Fyllbox();
            }
        }

       

        private void btnAvsla_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbVisaSokande.Text))
            {
                MessageBox.Show("Välj Förskottsansökning");
            }

            else
            {
                var Sokande = cbVisaSokande.SelectedItem.ToString().Substring(0, 2);
                var id = Convert.ToInt32(Sokande);
                sqlHelper.Modify("Update Forskott set Status ='Ej Godkänd' where Forskott.Fid = " + id);
                MessageBox.Show("Snålt");
                tbMotivering.Clear();
                tbSokande.Clear();
                tbSumma.Clear();
                tbUppdrag.Clear();
                cbVisaSokande.Text = "";
                Fyllbox();
            }

        }

    }

}

