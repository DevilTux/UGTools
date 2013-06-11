using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using Newtonsoft.Json;

namespace UGTools.Utils
{
    public static class JSonObject
    {
        public static string Serialize<T>(T obj)
        {
            //var serializer = new DataContractJsonSerializer(obj.GetType());
            //var ms = new MemoryStream();
            //serializer.WriteObject(ms, obj);
            //string retVal = Encoding.UTF8.GetString(ms.ToArray());
            //return retVal;
            string result = JsonConvert.SerializeObject(obj);
            return result;
        }

        public static T Deserialize<T>(string json)
        {
            //var obj = Activator.CreateInstance<T>();
            //var ms = new MemoryStream(Encoding.Unicode.GetBytes(json));
            //var serializer = new DataContractJsonSerializer(obj.GetType());
            //obj = (T)serializer.ReadObject(ms);
            //ms.Close();
            //return obj;
            var obj=(T)JsonConvert.DeserializeObject(json, typeof(T));
            return obj;
        }
    }
}
