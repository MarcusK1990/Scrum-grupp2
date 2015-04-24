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

        }

    }
}

