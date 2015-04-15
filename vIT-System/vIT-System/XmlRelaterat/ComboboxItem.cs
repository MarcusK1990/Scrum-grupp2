using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vIT_System.XmlRelaterat
{
    public class ComboboxItem
    {
        public string Text { get; set; }
        public double Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
