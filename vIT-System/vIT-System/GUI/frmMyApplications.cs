using System;
using System.Data;
using System.Windows.Forms;
using vIT_System.SQL;

namespace vIT_System.GUI
{
    public partial class FrmMyApplications : Form
    {
        private SqlHelper sqlHelper;

        public FrmMyApplications()
        {
            InitializeComponent();
            sqlHelper = new SqlHelper("Database\\vITs2.mdf");
        }

        private void FrmMyApplications_Load(object sender, EventArgs e)
        {

            var dt = sqlHelper.Fetch("select * from ansokan");
            foreach (DataRow dr in dt.Rows)
            {
                var reseansokan = dr["ansid"].ToString();
                reseansokan += ". ";
                reseansokan += dr["namn"].ToString();
                cbShowAns.Items.Add(reseansokan);
            }
        }

        private void cbShowAns_SelectedIndexChanged(object sender, EventArgs e)
        {
            var vald = cbShowAns.SelectedItem.ToString().Substring(0, 1);
            var id = Convert.ToInt32(vald);
            var dt = sqlHelper.Fetch("select *from Resa where resa.ansid = " + id);
            if (dt.Rows.Count > 0)
            {
                lbCountry.Text = dt.Rows[0]["land"].ToString();
            }
            else
            {
                lbCountry.Text = "landet finns inte";
            }
            MessageBox.Show("yay!");
        }
    }
}
