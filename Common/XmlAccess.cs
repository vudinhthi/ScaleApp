using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ScaleApp.Common
{
 public  class XmlAccess
    {
        public static T ReadXmlFromFile<T>(string filename)
        {
            using (var reader = XmlReader.Create(filename))    // Read Xml Data from file
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(T));
                return (T)deserializer.Deserialize(reader);
            }
        }
        public static void WriteXmlToFile<T>(string filename, T rootModel)
        {
            using (StreamWriter writer = new StreamWriter(filename))  // Write Xml to file
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(writer, rootModel);
            }
        }

    }
}
