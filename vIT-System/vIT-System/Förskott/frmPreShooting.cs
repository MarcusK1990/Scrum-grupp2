using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vIT_System.SQL;
using vIT_System.Förskott;

namespace vIT_System.GUI
{
    public partial class frmPreShooting : Form
    {
        public frmPreShooting()
        {
            InitializeComponent();
        }
        private void frmPreShooting_Load(object sender, EventArgs e)
        {
            //Hämtar alla bossar och fyller upp combobox med alla chefer som finns
            var lista = DataPreShooting.FillCbBoss();
            foreach (var chef in lista)
            {
                cbBoss.Items.Add(chef);
            }

            //Fhämtar alla uppdrag som finns i databasen och fyller comboboxen
            //denna fungerar inte förrän det finns en uppdtagstabell i databasen
            //var uppdraglista = DataPreShooting.FillCbChooseUppdrag();
            //foreach (var uppd in uppdraglista)
            //{
            //    cbChooseUppdrag.Items.Add(uppd);
            //}
        }

        //Posta innehållet i formuläret till databasen
        private void btnSendPre_Click(object sender, EventArgs e)
        {
            var motiv = tbMotivation.Text;
            var sum = 0;

            if (Validation.IsEmpty(motiv) || Validation.IsEmpty(tbSum.Text))
            {
                MessageBox.Show("Fyll i alla fält!");
            }
            else
            {
                var bossID = DataPreShooting.getBoss(cbBoss.SelectedItem.ToString());
                DataPreShooting.savePreShooting(sum, motiv, bossID);
                tbMotivation.Text = "";
                tbSum.Text = "";
            }

            //var uppd = cbChooseUppdrag.SelectedItem.ToString();
        }
    }
}
