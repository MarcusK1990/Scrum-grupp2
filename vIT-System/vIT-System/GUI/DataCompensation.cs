using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vIT_System.Data;

namespace vIT_System.GUI
{
    public static class DataCompensation
    {
        //userid =Plockat id från den som är inloggad
        //metoden skapar ett nytt formulär i databasen, den tilldelas ett id, och lägger till den inloggade som "ägare"
        //i övrigt är Ansökan i db tom
        public static int newCompensationfrm(int userId)
        {
            var query = "insert into ansokan(id) values (" + userId + ")";
            var path = Helpers.getSourcePath();
            var sqldb = new SqlConnection(path);
            sqldb.Open();
            var sqlC = new SqlCommand(query, sqldb);
            sqlC.ExecuteNonQuery();

            var query2 = "select top 1 AnsId from ansokan order by ansid desc";
            var sqlC2 = new SqlCommand(query2, sqldb);
            SqlDataReader myReader;
            myReader = sqlC2.ExecuteReader();
            myReader.Read();
            var idhamtat = myReader.GetInt32(0);

            sqldb.Close();
            return idhamtat;

        }
    }
}
