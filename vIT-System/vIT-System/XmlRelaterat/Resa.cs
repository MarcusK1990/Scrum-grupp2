using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vIT_System.XmlRelaterat
{
    public class Resa
    {
        public string Land { get; set; }
        public string SemesterDagar { get; set; }
        public string HemResa { get; set; }
        public string UtResa { get; set; }
        public double TraktamenteFörLandet { get; set; }
        public string TraktamenteEfterAvdrag { get; set; } // kanske ej behövs
    }
}
