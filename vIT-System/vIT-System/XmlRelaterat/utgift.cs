using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vIT_System.XmlRelaterat
{
    public class Utgift
    {
        public double valutaKurs { get; set; }
        public double belopp { get; set; }
        public string valuta { get; set; }
        public string andaMal { get; set; }
        public int moms { get; set; }
    }
}
