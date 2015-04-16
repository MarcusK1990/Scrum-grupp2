using System.IO;
using System.Xml.Serialization;

namespace vIT_System.XmlRelaterat
{
    public class Xmelliserare
    {

        public XmlSerializer xml { get; set; }
        private string Path { get; set; }
        // @"C:\xmlCompensationModel.xml"

        public Xmelliserare(string sökväg)
        {
            Path = sökväg;
        }

        public void SkrivCompensationModel(CompensationModel Uppgifter)
        {            
            xml = new XmlSerializer(typeof(CompensationModel));
            using (var sw = new StreamWriter(Path))
            {
                xml.Serialize(sw, Uppgifter);
            }
        }

        public CompensationModel LaddaUtkast()
        {
            xml = new XmlSerializer(typeof(CompensationModel));
            if (!File.Exists(Path))
            {
                return new CompensationModel();
            }

            using (var sr = new StreamReader(Path))
            {
                return xml.Deserialize(sr) as CompensationModel;
            }
        }

        
    }




}
