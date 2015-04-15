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

namespace vIT_System
{
    public partial class Konsulthantering : Form
    {
        private SqlHelper sqlHelper;
        public Konsulthantering()
        {
            InitializeComponent();
            sqlHelper = new SqlHelper("Database\\vITs.mdf");

            DataTable dt = sqlHelper.Fetch("select * from anstallda");
        }
    }
}
