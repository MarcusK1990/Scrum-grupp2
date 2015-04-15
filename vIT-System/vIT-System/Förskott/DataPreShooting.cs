using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using vIT_System.Data;

namespace vIT_System.Förskott
{
    public static class DataPreShooting
    {
        //public static void accessDB(string path, string query)
        //{
        ////    SqlConnection sqlCon = new SqlConnection(path);
        ////    SqlCommand sqlCom = new SqlCommand(query, sqlCon);
        ////    SqlDataReader myReader;

        ////    sqlCon.Open();

        ////    myReader = sqlCom.ExecuteReader();
        ////    sqlCon.Close();
        ////    myReader.Close();
        //}

        //Hämtar bossarnas namn och returnerar en lista av dem
        public static List<string> FillCbBoss()
        {
           var path = Helpers.getSourcePath();

            var sqldb = new SqlConnection(path);
            var query = "select Fnamn from Anstallda where Anstallda.Chef = 'ja'";

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

            var query = "select Uppdragnamn from Uppdrag";

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

        public static void savePreShooting(int summa, string beskr, int id)
        {
            //Behöver man inte veta vem det är som har skickat, är det de som är id?
            //behöver även en kolumn med uppdrag
            var path = Helpers.getSourcePath();

            var sqldb = new SqlConnection(path); 
            
            sqldb.Open(); 
            var query = "insert into forskott values (" +summa + ", '"+ beskr + "', " + id +")";
            var sqlComm = new SqlCommand(query, sqldb);
            sqlComm.ExecuteNonQuery();
            
        }
    }
}
