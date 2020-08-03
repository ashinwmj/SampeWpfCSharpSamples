using System;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    class Program
    {
        private static object syncLock=new object();
        static void Main(string[] args)
        {
            //Thread t1 = new Thread(RunLoop3);
            //Thread t2=new Thread(RunLoop3);
            //t1.Name = "Thread1";
            //t2.Name = "Thread2";
            //t1.Start();
           // Thread.Sleep(500);
            //t2.Start();
            Console.WriteLine("Main app ended");
            Parallel.For(0, 10, x => RunLoop2());

            //Tick Tak

        }

        public static void RunLoop1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} is Executing the  loop1 {i} time");
                Thread.Sleep(500);
            }

        }

        public static void RunLoop2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} is Executing the  loop2 {i} time");
                Thread.Sleep(500);
            }
        }
        public static void RunLoop3()
        {
            lock (syncLock)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name} is Executing the  loop2 {i} time");
                    Thread.Sleep(500);
                }
            }
        }
    }
}
