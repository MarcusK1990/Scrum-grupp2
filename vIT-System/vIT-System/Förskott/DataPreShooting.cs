using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using vIT_System.Data;

namespace vIT_System.Förskott
{
    public static class DataPreShooting
    {
        //Hämtar bossarnas namn och returnerar en lista av dem
        public static List<string> FillCbBoss()
        {
            var path = Helpers.getSourcePath();

            var sqldb = new SqlConnection(path);
            var query = "select Fnamn from Anstallda where Anstallda.Chef = 'true'";
            
            var sqlC = new SqlCommand(query, sqldb);
            SqlDataReader myReader;
            var lista = new List<string>();
            try
            {
                sqldb.Open();
                myReader = sqlC.ExecuteReader();
                while (myReader.Read())
                {
                    string fName = myReader.GetString(0);
                    lista.Add(fName);
                }
                sqldb.Close();
                myReader.Close();
            }
            catch (FormatException)
            {

            }
            return lista;
        }
        //hämtar de uppdrag som finns i databasen och returnerar en lista med dem.
        public static List<string> FillCbChooseUppdrag()
        {
            var path = Helpers.getSourcePath();
            var sqldb = new SqlConnection(path);
            var query = "select namn from uppdrag";

            var sqlC = new SqlCommand(query, sqldb);
            SqlDataReader myReader;
            var lista = new List<string>();
            try
            {
                sqldb.Open();
                myReader = sqlC.ExecuteReader();
                while (myReader.Read())
                {
                    string uppdragnamn = myReader.GetString(0);
                    lista.Add(uppdragnamn);
                }
                sqldb.Close();
                myReader.Close();
            }
            catch (FormatException)
            {

            }
            return lista;
        }

        public static int getBoss(string cbBoss)
        {
            var path = Helpers.getSourcePath();

            var sqldb = new SqlConnection(path);
            
            var query = "select id from anstallda where fnamn = '" + cbBoss + "'";
            SqlCommand sqlSelect = new SqlCommand(query, sqldb);

            SqlDataReader myReader;
            var idhamtat = 0;
            try
            {
                sqldb.Open();
                myReader = sqlSelect.ExecuteReader();
                while (myReader.Read())
                {
                    idhamtat = myReader.GetInt32(0);
                }

                myReader.Close();
            }
            catch (FormatException)
            {
            }
            return idhamtat;
        }


        public static int getUppdrag(string cbUppdrag)
        {
            var path = Helpers.getSourcePath();

            var sqldb = new SqlConnection(path);

            var query = "select uppid from uppdrag where namn = '" + cbUppdrag + "'";
            SqlCommand sqlSelect = new SqlCommand(query, sqldb);

            SqlDataReader myReader;
            var idhamtat = 0;
            try
            {
                sqldb.Open();
                myReader = sqlSelect.ExecuteReader();
                while (myReader.Read())
                {
                    idhamtat = myReader.GetInt32(0);
                }

                myReader.Close();
            }
            catch (FormatException)
            {
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
            var query = "insert into forskott values (" + summa + ", '"+ beskr + "', '" + chefId + "', 'Bearbetas'," + uppID + ", 1)";

            var sqlComm = new SqlCommand(query, sqldb);
            sqlComm.ExecuteNonQuery();
            
        }
    }
}
