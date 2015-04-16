using System;
using System.Data;
using System.Data.SqlClient;

namespace vIT_System.SQL
{
    public class SqlHelper
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
        /// <summary>
        /// Hämtar resultatet från en SQL-query i form av en DataTable
        /// </summary>
        /// <param name="query">Din SQL-query</param>
        /// <returns>DataTable</returns>
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
        /// <summary>
        /// Används för SQL-queries som ändrar på databasen utan att returnera data (t.ex. insert, alter, drop)
        /// </summary>
        /// <param name="query">Din SQL-query</param>
        public void Modify(string query)
        {
            try
            {
                con.Open();

                System.Diagnostics.Debug.WriteLine("Connected to DB");
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                System.Diagnostics.Debug.WriteLine("Successfully executed query");

                con.Close();
                System.Diagnostics.Debug.WriteLine("Closed connection to DB");

            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("An error occurred:\n" + e.Message);
            }
        }
    }
}
