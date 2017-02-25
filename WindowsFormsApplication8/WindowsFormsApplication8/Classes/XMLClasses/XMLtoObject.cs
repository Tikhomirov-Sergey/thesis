using System;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace WindowsFormsApplication8
{
    class XMLtoObject
    {
        public static object inaccuracyOfPositioningPartFromXML(string xmlFile, object obj)
        {
            Type typeOfObject  = obj.GetType();
            XmlSerializer xmlSerialize = new XmlSerializer(typeOfObject);

            FileStream fileStream = new FileStream(xmlFile, FileMode.Open);
            XmlReader reader = XmlReader.Create(fileStream);

            obj = xmlSerialize.Deserialize(reader);
            return obj;
        }
    }
}
