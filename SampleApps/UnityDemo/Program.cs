using System;
using Unity;
using Unity.Injection;

namespace UnityDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var unityContainer=new UnityContainer();
            unityContainer.RegisterType<ICar, Audi>();
            unityContainer.RegisterType<ICar, BMW>("LuxuryCar");
            unityContainer.RegisterType<Driver>("LuxuryCarDriver",
                new InjectionConstructor(unityContainer.Resolve<ICar>("LuxuryCar")));

            var driver1 = unityContainer.Resolve<Driver>("LuxuryCarDriver");
            driver1.Drive();
            Console.ReadLine();

        }
        
    }
    public class Audi : ICar
    {
        private int _miles=0;
        public int Run()
        {
          return  ++_miles;
        }
    }
    public class BMW : ICar
    {
        private int _miles=0;
        public int Run()
        {
           return ++_miles;
        }
    }
    public interface ICar
    {
        int Run();
    }

    public class Driver
    {
        private ICar _car;
        public Driver(ICar car)
        {
            _car = car;
        }
        public void Drive()
        {
            Console.WriteLine($"Running {_car.GetType()} {_car.Run()}");
        }
    }
}
