using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vIT_System
{
    static class SQLhelp
    {
        public static void SqlConnect()
        {
            using (SqlConnection sql = new SqlConnection("LÄGG TILL CONNECTIONSTRING"))
            {
                try
                {
                    sql.Open();
                    MessageBox.Show("Funka");
                    SqlQuery("Insert into test values (2)");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("SQLfel: \n" + ex.ToString());
                }
            }
        }

        public static void SqlQuery(String query)
        {
            try
            {
                SqlCommand comm = new SqlCommand(query);
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}