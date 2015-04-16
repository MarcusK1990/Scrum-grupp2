namespace vIT_System.XmlRelaterat
{
    public class Utgift
    {

        public double ValutaKurs { get; set; }

        public double Belopp { get; set; }

        public string Valuta { get; set; }

        public string AndaMal { get; set; }

        public int Moms { get; set; }

        public string Konverterad { get; set; }

        public string VisaIListBox{
            get { return Valuta + " " + Belopp + " för ändamål:" + AndaMal + " (SEK " + Konverterad + ")"; }
        }

        
    }
}
