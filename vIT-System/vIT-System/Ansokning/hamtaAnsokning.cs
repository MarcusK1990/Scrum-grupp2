using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vIT_System.Rapport
{
    public partial class hamtaAnsokning : Form
    {
        public hamtaAnsokning()
        {
            InitializeComponent();
        }

        private DataTable createTestDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.Clear();
            dataTable.Columns.Add("id");
            dataTable.Columns.Add("username");
            dataTable.Columns.Add("password");

            DataRow foo = dataTable.NewRow();
            foo["id"] = "0";
            foo["username"] = "admin";
            foo["password"] = "pass123";
            dataTable.Rows.Add(foo);

            foo = dataTable.NewRow();
            foo["id"] = "1";
            foo["username"] = "chefen22";
            foo["password"] = "qwerty";
            dataTable.Rows.Add(foo);

            return dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = createTestDataTable();

            gridAnsokning.DataSource = dt;
        }
    }
}
