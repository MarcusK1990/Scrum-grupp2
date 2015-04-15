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

namespace vIT_System.Rapport
{
    public partial class hamtaAnsokning : Form
    {
        private SqlHelper sqlHelper;
        public hamtaAnsokning(SqlHelper sqlHelper)
        {
            InitializeComponent();
            this.sqlHelper = sqlHelper;
        }

        private void hamtaAnsokning_Load(object sender, EventArgs e)
        {

        }
    }
}
