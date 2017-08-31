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
        //TODO: Fix long break text, fix status bar
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
            progressBar.Maximum = counting.Minutes * 60;
            progressBar.Value = counting.Minutes * 60;
            timer.Start();
            breakLabel.Text = ChangeBreakText();
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
            timeLabel.Text = String.Format("Pozostało {0} sekund, {1} minut",
                  counting.Seconds, counting.Minutes);
        }
        private string ChangeBreakText()
        {
            if (counting.IsBreak)
            {
                return String.Format("Przerwa 5 minutowa");
            }
            else if (!counting.IsBreak)
            {
                return "Do roboty!";
            }
            else if (counting.IsLongBreak)
            {
                return String.Format("Przerwa {0} minutowa");
            }
                return "Do roboty!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
