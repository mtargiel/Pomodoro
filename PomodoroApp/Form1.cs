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
        //TODO Add delegate and event to check break

        Counting counting = new Counting(1, 15);
        public Form1()
        {
            InitializeComponent();
            ChangeBreakText();
            counting.ChangeBreak += Counting_ChangeBreak;
            
        }

        private void Counting_ChangeBreak(object sender, EventArgs e)
        {
            ChangeBreakText();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            progressBar.Maximum = counting.Minutes * 60;
            progressBar.Value = counting.Minutes * 60;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            counting.SubtrackMinute();
            ChangeText();
            //if (progressBar.Value == 0)
            //    progressBar.Value = counting.Minutes*60;
            //progressBar.Value--;
        }

        private void ChangeText()
        {
            timeLabel.Text = String.Format("Do przerwy pozostało {0} sekund, {1} minut",
                  counting.Seconds, counting.Minutes);
        }
        private void ChangeBreakText()
        {
            breakLabel.Text = String.Format("Krótka przerwa: {0}, Długa przerwa: {1}", counting.IsBreak, counting.IsBreak);
            countingBreaks.Text = String.Format("Ilość krótkich przerw {0}, długich {1}", counting.BreakCounter, counting.LongBreakCounter);
        }


    }

}
