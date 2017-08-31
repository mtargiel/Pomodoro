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

        private bool _longBreak;
        public bool IsLongBreak
        {
            get { return _longBreak; }
            set
            {
                _longBreak = value;
                ChangeBreak(this, null);
            }
        }

        public int BreakCounter { get; set; }
        private int _startMinutes;
        private int _startBreakMinutes;
        public Counting(int minutes, int breakTime)
        {
            Minutes = minutes;
            _startMinutes = minutes;
            _startBreakMinutes = breakTime;

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
                IsLongBreak = IsLongBreak ? false : true;
                setBreak();
            }
            else
                Seconds--;
        }

        private void setBreak()
        {
            if (IsBreak)
            {
                Minutes = _startMinutes;
                IsBreak = false;
            }
            else
            {
                Minutes = 1;
                IsBreak = true;
                BreakCounter++;
            }
            if (BreakCounter==5 && IsLongBreak == false)
            {
                Minutes = _startBreakMinutes;
                IsLongBreak = IsLongBreak ? false : true;
                BreakCounter = 0;
                LongBreakCounter++;
            }
        }

    }

}
