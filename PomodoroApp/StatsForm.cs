using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodoroApp
{
    public partial class StatsForm : Form
    {
        public StatsForm()
        {
            InitializeComponent();
            List<Stats> listOfStats = ReadFromJson();
            dataGridView1.DataSource = listOfStats;
        }

        private static List<Stats> ReadFromJson()
        {
            using (StreamReader r = File.OpenText(@"..\..\file.json"))
            {

                List<Stats> Lista = JsonConvert.DeserializeObject<List<Stats>>(r.ReadToEnd());
                return Lista;
            }

        }



    }
}
