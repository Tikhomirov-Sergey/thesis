using System;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsFormsApplication8
{
    class JsonToObject
    {
        public static object objectFromJson(string jsonFile, object obj)
        {
            Type typeOfObject  = obj.GetType();
            
            FileStream fileStream = new FileStream(jsonFile, FileMode.Open);
            StreamReader reader = new StreamReader(fileStream);

            string str = reader.ReadToEnd();

            ParametersOfWorkpieces g = new ParametersOfWorkpieces();

            obj = JsonConvert.DeserializeAnonymousType(str, g);
            
            return g;
        }
    }
}

