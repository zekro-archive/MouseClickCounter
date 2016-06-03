using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace mouseCounter
{
    static class cXMLSerializer
    {
        public static void writeXML(object obj, string file)
        {
            XmlSerializer ser = new XmlSerializer(obj.GetType());
            TextWriter writer = new StreamWriter(file);
            ser.Serialize(writer, obj);
            writer.Close();
        }

        /* DESERIALIZE WITH
        XmlSerializer ser = new XmlSerializer(typeof(cXMLdataSet));
        FileStream read = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read);
        cXMLdataSet set = (cXMLdataSet)ser.Deserialize(read);

        ... = set.data1
        ...
        */
        
    }



    public class cXMLdataSet
    {
        private string _data1, _data2;

        public string leftMouseCounter
        {
            get { return _data1; }
            set { _data1 = value; }
        }

        public string rightMouseCounter
        {
            get { return _data2; }
            set { _data2 = value; }
        }
    }
}
