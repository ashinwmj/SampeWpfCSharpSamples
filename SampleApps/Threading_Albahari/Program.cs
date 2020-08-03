using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading_Albahari
{
    class Program
    {
        static void Main(string[] args)
        {
            var thread1=new Thread(PrintHello);
            thread1.Start();
            new Thread(PrintHello).Start();
            var thread2=new Thread((() => Console.WriteLine("Hello")));
            var thread3=new Thread((() => PrintMessage("Ashin")));
            thread3.Start();
            var thread4=new  Thread(PrintMessage);
            thread4.Start("Ashin");
        }

        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static void PrintMessage(object obj)
        {
            var message = (string) obj;
            Console.WriteLine(message);
        }
        public static void PrintHello()
        {
            Console.WriteLine("Hello");
        }
    }
}
