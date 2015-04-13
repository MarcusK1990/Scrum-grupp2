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
    }
}
