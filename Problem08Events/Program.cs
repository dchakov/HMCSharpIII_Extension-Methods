using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem08Events
{
    class Program
    {
        static void Main()
        {
            //https://msdn.microsoft.com/en-us/library/system.timers.elapsedeventargs.signaltime(v=vs.110).aspx
            //https://msdn.microsoft.com/en-us/library/system.timers.timer.interval(v=vs.110).aspx

            //Problem 8.* Events• Read in MSDN about the keyword  event  in C# and how to publish events.
            //• Re-implement the above using .NET events and following the best practices.
            
            Publisher pub = new Publisher();
            Subscriber sub1 = new Subscriber(pub);
            
            pub.DoSomething(2000);

        }
    }
}
