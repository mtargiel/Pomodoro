using System;

namespace PomodoroApp
{
    public class Counting
    {
        public event EventHandler ChangeBreak;

        private int _seconds = 0;
        private bool _isBreak;
        private bool _longBreak;
        private int _startMinutes;
        private int _startBreakMinutes;
        private int breakCounter;

        public int GetBreakCounter() => breakCounter;
        public int GetSumOfMinutes() => _startMinutes*breakCounter;
        public int GetSumOfBreakMinutes() => (_startBreakMinutes * LongBreakCounter) + (breakCounter * 5);

        private void SetBreakCounter(int value) => breakCounter = value;

        public int Minutes { get; private set; }
        public int LongBreakCounter { get; private set; }
        public int Seconds
        {
            get { return _seconds; }
            private set { _seconds = value; }
        }

        public bool IsBreak
        {
            get { return _isBreak; }
            private set
            {
                _isBreak = value;
                    ChangeBreak(this, null);
            }
        }

        public bool IsLongBreak
        {
            get { return _longBreak; }
            private set
            {
                _longBreak = value;
                ChangeBreak(this, null);
            }
        }
        public  int MinutesOfBreak
        {
            get
            {
                return _startBreakMinutes;
            }
            private set { _startBreakMinutes = value; }
        }



        public Counting(int minutes, int breakTime)
        {
            Minutes = minutes;
            _startMinutes = minutes;
            MinutesOfBreak = breakTime;

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
                SetBreak();
            }
            else
                Seconds--;
        }

        private void SetBreak()
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
                if (GetBreakCounter() >= 4)
                {
                    IsLongBreak = true;
                    LongBreakCounter++;
                    SetBreakCounter(0);
                }
                else
                {
                    Minutes = 5;
                    IsBreak = true;
                    SetBreakCounter(GetBreakCounter() + 1);
                }
            }
        }

    }

}
