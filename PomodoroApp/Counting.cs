using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomodoro
{
    public class Counting
    {
        private int BreakCounter;
        private int LongBreakCounter;
        public event EventHandler ChangeBreak;
        public int Minutes { get; private set; }
        int _startMinutes;
        public int StartMinutes { get { return _startMinutes; } private set { _startMinutes = value;  Minutes = value; } }
        public int LongBreakMinutes { get; private set; }
        public int BreakMinutes { get; private set; }
        private bool _isBreak;
        private int _seconds;
        public int Seconds { get => _seconds; set => _seconds = value; }

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
        public bool IsLongBreak { get; set; }
        public Counting(int minutes, int longBreakMinutes, int breakMinutes)
        {
            StartMinutes = minutes;
            LongBreakMinutes = longBreakMinutes;
            BreakMinutes = breakMinutes;
        }
        private void SubtractMinute()
        {
            if (Minutes <= 0 && IsBreak && Seconds <= 0)
            {
                SetWork();
            }
            else if (Minutes <= 0 && !IsBreak && Seconds <= 0)
            {
                SetBreak();
            }
            Minutes--;
        }

        private void SetBreak()
        {
            IsBreak = true;
            if (BreakCounter >= 3)
            {
                IsLongBreak = true;
                LongBreakCounter++;
                BreakCounter = 0;
                Minutes = LongBreakMinutes;
            }
            else
            {
                Minutes = BreakMinutes;
                BreakCounter++;
            }
        }

        public void SubtractSecond()
        {
            if (Seconds <= 0)
            {
                SubtractMinute();
                Seconds = 60;
            }
            Seconds--;
        }

        private void SetWork()
        {
            if (IsLongBreak)
                IsLongBreak = false;
            IsBreak = false;
            Minutes = StartMinutes;
        }

        public int GetCycles() => LongBreakCounter;

        internal int GetSumOfMinutes()
        {
            throw new NotImplementedException();
        }

        internal int GetSumOfBreakMinutes()
        {
            throw new NotImplementedException();
        }
    }

}
