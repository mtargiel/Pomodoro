using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroApp
{
    class JsonRW<T>
    {
        public T JsonObject { get; set; }
        public string FilePath { get; private set; }
        public JsonRW(T jsonObject, string filePath)
        {
            JsonObject = jsonObject;
            FilePath = filePath;
        }
        public JsonRW(string filePath)
        {
            FilePath = filePath;
        }
        public List<T> SaveToFileJson(List<T> Lista)
        {
            using (StreamWriter file = File.CreateText($@"{FilePath}"))
            {
                if (Lista != null)
                    Lista.Add(JsonObject);
                else
                    Lista = new List<T>() { JsonObject };

                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, Lista);
            }

            return Lista;
        }

        public List<T> OpenFileJson(List<T> Lista)
        {
            using (StreamReader r = File.OpenText($@"{FilePath}"))
            {
                Lista = JsonConvert.DeserializeObject<List<T>>(r.ReadToEnd());
            }
            return Lista;
        }
    }
}
