using System;

namespace PomodoroApp
{
    public class Counting
    {
        public int Minutes { get; private set; }
        public int LongBreakCounter { get; private set; }
        private int _seconds = 0;
        public event EventHandler ChangeBreak;
        public int Seconds
        {
            get { return _seconds; }
            private set { _seconds = value; }
        }

        private bool _isBreak;

        public bool IsBreak
        {
            get { return _isBreak; }
            private set
            {
                _isBreak = value;
                    ChangeBreak(this, null);
            }
        }

        private bool _longBreak;
        public bool IsLongBreak
        {
            get { return _longBreak; }
            private set
            {
                _longBreak = value;
                ChangeBreak(this, null);
            }
        }
        public  int BreakMinutes
        {
            get
            {
                return _startBreakMinutes;
            }
            private set { _startBreakMinutes = value; }
        }
        public int BreakCounter { get; private set; }
        int _startMinutes;
        int _startBreakMinutes;
        public Counting(int minutes, int breakTime)
        {
            Minutes = minutes;
            _startMinutes = minutes;
            BreakMinutes = breakTime;

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
                Minutes = _startMinutes;
                IsBreak = false;
            }
            else if (IsLongBreak)
            {
                Minutes = _startBreakMinutes;
                IsLongBreak = false;
            }
            else
            {
                if (BreakCounter >= 4)
                {
                    IsLongBreak = true;
                    LongBreakCounter++;
                    BreakCounter = 0;
                }
                else
                {
                    Minutes = 5;
                    IsBreak = true;
                    BreakCounter++;
                }
            }
        }

    }

}
