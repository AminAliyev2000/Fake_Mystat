using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp9
{
    public static  class JsonReadWrite
    {
        public static void JSONSerialization(string data, string fileName)
        {
            if ((!string.IsNullOrWhiteSpace(data)) && (!string.IsNullOrWhiteSpace(fileName)))
            {
                var serializer = new JsonSerializer();

                if (!Directory.Exists("Data"))
                {
                    Directory.CreateDirectory("Data");
                }

                using (var sw = new StreamWriter($"Data/{fileName}"))
                {
                    using (var jw = new JsonTextWriter(sw))
                    {
                        jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                        serializer.Serialize(jw, data);
                    }
                }
            }
        }

        public static void JSONDeSerialization(ref string data, string fileName)
        {
            if (!string.IsNullOrWhiteSpace(fileName))
            {
                var serializer = new JsonSerializer();

                using (var sr = new StreamReader($"Data/{fileName}"))
                {
                    using (var jr = new JsonTextReader(sr))
                    {
                        data = serializer.Deserialize<string>(jr);
                    }
                }
            }
        }


        public static void JSONSerialization<T>(List<T> datas, string fileName)
        {
            var serializer = new JsonSerializer();

            if (!Directory.Exists("Data"))
            {
                Directory.CreateDirectory("Data");
            }

            using (var sw = new StreamWriter($"Data/{fileName}"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, datas);
                }
            }
        }


        public static void JSONDeSerialization<T>(ref List<T> datas, string fileName)
        {
            var serializer = new JsonSerializer();

            using (var sr = new StreamReader($"Data/{fileName}"))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    datas = serializer.Deserialize<List<T>>(jr);
                }
            }
        }
    }
}
