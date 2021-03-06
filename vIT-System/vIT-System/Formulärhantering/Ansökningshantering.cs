﻿using System;
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
    public partial class Ansökningshantering : Form
    {
        private SqlHelper sqlHelper;
        private string id;
        
        public Ansökningshantering(string Aid)
        {
            InitializeComponent();
            id = Aid;
            sqlHelper = new SqlHelper("Database\\vITs2.mdf");
        }

        // kvar:  det ska bara komma upp anökningar från den som är inloggad
        private void Ansökningshantering_Load(object sender, EventArgs e)
        {
            Fyllbox();
        }

        public void Fyllbox()
        {
            tbAvresa.Clear();
            tbErsattning.Clear();
            tbForskott.Clear();
            tbHemresa.Clear();
            tbId.Clear();
            tbLand.Clear();
            tbMat.Clear();
            tbSem.Clear();
            tbSokande.Clear();
            tbTotalsumma.Clear();
            tbTrak.Clear();
            tbUppdrag.Clear();
            cbVisaRid.Text = "";
            cbVisaAnsid.Text = "";

            cbVisaAnsid.Items.Clear();
            var chef = sqlHelper.Fetch("select Fnamn from Anstallda where id = " + id);
            if (chef.Rows.Count > 0)
            {
                var cheff = chef.Rows[0]["fnamn"];
                var Dl = sqlHelper.Fetch("select AnsId from Ansokan where status = 'bearbetas' and chef = " + "'" + cheff + "'");

                foreach (DataRow dr in Dl.Rows)
                {
                    var Sokande = dr["AnsId"].ToString();
                    cbVisaAnsid.Items.Add(Sokande);
                }  
            }
            else
            {
                MessageBox.Show("Du har inga nya ansökningar");
                return;
            }
                
        }

        private void cbVisaAnsid_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Sokande = cbVisaAnsid.SelectedItem.ToString();
            var id = Convert.ToInt32(Sokande);

            var Dl = sqlHelper.Fetch("Select RId from Resa where AnsId  = " + id);
            foreach (DataRow dr in Dl.Rows)
            {
                var Resor = dr["RId"].ToString();
                cbVisaRid.Items.Add(Resor);
            }

            var Q = sqlHelper.Fetch("select Ansokan.Ersättning,Anstallda.Fnamn, Anstallda.Enamn, Anstallda.Id from Ansokan join Anstallda on Anstallda.Id = Ansokan.Id where Ansokan.AnsId = " + id);
            var Q2 = sqlHelper.Fetch("Select Forskott.Summa from Ansokan join Forskott on Forskott.Fid = Ansokan.Fid where AnsId = " + id);
            
            if (Q.Rows.Count > 0)

            {
                tbSokande.Text = Q.Rows[0]["Fnamn"].ToString() + " " + Q.Rows[0]["Enamn"].ToString();
                tbId.Text = Q.Rows[0]["Id"].ToString();
                tbErsattning.Text = Q.Rows[0]["Ersättning"].ToString();
            }

            else
            {
                    MessageBox.Show("Något är fel");
            }

            if(Q2.Rows.Count > 0)
            {
                tbForskott.Text = Q.Rows[0]["Summa"].ToString();
            }
            else
            {
                tbForskott.Text = "0";
            }
                
            }
        
        private void cbVisaRid_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Resa = cbVisaRid.SelectedItem.ToString();
            var Rid = Convert.ToInt32(Resa);
            var Q = sqlHelper.Fetch("select * from resa where Resa.Rid= " + Rid);
            var Q1 = sqlHelper.Fetch("select Uppdrag.Namn from ResaUppdrag join Uppdrag on Uppdrag.UppId = ResaUppdrag.UppId where ResaUppdrag.RId = " + Rid);
            var Q2 = sqlHelper.Fetch("Select * from utgifter where RId = " + Rid);
            var Q3 = sqlHelper.Fetch("Select * from Mat where RId = " + Rid);
            var Q4 = sqlHelper.Fetch("Select * from SemDagar where RId = " + Rid);
            

            if (Q.Rows.Count > 0)
            {
                tbAvresa.Text = Q.Rows[0]["Avresa"].ToString();
                tbHemresa.Text = Q.Rows[0]["Hemresa"].ToString();                
                tbTrak.Text = Q.Rows[0]["Traktamente"].ToString();
                tbLand.Text = Q.Rows[0]["Land"].ToString();
                tbTotalsumma.Text = Q.Rows[0]["Totalsumma"].ToString();
            }

            if (Q1.Rows.Count > 0)
            {
                foreach (DataRow dr in Q1.Rows)
                {
                    tbUppdrag.Text = Q1.Rows[0]["Namn"].ToString();
                }
            }

            if (Q2.Rows.Count > 0)
            {
                foreach (DataRow dr in Q2.Rows)
                {
                     var Lw = new ListViewItem(dr["UtId"].ToString());
                     Lw.SubItems.Add(dr["Typ"].ToString());
                     Lw.SubItems.Add(dr["Valuta"].ToString());
                     Lw.SubItems.Add(dr["ValutaKurs"].ToString());
                     Lw.SubItems.Add(dr["Moms"].ToString());
                     Lw.SubItems.Add(dr["Kvitto"].ToString());
                     Lw.SubItems.Add(dr["Summa"].ToString());

                     lwUtgifter.Items.Add(Lw);   
                }
            }

            if (Q3.Rows.Count > 0)
            {
                foreach (DataRow dr in Q3.Rows)
                {
                    tbMat.Text = Q3.Rows[0]["Typ"].ToString() + ": " + Q3.Rows[0]["Summa"].ToString() + "Kr"; 
                }    
            }

            if (Q4.Rows.Count > 0)
            {
                foreach (DataRow dr in Q4.Rows)
                {
                    tbSem.Text = Q4.Rows[0]["SemStart"].ToString() + " - " + Q.Rows[0]["SemSlut"].ToString();
                }
            }

                else
                {
                    MessageBox.Show("Något är fel");
                }
            }
        

        
        private void btnGodkann_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbVisaAnsid.Text))
            {
                MessageBox.Show("Välj Ansökan");
            }

            else
            {
                var Sokande = cbVisaAnsid.SelectedItem.ToString().Substring(0, 2);
                var id = Convert.ToInt32(Sokande);
                sqlHelper.Modify("Update Ansokan set Status ='Godkänd' where Ansokan.AnsId = " + id);
                MessageBox.Show("Ansökningen är nu godkänd");
                
                Fyllbox();
            }
        }

        
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
                sqlHelper.Modify("Update Ansokan set Status ='Ej Godkänd' where Ansokan.AnsId = " + id);
                MessageBox.Show("Ansökningen är nu nekad");
                Fyllbox();
            }
        }

     

    }
}

