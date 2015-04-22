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


namespace vIT_System.Förskott
{
    public partial class frmMyPreShooting : Form
    {
        private SqlHelper sqlHelper;

        public frmMyPreShooting()
        {
            InitializeComponent();
            sqlHelper = new SqlHelper("Database\\vITs2.mdf");
        }

        private void frmMyPreShooting_Load(object sender, EventArgs e)
        {
            var Dl = sqlHelper.Fetch("select * from Forskott");
            foreach (DataRow dr in Dl.Rows)
            {
                var Forskott = dr["Fid"].ToString();
                cbShowFid.Items.Add(Forskott);
            }
        }

        private void cbShowFid_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Fid = cbShowFid.SelectedItem.ToString().Substring(0, 1);
            var id = Convert.ToInt32(Fid);
            var Q = sqlHelper.Fetch("select * from Forskott where Forskott.Fid = " + id);
            if (Q.Rows.Count > 0)

            {
                tbMotivation.Text = Q.Rows[0]["Kommentar"].ToString();
                tbUppdrag.Text = Q.Rows[0]["UppId"].ToString();
                tbSumma.Text = Q.Rows[0]["Summa"].ToString();
                tbChef.Text = Q.Rows[0]["Chef"].ToString();
                tbStatus.Text = Q.Rows[0]["Status"].ToString();
            }
                else
                {
                    MessageBox.Show("Något är fel");
                }
            }

        
    }
}
