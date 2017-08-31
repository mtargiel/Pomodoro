using System;

namespace PomodoroApp
{
    public class Counting
    {
        public int Minutes { get; set; }
        public int LongBreakCounter { get; set; }
        private int _seconds = 0;
        public event EventHandler ChangeBreak;
        public int Seconds
        {
            get { return _seconds; }
            set { _seconds = value; }
        }

        int LongBreakTime { get; set; }
        private bool _isBreak;

        public bool IsBreak
        {
            get { return _isBreak; }
            set
            {
                _isBreak = value;
                    ChangeBreak(this, null);
                
            }
        }

        public bool IsLongBreak { get; set; }
        public int BreakCounter { get; set; }

        public Counting(int minutes, int breakTime)
        {
            this.Minutes = minutes;
            this.LongBreakTime = breakTime;
        }

        public void SubtrackMinute()
        {
            
            if (Seconds <= 0 && Minutes > 0)
            {
                Minutes--;
                Seconds = 60;
            }
            else if (Minutes <= 0 && Seconds <= 0)
            {
               setBreak();
            }
            else
                Seconds--;
        }

        private void setBreak()
        {
            if (IsBreak)
            {
                Minutes = 25;
                IsBreak = false;
            }
            else
            {
                Minutes = 1;
                IsBreak = true;
                BreakCounter++;
            }
            if (BreakCounter==5)
            {
                Minutes = 15;
                IsLongBreak = IsLongBreak ? false : true;
                BreakCounter = 0;
                LongBreakCounter++;
            }
        }

    }

}
