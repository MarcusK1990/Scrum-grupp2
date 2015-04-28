using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using vIT_System.SQL;

namespace vIT_System.GUI
{
    public partial class FrmMyApplications : Form
    {
        private SqlHelper sqlHelper;
        private List<int> idLista;
        private string testId;

        public FrmMyApplications(string namn, string efternamn, string email, ApplicationMode.Mode mode, string id)
        {
            InitializeComponent();
            testId = id;
            sqlHelper = new SqlHelper("Database\\vITs2.mdf");
            idLista = new List<int>();            
        }

        private void FrmMyApplications_Load(object sender, EventArgs e)
        {
            var dt = sqlHelper.Fetch("select * from ansokan where id = " + testId);
            idLista = new List<int>();
            foreach (DataRow dr in dt.Rows)
            {
                var reseansokan = dr["ansid"].ToString();
                reseansokan += ". ";
                reseansokan += dr["namn"].ToString();
                cbShowAns.Items.Add(reseansokan);
                idLista.Add(Convert.ToInt32(dr["AnsId"]));
            }
        }

        private void cbShowAns_SelectedIndexChanged(object sender, EventArgs e)
        {
            var vald = cbShowAns.SelectedIndex.ToString();
            
            int id = idLista[cbShowAns.SelectedIndex];

            var dt = sqlHelper.Fetch("select * from Ansokan left join Resa on Ansokan.AnsId = Resa.AnsId left join Utgifter on Resa.RId = Utgifter.RId where Ansokan.AnsId = " + id);

            if (dt.Rows.Count > 0)
            {
                lbCountry.Text = dt.Rows[0]["Land"].ToString();
                lbStatus.Text = dt.Rows[0]["Status"].ToString();
                lbTotComp.Text = dt.Rows[0]["Ersättning"].ToString();
                lbStartDate.Text = dt.Rows[0]["Avresa"].ToString();
                lbEndDate.Text = dt.Rows[0]["Hemresa"].ToString();
                lbSumTrakt.Text = dt.Rows[0]["Traktamente"].ToString();
                lbSumExpenses.Text = dt.Rows[0]["Summa"].ToString();

            }
            else
            {
                lbCountry.Text = "landet finns inte";
                lbStatus.Text = "fungerar inte";
            }  

        }
    }
}
