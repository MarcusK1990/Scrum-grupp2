using System;
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
            
            var nyUtgift = new Utgift
            {
                belopp = parsedBelopp,
                andaMal = tbAndaMal.Text,
                valuta = "SEK", //cbValuta.SelectedItem.Text
                moms = 2,
                utgiftID = 1

                //moms = tb            

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

            validera();

            var utkast = new CompensationModel
            {
                eMail = "test@email.com", //tbEmail.Text,
                forNamn = "Test", //tbForNamn.Text,
                eftNamn = "Exempel", //tbEfterNamn.Text,
                //Bild nånting hur fan man nu gör det
                milErsattning = 23,        //Convert.ToInt32(tbMilErsattning.Text),
                utresa = dtpUtResa.Value.ToString("yyyy-MM-dd"),
                hemresa = dtpHemResa.Value.ToString("yyyy-MM-dd"),
                semesterDagar = 2.ToString(), // tbSemesterdagar.Text,
                land = "ett land långt borta",  //cbLand.SelectedItem.ToString(),
                frukost = 12, //Convert.ToInt32(tbFrukost.Text),
                lunch = 2, //Convert.ToInt32(tbLunch.Text),
                middag = 3, //Convert.ToInt32(tbMiddag.Text),
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

        private void validera()
        {
            var felmeddelanden = "";
            var f1 = "Följande fel har uppstått: \n";
            ValidationCheck.checkValidering(tbEfterNamn, "tom", "efternamn");
            ValidationCheck.checkValidering(tbEfterNamn, "längre255", "efternamn");
            ValidationCheck.checkValidering(tbEfterNamn, "siffor", "efternamn");

            ValidationCheck.checkValidering(tbForNamn, "tom", "förnamn");
            ValidationCheck.checkValidering(tbForNamn, "längre255", "förnamn");
            ValidationCheck.checkValidering(tbForNamn, "siffor", "förnamn");

            ValidationCheck.checkValidering(tbEmail, "tom", "email");
            ValidationCheck.checkValidering(tbEmail, "längre255", "email");
            ValidationCheck.checkValidering(tbEmail, "email", "email");

            //ValidationCheck.checkValidering(tbMilErsattning, "tom", "milersättning");
            ValidationCheck.checkValidering(tbMilErsattning, "bokstäver", "milersättning");

            ValidationCheck.checkValidering(tbSemesterdagar, "bokstäver", "semesterdagar");

            ValidationCheck.checkValidering(tbFrukost, "bokstäver", "frukost");

            ValidationCheck.checkValidering(tbLunch, "bokstäver", "lunch");

            ValidationCheck.checkValidering(tbMiddag, "bokstäver", "middag");

            felmeddelanden = ValidationCheck.felString;

            if (felmeddelanden.Length > 0)
            {
                MessageBox.Show(f1 + felmeddelanden);
                ValidationCheck.felString = "";
                return;
            }
        }

        private void btnSkickaAnsokan_Click(object sender, EventArgs e)
        {
            validera();
        }
    }
}
