using System;
using System.Threading.Tasks;

namespace Problem08Events
{
    public class Subscriber
    {
        public Subscriber(Publisher pub)
        {
            pub.RaiseCustomEvent += HandleCustomEvent;
        }
        // Define what actions to take when the event is raised. 
        public void HandleCustomEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Event: {0}", DateTime.Now);
        }
    }


}
