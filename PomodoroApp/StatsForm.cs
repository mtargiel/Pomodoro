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
            dataGridView1.DataSource = new JsonRW<Stats>(@"file.json").OpenFileJson(new List<Stats>());
        }

    }
}
