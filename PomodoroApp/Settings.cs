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
            set
            {
                if (value != 0)
                    _breakTime = value;
                else
                  MessageBox.Show("Długa przerwa nie może wynosić 0 minut!");
            }
        }
        private int _workTime = 25;

        public int WorkTime
        {
            get { return _workTime; }
            set
            { if (value != 0)
                _workTime = value;
              else
                MessageBox.Show("Czas pracy nie może wynosić 0 minut!");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            BreakTime = GetBreakTime();
            WorkTime = GetWorkTime();
            this.Close();
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
