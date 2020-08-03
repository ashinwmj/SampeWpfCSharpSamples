using System;
using System.Threading.Channels;
using Delegates.PhotoProcessingTut;
using Delegates.Tutorial1;

namespace Delegates
{
    class Program
    {
        delegate double MyDelegate(double val);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Old way
            var del = new MyDelegate(CircleArea);
            var area = del(5);

            //Using Anonymous method and lambda expression
            MyDelegate del2 = r => 3.14 * r * r;
            var area2 = del2(4);
            //Using Func since parameter and return value is present
            Func<double, double> del3 = r => 3.14 * r * r;
            var area3 = del3(4);

            //Action used when there is no return type
            Action<string> del4 = x=>Console.WriteLine(x);

            //Predicate is used for checking purpose
            Predicate<string> checkLengthGreaterThan5 = x => x.Length > 5;
           var isle= checkLengthGreaterThan5("Ashin");

           ClientClass1 clientClass1=new ClientClass1();
           clientClass1.CallProcess();

           #region PhotoProcessing example
           var photoProcessor=new PhotoProcessor();
           var photoFilter=new PhotoFilter();
           Action<Photo> handler = photoFilter.ApplyBlackAndWhite;
           handler += photoFilter.ApplyForestFilter;
           photoProcessor.Process("url",handler);
           Console.ReadLine();



           #endregion


        }

        private static double CircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        private static void PrintName(string name)
        {
            Console.WriteLine(name);
        }


    }


}
