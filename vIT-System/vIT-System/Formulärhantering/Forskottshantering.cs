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

        public Forskottshantering()
        {
            InitializeComponent();
            sqlHelper = new SqlHelper("Database\\vITs2.mdf");
        }
        //Inte det smidigaste att göra textboxar, borde kanske ändras. 

        // kvar: även where Chef = 'den chef som är inloggad' så inte alla förskottsansökningar till alla chefer kommer upp. 
        private void Forskottshantering_Load(object sender, EventArgs e)
        {
            var Dl = sqlHelper.Fetch("select Fid from Forskott where Status = 'Bearbetas' ");
            foreach (DataRow dr in Dl.Rows)
            {
                var Sokande = dr["Fid"].ToString();
                cbVisaSokande.Items.Add(Sokande);
             
            }
           
        }

       
        private void cbVisaSokande_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Sokande = cbVisaSokande.SelectedItem.ToString().Substring(0, 1);
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
                
            var Sokande = cbVisaSokande.SelectedItem.ToString().Substring(0, 1);
            var id = Convert.ToInt32(Sokande);
            sqlHelper.Modify("Update Forskott set Status ='Godkänd' where Forskott.Fid = " + id);
            MessageBox.Show("Förskottsansökningen är nu godkänd");
            }

        }

        // formuläret ska tömmas och uppdateras också. 

        private void btnAvsla_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbVisaSokande.Text))
            {
                MessageBox.Show("Välj Förskottsansökning");
            }

            else
            {
                var Sokande = cbVisaSokande.SelectedItem.ToString().Substring(0, 1);
                var id = Convert.ToInt32(Sokande);
                sqlHelper.Modify("Update Forskott set Status ='Ej godkänd' where Forskott.Fid = " + id);
                MessageBox.Show("Snålt");
            }
            
        }
        
        }

    }

