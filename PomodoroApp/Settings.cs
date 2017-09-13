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
            soundOfTicking.Checked = Properties.Settings.Default.ClockTicking;
            breakSound.Checked = Properties.Settings.Default.AlarmSound;
            setTimeOfBreak.Text = BreakTime.ToString();
            workTimeBox.Text = WorkTime.ToString();
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

        public int breakMinutes { get; private set; }

        private void saveButton_Click(object sender, EventArgs e)
        {
            BreakTime = GetBreakTime();
            WorkTime = GetWorkTime();
            CheckBoxState();
            Close();
        }

        private int GetBreakTime()
        {
            int.TryParse(setTimeOfBreak.Text, out int time);
            return time;
        }
        private int GetWorkTime()
        {
            int.TryParse(workTimeBox.Text, out int time);
            return time;
        }

        private void CheckBoxState()
        {
            if (soundOfTicking.Checked)
                Properties.Settings.Default.ClockTicking = true;
            else
                Properties.Settings.Default.ClockTicking = false;
            if (breakSound.Checked)
                Properties.Settings.Default.AlarmSound = true;
            else
                Properties.Settings.Default.AlarmSound = false;

            Properties.Settings.Default.Save();

        }

    }
}
