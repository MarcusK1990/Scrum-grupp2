using System.Data;
using System.Text;

namespace vIT_System.Traktamentestabell
{
    static class Traktamentestabell
    {
        public static DataTable dataTable;
        static Traktamentestabell()
        {
            dataTable = new DataTable();
            dataTable.Clear();
            dataTable.Columns.Add("land");
            dataTable.Columns.Add("belopp");

            string line;

            System.Diagnostics.Debug.WriteLine(System.IO.Path.GetFullPath("Traktamentestabell\\traktamente.txt"));
            System.IO.StreamReader file = new System.IO.StreamReader(System.IO.Path.GetFullPath("Traktamentestabell\\traktamente.txt"), Encoding.Default);
            while ((line = file.ReadLine()) != null)
            {
                string[] split = line.Split(new char[] { ':' });
                var dr = dataTable.NewRow();
                dr["land"] = split[0];
                dr["belopp"] = split[1];
                dataTable.Rows.Add(dr);
            }
        }

        private static void Outputshit()
        {
            foreach (DataRow dr in dataTable.Rows)
            {
                System.Diagnostics.Debug.WriteLine("Land: " + dr["land"].ToString() + " - Belopp: " + dr["belopp"].ToString());
            }

            foreach (DataRow dr in dataTable.Rows)
            {
                if (dr["land"].Equals("Rumänien"))
                {
                    System.Diagnostics.Debug.WriteLine("@@@ RUMÄNIEN @@@");
                    break;
                }
            }
        }
        /// <summary>
        /// Hämta traktamentesbeloppet för ett specifikt land
        /// </summary>
        /// <param name="land">Landet du vill hitta beloppet för</param>
        /// <returns>Beloppet</returns>
        public static string HämtaTraktBelopp(string land)
        {
            foreach (DataRow dr in dataTable.Rows)
            {
                if (dr["land"].Equals(land))
                {
                    return dr["belopp"].ToString();
                }
            }
            // om landet inte hittas returneras beloppet för Övrigt (den sista raden i tabellen)
            return dataTable.Rows[dataTable.Rows.Count - 1]["belopp"].ToString();
        }
        public static string[] HämtaLänder()
        {
            string[] länder = new string[dataTable.Rows.Count];
            
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                länder[i] = dataTable.Rows[i]["land"].ToString();
            }

            return länder;
        }
        public static string[,] HämtaLänderOchBelopp()
        {
            string[,] länder = new string[dataTable.Rows.Count, 2];

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                länder[i, 0] = dataTable.Rows[i]["land"].ToString();
                länder[i, 1] = dataTable.Rows[i]["belopp"].ToString();
            }

            return länder;
        }

    }
}
