using System;
using System.Threading;

namespace Problem08Events
{
    public class Publisher
    {
        public event EventHandler RaiseCustomEvent;

        public void DoSomething(int seconds)
        {
            while (true)
            {
                Console.WriteLine(DateTime.Now);
                Thread.Sleep(seconds);
            }
        }

        protected virtual void OnRaiseCustomEvent()
        {
            EventHandler handler = RaiseCustomEvent;
            if (handler != null)
            {
                handler(this, null);
            }
        }

    }
}
