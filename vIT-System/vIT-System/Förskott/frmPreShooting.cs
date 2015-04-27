using System;
using System.Windows.Forms;
using vIT_System.Förskott;
using System.Net.Mail;
using vIT_System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using vIT_System.Validering;

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
        private bool Validering()
        {
            ValidationCheck.checkValidering(tbSum, "InnehållerBokstav", "summa");
            ValidationCheck.checkValidering(tbSum, "tom", "summa");
            ValidationCheck.checkValidering(tbSum, "NegativaTal", "summa");

            ValidationCheck.checkValidering(tbMotivation, "tom", "motivering");
            ValidationCheck.checkValidering(tbMotivation, "längre255", "motivering");

            ValidationCheck.CheckCombox(cbBoss, "chef");
            ValidationCheck.CheckCombox(cbChooseUppdrag, "uppdrag");

            var felmeddelanden = ValidationCheck.felString;

            if (felmeddelanden.Length <= 0)
            {
                return true;
            }

            MessageBox.Show(string.Format(@"Följande fel har uppstått: {0}", felmeddelanden));
            ValidationCheck.felString = "";
            return false;
        }

        //Posta innehållet i formuläret till databasen
        private void btnSendPre_Click(object sender, EventArgs e)
        {
            //Hämtar värden i boxarna
            if (!Validering())
            {
                return;
            }
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
                sendMail();

                tbMotivation.Text = "";
                tbSum.Text = "";
                cbBoss.SelectedIndex = -1;
                cbChooseUppdrag.SelectedIndex = -1;
                
        }

        //En egen metod för att skicka mailet, för att det inte skulle bli så grötigt i click-metoden
        private void sendMail()
        {

            var selected = this.cbBoss.GetItemText(this.cbBoss.SelectedItem);
            var path = Helpers.getSourcePath();

            var sqldb = new SqlConnection(path);
            var query = "select mail from anstallda where fnamn = '" + selected + "'";

            var sqlC = new SqlCommand(query, sqldb);
            SqlDataReader myReader;
            var lista = new List<string>();
            var to = "";

            try
            {
                sqldb.Open();
                myReader = sqlC.ExecuteReader();
                myReader.Read();

                to = myReader.GetString(0);

                sqldb.Close();
                myReader.Close();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            SmtpClient client = new SmtpClient();

            var from = "sergio.saxofonguden@gmail.com";
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
                MessageBox.Show("Din förskottsansökan har skickats till "+ to);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


    }
}

