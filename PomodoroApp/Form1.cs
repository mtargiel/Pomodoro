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

        Counting counting = new Counting(25, 15);

        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ChangeText();
            counting.SubtrackMinute();
            progressBar.Value += 1;
        }

        private void ChangeText() => timeLabel.Text = String.Format("Do przerwy pozostało {0} sekund, {1} minut",
                counting.Seconds, counting.Minutes);

    }

}
