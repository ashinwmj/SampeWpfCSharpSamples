
using System;

namespace DesignPatterns.PubSubPattern
{
    public class Subscriber
    {
        
        public void Subscribe(Publisher pub)
        {
            pub.MessageEvent += Update;
        }

       
        public void Unsubscribe(Publisher pub)
        {
            pub.MessageEvent -= Update;
        }
        private void Update(object sender, MessageEventArgs e)
        {
            Console.WriteLine(e.Message);
        }


    }
}