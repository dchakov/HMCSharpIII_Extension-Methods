//Problem 7. Timer• Using delegates write a class  Timer  that can execute certain method at each  t  seconds.

using System;
using System.Threading;

namespace Problem07
{
    public static class Timer
    {
        //https://msdn.microsoft.com/en-us/library/system.timers.timer.interval(v=vs.110).aspx
        //https://msdn.microsoft.com/en-us/library/System.Timers.Timer(v=vs.110).aspx
        //http://stackoverflow.com/questions/186084/how-do-you-add-a-timer-to-a-c-sharp-console-application

        private static void TimerCallback(Object o)
        {
            Console.WriteLine("TimerCallback:"+DateTime.Now);
            GC.Collect();
        }
        public static void Main()
        {
            Console.WriteLine("Press Enter to exit");
            System.Threading.Timer t = new System.Threading.Timer(TimerCallback, null, 0, 2000);
            Console.ReadLine();
        }
    }
}
