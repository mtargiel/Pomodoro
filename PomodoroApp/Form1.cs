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
    public partial class Form1 : Form
    {
        //TODO: Create settings window with app customization, 
        //TODO: Create statistic window. 
        //TODO: Add Sound
        //TODO: Add minimalize to tray function.

        Counting counting;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Counting_ChangeBreak(object sender, EventArgs e)
        {
           breakLabel.Text = ChangeBreakText();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            counting = new Counting((int)numericUpDownMinutes.Value, (int)numericUpDownBreak.Value);
            counting.ChangeBreak += Counting_ChangeBreak;

            timer.Start();
            breakLabel.Text = ChangeBreakText();
            progressBar.Value = (int)numericUpDownMinutes.Value*60;
            progressBar.Maximum = (int)numericUpDownMinutes.Value * 60;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value>0)
                progressBar.Value--;

            counting.SubtrackMinute();
            ChangeText();
        }

        private void ChangeText()
        {
            timeLabel.Text = String.Format("Pozostało {0} sekund, {1} minut",
                  counting.Seconds, counting.Minutes);
        }
        private string ChangeBreakText()
        {
            if (counting.IsBreak)
            {
                SetProgressBar(counting.Minutes);
                return String.Format("Przerwa 5 minutowa");
            }
            else if (counting.IsLongBreak)
            {
                SetProgressBar((int)numericUpDownBreak.Value);
                return String.Format("Przerwa {0} minutowa");
            }
            else
            {
                SetProgressBar(counting.Minutes);
                return "Do roboty!";
            }
        }

        private void SetProgressBar(int minutes)
        {
            progressBar.Maximum = minutes * 60;
            progressBar.Value = minutes * 60;
        }
    }

}
