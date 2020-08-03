using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.PubSubPattern
{
   public class Publisher
    {
        public event EventHandler<MessageEventArgs> MessageEvent;
        public void Notify()
        {
            MessageEvent?.Invoke(this,new MessageEventArgs("Message from Publisher"));
        }
    }
}
