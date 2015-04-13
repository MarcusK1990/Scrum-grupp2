using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using vIT_System.XmlRelaterat;
using System.Xml;
using System.Xml.Serialization;

namespace vIT_System.XmlRelaterat
{
    public class Xmelliserare
    {

        public XmlSerializer xml { get; set; }

        public void SkrivXmlCompensationModel(CompensationModel Uppgifter)
        {            
            xml = new XmlSerializer(typeof(CompensationModel));
            using (var sw = new StreamWriter(@"C:\xmlCompensationModel.xml"))
            {
                xml.Serialize(sw, Uppgifter);
            }
        }

        
    }




}
