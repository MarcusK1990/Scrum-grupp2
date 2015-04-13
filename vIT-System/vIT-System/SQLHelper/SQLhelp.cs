using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vIT_System
{
    class SQLhelp
    {
        public void SqlConnect()
        {
            using (SqlConnection sql = new SqlConnection("LÄGG TILL PARAMETRAR"))
            {
                try
                {
                    sql.Open();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("SQLfel: \n" + ex);
                }
            }
        }

        public void SqlQuery(String query)
        {
            SqlCommand comm = new SqlCommand(query);
            comm.ExecuteNonQuery();
        }
    }
}
