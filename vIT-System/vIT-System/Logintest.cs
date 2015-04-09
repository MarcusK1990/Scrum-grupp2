using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vIT_System
{
    public partial class Logintest : Form
    {
        public Logintest(int mode)
        {
            InitializeComponent();
            if (mode == 1)
            {
                MessageBox.Show("Offline");
                textBox1.Enabled = false;
                textBox2.Enabled = false;
            }
            if (mode == 2)
            {
                textBox1.BackColor = Color.Aqua;
            }
        }

        private void Logintest_Load(object sender, EventArgs e)
        {

        }
        

    }
}
