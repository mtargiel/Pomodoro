namespace PomodoroApp
{
    public class Counting
    {
        public int Minutes { get; set; }
        public int LongBreakCounter { get; set; }
        private int _seconds = 60;

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
            set { _isBreak = value; }
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
            Seconds--;
            if (Seconds == 0)
            {
                Minutes -= 1;
                Seconds = 60;
            }

            if (Minutes == 0)
                setBreak();
        }

        private void setBreak()
        {
            if (IsBreak)
                IsBreak = false;
            else
            {
                Minutes = 5;
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
