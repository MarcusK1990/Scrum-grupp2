using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vIT_System.Data
{
    public static class Helpers
    {
        //Fulade till med denna metod som "trimmar" sökvägen till databsen.
        //den trimmar bort file:\\ och \\bin\\Debug från sökvägen.
        public static string getSourcePath()
        {
            var sourceString = "Data Source=(localdb)\\v11.0;AttachDbFilename=" + Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().GetName().CodeBase) + "\\Database\\vITs.mdf;Integrated Security=True";

            const string removeString = "\\bin\\Debug";
            int index = sourceString.IndexOf(removeString);
            int length = removeString.Length;
            string startOfString = sourceString.Substring(0, index);
            string endOfString = sourceString.Substring(index + length);
            string cleanPath = startOfString + endOfString;

            const string removeString2 = "file:\\";
            int index2 = cleanPath.IndexOf(removeString2);
            int length2 = removeString2.Length;
            string startOfString2 = cleanPath.Substring(0, index2);
            string endOfString2 = cleanPath.Substring(index2 + length2);
            string cleanPath2 = startOfString2 + endOfString2;

            return cleanPath2;
        }
    }
}
