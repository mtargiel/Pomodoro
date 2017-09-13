using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            try
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
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("File {0} not found!", ex.FileName);
            }
            catch (IOException ex)
            {
                MessageBox.Show(
                    "{0}: The write operation could not " +
                    "be performed because the specified " +
                    "part of the file is locked.",
                    ex.GetType().Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return Lista;
        }

        public List<T> OpenFileJson(List<T> Lista)
        {
            try
            {
                using (StreamReader r = File.OpenText($@"{FilePath}"))
                {
                    Lista = JsonConvert.DeserializeObject<List<T>>(r.ReadToEnd());
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"File {ex.FileName} not found!");
            }
            catch (IOException ex)
            {
                MessageBox.Show(
                    $"{ex.GetType().Name}: The write operation could not " +
                    "be performed because the specified " +
                    "part of the file is locked.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return Lista;
        }
    }
}
