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
        public DateTime DateOfWork { get; set; }

        public Stats(int cycles, int workMinutes, int breakMinutes, DateTime dateOfWork)
        {
            Cycles = cycles;
            WorkingMinutes = workMinutes;
            BreakMinutes = breakMinutes;
            DateOfWork = dateOfWork;

        }
        public Stats()
        {

        }

        public void SaveToJson()
        {
            List<Stats> Lista = new List<Stats>();
            JsonRW<Stats> jsonRW = new JsonRW<Stats>(this, Properties.Settings.Default.jsonFileLocation);
            Lista = jsonRW.OpenFileJson(Lista);
            jsonRW.SaveToFileJson(Lista);
        }

    }
}
