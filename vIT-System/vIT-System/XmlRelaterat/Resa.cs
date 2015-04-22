using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace vIT_System.XmlRelaterat
{
    public class Resa
    {
        public string Land { get; set; }
        public string SemesterDagar { get; set; }
        public DateTime HemResa { get; set; }
        public DateTime UtResa { get; set; }
        public double TraktamenteFörLandet { get; set; }
        public double TraktamenteEfterAvdrag { get; set; }
        public int AntalMiddag { get; set; }
        public int AntalFrukost { get; set; }
        public int AntalLunch { get; set; }
        public List<Utgift> UtgifterFörResa { get; set; }
        public string Uppdrag { get; set; }
        public string VisaResaIListBox
        {
            get { return "Land:" + Land + " ( Uppdrag: " + Uppdrag + " )"; }
        }

// kanske ej behövs
    }
}
