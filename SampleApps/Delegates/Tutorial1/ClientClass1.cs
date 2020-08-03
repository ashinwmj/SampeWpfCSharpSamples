using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates.Tutorial1
{
    public class ClientClass1
    {
        public void CallProcess()
        {
           ClientClass2.LongRunningMethod(PrintStatues);
           Console.ReadLine();
        }

        public void PrintStatues(int i)
        {
            Console.WriteLine(i);
        }
    }
}
