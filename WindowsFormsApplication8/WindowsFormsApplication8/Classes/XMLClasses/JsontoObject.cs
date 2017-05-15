using System;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsFormsApplication8
{
    class FileToObject
    {
        public static object objectFromJson(string jsonFile, object obj)
        {//не работает
            Type typeOfObject  = obj.GetType();
            
            FileStream fileStream = new FileStream(jsonFile, FileMode.Open);
            StreamReader reader = new StreamReader(fileStream);

            string str = reader.ReadToEnd();

            ParametersOfSurfacesAfterVariousOperations g = new ParametersOfSurfacesAfterVariousOperations();

            obj = JsonConvert.DeserializeAnonymousType(str, g);
            
            return obj;
        }

        public static object objectFromXML(string xmlFile, object obj)
        {
            Type typeOfObject = obj.GetType();
            XmlSerializer xmlSerialize = new XmlSerializer(typeOfObject);

            FileStream fileStream = new FileStream(xmlFile, FileMode.Open);
            XmlReader reader = XmlReader.Create(fileStream);

            obj = xmlSerialize.Deserialize(reader);

            return obj;
        }
    }
}

