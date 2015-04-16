﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vIT_System.XmlRelaterat;
using vIT_System.Validering;
using System.Net.Mail;

namespace vIT_System.GUI
{
    public partial class frmCompensation : Form
    {
        public List<Utgift> totalOutpoison;
        public ApplicationMode.Mode CompMode { get; set; }

        public frmCompensation(ApplicationMode.Mode modee)
        {
            InitializeComponent();
            totalOutpoison = new List<Utgift>();
            CompMode = modee;
        }

        public frmCompensation(string email, string namn, string efternamn, ApplicationMode.Mode inMode)
        {
            InitializeComponent();
            totalOutpoison = new List<Utgift>();
            tbEmail.Text = email;
            tbForNamn.Text = namn;
            tbEfterNamn.Text = efternamn;
            CompMode = inMode;
        }

        private void LaddaComboBox()
        {
            var sek = new ComboboxItem
            {
                Text = "SEK",
                Value = 1
            };
            var dollarinos = new ComboboxItem
            {
                Text = "USD",
                Value = 6.12
            };
            var evro = new ComboboxItem
            {
                Text = "EUR",
                Value = 8.1337
            };

            cbValuta.Items.Add(sek);
            cbValuta.Items.Add(dollarinos);
            cbValuta.Items.Add(evro);

            cbValuta.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            //  string file = openFileDialog1.FileName;

        }

        private void btnUtgiter_Click(object sender, EventArgs e)
        {

           
            double parsedBelopp = 0;
            double.TryParse(tbBelopp.Text, out parsedBelopp);

            var felmeddelanden = "";
            var f1 = "Följande fel har uppstått: \n";
            ValidationCheck.checkValidering(tbBelopp, "tom", "belopp");
            ValidationCheck.checkValidering(tbBelopp, "bokstäver", "belopp");
            ValidationCheck.checkValidering(tbBelopp, "längre255", "belopp");

            ValidationCheck.checkValidering(tbAndaMal, "tom", "ändamål");
            ValidationCheck.checkValidering(tbAndaMal, "längre255", "ändamål");
            ValidationCheck.checkValidering(tbAndaMal, "siffor", "ändamål");

            felmeddelanden = ValidationCheck.felString;

            if (felmeddelanden.Length > 0)
            {
                MessageBox.Show(f1 + felmeddelanden);
                ValidationCheck.felString = "";
                return;
            }
            double parsadValutakursdouble = 0;
            Double.TryParse(cbValuta.SelectedValue.ToString(), out parsadValutakursdouble);
            var nyUtgift = new Utgift
            {
                belopp = parsedBelopp,
                andaMal = tbAndaMal.Text,
                valuta = cbValuta.SelectedText,
                valutaKurs = parsadValutakursdouble,
                moms = 2 // % eller ?!?!?!        
            };
            totalOutpoison.Add(nyUtgift);
            UppdateraTotalSumma();
        }

        public void UppdateraTotalSumma()
        {

            //var total = totalOutpoison.Aggregate<utgift, double>(0, (current, t) => current + t.belopp);
            //labelTotal.Text = total.ToString();
            double total = 0;
            for (var i = 0; i < totalOutpoison.Count; i++)
            {
                total += totalOutpoison[i].belopp;
            }
            labelTotal.Text = total.ToString();
        }

        private void btnSparaUtkast_Click(object sender, EventArgs e)
        {
            var äcksämäll = new Xmelliserare(@"C:\dump\xmlCompensationModel.xml");

            if (!validera())
            {
                return;
            }
            

            var utkast = new CompensationModel
            {
                eMail = tbEmail.Text,
                forNamn = tbForNamn.Text,
                eftNamn = tbEfterNamn.Text,
                //Bild nånting hur fan man nu gör det
                milErsattning = Convert.ToInt32(tbMilErsattning.Text),
                utresa = dtpUtResa.Value.ToString("yyyy-MM-dd"),
                hemresa = dtpHemResa.Value.ToString("yyyy-MM-dd"),
                semesterDagar = tbSemesterdagar.Text,
                land = cbLand.SelectedItem.ToString(),
                frukost = Convert.ToInt32(tbFrukost.Text),
                lunch = Convert.ToInt32(tbLunch.Text),
                middag = Convert.ToInt32(tbMiddag.Text),
                utgifter = totalOutpoison
            };

            äcksämäll.SkrivCompensationModel(utkast);

            var asd = new CompensationModel(totalOutpoison);
            Console.WriteLine("TotalOutpoison Count: " + totalOutpoison.Count);
            Console.WriteLine("asd listan Count: " + asd.utgifter.Count);

        }

        private void frmCompensation_Load(object sender, EventArgs e)
        {
            if (CompMode == ApplicationMode.Mode.OFFLINE)
            {
                tbEmail.Enabled = true;
                tbForNamn.Enabled = true;
                tbEfterNamn.Enabled = true;
            }
            LaddaComboBox();
            hämtaLänder();
        }

        private void btnLaddaUtkast_Click(object sender, EventArgs e)
        {
            var äcksämäll = new Xmelliserare(@"C:\dump\xmlCompensationModel.xml");
            var utkast = äcksämäll.LaddaUtkast();

            tbEmail.Text = utkast.eMail;
            tbForNamn.Text = utkast.forNamn;
            tbEfterNamn.Text = utkast.eftNamn;
            //Bild nånting hur fan man nu gör det
            tbMilErsattning.Text = utkast.milErsattning.ToString();
            dtpUtResa.Value = DateTime.Parse(utkast.utresa);
            dtpHemResa.Value = DateTime.Parse(utkast.hemresa);
            tbSemesterdagar.Text = utkast.semesterDagar;
            //land = cbLand.SelectedItem.ToString(),
            tbFrukost.Text = utkast.frukost.ToString();
            tbLunch.Text = utkast.lunch.ToString();
            tbMiddag.Text = utkast.middag.ToString();
            totalOutpoison = utkast.utgifter;
        }

        private bool validera()
        {
            var felmeddelanden = "";
            var f1 = "Följande fel har uppstått: \n";
            ValidationCheck.checkValidering(tbEfterNamn, "tom", "efternamn");
            ValidationCheck.checkValidering(tbEfterNamn, "längre255", "efternamn");
            ValidationCheck.checkValidering(tbEfterNamn, "innehållerInt", "efternamn");

            ValidationCheck.checkValidering(tbForNamn, "tom", "förnamn");
            ValidationCheck.checkValidering(tbForNamn, "längre255", "förnamn");       
            ValidationCheck.checkValidering(tbForNamn, "innehållerInt", "förnamn");

            ValidationCheck.checkValidering(tbEmail, "tom", "email");
            ValidationCheck.checkValidering(tbEmail, "längre255", "email");
            ValidationCheck.checkValidering(tbEmail, "email", "email");

            ValidationCheck.checkValidering(tbMilErsattning, "innehållerBokstav", "milersättning");

            ValidationCheck.checkValidering(tbSemesterdagar, "innehållerBokstav", "semesterdagar");

            ValidationCheck.checkValidering(tbFrukost, "innehållerBokstav", "frukost");

            ValidationCheck.checkValidering(tbLunch, "innehållerBokstav", "lunch");

            ValidationCheck.checkValidering(tbMiddag, "innehållerBokstav", "middag");

            felmeddelanden = ValidationCheck.felString;

            if (felmeddelanden.Length <= 0)
            {
                return true;
            }
            
            MessageBox.Show(f1 + felmeddelanden);
            ValidationCheck.felString = "";
            return false;
        }

        private void btnSkickaAnsokan_Click(object sender, EventArgs e)
        {
            if (!validera())
            {

                return;
            }
            SmtpClient client = new SmtpClient();

            string from = "sergio.saxofonguden@gmail.com";
            string to = "sergio.saxofonguden@gmail.com";
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
                MessageBox.Show("Mail skickat!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //det som ska sparas i db
        }

        private void hämtaLänder()
        {
            string[,] länder = vIT_System.Traktamentestabell.Traktamentestabell.HämtaLänderOchBelopp();

            cbLand.Items.Clear();

            for (int i = 0; i < länder.GetLength(0); i++)
            {
                System.Diagnostics.Debug.WriteLine(länder[i, 0] + " + " + länder[i, 1]);
                cbLand.Items.Add(new ComboboxItem { Text = länder[i, 0], Value = Convert.ToDouble(länder[i, 1]) });
            }

            cbLand.SelectedIndex = 0;
        }
    }
}
