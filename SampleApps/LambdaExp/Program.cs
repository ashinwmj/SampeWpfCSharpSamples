using System;

namespace LambdaExp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Square(5));
            Func<int,int> squareFunc = x => x * x; //no access modifier, no method name ,no return statement
            Console.WriteLine(squareFunc(4));
            Console.ReadLine();
        }

        public static int Square(int num)
        {
            return num * num;
        }
    }
}
