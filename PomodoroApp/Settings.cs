using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodoroApp
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }
        private int _breakTime = 15;
        public int BreakTime
        {
            get { return _breakTime; }
            set { _breakTime = value; }
        }
        private int _workTime = 25;

        public int WorkTime
        {
            get { return _workTime; }
            set { _workTime = value; }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            BreakTime = GetBreakTime();
            WorkTime = GetWorkTime();
        }

        private int GetBreakTime()
        {
            int time;
            int.TryParse(setTimeOfBreak.Text,out time);
            return time;
        }
        private int GetWorkTime()
        {
            int time;
            int.TryParse(workTimeBox.Text, out time);
            return time;
        }
    }
}
