using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using vIT_System.Data;

namespace vIT_System.Förskott
{
    public static class DataPreShooting
    {

        public static List<string> cbFill(string query)
        {
            var path = Helpers.getSourcePath();
            var sqldb = new SqlConnection(path);
            var sqlC = new SqlCommand(query, sqldb);
            SqlDataReader myReader;
            var lista = new List<string>();
            try
            {
                sqldb.Open();
                myReader = sqlC.ExecuteReader();
                while (myReader.Read())
                {
                    var namn = myReader.GetString(0);
                    lista.Add(namn);
                }
                sqldb.Close();
                myReader.Close();
            }
            catch (Exception)
            {
            }
            return lista;
        }


        public static int getId(string cbItem, string query)
        {
            var path = Helpers.getSourcePath();

            var sqldb = new SqlConnection(path);

            var sqlSelect = new SqlCommand(query, sqldb);

            SqlDataReader myReader;
            var idhamtat = 0;

            try
            {
                sqldb.Open();
                myReader = sqlSelect.ExecuteReader();
                myReader.Read();

                idhamtat = myReader.GetInt32(0);

                myReader.Close();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
               
            }
            return idhamtat;
        }

        public static void savePreShooting(int summa, string beskr, int chefId, int uppID)
        {
            //TODO: Hämta ut id på den som är inloggad
            //Ska chefen läggas in som id. Bäst kanske
            //Sista variabeln som är hårdkodad i insertfrågan är eg anställningsid, alltså den som är inloggad
            var path = Helpers.getSourcePath();
            var sqldb = new SqlConnection(path);
            sqldb.Open();
            var query = "insert into forskott values (" + summa + ", '" + beskr + "', '" + chefId + "', 'Bearbetas'," + uppID + ", 1)";

            var sqlComm = new SqlCommand(query, sqldb);
            sqlComm.ExecuteNonQuery();
            sqldb.Close();

        }
    }
}
