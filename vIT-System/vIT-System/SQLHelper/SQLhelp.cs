using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            using (SqlConnection sql = new SqlConnection("LÄGG TILL PARAMETRAR"))
            {
                try
                {
                    sql.Open();
                    MessageBox.Show("Funka");
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