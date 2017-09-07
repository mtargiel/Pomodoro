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

        private void Counting_ChangeBreak(object sender, EventArgs e)
        {
           breakLabel.Text = ChangeBreakText();
        }

        private void startButton_Click(object sender, EventArgs e)
        {

            startButton.Text = "Zakończ";
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
            counting = new Counting(settings.WorkTime, settings.BreakTime);
            PlaySound(false);
            counting.ChangeBreak += Counting_ChangeBreak;
            breakLabel.Text = ChangeBreakText();
            timer.Start();
            SetProgressBar(counting.Minutes);
        }

        private void PlaySound(bool BreakSound)
        {
            SoundPlayer ticking = new SoundPlayer(@"tick.wav");
            SoundPlayer breakSound = new SoundPlayer(@"Alarm.wav");
            if (Properties.Settings.Default.ClockTicking && !BreakSound)
                ticking.PlayLooping();
            else if (Properties.Settings.Default.AlarmSound && BreakSound)
                breakSound.Play();
        }

        private void ClickButton()
        {
            timer.Stop();
            string mess;
            mess = $"Zakończyłeś sesję, ilość POMODORO {counting.GetBreakCounter()}";

            DialogResult result1 = MessageBox.Show(mess,  "Czy chcesz zrestartować pomodoro?",
                MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                AddStats();
                Start();
            }
            else if (result1 == DialogResult.No)
            {
                AddStats();
                this.Close();
            }
        }

        private void AddStats()
        {
            Stats stats = new Stats(counting.GetBreakCounter(), counting.GetSumOfMinutes(), counting.GetSumOfBreakMinutes(), counting.GetBreakCounter() * 5, DateTime.Now);
            stats.SaveToJson();
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
                PlaySound(true);
                SetProgressBar(counting.Minutes);
                return String.Format("Przerwa 5 minutowa");
            }
            else if (counting.IsLongBreak)
            {
                PlaySound(true);
                SetProgressBar(counting.MinutesOfBreak);
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

        private void czasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings.Activate();
            //TODO Cannot reopen settings after save
            settings.Show();
        }

        private void statystykiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatsForm stats = new StatsForm();
            stats.Show();
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
