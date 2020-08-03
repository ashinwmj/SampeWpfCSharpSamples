using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates.Tutorial1
{

    
  public static  class ClientClass2
    {
        
        public static void LongRunningMethod(Action<int> callback)
        {
            ClientClass1 class1 = new ClientClass1();
            for (int i = 0; i<10000; i++)
            {
                callback(i);
              // class1.PrintStatues(i);
              //instead

            }
        }

    }
}
