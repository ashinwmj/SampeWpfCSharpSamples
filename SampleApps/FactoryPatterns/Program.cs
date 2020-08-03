using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using DesignPatterns.ObserverPattern;
using DesignPatterns.ObserverPattern.SimplePattern;
using DesignPatterns.PubSubPattern;
using FactoryPatterns.AbstractFactory;
using FactoryPatterns.Adapter;
using FactoryPatterns.DecoratorPattern;
using FactoryPatterns.FactoryMethod;
using FactoryPatterns.StrategyPattern;

namespace FactoryPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Abstract Method
            //ContinentFactory africaFactory = new AfricaFactory();
            //AnimalWorld world = new AnimalWorld(africaFactory);
            //world.RunFoodChain();

            //ContinentFactory americaFactory = new AmericaFactory();
            //world = new AnimalWorld(americaFactory);
            //world.RunFoodChain();
            //#endregion

            //#region Decorator
            //var regularOrder = new RegularOrder();
            //Console.WriteLine(regularOrder.CalculateTotalOrderPrice());
            //Console.ReadLine();

            //var preOrder = new PreOrder();
            //Console.WriteLine(preOrder.CalculateTotalOrderPrice());
            //Console.ReadLine();

            //var premiumPreOrder = new PremiumPreOrder(preOrder);
            //Console.WriteLine(premiumPreOrder.CalculateTotalOrderPrice());
            //#endregion

            //#region Adapter Pattern

            //var xmlConverter = new XmlConverter();
            //var adapter=new XmlToJsonAdapter(xmlConverter);
            //adapter.ConvertXmlToJson();


            #endregion

            #region StrategyPattern

            //var ashinBill=new Bill();
            //ashinBill.CustomerName = "Ashin";
            //ashinBill.BillAount = 1000;
            //ashinBill.CustomerType = CustomerType.NonPremiumCustomer; 
            //var finalBill= ashinBill.GetFinalDiscountPrice();
            #endregion

            #region ObserverSimple

            var weatherStation=new WeatherStation();
            weatherStation.Subscribe(new NewsAgency());
            weatherStation.Subscribe(new PaperAgency());
            weatherStation.ReportWeather();

            #endregion

            #region PubSrb-Pattern
            var publiser=new Publisher();
            var sub1 = new Subscriber();
            var sub2 = new Subscriber();
            var sub3 = new Subscriber();
            sub1.Subscribe(publiser);
            sub2.Subscribe(publiser);
            sub3.Subscribe(publiser);
            publiser.Notify();
            sub3.Unsubscribe(publiser);
            publiser.Notify();
            #endregion


        }
    }

    public class EmployeeManager
    {
        private IList<Employee> _employees;

        public virtual string GetEmpDetailsAsXml()
        {
            return null;
        }
    }

    public class EmployeeManagerAdapter:EmployeeManager, IEmployeeManager
    {
        public string GetEmpDetailsAsJson()
        {
            var xml = base.GetEmpDetailsAsXml();
            return null;
        }
    }

    public interface IEmployeeManager
    {
        string GetEmpDetailsAsJson();
    }

    internal class Employee
    {
    }

    public class Client
    {
        void Method()
        {
            IEmployeeManager empManager=new EmployeeManagerAdapter();
            empManager.GetEmpDetailsAsJson();
        }
    }
}
