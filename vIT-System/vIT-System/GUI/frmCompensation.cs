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
                
        public frmCompensation()
        {
            InitializeComponent();
            totalOutpoison = new List<Utgift>();

        }
        public frmCompensation(string email, string namn, string efternamn)
        {
            InitializeComponent();
            totalOutpoison = new List<Utgift>();
            tbEmail.Text = email;
            tbForNamn.Text = namn;
            tbEfterNamn.Text = efternamn;
            
        
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
            var nyUtgift = new Utgift
            {
                belopp = parsedBelopp,
                andaMal = tbAndaMal.Text,
                valuta = "SEK",
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
            checkValidering();
            var äcksämäll = new Xmelliserare();
            
            var utkast = new CompensationModel
            {
                eMail = tbEmail.Text,
                forNamn = tbForNamn.Text,
                eftNamn = tbEfterNamn.Text,
                //Bild nånting hur fan man nu gör det
                milErsattning = Convert.ToInt32(tbMilErsattning.Text),
                utresa = dtpUtResa.Value,
                hemresa = dtpHemResa.Value,
                semesterDagar = tbSemesterdagar.Text,
                land = cbLand.SelectedItem.ToString(),
                frukost = Convert.ToInt32(tbFrukost.Text),
                lunch = Convert.ToInt32(tbLunch.Text),
                middag = Convert.ToInt32(tbMiddag.Text),
                utgifter = totalOutpoison
            };
            
            äcksämäll.SkrivXmlCompensationModel(utkast);

            var asd = new CompensationModel(totalOutpoison);
            Console.WriteLine("TotalOutpoison Count: " + totalOutpoison.Count);
            Console.WriteLine("asd listan Count: " + asd.utgifter.Count);

        }

        private void checkValidering()
        {
            Boolean fel = false;
            string felMedelande = "Följande fel har uppstått: \n";

            if (Validation.IsEmpty(tbEmail.Text))
            {
                fel = true;
                felMedelande += "\n• Fältet för Email är tomt.";
            }
            if (Validation.IsEmailAddress(tbEmail.Text))
            {
                fel = true;
                felMedelande += "\n• Fältet för Email är inte i rätt format.";
            }
            if (Validation.IsLongerThan(tbEmail.Text, 255))
            {
                fel = true;
                felMedelande += "\n• Fältet för Email innehåller för många tecken.";
            }
            if (Validation.IsEmpty(tbForNamn.Text))
            {
                fel = true;
                felMedelande += "\n• Fältet för förnamn är tomt.";
            }
            if (Validation.IsNumeric(tbForNamn.Text))
            {
                fel = true;
                felMedelande += "\n• Fältet för förnamn innehåller siffror.";
            }
            if (Validation.IsLongerThan(tbForNamn.Text, 255))
            {
                fel = true;
                felMedelande += "\n• Fältet för förnamn innehåller för många tecken.";
            }
            if (Validation.IsEmpty(tbEfterNamn.Text))
            {
                fel = true;
                felMedelande += "\n• Fältet för efternamn är tomt.";
            }
            if (Validation.IsNumeric(tbEfterNamn.Text))
            {
                fel = true;
                felMedelande += "\n• Fältet för efternamn innehåller siffror.";
            }
            if (Validation.IsLongerThan(tbEfterNamn.Text, 255))
            {
                fel = true;
                felMedelande += "\n• Fältet för efternamn innehåller för många tecken.";
            }
            if (fel)
            {
                MessageBox.Show(felMedelande);
            }

            

            // Önskedrömmen -->
            //ValidationCheck.checkValidering(tbEfterNamn, "tom", "siffror", "längre", "efternamn");

           
           
        }

        private void frmCompensation_Load(object sender, EventArgs e)
        {
            tbEmail.Enabled = true;
            tbForNamn.Enabled = true;
            tbEfterNamn.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var felmeddelanden = "";
            var f1 = "Följande fel har uppstått: \n";
            ValidationCheck.checkValidering(tbEfterNamn, "tom", "efternamn");
            ValidationCheck.checkValidering(tbEfterNamn, "längre", "efternamn");
            ValidationCheck.checkValidering(tbEfterNamn, "siffor", "efternamn");

            ValidationCheck.checkValidering(tbForNamn, "tom", "förnamn");
            ValidationCheck.checkValidering(tbForNamn, "längre", "förnamn");
            ValidationCheck.checkValidering(tbForNamn, "siffor", "förnamn");

            ValidationCheck.checkValidering(tbEmail, "tom", "email");
            ValidationCheck.checkValidering(tbEmail, "längre", "email");
            ValidationCheck.checkValidering(tbEmail, "email", "email");

            felmeddelanden = ValidationCheck.rickardsträng;
            MessageBox.Show(f1 + felmeddelanden);
        }
    }
}
