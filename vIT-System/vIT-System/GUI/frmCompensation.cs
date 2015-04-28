using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using vIT_System.SQL;
using vIT_System.Data;
using vIT_System.Validering;
using vIT_System.XmlRelaterat;
using System.Data;

namespace vIT_System.GUI
{

    public partial class FrmCompensation : Form
    {
        private SqlHelper sqlHelper;

        public BindingList<Resa> AllaResor;
        public int ValdResa { get; set; }
        public double Mil { get; set; }
        public ApplicationMode.Mode CompMode { get; set; }
        private string namn { get; set; }
        private string efterNamn { get; set; }
        string eMail { get; set; }

        public FrmCompensation(ApplicationMode.Mode inMode)
        {
            InitializeComponent();
            AllaResor = new BindingList<Resa>();
            sqlHelper = new SqlHelper("Database\\vITs2.mdf");

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
            eMail = email;
            this.namn = namn;
            efterNamn = efternamn;
            CompMode = inMode;
            sqlHelper = new SqlHelper("Database\\vITs2.mdf");

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
            var ansId = DataCompensation.newCompensationfrm(1) - 1;
            lblAnsID.Text = ansId.ToString(CultureInfo.InvariantCulture);
            HämtaLänder();


            if (CompMode == ApplicationMode.Mode.OFFLINE)
            {
                tbEmail.Enabled = true;
                tbForNamn.Enabled = true;
                tbEfterNamn.Enabled = true;
                lblValutaKurs.Text = @"Valutakurs kunde inte uppdateras.";
                cbUppdrag.Items.Add(new ComboboxItem { Text = "Test", Value = 1 });
                //LaddaValutaOffline(); en ide!
                LaddaValuta();
            }
            else
            {
                LaddaUppdrag();
                LaddaValuta();
                lblValutaKurs.Text = @"Senaste valutakurs: " + DateTime.Now;

                autoFill();
            }
        }
        private void autoFill()
        {
            tbEmail.Text = eMail;
            tbForNamn.Text = namn;
            tbEfterNamn.Text = efterNamn;
        }

        private void HämtaLänder()
        {
            var länder = Traktamentestabell.Traktamentestabell.HämtaLänderOchBelopp();

            cbLand.Items.Clear();

            for (var i = 0; i < länder.GetLength(0); i++)
            {
                //System.Diagnostics.Debug.WriteLine(länder[i, 0] + " + " + länder[i, 1]);

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

        private static bool Ping()
        {
            var ping = new Ping();

            try
            {
                var result = ping.Send("www.finance.yahoo.com");
                return result != null && result.Status == IPStatus.Success;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        private void LaddaValuta()
        {
            if (CompMode == ApplicationMode.Mode.STANDARD)
            {
            if (Ping())
            {
                var frånstringtilldecimaltilldoubleUsd = ValutaOmvandlare.KonverteraTillFrån("SEK", "USD", "1");
                var frånstringtilldecimaltilldoubleEur = ValutaOmvandlare.KonverteraTillFrån("SEK", "EUR", "1");

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
            //foreach (var utgifter in AllaResor)
            //{
            //    total = utgifter.UtgifterFörResa.Sum(x => x.Belopp);
            //}
            var total = AllaResor[ValdResa].UtgifterFörResa.Sum(x => x.Konverterad);

            labelTotal.Text = total.ToString(CultureInfo.InvariantCulture);
        }

        private void btnUtgiter_Click(object sender, EventArgs e)
        {
            double parsedBelopp;
            double.TryParse(tbBelopp.Text, out parsedBelopp);


            ValidationCheck.checkValidering(tbBelopp, "tom", "belopp");
            ValidationCheck.checkValidering(tbBelopp, "bokstäver", "belopp");
            ValidationCheck.checkValidering(tbBelopp, "längre255", "belopp");

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
            if (valtItemValutaNamn == "SEK")
            {
                konverterad = parsedBelopp;
            }
            else if (valtItemValutaNamn == "USD")
            {
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

            var ansid = Convert.ToInt32(lblAnsID.Text);
            var queryInsert = "";

            for (var i = 0; i < AllaResor.Count; i++)
            {
                var utresa = AllaResor[i].UtResa;
                var hemresa = AllaResor[i].HemResa;
                var resa = AllaResor[i].Land;
                var traktamente = AllaResor[i].TraktamenteFörLandet;
                // var totalSumma = AllaResor[i].TraktamenteEfterAvdrag;
                var semester = AllaResor[i].SemesterDagar;
                var utgifter = AllaResor[i].UtgifterFörResa;
                var land = AllaResor[i].Land;
                var totalsumma = tbTotalaAvdrag.Text;

                queryInsert = "insert into resa (avresa, hemresa, traktamente, land, totalsumma, ansid) values " +
               "('" + utresa + "', '" + hemresa + "', '" + traktamente + "', '" + land + "', " + totalsumma + ", " + ansid + ")";

                System.Diagnostics.Debug.WriteLine(queryInsert);

                sqlHelper.Modify(queryInsert);
                var queryRid = "select rid from Resa";
                var Rid2 = sqlHelper.Fetch(queryRid);
                var Rid = Rid2.Rows[0]["rid"].ToString();

                if (Convert.ToInt32(AllaResor[i].SemesterDagar) >= 1)
                {
                    var semesterStart = "";
                    var semesterSlut = "";
                    var SemId = 0;
                    var querySemester = "insert into SemDagar (SemStart, SemSlut, Rid, SemId) values " +
                        "('" + semesterStart + "', '" + semesterSlut + "', " + Rid + ", " + SemId + ")";
                } // semester if

                if (AllaResor[i].UtgifterFörResa.Count >= 1)
                {
                    for (var j = 0; j < AllaResor[i].UtgifterFörResa.Count; j++)
                    {
                        var typ = AllaResor[i].UtgifterFörResa[j].AndaMal;
                        var valuta = AllaResor[i].UtgifterFörResa[j].Valuta;
                        var valutakurs = AllaResor[i].UtgifterFörResa[j].ValutaKurs;
                        var moms = 0;
                        var summa = AllaResor[i].UtgifterFörResa[j].Konverterad;
                        var kvitto = AllaResor[i].UtgifterFörResa[j].Kvitto;

                        var queryUtgift = "insert into Utgifter (typ, valuta, valutakurs, moms, summa, kvitto) " +
                            "values ('" + typ + "', '" + valuta + "', " + valutakurs + ", " + moms + ", " + summa + ", '" + kvitto + "')";
                        sqlHelper.Modify(queryUtgift);
                    }
                    var totalaUtgifter = tbTotalaUtgifter.Text;

                    //
                    
                    var resaTotal = AllaResor.Count / Convert.ToDouble(totalaUtgifter);

                    var queryUtgifter = "insert into ansokan(Ersättning) values (" + totalaUtgifter + ")";
                    sqlHelper.Modify(queryUtgifter);
        }

                if (AllaResor[i].AntalFrukost >= 1 || AllaResor[i].AntalLunch >= 1 || AllaResor[i].AntalMiddag >= 1)
                {

                    var mat = 0;
                    var typ = "";
                    var summa = 0.0;
                    if (AllaResor[i].AntalFrukost >= 1)
                    {
                        mat = AllaResor[i].AntalFrukost;
                        typ = "frukost";
                        summa = (traktamente * 0.15) * mat;
                    }

                    if (AllaResor[i].AntalLunch >= 1)
                    {
                        mat = AllaResor[i].AntalLunch;
                        typ = "lunch";
                        summa = (traktamente * 0.35) * mat;
                    }

                    if (AllaResor[i].AntalMiddag >= 1)
                    {
                        mat = AllaResor[i].AntalMiddag;
                        typ = "middag";
                        summa = (traktamente * 0.35) * mat;
                    }

                    var queryMat = "insert into mat (Typ, Summa, Rid) values (" + typ + "', '" + summa + "', " + Rid + ")";
                    sqlHelper.Modify(queryMat);
                }


            } // loopen

            var ersattning = tbTotalTraktamentesUtbetalning.Text;
            var anställdQuery = "select Id from anstallda where fnamn = '" + tbForNamn.Text + "' AND enamn =  '" + tbEfterNamn.Text + "'";
            var anställd = sqlHelper.Fetch(anställdQuery);
            var ans = anställd.Rows[0]["Id"].ToString();

            var sqlAnsokan = "insert into ansokan (namn, ersättning, status, Id) values " +
                " ( 'namnpaansokan'," + ersattning + ", 'bearbetas', " + ans + ")";



            var query = "select forskott.id, summa from Forskott" +
            "join anstallda on Anstallda.id = Forskott.Id where Anstallda.id = "+ans+" and status = 'bearbetas'";
            var forskott = sqlHelper.Fetch(query);
           var totsum = 0;

            foreach(DataRow dr in forskott.Rows)
            {
               var id = dr["fid"];
               totsum += Convert.ToInt32(dr["summa"]);
            }

            var uträknadSumma = Convert.ToDouble(ersattning) - totsum;
            // det sk räknas lite här. Men vi taR DET NÄSTA SPRINT.

            sqlHelper.Modify(queryInsert);
            sqlHelper.Modify(sqlAnsokan);

            MessageBox.Show("it works!");
            this.Close();
        }

        private bool ValideraVidLaggTillResa()
        {
            ValidationCheck.checkValidering(tbSemesterdagar, "InnehållerBokstav", "semesterdagar");
            ValidationCheck.checkValidering(tbSemesterdagar, "längre255", "semesterdagar");

            ValidationCheck.checkValidering(tbFrukost, "InnehållerBokstav", "frukost");
            ValidationCheck.checkValidering(tbLunch, "InnehållerBokstav", "lunch");
            ValidationCheck.checkValidering(tbMiddag, "InnehållerBokstav", "middag");

            ValidationCheck.CheckCombox(cbUppdrag, "uppdrag");

            ValidationCheck.CheckDates(dtpUtResa.Value, dtpHemResa.Value);

            double avrundaDagar = Math.Ceiling((dtpHemResa.Value - dtpUtResa.Value).TotalDays);
            double semesterDagar = Convert.ToDouble(tbSemesterdagar.Text);
            ValidationCheck.CheckSemesterDagar(avrundaDagar, semesterDagar);


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
                tbSemesterdagar.Text = @"0";
            }

            if (Validation.IsEmpty(tbFrukost.Text))
            {
                tbFrukost.Text = @"0";
            }

            if (Validation.IsEmpty(tbMiddag.Text))
            {
                tbMiddag.Text = @"0";
            }

            if (Validation.IsEmpty(tbLunch.Text))
            {
                tbLunch.Text = @"0";
            }
            //Om databasen börjar funka validera med denna
            //if (ValdResa > -1 && ValdResa < AllaResor.Count)
            //{

            //}
          
            btnUtgiter.Enabled = true;
            

            var valtItem = (ComboboxItem)cbLand.SelectedItem;
            var valtTraktamenteFörLandet = Convert.ToDouble(valtItem.Value);
            var valtLand = Convert.ToString(valtItem.Text);
            var uppdrag = cbUppdrag.SelectedText.ToString();
            var nyResa = new Resa
            {
                UtResa = dtpUtResa.Value,
                HemResa = dtpHemResa.Value,
                Land = valtLand,
                SemesterDagar = tbSemesterdagar.Text,
                TraktamenteFörLandet = valtTraktamenteFörLandet,
                AntalMiddag = Convert.ToInt32(tbMiddag.Text),
                AntalFrukost = Convert.ToInt32(tbFrukost.Text),
                AntalLunch = Convert.ToInt32(tbLunch.Text),
                Uppdrag = uppdrag,
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


            //var totalsumma = betalningsBerättigadeDagar * valtTraktamenteFörLandet;

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

        private void btnUppdateraSammanstallning_Click(object sender, EventArgs e)
        {

            double totalaUtgifter = 0;
            var totalaSemesterDagar = 0;
            var dagarbortaRäknaMed = 0.0;
            double totaltAvdragFrånTraktamente = 0;
            var traktamenteFörLandet = 0.0;


            for (var i = 0; i < AllaResor.Count; i++)
            {

                totalaUtgifter += AllaResor[i].UtgifterFörResa.Sum(x => x.Belopp);
                totalaSemesterDagar += Convert.ToInt32(AllaResor[i].SemesterDagar);
                var hemresa = AllaResor[i].HemResa;
                var utresa = AllaResor[i].UtResa;
                traktamenteFörLandet = AllaResor[i].TraktamenteFörLandet;

                var dagarborta = hemresa - utresa;
                if (dagarborta.TotalDays < 0)
                {
                    dagarbortaRäknaMed += dagarborta.TotalDays * -1;
                }
                if (dagarborta.TotalDays > 0)
                {
                    dagarbortaRäknaMed += dagarborta.TotalDays;
                }

                var antalFrukost = AllaResor[i].AntalFrukost;
                var antalMiddag = AllaResor[i].AntalMiddag;
                var antalLunch = AllaResor[i].AntalLunch;

                var lunchförresa = (AllaResor[i].TraktamenteFörLandet * 0.35) * antalLunch;
                var middagförresa = (AllaResor[i].TraktamenteFörLandet * 0.35) * antalMiddag;
                var frukostförresa = (AllaResor[i].TraktamenteFörLandet * 0.15) * antalFrukost;

                totaltAvdragFrånTraktamente += frukostförresa + middagförresa + lunchförresa;
            }
            
            var totalaDagarBortrestAvrundatUppåt = Math.Ceiling(dagarbortaRäknaMed);
            var traktamentesdagar = totalaDagarBortrestAvrundatUppåt - totalaSemesterDagar;

            var traktamenteEfterAvdrag = (traktamentesdagar * traktamenteFörLandet) -
                                 totaltAvdragFrånTraktamente;

            tbTotalaUtgifter.Text = totalaUtgifter.ToString(CultureInfo.InvariantCulture);
            tbTotalTraktamenteDagar.Text = traktamentesdagar.ToString(CultureInfo.InvariantCulture);
            tbTotalMilErsättning.Text = Mil * 13.37 + @" Literpris: 13.37";
            tbTotalaAvdrag.Text = totaltAvdragFrånTraktamente.ToString(CultureInfo.InvariantCulture);
            tbTotalTraktamentesUtbetalning.Text = traktamenteEfterAvdrag.ToString(CultureInfo.InvariantCulture);
            tbDagarBortRest.Text = totalaDagarBortrestAvrundatUppåt.ToString(CultureInfo.InvariantCulture);
        }

        private bool ErsattningValidera()
        {
            ValidationCheck.checkValidering(tbMilErsattning, "InnehållerBokstav", "milersättning");
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

        private void btnMilErsättningPlus_Click(object sender, EventArgs e)
        {

            if (!ErsattningValidera())
            {
               return;
            }
            Mil = Convert.ToDouble(tbMilErsattning.Text);
        }
    } // klassen
} // namespace
