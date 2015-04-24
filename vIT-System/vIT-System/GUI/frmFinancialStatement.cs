using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vIT_System.SQL;
using vIT_System.XmlRelaterat;

namespace vIT_System.GUI
{
    public partial class frmFinancialStatement : Form
    {
        private SqlHelper sqlHelper;

        public frmFinancialStatement()
        {
            InitializeComponent();
            sqlHelper = new SqlHelper("Database\\vITs2.mdf");
        }

        private void frmFinancialStatement_Load(object sender, EventArgs e)
        {
            cbYear.Items.Add(new ComboboxItem { Text = "2013", Value = 2013 });
            cbYear.Items.Add(new ComboboxItem { Text = "2014", Value = 2014 });
            cbYear.Items.Add(new ComboboxItem { Text = "2015", Value = 2015 });

            cbPeriod.Items.Add(new ComboboxItem { Text = "jan-mars", Value = 1 });
            cbPeriod.Items.Add(new ComboboxItem { Text = "apr-jun", Value = 2 });
            cbPeriod.Items.Add(new ComboboxItem { Text = "jul-sep", Value = 3 });
            cbPeriod.Items.Add(new ComboboxItem { Text = "okt-dec", Value = 4 });
            cbPeriod.Items.Add(new ComboboxItem { Text = "jan-jun", Value = 5 });
            cbPeriod.Items.Add(new ComboboxItem { Text = "jul-dec", Value = 6 });
            cbPeriod.Items.Add(new ComboboxItem { Text = "jan-dec", Value = 7 });

        }

        private void button1_Click(object sender, EventArgs e)
        {            //validering om inget har blivit valt
            var start = cbYear.SelectedItem.ToString();
            var month1 = (ComboboxItem)cbPeriod.SelectedItem;
            var startMonth = Convert.ToInt32(month1.Value);

            switch (startMonth)
            {
                case 1:
                    start += "-01-01";
                    break;
                case 2:
                    start += "-04-01";
                    break;
                case 3:
                    start += "-07-01";
                    break;
                case 4:
                    start += "-10-01";
                    break;
                case 5:
                    start += "-01-01";
                    break;
                case 6:
                    start += "-07-01";
                    break;
                case 7:
                    start += "-01-01";
                    break;
            }

            var slut = cbYear.SelectedItem.ToString();
            var month2 = (ComboboxItem)cbPeriod.SelectedItem;
            var endMonth = Convert.ToInt32(month2.Value);

            switch (endMonth)
            {
                case 1:
                    slut += "-03-31";
                    break;
                case 2:
                    slut += "-06-30";
                    break;
                case 3:
                    slut += "-09-30";
                    break;
                case 4:
                    slut += "-12-31";
                    break;
                case 5:
                    slut += "-06-30";
                    break;
                case 6:
                    slut += "-12-31";
                    break;
                case 7:
                    slut += "-12-31";
                    break;
            }

            //Hämta reseansökningarna mellan dessa datum
            var query = "select * from Ansokan join Resa on resa.AnsId = Ansokan.AnsId where Avresa between '" + start + "' and '" + slut + "' ";
            var dt = sqlHelper.Fetch(query);
            var antalResor = 0;
            var sumErs = 0;

            if (dt.Rows.Count < 0)
            {
                MessageBox.Show("Inga ersättningar utbetalda under denna period");
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    sumErs += Convert.ToInt32(dr["ersättning"]);
                    antalResor++;
                }

                tbPeriod1.Text = start;
                tbPeriod2.Text = slut;
                tbAntalResor.Text = antalResor.ToString();
                tbSumErs.Text = sumErs.ToString();
            }
        }
    }
}
