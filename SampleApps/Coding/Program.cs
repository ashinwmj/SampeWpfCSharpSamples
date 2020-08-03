using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Interfaces.Models.Interfaces;
using ServiceLayer;
using Unity;
using UnityContainer;

namespace Coding
{

    class Program
    {
        static async Task Main(string[] args)
        {
            //var result = FindFactorial(4);
            // var result = Reverse("Ashin");
            //var result = Reverse(100);
            //var result = SumOfEvenBwtWeenInc(2, 6);
            // var result = ShiftLeftByOne("Ashin");
            //PrintPrimeNumbersUpto(15);
            //Console.WriteLine(FindStringLength("ashin"));
            //SwapNos(2,3);
            // SumOfNo(123);
            // PrintFibunocci(12);
            //var signalRepo = new SignalRepository("tagmanagement.signals");
          //  var unityContainer = Container.Instance.GetUnityContainer();
            //var signalService = unityContainer.Resolve<ISignalService>();
            //var signals = await signalService.GetHarmonySignals();

            // BaseClass b=new DerivedClass();
            //  Stack stach=new Stack();
            //var en=  stach.GetEnumerator();
            //while (en.MoveNext())
            //{
            //    Console.WriteLine(en.Current);
            //}
            //  IList t=new ArrayList();
            //  stach.Push("sdasd");
            //  Stack<int> st =new Stack<int>(); 

        }


        static int FindFactorial(int n)
        {
            var num = 1;
            if (n == 0)
            {
                return 1;
            }

            for (int i = n; i >0; i--)
            {
                num *= i;
            }

            return num;
        }

        static string Reverse(string thestring)
        {
         string destination=String.Empty;
         for (int i = thestring.Length-1; i >=0; i--)
         {
             destination += thestring[i];
         }
         ;
         return destination;
        }

        static int Reverse(int n)
        {
            int reverse = 0;
            while (n>0)
            {
                int remainder = n % 10;
                reverse = reverse * 10 + remainder;
                n = n / 10;
            }

            return reverse;
        }

        static int SumOfEvenBwtWeenInc(int num1, int num2)
        {
            int sum = 0;
            while (num1<=num2)
            {
                if (num1 % 2 == 0)
                {
                    sum += num1;
                }

                num1++;
            }
            return sum;
        }

        static string ShiftLeftByOne(string inputString)
        {
            var charAray = inputString.ToCharArray();
            var  temp = charAray[0];
            int i = 0;
            for ( i = 0; i < charAray.Length-1; i++)
            {
                charAray[i] = charAray[i + 1];
            }

            charAray[i] = temp;
            return charAray.ToString();
        }

        /// <summary>
        /// Print prime nos upto the specified no which is passed
        /// </summary>
        /// <param name="n"></param>
        static void PrintPrimeNumbersUpto(int n)
        {
            bool isPrime = true;
            for (int i = 2; i < n; i++)
            {
                for (int j = 2; j < n; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;;
                    }
                
                }
                if (isPrime)
                {
                    Console.WriteLine(i);
                }
                isPrime = true;
            }
        }

        static int FindStringLength(string sourceString)
        {
            int count = 0;
            foreach (char charac in sourceString)
            {
                count = count + 1;
            }

            return count;
        }

        static void SwapNos(int first, int second)
        {
            Console.WriteLine($" first no {first}  : Second no {second}");
            int temp = 0;
            temp = first;
            first = second;
            second = temp;
            Console.WriteLine($"  After swapping first no {first}  : Second no {second}");
        }

        static void SumOfNo(int number)
        {
            int sum = 0;
            while (number>0)
            {
                var remainder = number % 10;
                sum = sum + remainder;
                number = number / 10;
            }

            Console.WriteLine(sum.ToString());

        }

        static void PrintFibunocci(int upperlimit)
        {
            var numlist=new List<int>();
            Console.WriteLine();
            for (int i = 0; i < upperlimit; i++)
            {
                if (i < 2)
                {
                    numlist.Add(i);
                    continue;
                }
                var no= numlist[i - 1] + numlist[i - 2];
                numlist.Add(no);
            }
            foreach (var num in numlist)
            {
                Console.WriteLine(num);
            }
        }
    }

    class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("From base class");
        }

 
    }

    class DerivedClass:BaseClass
    {
        public override void Print()
        {
            Console.WriteLine("From Derived class");
        }
        public void Read()
        {
            Console.WriteLine("Read from base");
        }
    }

    class teststatic
    {
        public  string teststring { get; set; }
    }
}
