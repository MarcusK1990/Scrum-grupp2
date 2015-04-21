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
            var query = "select Fnamn from Anstallda where Anstallda.Chef = 'true'";
            var query2 = "select namn from uppdrag";
            var lista = DataPreShooting.cbFill(query);
            foreach (var chef in lista)
            {
                cbBoss.Items.Add(chef);
            }

            tbSum.Text = "";

            var uppList = DataPreShooting.cbFill(query2);
            foreach (var upp in uppList)
            {
                cbChooseUppdrag.Items.Add(upp);
            }
        }

        //Posta innehållet i formuläret till databasen
        private void btnSendPre_Click(object sender, EventArgs e)
        {
                          //Hämtar värden i boxarna
              if (
                Validation.IsEmpty(tbMotivation.ToString()) ||
                Validation.IsEmpty(tbSum.Text) ||
                Validation.IsEmpty(cbBoss.SelectedItem.ToString())||
                Validation.IsEmpty(cbChooseUppdrag.SelectedItem.ToString()))
            {
                MessageBox.Show("Fyll i alla fält!");
            }
            else
            {
                var motiv = tbMotivation.Text;
                var uppdrag = cbChooseUppdrag.SelectedItem.ToString();
                var boss = cbBoss.SelectedItem.ToString();
                var query1 = "select id from anstallda where fnamn = '" + boss + "'";
                var query2 = "select uppid from uppdrag where namn = '" + uppdrag + "'";
                var nånting = 0;
                Int32.TryParse(tbSum.Text, out nånting);
                
                var bossID = DataPreShooting.getId(boss, query1);
                var uppdragID = DataPreShooting.getId(uppdrag, query2);
                DataPreShooting.savePreShooting(nånting, motiv, bossID, uppdragID);
                tbMotivation.Text = "";
                tbSum.Text = "";

                //Ska skickas när ansökan har sparats!
                SmtpClient client = new SmtpClient();

                string from = "sergio.saxofonguden@gmail.com";
                string to = "painblom@gmail.com";
                string subject = "Ny vits ansökan";
                string meddelande = "Du har en ny ansökan från någon utav dina anställda konsulter";

                MailMessage mail = new MailMessage(from, to, subject, meddelande);
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
