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

    // kvar:  det ska bara komma upp anökningar från den som är inloggad 

    public partial class Ansökningshantering : Form
    {
        private SqlHelper sqlHelper;

        public Ansökningshantering()
        {
            InitializeComponent();
            sqlHelper = new SqlHelper("Database\\vITs2.mdf");
        }

        private void Ansökningshantering_Load(object sender, EventArgs e)
        {
            var Dl = sqlHelper.Fetch("select ansid from Ansokan");
            
            foreach (DataRow dr in Dl.Rows)
            {
                var Sokande = dr["AnsId"].ToString();
                cbVisaAnsid.Items.Add(Sokande);
            }      
        }

        private void cbVisaAnsid_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Sokande = cbVisaAnsid.SelectedItem.ToString().Substring(0, 1);
            var id = Convert.ToInt32(Sokande);

            var Dl = sqlHelper.Fetch("Select RId from Resa where AnsId  = " + id);
            foreach (DataRow dr in Dl.Rows)
            {
                var Resor = dr["Rid"].ToString();
                cbVisaRid.Items.Add(Resor);
            }

            // + Fyll fälten
        }

        private void cbVisaRid_SelectedIndexChanged(object sender, EventArgs e)
        {
            //fyll alla fält
        }


        // kvar : Sidan ska uppdateras efter den är godkänd.
        private void btnGodkann_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbVisaAnsid.Text))
            {
                MessageBox.Show("Välj Ansökan");
            }

            else
            {
                var Sokande = cbVisaAnsid.SelectedItem.ToString().Substring(0, 1);
                var id = Convert.ToInt32(Sokande);
                sqlHelper.Modify("Update Ansokan set Status ='Godkänd' where Forskott.Fid = " + id);
                MessageBox.Show("Ansökningen är nu godkänd");
            }
        }

        //Kvar: Sidan ska uppdateras efter. 
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbVisaAnsid.Text))
            {
                MessageBox.Show("Välj Ansökan");
            }

            else
            {
                var Sokande = cbVisaAnsid.SelectedItem.ToString().Substring(0, 1);
                var id = Convert.ToInt32(Sokande);
                sqlHelper.Modify("Update Ansokan set Status ='Ej Godkänd' where Forskott.Fid = " + id);
                MessageBox.Show("Ansökningen är nu godkänd");
            }
        }

     

    }
}

