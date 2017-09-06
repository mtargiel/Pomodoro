using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroApp
{
    public class Stats
    {
        public int Cycles { get; set; }
        public int WorkingMinutes { get; set; }
        public int BreakMinutes { get; set; }
        public int ShortBreak { get; set; }
        public DateTime DateOfWork { get; set; }

        public Stats(int cycles, int workMinutes, int breakMinutes, int shortBreak, DateTime dateOfWork)
        {
            Cycles = cycles;
            WorkingMinutes = workMinutes;
            BreakMinutes = breakMinutes;
            ShortBreak = shortBreak;
            DateOfWork = dateOfWork;

        }
        public Stats()
        {

        }

        public void SaveToJson()
        {
            List<Stats> Lista;
            Lista = OpenFileJson();
            Lista = SaveToFileJson(Lista);

        }

        private List<Stats> SaveToFileJson(List<Stats> Lista)
        {
            using (StreamWriter file = File.CreateText(@"..\..\file.json"))
            {
                if (Lista != null)
                    Lista.Add(this);
                else
                    Lista = new List<Stats>() { this };

                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, Lista);
            }

            return Lista;
        }

        private static List<Stats> OpenFileJson()
        {
            List<Stats> Lista;
            using (StreamReader r = File.OpenText(@"..\..\file.json"))
            {

                Lista = JsonConvert.DeserializeObject<List<Stats>>(r.ReadToEnd());
            }

            return Lista;
        }
    }
}
