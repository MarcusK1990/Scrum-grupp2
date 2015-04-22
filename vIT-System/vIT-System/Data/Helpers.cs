using System.IO;

namespace vIT_System.Data
{
    public static class Helpers
    {
        //Fulade till med denna metod som "trimmar" sökvägen till databsen.
        //den trimmar bort file:\\ och \\bin\\Debug från sökvägen.
        public static string getSourcePath()
        {
            var sourceString = "Data Source=(localdb)\\v11.0;AttachDbFilename=" + Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().GetName().CodeBase) + "\\Database\\vITs2.mdf;Integrated Security=True";

            const string removeString = "\\bin\\Debug";
            var index = sourceString.IndexOf(removeString);
            var length = removeString.Length;
            var startOfString = sourceString.Substring(0, index);
            var endOfString = sourceString.Substring(index + length);
            var cleanPath = startOfString + endOfString;

            const string removeString2 = "file:\\";
            var index2 = cleanPath.IndexOf(removeString2);
            var length2 = removeString2.Length;
            var startOfString2 = cleanPath.Substring(0, index2);
            var endOfString2 = cleanPath.Substring(index2 + length2);
            var cleanPath2 = startOfString2 + endOfString2;

            return cleanPath2;
        }
    }
}
