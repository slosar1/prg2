using System;

namespace prg2._1_intro
{
    public class Clock
    {
        int Hours;
        int MAX_HOURS = 23;
        int Minutes;
        int MAX_MINUTES = 59;
        int Seconds;
        int MAX_SECONDS = 59;
        public Clock(int hours, int minutes, int seconds)
        {
            Hours = 0;
            Minutes = 0;
            Seconds = 0;
        }
        public void SetTime(int Hour,int Minute,int Second)
        {
            Hours = Hour;
            Minutes = Minute;
            Seconds = Second;
        }
        public void Tick()
        {
            Seconds ++;
            if (Seconds > MAX_SECONDS)
            {
                Minutes ++;
                Seconds = 0;
                if (Minutes > MAX_MINUTES)
                {
                    Hours ++;
                    Minutes = 0;
                    if (Hours > MAX_HOURS)
                    {
                        Hours = 0;
                    }
                }
            }
        }
        public string DisplayTime()
        {
            return " "+Hours+":"+Minutes+""+Seconds;      
        }
    }
}