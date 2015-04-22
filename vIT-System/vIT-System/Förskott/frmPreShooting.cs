using System;
using System.Windows.Forms;
using vIT_System.Förskott;
using System.Net.Mail;

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
            var getChef = "select Fnamn from Anstallda where Anstallda.Chef = 'true'";
            var getUppd = "select namn from uppdrag";
            var lista = DataPreShooting.cbFill(getChef);

            foreach (var chef in lista)
            {
                cbBoss.Items.Add(chef);
            }

            tbSum.Text = "";

            var uppList = DataPreShooting.cbFill(getUppd);

            foreach (var upp in uppList)
            {
                cbChooseUppdrag.Items.Add(upp);
            }
        }

        //Posta innehållet i formuläret till databasen
        private void btnSendPre_Click(object sender, EventArgs e)
        {
            //Hämtar värden i boxarna
            if (Validation.IsEmpty(tbMotivation.ToString()) ||
              Validation.IsEmpty(tbSum.Text) ||
              Validation.IsEmpty(cbBoss.SelectedItem.ToString()) ||
              Validation.IsEmpty(cbChooseUppdrag.SelectedItem.ToString()))
            {
                MessageBox.Show("Fyll i alla fält!");
            }
            else
            {
                var motiv = tbMotivation.Text;
                var uppdrag = cbChooseUppdrag.SelectedItem.ToString();
                var boss = cbBoss.SelectedItem.ToString();
                var QbossId = "select id from anstallda where fnamn = '" + boss + "'";
                var QuppId = "select uppid from uppdrag where namn = '" + uppdrag + "'";
                var summa = 0;

                Int32.TryParse(tbSum.Text, out summa);
                var bossID = DataPreShooting.getId(boss, QbossId);
                var uppdragID = DataPreShooting.getId(uppdrag, QuppId);

                DataPreShooting.savePreShooting(summa, motiv, bossID, uppdragID);

                tbMotivation.Text = "";
                tbSum.Text = "";
                cbBoss.SelectedIndex = -1;
                cbChooseUppdrag.SelectedIndex = -1;

                //Ska skickas när ansökan har sparats!
                SmtpClient client = new SmtpClient();
                var from = "sergio.saxofonguden@gmail.com";
                var to = "painblom@gmail.com";
                var subject = "Ny vits ansökan";
                var meddelande = "Du har en ny ansökan från någon utav dina anställda konsulter";

                var mail = new MailMessage(from, to, subject, meddelande);
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.EnableSsl = true;
                client.Credentials = new System.Net.NetworkCredential("sergio.saxofonguden@gmail.com", "Sergio1977");

                try
                {
                    client.Send(mail);
                    MessageBox.Show(@"Mail skickat!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
