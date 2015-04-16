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
using System.Windows;

namespace vIT_System.Reseansökning
{
    public partial class frmCompensation : Form
    {
        public BindingList<Utgift> TotalOutPoison;
        public BindingList<Resa> AllaResor;
        public ApplicationMode.Mode CompMode { get; set; }

        public frmCompensation(ApplicationMode.Mode inMode)
        {
            InitializeComponent();
            TotalOutPoison = new BindingList<Utgift>();
            AllaResor = new BindingList<Resa>();
            CompMode = inMode;
            TotalOutPoison.Add(new Utgift() { valuta = "test", valutaKurs = 1, andaMal = "test utgift." });
            
            lbUtgifter.DisplayMember = "andaMal";
            lbUtgifter.ValueMember = "valutaKurs";
            lbUtgifter.DataSource = TotalOutPoison;

            lbResa.DisplayMember = "Resa till: " + "Land";
            lbResa.ValueMember = "TraktamenteFörLandet";
            lbResa.DataSource = AllaResor;

        }

        public frmCompensation(string email, string namn, string efternamn, ApplicationMode.Mode inMode)
        {
            InitializeComponent();
            TotalOutPoison = new BindingList<Utgift>();
            tbEmail.Text = email;
            tbForNamn.Text = namn;
            tbEfterNamn.Text = efternamn;
            CompMode = inMode;

            TotalOutPoison = new BindingList<Utgift>();
            AllaResor = new BindingList<Resa>();
            TotalOutPoison.Add(new Utgift() { valuta = "test", valutaKurs = 1, andaMal = "test utgift." });

            lbUtgifter.DisplayMember = "andaMal";
            lbUtgifter.ValueMember = "valutaKurs";
            lbUtgifter.DataSource = TotalOutPoison;

            lbResa.DisplayMember = "Resa till: " + "Land";
            lbResa.ValueMember = "TraktamenteFörLandet";
            lbResa.DataSource = AllaResor;
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

        //private void button1_Click(object sender, EventArgs e)
        //{

        //}



        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fDialog = new OpenFileDialog();

            String exeLocation = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
            string exeDir = System.IO.Path.GetDirectoryName(exeLocation);

            if (fDialog.ShowDialog() != DialogResult.OK)

                return;

            System.IO.FileInfo fInfo = new System.IO.FileInfo(fDialog.FileName);

            string strFileName = fInfo.Name;

            string strFilePath = fInfo.DirectoryName;

            string fullpath = strFilePath + @"\" + strFileName;

            //MessageBox.Show(strFilePath);

            bool exist = System.IO.Directory.Exists(Application.StartupPath + "\\Images\\");

            if(!exist)
            {
                System.IO.Directory.CreateDirectory(Application.StartupPath + "\\Images\\");
            }

            System.IO.File.Copy(fullpath, Application.StartupPath + "\\Images\\" + strFileName);

            //// Sökväg som skall sparas i databasen (kvitto)
            //string NewFullpath = Application.StartupPath + "\\Images\\" + strFileName;
            //MessageBox.Show(NewFullpath);


        }

        private void btnUtgiter_Click(object sender, EventArgs e)
        {
            double parsedBelopp = 0;
            double.TryParse(tbBelopp.Text, out parsedBelopp);

            var felmeddelanden = "";

            ValidationCheck.checkValidering(tbBelopp, "tom", "belopp");
            ValidationCheck.checkValidering(tbBelopp, "bokstäver", "belopp");
            ValidationCheck.checkValidering(tbBelopp, "längre255", "belopp");

            ValidationCheck.checkValidering(tbAndaMal, "tom", "ändamål");
            ValidationCheck.checkValidering(tbAndaMal, "längre255", "ändamål");
            ValidationCheck.checkValidering(tbAndaMal, "siffor", "ändamål");

            felmeddelanden = ValidationCheck.felString;

            if (felmeddelanden.Length > 0)
            {
                MessageBox.Show("Följande fel har uppstått: \n" + felmeddelanden);
                ValidationCheck.felString = "";
                return;
            }
           // double parsadValutakursdouble = 0;
           // var selectedValue = cbValuta.Items[1].ToString();

            var valtItem = (ComboboxItem)cbValuta.SelectedItem;
            var valtItemDouble = Convert.ToDouble(valtItem.Value);
            var valtItemText = Convert.ToString(valtItem.Text);
            
            //Double.TryParse(cbValuta.SelectedValue.ToString(), out parsadValutakursdouble);
            var nyUtgift = new Utgift
            {
                belopp = parsedBelopp,
                andaMal = tbAndaMal.Text,
                valuta = valtItemText,
                valutaKurs = valtItemDouble,   //parsadValutakursdouble,
                moms = 2 // % eller ?!?!?!        
            };

            TotalOutPoison.Add(nyUtgift);
            
            UppdateraTotalSumma();
        }

        public void UppdateraTotalSumma()
        {
            //var total = totalOutpoison.Aggregate<utgift, double>(0, (current, t) => current + t.belopp);
            //labelTotal.Text = total.ToString();

            double total = 0;

            for (var i = 0; i < TotalOutPoison.Count; i++)
            {
                total += TotalOutPoison[i].belopp;
            }

            labelTotal.Text = total.ToString();
        }

        private void btnSparaUtkast_Click(object sender, EventArgs e)
        {
            var äcksämäll = new Xmelliserare(@"C:\dump\xmlCompensationModel.xml");

            if (!ValideraVidSpara())
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
                ÄndraISparadAnsökan = tbÄndraISparatForumlär.Text,
                Utgifter = TotalOutPoison,
                Resor = AllaResor
            };

            äcksämäll.SkrivCompensationModel(utkast);


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
            tbMilErsattning.Text = utkast.milErsattning.ToString();
            // Bild nånting hur fan man nu gör det
            TotalOutPoison = utkast.Utgifter;
            AllaResor = utkast.Resor;
        }

        private bool ValideraVidSpara()
        {
            var felmeddelanden = "";

            ValidationCheck.checkValidering(tbEfterNamn, "tom", "efternamn");
            ValidationCheck.checkValidering(tbEfterNamn, "längre255", "efternamn");
            ValidationCheck.checkValidering(tbEfterNamn, "innehållerInt", "efternamn");

            ValidationCheck.checkValidering(tbForNamn, "tom", "förnamn");
            ValidationCheck.checkValidering(tbForNamn, "längre255", "förnamn");       
            ValidationCheck.checkValidering(tbForNamn, "innehållerInt", "förnamn");

            ValidationCheck.checkValidering(tbEmail, "tom", "email");
            ValidationCheck.checkValidering(tbEmail, "längre255", "email");
            ValidationCheck.checkValidering(tbEmail, "email", "email");

            ValidationCheck.checkValidering(tbMilErsattning, "InnehållerBokstav", "milersättning");
                    
            felmeddelanden = ValidationCheck.felString;

            if (felmeddelanden.Length <= 0)
            {
                return true;
            }

            MessageBox.Show("Följande fel har uppstått: \n" + felmeddelanden);
            ValidationCheck.felString = "";
            return false;
        }

        private void btnSkickaAnsokan_Click(object sender, EventArgs e)
        {
            if (!ValideraVidSpara())
            {
                return;
            }
            //det som ska sparas i db
        }

        private void hämtaLänder()
        {
            string[,] länder = vIT_System.Traktamentestabell.Traktamentestabell.HämtaLänderOchBelopp();

            cbLand.Items.Clear();

            for (int i = 0; i < länder.GetLength(0); i++)
            {
                //System.Diagnostics.Debug.WriteLine(länder[i, 0] + " + " + länder[i, 1]);
                cbLand.Items.Add(new ComboboxItem { Text = länder[i, 0], Value = Convert.ToDouble(länder[i, 1]) });
            }

            cbLand.SelectedIndex = 0;
        }

        private void btnLaggTillResa_Click(object sender, EventArgs e)
        {

            ValidationCheck.checkValidering(tbSemesterdagar, "tom", "semesterdagar");
            ValidationCheck.checkValidering(tbSemesterdagar, "InnehållerBokstav", "semesterdagar");
            ValidationCheck.checkValidering(tbSemesterdagar, "längre255", "semesterdagar");

            ValidationCheck.checkValidering(tbFrukost, "InnehållerBokstav", "frukost");
            ValidationCheck.checkValidering(tbLunch, "InnehållerBokstav", "lunch");
            ValidationCheck.checkValidering(tbMiddag, "InnehållerBokstav", "middag");

            var felmeddelanden = ValidationCheck.felString;

            if (felmeddelanden.Length > 0)
            {
                MessageBox.Show("Följande fel har uppstått: \n" + felmeddelanden);
                ValidationCheck.felString = "";
                return;
            }
           // double parsadValutakursdouble = 0;
           // var selectedValue = cbValuta.Items[1].ToString();

            var valtItem = (ComboboxItem)cbLand.SelectedItem;
            var valtTraktamenteFörLandet = Convert.ToDouble(valtItem.Value);
            var valtLand = Convert.ToString(valtItem.Text);
            
            //Double.TryParse(cbValuta.SelectedValue.ToString(), out parsadValutakursdouble);
            var nyResa = new Resa
            {
                UtResa = dtpUtResa.Value.ToString("yyyy-MM-dd"),
                HemResa = dtpHemResa.Value.ToString("yyyy-MM-dd"),
                Land = valtLand,
                SemesterDagar = tbSemesterdagar.Text,
                TraktamenteFörLandet = 23                
            };

            //var middagar = Convert.ToInt32(tbMiddag.Text);
            //var resa = new Resa {TraktamenteEfterAvdrag = middagar * nyResa.TraktamenteFörLandet};

            AllaResor.Add(nyResa);          
        

        }
    }
}
