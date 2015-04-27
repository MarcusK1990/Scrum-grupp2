using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using vIT_System.Data;
using vIT_System.Validering;
using vIT_System.XmlRelaterat;

namespace vIT_System.GUI
{
    public partial class FrmCompensation : Form
    {
        public BindingList<Resa> AllaResor;
        public int ValdResa { get; set; }
        public ApplicationMode.Mode CompMode { get; set; }

        public FrmCompensation(ApplicationMode.Mode inMode)
        {
            InitializeComponent();
            AllaResor = new BindingList<Resa>();

            CompMode = inMode;

            lbUtgifter.DisplayMember = "VisaValutaIListBox";
            lbUtgifter.ValueMember = "ValutaKurs";

            lbResa.DisplayMember = "VisaResaIListBox";
            lbResa.ValueMember = "TraktamenteFörLandet";
            lbResa.DataSource = AllaResor;

        }

        public FrmCompensation(string email, string namn, string efternamn, ApplicationMode.Mode inMode)
        {
            InitializeComponent();
            tbEmail.Text = email;
            tbForNamn.Text = namn;
            tbEfterNamn.Text = efternamn;
            CompMode = inMode;

            AllaResor = new BindingList<Resa>();

            lbUtgifter.DisplayMember = "VisaValutaIListBox";
            lbUtgifter.ValueMember = "ValutaKurs";

            lbResa.DisplayMember = "VisaResaIListBox";
            lbResa.ValueMember = "TraktamenteFörLandet";
            lbResa.DataSource = AllaResor;
        }

        private void frmCompensation_Load(object sender, EventArgs e)
        {
            //Skapa en ny ansökan
            var ansId = DataCompensation.newCompensationfrm(1);
            lblAnsID.Text = ansId.ToString(CultureInfo.InvariantCulture);
            HämtaLänder();


            if (CompMode == ApplicationMode.Mode.OFFLINE)
            {
                tbEmail.Enabled = true;
                tbForNamn.Enabled = true;
                tbEfterNamn.Enabled = true;
                lblValutaKurs.Text = "Valutakurs kunde inte uppdateras.";
                cbUppdrag.Items.Add(new ComboboxItem { Text = "Test", Value = 1 });
                //LaddaValutaOffline(); en ide!
                LaddaValuta();
            }
            else
            {
                LaddaUppdrag();
                LaddaValuta();
                lblValutaKurs.Text = @"Senaste valutakurs: " + DateTime.Now;
            }
        }

        private void HämtaLänder()
        {
            var länder = Traktamentestabell.Traktamentestabell.HämtaLänderOchBelopp();

            cbLand.Items.Clear();

            for (var i = 0; i < länder.GetLength(0); i++)
            {
                System.Diagnostics.Debug.WriteLine(länder[i, 0] + " + " + länder[i, 1]);

                cbLand.Items.Add(new ComboboxItem { Text = länder[i, 0], Value = Convert.ToDouble(länder[i, 1]) });
            }

            cbLand.SelectedIndex = 0;
        }

        private bool ValideraVidSparaUtkast()
        {
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
            ValidationCheck.checkValidering(tbMilErsattning, "tom", "milersättning");
            ValidationCheck.checkValidering(tbMilErsattning, "NegativaTal", "milersättning");

            var felmeddelanden = ValidationCheck.felString;

            if (felmeddelanden.Length <= 0)
            {
                return true;
            }

            MessageBox.Show(string.Format(@"Följande fel har uppstått: {0}", felmeddelanden));
            ValidationCheck.felString = "";
            return false;
        }

        private static bool Ping(){
            var ping = new Ping();

            try{
                var result = ping.Send("www.finance.yahoo.com");
                return result != null && result.Status == IPStatus.Success;
            }
            catch (Exception ex){
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        private void LaddaValuta()
        {

            double frånstringtilldecimaltilldoubleUsd = 0;
            double frånstringtilldecimaltilldoubleEur = 0;

            if (CompMode == ApplicationMode.Mode.STANDARD){
            if (Ping())
            {
                frånstringtilldecimaltilldoubleUsd = ValutaOmvandlare.KonverteraTillFrån("SEK", "USD", "1");
                frånstringtilldecimaltilldoubleEur = ValutaOmvandlare.KonverteraTillFrån("SEK", "EUR", "1");

            var dollarinos = new ComboboxItem
            {
                Text = "USD",
                Value = frånstringtilldecimaltilldoubleUsd
            };

            var evro = new ComboboxItem
            {
                Text = "EUR",
                Value = frånstringtilldecimaltilldoubleEur
            };

            cbValuta.Items.Add(dollarinos);
            cbValuta.Items.Add(evro);
                }
                else
                {
                    MessageBox.Show(@"Kunde inte hämta senaste valutakurserna");
                }
            }

            var sek = new ComboboxItem
            {
                Text = "SEK",
                Value = 1
            };
           

            cbValuta.Items.Add(sek);
            

            cbValuta.SelectedIndex = 0;
        }

        private void LaddaUppdrag()
        {

            //MessageBox.Show(@"Nu ska vi ha hämtat uppdrag från databasen, men David vågar inte skriva SQL");
            // var allaUppdrag = Uppdrag.All(x => x.Namn); ???
            const string query = "select namn from uppdrag";
            var path = Helpers.getSourcePath();
            var sqldb = new SqlConnection(path);
            var sqlC = new SqlCommand(query, sqldb);
            try
            {
                sqldb.Open();
                var myReader = sqlC.ExecuteReader();
                while (myReader.Read())
                {
                    var namn = myReader.GetString(0);
                    cbUppdrag.Items.Add(namn);
                }
                sqldb.Close();
                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void UppdateraTotalSumma()
        {

            double total = 0;
            //foreach (var utgifter in AllaResor)
            //{
            //    total = utgifter.UtgifterFörResa.Sum(x => x.Belopp);
            //}
            total = AllaResor[ValdResa].UtgifterFörResa.Sum(x => x.Konverterad);


            labelTotal.Text = total.ToString(CultureInfo.InvariantCulture);
        }

        private void btnUtgiter_Click(object sender, EventArgs e)
        {
            double parsedBelopp;
            double.TryParse(tbBelopp.Text, out parsedBelopp);


            ValidationCheck.checkValidering(tbBelopp, "tom", "belopp");
            ValidationCheck.checkValidering(tbBelopp, "bokstäver", "belopp");
            ValidationCheck.checkValidering(tbBelopp, "längre255", "belopp");
            ValidationCheck.checkValidering(tbBelopp, "NegativaTal", "belopp");

            ValidationCheck.checkValidering(tbAndaMal, "tom", "ändamål");
            ValidationCheck.checkValidering(tbAndaMal, "längre255", "ändamål");
            ValidationCheck.checkValidering(tbAndaMal, "siffor", "ändamål");

            var felmeddelanden = ValidationCheck.felString;

            if (felmeddelanden.Length > 0)
            {
                MessageBox.Show(string.Format(@"Följande fel har uppstått: {0}", felmeddelanden));
                ValidationCheck.felString = "";
                return;
            }

            var valtItem = (ComboboxItem)cbValuta.SelectedItem;
            var valtItemValutaKurs = Convert.ToDouble(valtItem.Value);
            var valtItemValutaNamn = Convert.ToString(valtItem.Text);

            double konverterad = 0;
            if (valtItemValutaNamn == "SEK"){
                konverterad = parsedBelopp;
            }
            else if (valtItemValutaNamn == "USD"){
                konverterad = parsedBelopp * valtItemValutaKurs;
            }
            else if (valtItemValutaNamn == "EUR")
            {
                konverterad = parsedBelopp * valtItemValutaKurs;
            }

            var nyUtgift = new Utgift
            {
                Belopp = parsedBelopp,
                AndaMal = tbAndaMal.Text,
                Valuta = valtItemValutaNamn,
                ValutaKurs = valtItemValutaKurs,
                Moms = 2,  // vi vet fortfarande inte varför vi har moms här. Det är en relik från en svunnen tid. 
                Konverterad = konverterad 
                
            };

            AllaResor[ValdResa].UtgifterFörResa.Add(nyUtgift);

            UppdateraTotalSumma();
        }

        private void btnSparaUtkast_Click(object sender, EventArgs e)
        {
            var äcksämäll = new Xmelliserare(@"C:\dump\Ansökan.xml");
            const string dumpPath = @"C:\dump";

            bool exists = System.IO.Directory.Exists(dumpPath);

            if (!exists)
            {
                System.IO.Directory.CreateDirectory(dumpPath);
            }

            if (!ValideraVidSparaUtkast())
            {
                return;
            }

            var utkast = new CompensationModel
            {
                eMail = tbEmail.Text,
                forNamn = tbForNamn.Text,
                eftNamn = tbEfterNamn.Text,
                Kvitto = tbKvitto.Text,
                milErsattning = Convert.ToInt32(tbMilErsattning.Text),
                Resor = AllaResor
            };
            äcksämäll.SkrivCompensationModel(utkast);
        }

        private void btnLaddaUtkast_Click(object sender, EventArgs e)
        {
            var äcksämäll = new Xmelliserare(@"C:\dump\Ansökan.xml");
            var utkast = äcksämäll.LaddaUtkast();

            tbEmail.Text = utkast.eMail;
            tbForNamn.Text = utkast.forNamn;
            tbEfterNamn.Text = utkast.eftNamn;
            tbMilErsattning.Text = utkast.milErsattning.ToString(CultureInfo.InvariantCulture);
            AllaResor = utkast.Resor;
            lbResa.DataSource = AllaResor;

        }



        private void btnSkickaAnsokan_Click(object sender, EventArgs e)
        {
            if (!ValideraVidSparaUtkast())
            {
                
            }
            //det som ska sparas i db
        }

        private bool ValideraVidLaggTillResa()
        {
            ValidationCheck.checkValidering(tbSemesterdagar, "InnehållerBokstav", "semesterdagar");
            ValidationCheck.checkValidering(tbSemesterdagar, "längre255", "semesterdagar");
            ValidationCheck.checkValidering(tbSemesterdagar, "NegativaTal", "semesterdagar");

            ValidationCheck.checkValidering(tbFrukost, "InnehållerBokstav", "frukost");
            ValidationCheck.checkValidering(tbFrukost, "NegativaTal", "frukost");
            ValidationCheck.checkValidering(tbLunch, "InnehållerBokstav", "lunch");
            ValidationCheck.checkValidering(tbLunch, "NegativaTal", "lunch");
            ValidationCheck.checkValidering(tbMiddag, "InnehållerBokstav", "middag");
            ValidationCheck.checkValidering(tbMiddag, "NegativaTal", "middag");
            ValidationCheck.CheckDates(dtpUtResa.Value, dtpHemResa.Value);



            var felmeddelanden = ValidationCheck.felString;

            if (felmeddelanden.Length > 0)
            {
                MessageBox.Show(string.Format(@"Följande fel har uppstått: {0}", felmeddelanden));
                ValidationCheck.felString = "";
                return false;
            }
            return true;
        }

        private void btnLaggTillResa_Click(object sender, EventArgs e)
        {
            if (!ValideraVidLaggTillResa())
            {
                return;
            }

            if (Validation.IsEmpty(tbSemesterdagar.Text))
            {
                tbSemesterdagar.Text = "0";
            }

            if (Validation.IsEmpty(tbFrukost.Text))
            {
                tbFrukost.Text = "0";
            }

            if (Validation.IsEmpty(tbMiddag.Text))
            {
                tbMiddag.Text = "0";
            }

            if (Validation.IsEmpty(tbLunch.Text))
            {
                tbLunch.Text = "0";
            }

            var valtItem = (ComboboxItem)cbLand.SelectedItem;
            var valtTraktamenteFörLandet = Convert.ToDouble(valtItem.Value);
            var valtLand = Convert.ToString(valtItem.Text);

            var nyResa = new Resa
            {
                UtResa = dtpUtResa.Value,
                HemResa = dtpHemResa.Value,
                Land = valtLand,
                SemesterDagar = tbSemesterdagar.Text,
                TraktamenteFörLandet = valtTraktamenteFörLandet,
                AntalMiddag = 0,//Convert.ToInt32(tbMiddag.Text),
                AntalFrukost = 0, //Convert.ToInt32(tbFrukost.Text),
                AntalLunch = 0,//Convert.ToInt32(tbLunch.Text),
                Uppdrag = "Hej",
                UtgifterFörResa = new List<Utgift>()
            };

            var frukostförresa = 0.0;
            double middagförresa = 0;
            double lunchförresa = 0;
            // lokaltraktamenteFörLandet = nyREsa.TraktamenteFörlandet;
            if (Validation.IsNumeric(tbFrukost.Text))
            {
                var antalFrukost = Convert.ToDouble(tbFrukost.Text);
                frukostförresa = (nyResa.TraktamenteFörLandet * 0.15) * antalFrukost;
            }

            if (Validation.IsNumeric(tbMiddag.Text))
            {
                var antalMiddag = Convert.ToDouble(tbMiddag.Text);
                middagförresa = (nyResa.TraktamenteFörLandet * 0.35) * antalMiddag;
            }

            if (Validation.IsNumeric(tbLunch.Text))
            {
                var antalLunch = Convert.ToDouble(tbLunch.Text);
                lunchförresa = (nyResa.TraktamenteFörLandet * 0.35) * antalLunch;
            }

                var totaltAvdragFrånTraktamente = frukostförresa + middagförresa + lunchförresa;

                var antalDagarBortrest = nyResa.UtResa - nyResa.HemResa;

                double dagarBortrestString = 0;
                if (antalDagarBortrest.TotalDays < 0)
                {
                    dagarBortrestString = antalDagarBortrest.TotalDays * -1;
                }
                var totalaDagarBortrestAvrundatUppåt = Math.Ceiling(dagarBortrestString);
                var betalningsBerättigadeDagar = totalaDagarBortrestAvrundatUppåt -
                                                 Convert.ToDouble(tbSemesterdagar.Text);

                var totalUtbetalning = (betalningsBerättigadeDagar * nyResa.TraktamenteFörLandet) -
                                       totaltAvdragFrånTraktamente;
                nyResa.TraktamenteEfterAvdrag = totalUtbetalning;


                tbTotalTraktamentesUtbetalning.Text = totalUtbetalning.ToString(CultureInfo.InvariantCulture);
                tbTotalTraktamenteDagar.Text = betalningsBerättigadeDagar.ToString(CultureInfo.InvariantCulture);

                tbMiddag.Text = "";
                tbLunch.Text = "";
                tbFrukost.Text = "";
                tbSemesterdagar.Text = "";
                dtpHemResa.ResetText();
                dtpUtResa.ResetText();

                AllaResor.Add(nyResa);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbBelopp.Text) || string.IsNullOrEmpty(tbAndaMal.Text) || string.IsNullOrEmpty(cbValuta.Text))
            {
                MessageBox.Show(@"Fyll i alla fälten för utgifter");
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

                var exist = System.IO.Directory.Exists(Application.StartupPath + "\\Images\\");

                if (!exist)
                {
                    System.IO.Directory.CreateDirectory(Application.StartupPath + "\\Images\\");
                }

                var newFullpath = Application.StartupPath + "\\Images\\" + strFileName;

                System.IO.File.Copy(fullpath, newFullpath);

                tbKvitto.AppendText(newFullpath);
                MessageBox.Show(@"Kvittot tillagt");


            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            var valtItem = (ComboboxItem)cbValuta.SelectedItem;
            var valutakurs = Convert.ToDouble(valtItem.Value);

            var belopp = Convert.ToDouble(tbBelopp.Text);

            var resultat = valutakurs * belopp;
            
            //TotalOutPoison.Add(asd);
            MessageBox.Show(resultat.ToString(CultureInfo.InvariantCulture));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var hämtadResa = (Resa)lbResa.SelectedItem;

            dtpHemResa.Value = hämtadResa.HemResa;
            dtpUtResa.Value = hämtadResa.UtResa;
            cbLand.SelectedItem = hämtadResa.Land;
            tbFrukost.Text = hämtadResa.AntalFrukost.ToString(CultureInfo.InvariantCulture);
            tbMiddag.Text = hämtadResa.AntalMiddag.ToString(CultureInfo.InvariantCulture);
            tbLunch.Text = hämtadResa.AntalLunch.ToString(CultureInfo.InvariantCulture);
            lbUtgifter.DataSource = hämtadResa.UtgifterFörResa;

        }

        private void lbResa_SelectedIndexChanged(object sender, EventArgs e)
        {

            lbUtgifter.Items.Clear();
            ValdResa = lbResa.SelectedIndex;
            labelTotal.Text = @"0";

            if (AllaResor[ValdResa].UtgifterFörResa.Count == 0 || AllaResor[ValdResa].UtgifterFörResa == null)
            {
            }
            else
            {

                for (var i = 0; i < AllaResor[ValdResa].UtgifterFörResa.Count; i++)
                {
                    var utgift = AllaResor[ValdResa].UtgifterFörResa[i];
                    lbUtgifter.Items.Add(utgift);
                }
                UppdateraTotalSumma();
            }
        }

        private void btnLaggTillAvdrag_Click(object sender, EventArgs e)
        {

        }



    } // klassen
} // namespace
