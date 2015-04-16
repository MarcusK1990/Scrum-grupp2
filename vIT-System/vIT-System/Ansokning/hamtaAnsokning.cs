using System;
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
