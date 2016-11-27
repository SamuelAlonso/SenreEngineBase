using System;

namespace SenreEngine
{
    public class Time
    {
        public static float TimeSinceCallbackThisFunction()
        {
            Stopwatch SW = new Stopwatch();
            while (true)
            {
                return SW.ElapsedMilliseconds;
            }
        }
    }
}
