using System;
using System.Linq;

namespace Pomodoro
{
    public class Counting
    {
        private bool _isBreak;
        bool _isLongBreak;
        private int _seconds;
        int _startMinutes;
        private int BreakCounter;
        private int LongBreakCounter;

        public Counting(int minutes, int longBreakMinutes, int breakMinutes)
        {
            StartMinutes = minutes;
            LongBreakMinutes = longBreakMinutes;
            BreakMinutes = breakMinutes;
        }

        public event EventHandler ChangeBreak;

        private void SetBreak()
        {
            if (BreakCounter >= 3)
            {
                LongBreakCounter++;
                BreakCounter = 0;
                Minutes = LongBreakMinutes;
                IsLongBreak = true;
            }
            else
            {
                Minutes = BreakMinutes;
                BreakCounter++;
            }
            IsBreak = true;
        }

        private void SetWork()
        {
            Minutes = StartMinutes;
            IsLongBreak = false;
            IsBreak = false;

        }

        private void SubtractMinute()
        {
            if (Minutes <= 0 && Seconds <= 0 && IsBreak)
            {
                SetWork();
            }
            else if (Minutes <= 0 && Seconds <= 0 && !IsBreak)
            {
                SetBreak();
            }
            Minutes--;
        }

        internal int GetSumOfBreakMinutes()
        {
            if (LongBreakCounter >= 1)
                return (LongBreakCounter * LongBreakMinutes) + (BreakMinutes * 3);
            else
                return BreakCounter * BreakMinutes;
        }

        internal int GetSumOfMinutes()
        {
            if (LongBreakCounter >= 1)
                return _startMinutes * LongBreakCounter * BreakCounter;
            else
                return _startMinutes * BreakCounter;
        }

        public int GetCycles() => LongBreakCounter;

        public void SubtractSecond()
        {
            if (Seconds <= 0)
            {
                SubtractMinute();
                Seconds = 60;
            }
            Seconds--;
        }

        public int BreakMinutes { get; private set; }

        public bool IsBreak
        {
            get
            {
                return _isBreak;
            }
            set
            {
                _isBreak = value;
                ChangeBreak(this, null);
            }
        }
        public bool IsLongBreak
        {
            get
            {
                return _isLongBreak;
            }
            set
            {
                _isLongBreak = value;
            }
        }
        public int LongBreakMinutes { get; private set; }
        public int Minutes { get; private set; }
        public int Seconds { get => _seconds; set => _seconds = value; }
        public int StartMinutes { get { return _startMinutes; } private set { _startMinutes = value; Minutes = value; } }
    }

}
