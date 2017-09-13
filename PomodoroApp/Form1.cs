using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Pomodoro;

namespace PomodoroApp
{
    public partial class Form1 : Form
    {


        Counting counting;
        Settings settings = new Settings();
        new bool Click;
        public Form1()
        {
            InitializeComponent();
        }

        private void Counting_ChangeBreak(object sender, EventArgs e) => breakLabel.Text = ChangeBreakText();

        private void startButton_Click(object sender, EventArgs e)
        {

            startButton.Text = "Interrupt";
            if (Click)
                ClickButton();
            else
            {
                Start();
                Click = true;
            }
        }

        private void Start()
        {
            counting = new Counting(settings.WorkTime, settings.BreakTime, 5);
            PlaySound(false);
            counting.ChangeBreak += Counting_ChangeBreak;
            breakLabel.Text = ChangeBreakText();
            timer.Start();
            SetProgressBar(counting.Minutes);
        }

        private void PlaySound(bool BreakSound)
        {
            SoundPlayer ticking = new SoundPlayer(@"Data/tick.wav");
            SoundPlayer breakSound = new SoundPlayer(@"Data/Alarm.wav");
            if (Properties.Settings.Default.ClockTicking && !BreakSound)
                ticking.PlayLooping();
            else if (Properties.Settings.Default.AlarmSound && BreakSound)
                breakSound.Play();
        }

        private void ClickButton()
        {
            timer.Stop();
            string mess;
            mess = $"You interrupt, end cycles: {counting.GetCycles()}";

            DialogResult result1 = MessageBox.Show(mess,  "Do you want to restart pomodoro?",
                MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                AddStats();
                Start();
            }
            else if (result1 == DialogResult.No)
            {
                AddStats();
                Close();
            }
        }

        private void AddStats()
        {
            Stats stats = new Stats(counting.GetCycles(), counting.GetSumOfMinutes(), counting.GetSumOfBreakMinutes(), DateTime.Now);
            stats.SaveToJson();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value>0)
                progressBar.Value--;

            counting.SubtractSecond();
            ChangeText();
        }

        private void ChangeText()
        {
            timeLabel.Text = String.Format("Left {0} seconds, {1} minutes",
                  counting.Seconds, counting.Minutes);
        }
        private string ChangeBreakText()
        {

            return counting.IsBreak?counting.IsLongBreak? 
            $"Long break {counting.LongBreakMinutes}": 
            $"Short break" : 
            $"Go to work!";
            //if (counting.IsBreak)
            //{
            //    PlaySound(true);
            //    SetProgressBar(counting.Minutes);
            //    return String.Format("Short break");
            //}
            //else if (counting.IsLongBreak)
            //{
            //    PlaySound(true);
            //    SetProgressBar(counting.Minutes);
            //    return String.Format("Long break {0} minutes", counting.LongBreakMinutes );
            //}
            //else
            //{
            //    PlaySound(false);
            //    SetProgressBar(counting.Minutes);
            //    return "Go to work!";
            //}
        }

        private void SetProgressBar(int minutes)
        {
            progressBar.Maximum = minutes * 60;
            progressBar.Value = minutes * 60;
        }

        private void CzasToolStripMenuItem_Click(object sender, EventArgs e)
        {
                settings = new Settings();
                settings.Show();
        }

        private void StatystykiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatsForm stats = new StatsForm();
            stats.Show();
        }

        private void ZakończToolStripMenuItem_Click(object sender, EventArgs e) => Close();
    }

}
