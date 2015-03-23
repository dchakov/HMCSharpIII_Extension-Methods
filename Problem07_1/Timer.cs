using System;
using System.Threading;

namespace Problem07_1
{
    public delegate void SampleDelegate(int seconds);

    public class Timer
    {
        static void TestMethod(int seconds)
        {
            while (true)
            {
                Console.WriteLine(DateTime.Now);
                Thread.Sleep(seconds);
            }

        }
        static void Main()
        {
            SampleDelegate d = new SampleDelegate(TestMethod);
            d(2000);
        }
    }
}
