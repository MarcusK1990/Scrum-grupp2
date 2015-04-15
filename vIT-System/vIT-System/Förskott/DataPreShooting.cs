using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vIT_System.Förskott
{
    public static class DataPreShooting
    {
        public static void accessDB(string path, string query)
        {
            SqlConnection sqlCon = new SqlConnection(path);
            SqlCommand sqlCom = new SqlCommand(query, sqlCon);
            SqlDataReader myReader;

            sqlCon.Open();
            
            myReader = sqlCom.ExecuteReader();
            sqlCon.Close();
            myReader.Close();
        }
//Hämtar bossarnas namn och returnerar en lista av dem
        public static List<string> FillCbBoss()
        {
            var sqldb = new SqlConnection("Data Source=(localdb)\\v11.0;AttachDbFilename=C:\\Users\\sofia\\Source\\Repos\\Scrum-grupp2\\vIT-System\\vIT-System\\Database\\vITs.mdf;Integrated Security=True");
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
    }
}
