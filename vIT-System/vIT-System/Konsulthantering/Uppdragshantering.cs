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


namespace vIT_System
{
    public partial class Uppdragshantering : Form
    {
        private SqlHelper sqlHelper;

        public Uppdragshantering()
        {
            InitializeComponent();
            sqlHelper = new SqlHelper("Database\\vITs2.mdf");
        }

        private void Uppdragshantering_Load(object sender, EventArgs e)
        {
            var Dl = sqlHelper.Fetch("select * from uppdrag");
            foreach (DataRow dr in Dl.Rows)
            {
                var uppdrag = dr["Namn"].ToString();
                cbShowFid.Items.Add(uppdrag);
            }
        }

        // Ev. lägga till validering på om uppdraget redan finns. 
        private void btnRedigera_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUppdrag.Text))
            {
                MessageBox.Show(@"Fyll i ett Uppdragsnamn");
            }

            else
            {
                sqlHelper.Modify("Insert into Uppdrag values('" + tbUppdrag.Text + "');");
                tbUppdrag.Clear();
                MessageBox.Show(@"Ett nytt uppdrag har lagts till!");
            }
        }

        


    }
}
