using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vIT_System.XmlRelaterat
{
    public class CompensationModel
    {
        public string eMail { get; set; }
        public string forNamn { get; set; }
        public string eftNamn { get; set; }
        public int milErsattning { get; set; }
        public string utresa { get; set; }
        public string hemresa { get; set; }
        public string semesterDagar { get; set; }
        public string land { get; set; }
        public int frukost { get; set; }
        public int lunch { get; set; }
        public int middag { get; set; }
        public List<Utgift> utgifter { get; set; }

        public CompensationModel(List<Utgift> utkastet)
        {
            utgifter = new List<Utgift>();
            utgifter = utkastet;
            
        }
    
        public CompensationModel()
        { }
    }
   
    
}
