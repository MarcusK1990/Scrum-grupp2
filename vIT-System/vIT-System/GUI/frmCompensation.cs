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
        public List<utgift> totalOutpoison;
        public frmCompensation()
        {
            InitializeComponent();
            totalOutpoison = new List<utgift>(); 
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
            var nyUtgift = new utgift
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
    }
}
