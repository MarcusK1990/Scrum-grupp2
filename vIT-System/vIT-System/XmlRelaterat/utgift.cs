﻿namespace vIT_System.XmlRelaterat
{
    public class Utgift
    {
        public string  Typ { get; set; }

        public string Valuta { get; set; }

        public double ValutaKurs { get; set; }


        public string Kvitto { get; set; }

        public double Belopp { get; set; }

        public string AndaMal { get; set; }

        public int Moms { get; set; }

        public double Konverterad { get; set; }

        public string VisaValutaIListBox{
            get { return Valuta + " " + Belopp + " för ändamål:" + AndaMal + " (SEK " + Konverterad + ")"; }
        }

        
    }
}
