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
    public partial class Konsulthantering : Form
    {
        private SqlHelper sqlHelper;
        public Konsulthantering()
        {
            // jag orkar inte kommentera koden just nu -carl
            // om ni behöver ändra i koden och undrar om något, hör av er

            InitializeComponent();
            sqlHelper = new SqlHelper("Database\\vITs.mdf");

            DataTable dt = sqlHelper.Fetch("select * from anstallda");

            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem lvi = new ListViewItem(dr["id"].ToString());
                lvi.SubItems.Add(dr["fnamn"].ToString());
                lvi.SubItems.Add(dr["enamn"].ToString());

                listvKonsulter.Items.Add(lvi);
            }
        }

        private void btnNyAnställd_Click(object sender, EventArgs e)
        {
            sqlHelper.Modify("insert into anstallda (losenord, fnamn, enamn, persnr, mail) values ('abc123', 'Ny', 'Anställd', 0, 'mail@example.com');");
            MessageBox.Show("En ny anställd har lagts till!");

            DataTable dt = sqlHelper.Fetch("select * from anstallda");

            listvKonsulter.Items.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem lvi = new ListViewItem(dr["id"].ToString());
                lvi.SubItems.Add(dr["fnamn"].ToString());
                lvi.SubItems.Add(dr["enamn"].ToString());

                listvKonsulter.Items.Add(lvi);
            }
        }

        private void btnRadera_Click(object sender, EventArgs e)
        {
            if (listvKonsulter.SelectedItems.Count == 0) { return; }
            DialogResult dialogResult = MessageBox.Show("Är du säker på att du vill ta bort " + listvKonsulter.SelectedItems[0].SubItems[1].Text + " " + listvKonsulter.SelectedItems[0].SubItems[2].Text + "?", "Ta bort anställd", MessageBoxButtons.YesNo);
            
            switch (dialogResult)
            {
                case DialogResult.No:
                    break;
                case DialogResult.Yes:
                    sqlHelper.Modify("delete from anstallda where id = " + listvKonsulter.SelectedItems[0].Text + ";");
                    MessageBox.Show("Konsulten har tagits bort.");
                    break;
            }
        }

        private void btnRedigera_Click(object sender, EventArgs e)
        {
            if (listvKonsulter.SelectedItems.Count == 0) { return; }

            DataTable dt = sqlHelper.Fetch("select * from anstallda where id = " + listvKonsulter.SelectedItems[0].Text + ";");

            tbId.Text = dt.Rows[0]["id"].ToString();
            tbFörnamn.Text = dt.Rows[0]["fnamn"].ToString();
            tbEfternamn.Text = dt.Rows[0]["enamn"].ToString();
            tbPersonnummer.Text = dt.Rows[0]["persnr"].ToString();
            tbMailadress.Text = dt.Rows[0]["mail"].ToString();
            tbLösenord.Text = dt.Rows[0]["losenord"].ToString();
        }

        private void btnSpara_Click(object sender, EventArgs e)
        {
            // TODO: VALIDERING orkar fan inte göra det nu
            // också skydda mot sql-injection när vi fixat det

            sqlHelper.Modify("update anstallda set fnamn='" + tbFörnamn.Text + "', enamn='" + tbEfternamn.Text + "', persnr=" + tbPersonnummer.Text + ", mail='" + tbMailadress.Text + "', losenord='" + tbLösenord.Text + "', chef=" + (cbÄrChef.Checked ? 1 : 0) + " where id=" + tbId.Text + ";");

            MessageBox.Show("Konsulten har uppdaterats.");

        }
    }
}
