using System;

namespace vIT_System.XmlRelaterat
{
    public class Resa
    {
        public string Land { get; set; }
        public string SemesterDagar { get; set; }
        public DateTime HemResa { get; set; }
        public DateTime UtResa { get; set; }
        public double TraktamenteFörLandet { get; set; }
        public double TraktamenteEfterAvdrag { get; set; } // kanske ej behövs
    }
}
