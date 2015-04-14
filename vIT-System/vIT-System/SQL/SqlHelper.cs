using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vIT_System.SQL
{
    class SqlHelper
    {
        private string dbPath;
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter da;

        public SqlHelper(string path)
        {
            dbPath = System.IO.Path.GetFullPath(path);

            string conStr =
                "Data Source=(LocalDB)\\v11.0;" +
                "AttachDbFilename=" + dbPath + ";" +
                "Integrated Security=True;" +
                "Connect Timeout=10";

            System.Diagnostics.Debug.WriteLine(conStr);
            con = new SqlConnection(conStr);

            System.Diagnostics.Debug.WriteLine("Database path: " + dbPath + "\nTesting connection...");

            try
            {
                con.Open();
                System.Diagnostics.Debug.WriteLine("Successfully connected to database");
                con.Close();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("An error occurred:\n" + e.Message);
            }
        }
        public DataTable Fetch(string query)
        {
            DataTable dt = new DataTable();

            try
            {
                con.Open();

                System.Diagnostics.Debug.WriteLine("Connected to DB");
                cmd = new SqlCommand(query, con);
                da = new SqlDataAdapter(cmd);
                System.Diagnostics.Debug.WriteLine("Successfully executed query");

                da.Fill(dt);

                con.Close();
                System.Diagnostics.Debug.WriteLine("Closed connection to DB");
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("An error occured:\n" + e.Message);
            }

            return dt;
        }
    }
}
