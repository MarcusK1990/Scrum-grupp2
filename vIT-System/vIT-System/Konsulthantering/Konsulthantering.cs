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
            sqlHelper = new SqlHelper("Database\\vITs2.mdf");

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
            // TODO: skydda mot sql-injection när vi fixat det / om vi anser att det är värt det och behövs

            // valideringsblock
            {
                bool foundError = false;
                string felmeddelande = "Följande fel har upstått:\n";

                if (Validation.IsEmpty(tbFörnamn.Text)) { felmeddelande += "\n• Fältet för förnamn måste vara ifyllt"; foundError = true; }
                if (Validation.IsShorterThan(tbFörnamn.Text, 256)) { felmeddelande += "\n• Förnamn måste vara kortare än 256 tecken"; foundError = true; }
                if (Validation.IsAlphabetic(tbFörnamn.Text)) { felmeddelande += "\n• Förnamn får endast innehålla bokstäver"; foundError = true; }

                if (Validation.IsEmpty(tbEfternamn.Text)) { felmeddelande += "\n• Fältet för Efternamn måste vara ifyllt"; foundError = true; }
                if (Validation.IsShorterThan(tbEfternamn.Text, 256)) { felmeddelande += "\n• Efternamn måste vara kortare än 256 tecken"; foundError = true; }
                if (Validation.IsAlphabetic(tbEfternamn.Text)) { felmeddelande += "\n• Efternamn får endast innehålla bokstäver"; foundError = true; }

                if (Validation.IsEmpty(tbPersonnummer.Text)) { felmeddelande += "\n• Fältet för personnummer måste vara ifyllt"; foundError = true; }
                if (Validation.IsShorterThan(tbPersonnummer.Text, 13)) { felmeddelande += "\n• Personnummer måste vara kortare än 13 tecken"; foundError = true; }
                if (Validation.IsNumeric(tbPersonnummer.Text)) { felmeddelande += "\n• Personnummer får endast innehålla siffror"; foundError = true; }

                if (Validation.IsEmpty(tbMailadress.Text)) { felmeddelande += "\n• Fältet för mailadress måste vara ifyllt"; foundError = true; }
                if (Validation.IsShorterThan(tbMailadress.Text, 256)) { felmeddelande += "\n• Mailadress måste vara kortare än 256 tecken"; foundError = true; }
                if (Validation.IsEmailAddress(tbMailadress.Text)) { felmeddelande += "\n• Mailadress måste följa formatet [text]@[text].[text]"; foundError = true; }

                if (Validation.IsEmpty(tbLösenord.Text)) { felmeddelande += "\n• Fältet för lösenord måste vara ifyllt"; foundError = true; }
                if (Validation.IsShorterThan(tbLösenord.Text, 256)) { felmeddelande += "\n• Lösenord måste vara kortare än 256 tecken"; foundError = true; }

                if (foundError) { MessageBox.Show(felmeddelande); return; }
            }

            sqlHelper.Modify("update anstallda set fnamn='" + tbFörnamn.Text + "', enamn='" + tbEfternamn.Text + "', persnr='" + tbPersonnummer.Text + "', mail='" + tbMailadress.Text + "', losenord='" + tbLösenord.Text + "', chef='" + (cbÄrChef.Checked ? "true" : "false") + "' where id=" + tbId.Text + ";");

            MessageBox.Show("Konsulten har uppdaterats.");

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
    }
}
