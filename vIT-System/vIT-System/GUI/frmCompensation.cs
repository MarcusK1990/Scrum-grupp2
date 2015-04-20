using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using vIT_System.Validering;
using vIT_System.XmlRelaterat;

namespace vIT_System.GUI {
    public partial class FrmCompensation : Form {
        public BindingList<Utgift> TotalOutPoison;
        public BindingList<Resa> AllaResor;
        public ApplicationMode.Mode CompMode { get; set; }

        public FrmCompensation(ApplicationMode.Mode inMode) {
            InitializeComponent();
            TotalOutPoison = new BindingList<Utgift>();
            AllaResor = new BindingList<Resa>();
            CompMode = inMode;

            lbUtgifter.DisplayMember = "VisaIListBox";
            lbUtgifter.ValueMember = "ValutaKurs";
            lbUtgifter.DataSource = TotalOutPoison;

            lbResa.DisplayMember = "VisaIListBox"; // "Resa till: " + Land + " Uppdrag: " + Uppdrag;
            lbResa.ValueMember = "TraktamenteFörLandet";
            lbResa.DataSource = AllaResor;

            }

        public FrmCompensation(string email, string namn, string efternamn, ApplicationMode.Mode inMode) {
            InitializeComponent();
            TotalOutPoison = new BindingList<Utgift>();
            tbEmail.Text = email;
            tbForNamn.Text = namn;
            tbEfterNamn.Text = efternamn;
            CompMode = inMode;

            TotalOutPoison = new BindingList<Utgift>();
            AllaResor = new BindingList<Resa>();

            lbUtgifter.DisplayMember = "VisaIListBox";
            lbUtgifter.ValueMember = "ValutaKurs";
            lbUtgifter.DataSource = TotalOutPoison;

            lbResa.DisplayMember = "VisaIListBox";
            lbResa.ValueMember = "TraktamenteFörLandet";
            lbResa.DataSource = AllaResor;
            }

        private void HämtaLänder() {
            var länder = Traktamentestabell.Traktamentestabell.HämtaLänderOchBelopp();

            //cbLand.Items.Clear();

            //for (var i = 0 ; i < länder.GetLength(0) ; i++) {
            //    //System.Diagnostics.Debug.WriteLine(länder[i, 0] + " + " + länder[i, 1]);
            //    cbLand.Items.Add(new ComboboxItem { Text = länder[i, 0], Value = Convert.ToDouble(länder[i, 1]) });
            //    }

            //cbLand.SelectedIndex = 0;
            }

        private bool ValideraVidSpara() {
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

            var felmeddelanden = ValidationCheck.felString;

            if (felmeddelanden.Length <= 0) {
                return true;
                }

            MessageBox.Show(string.Format(@"Följande fel har uppstått: {0}", felmeddelanden));
            ValidationCheck.felString = "";
            return false;
            }

        private void LaddaComboBox(){


            var frånstringtilldecimaltilldoubleUsd = TestaValutaOmvandlare.KonverteraTillFrån("SEK", "USD", "1");
            var frånstringtilldecimaltilldoubleEur = TestaValutaOmvandlare.KonverteraTillFrån("SEK", "EUR", "1");

            var sek = new ComboboxItem {
                Text = "SEK",
                Value = 1
            };
            var dollarinos = new ComboboxItem {
                Text = "USD",
                Value = frånstringtilldecimaltilldoubleUsd
            };
            var evro = new ComboboxItem {
                Text = "EUR",
                Value = frånstringtilldecimaltilldoubleEur
            };

            cbValuta.Items.Add(sek);
            cbValuta.Items.Add(dollarinos);
            cbValuta.Items.Add(evro);

            cbValuta.SelectedIndex = 0;
            }


       
        public void UppdateraTotalSumma() {
            //for (var i = 0 ; i < TotalOutPoison.Count ; i++) {
            //    total += TotalOutPoison[i].belopp;
            //    }
            var total = TotalOutPoison.Sum(t => t.Belopp);

            labelTotal.Text = total.ToString(CultureInfo.InvariantCulture);
            }
        private void btnUtgiter_Click(object sender, EventArgs e) {
            double parsedBelopp;
            double.TryParse(tbBelopp.Text, out parsedBelopp);

            ValidationCheck.checkValidering(tbBelopp, "tom", "belopp");
            ValidationCheck.checkValidering(tbBelopp, "bokstäver", "belopp");
            ValidationCheck.checkValidering(tbBelopp, "längre255", "belopp");

            ValidationCheck.checkValidering(tbAndaMal, "tom", "ändamål");
            ValidationCheck.checkValidering(tbAndaMal, "längre255", "ändamål");
            ValidationCheck.checkValidering(tbAndaMal, "siffor", "ändamål");

            var felmeddelanden = ValidationCheck.felString;

            if (felmeddelanden.Length > 0) {
                MessageBox.Show(string.Format(@"Följande fel har uppstått: {0}", felmeddelanden));
                ValidationCheck.felString = "";
                return;
                }
            // double parsadValutakursdouble = 0;
            // var selectedValue = cbValuta.Items[1].ToString();

            var valtItem = (ComboboxItem)cbValuta.SelectedItem;
            var valtItemDouble = Convert.ToDouble(valtItem.Value);
            var valtItemText = Convert.ToString(valtItem.Text);

            //Double.TryParse(cbValuta.SelectedValue.ToString(), out parsadValutakursdouble);
            var nyUtgift = new Utgift {
                Belopp = parsedBelopp,
                AndaMal = tbAndaMal.Text,
                Valuta = valtItemText,
                ValutaKurs = valtItemDouble,   //parsadValutakursdouble,
                Moms = 2 // % eller ?!?!?!        
            };

            TotalOutPoison.Add(nyUtgift);

            UppdateraTotalSumma();
            }

        private void btnSparaUtkast_Click(object sender, EventArgs e) {
            var äcksämäll = new Xmelliserare(@"C:\dump\xmlCompensationModel.xml");

            if (!ValideraVidSpara()) {
                return;
                }

            var utkast = new CompensationModel {
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

        private void frmCompensation_Load(object sender, EventArgs e) {
            if (CompMode == ApplicationMode.Mode.OFFLINE) {
                tbEmail.Enabled = true;
                tbForNamn.Enabled = true;
                tbEfterNamn.Enabled = true;
                }
            LaddaComboBox();
            HämtaLänder();
            }

        private void btnLaddaUtkast_Click(object sender, EventArgs e) {
            var äcksämäll = new Xmelliserare(@"C:\dump\xmlCompensationModel.xml");
            var utkast = äcksämäll.LaddaUtkast();

            tbEmail.Text = utkast.eMail;
            tbForNamn.Text = utkast.forNamn;
            tbEfterNamn.Text = utkast.eftNamn;
            tbMilErsattning.Text = utkast.milErsattning.ToString(CultureInfo.InvariantCulture);
            // Bild nånting hur fan man nu gör det
            TotalOutPoison = utkast.Utgifter;
            AllaResor = utkast.Resor;
            }



        private void btnSkickaAnsokan_Click(object sender, EventArgs e) {
            if (!ValideraVidSpara()) { }
            //det som ska sparas i db
            }

        private void btnLaggTillResa_Click(object sender, EventArgs e) {

            ValidationCheck.checkValidering(tbSemesterdagar, "tom", "semesterdagar");
            ValidationCheck.checkValidering(tbSemesterdagar, "InnehållerBokstav", "semesterdagar");
            ValidationCheck.checkValidering(tbSemesterdagar, "längre255", "semesterdagar");

            ValidationCheck.checkValidering(tbFrukost, "InnehållerBokstav", "frukost");
            ValidationCheck.checkValidering(tbLunch, "InnehållerBokstav", "lunch");
            ValidationCheck.checkValidering(tbMiddag, "InnehållerBokstav", "middag");

            var felmeddelanden = ValidationCheck.felString;

            if (felmeddelanden.Length > 0) {
                MessageBox.Show(string.Format(@"Följande fel har uppstått: {0}", felmeddelanden));
                ValidationCheck.felString = "";
                return;
                }

            var valtItem = (ComboboxItem)cbLand.SelectedItem;
            var valtTraktamenteFörLandet = Convert.ToDouble(valtItem.Value);
            var valtLand = Convert.ToString(valtItem.Text);

            //Double.TryParse(cbValuta.SelectedValue.ToString(), out parsadValutakursdouble);
            var nyResa = new Resa {
                UtResa = dtpUtResa.Value.ToString("yyyy-MM-dd"),
                HemResa = dtpHemResa.Value.ToString("yyyy-MM-dd"),
                Land = valtLand,
                SemesterDagar = tbSemesterdagar.Text,
                TraktamenteFörLandet = valtTraktamenteFörLandet
            };

            //var middagar = Convert.ToInt32(tbMiddag.Text);
            //var resa = new Resa {TraktamenteEfterAvdrag = middagar * nyResa.TraktamenteFörLandet};

            AllaResor.Add(nyResa);
            }

        private void button1_Click(object sender, EventArgs e) {

            if (string.IsNullOrEmpty(tbBelopp.Text) || string.IsNullOrEmpty(tbAndaMal.Text) || string.IsNullOrEmpty(cbValuta.Text))
            {
                MessageBox.Show("Fyll i alla fälten");
            }
            
            else
            {
                var fDialog = new OpenFileDialog();

                var exeLocation = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
                // ReSharper disable once UnusedVariable
                var exeDir = System.IO.Path.GetDirectoryName(exeLocation);

                if (fDialog.ShowDialog() != DialogResult.OK)

                    return;

                var fInfo = new System.IO.FileInfo(fDialog.FileName);

                var strFileName = fInfo.Name;

                var strFilePath = fInfo.DirectoryName;

                var fullpath = strFilePath + @"\" + strFileName;

                //MessageBox.Show(strFilePath);

                var exist = System.IO.Directory.Exists(Application.StartupPath + "\\Images\\");

                if (!exist)
                {
                    System.IO.Directory.CreateDirectory(Application.StartupPath + "\\Images\\");
                }

                System.IO.File.Copy(fullpath, Application.StartupPath + "\\Images\\" + strFileName);

                //// Sökväg som skall sparas i databasen (kvitto)
                //string NewFullpath = Application.StartupPath + "\\Images\\" + strFileName;
                //MessageBox.Show(NewFullpath);
            }
            }

        private void button1_Click_1(object sender, EventArgs e){

            var valtItem = (ComboboxItem)cbValuta.SelectedItem;
            var valutakurs = Convert.ToDouble(valtItem.Value);
            var valuta = valtItem.Text;

            var belopp = Convert.ToDouble(tbBelopp.Text);

            var resultat = valutakurs*belopp;

            var asd = new Utgift {
                Belopp = belopp, 
                AndaMal = "Testar", 
                Valuta = valuta, 
                ValutaKurs = valutakurs, 
                Konverterad = resultat.ToString(CultureInfo.InvariantCulture)
            };
            TotalOutPoison.Add(asd);
            MessageBox.Show(resultat.ToString(CultureInfo.InvariantCulture));

        }
        }
    }
