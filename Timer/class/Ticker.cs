using System;
using System.Collections.Generic;
using System.Text;

namespace Timer
{
	public class Ticker
	{
        private int StartTime=0;

	    public int CurrentTime
	    {
	        get { return StartTime; }
	    }

        public void Start()
        {
            StartTime=Registries.getreg("StartTime");
        }

        public string ConvertToTime()
        {
            // tickcount is in seconds, convert to a minutes: seconds string
            long seconds=StartTime;
            string val=(seconds/60/60).ToString("00")+":"+((seconds/60)%60).ToString("00")+":"+(seconds%60).ToString("00");
            return val;
        }

        public String Tick()
        {
            // Decrement the time
            StartTime--;
            return ConvertToTime();           
        }
	}
}
