using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text;

namespace SOLID.OpenClosed
{
    public class Rectangle
    {
        public double Length { get; set; }
        public double Breadth { get; set; }
            
    }
    public class Circle
    {
        public double Radius { get; set; }

    }

    /// <summary>
    /// Class to Calculate the area of shapes
    /// </summary>
    public class AreaCalculator
    { 
    //Each time  new shape is added this class is open for modification , size of the class keeps on increases
        public double CalculateArea(object obj)
        {
            double area = 0;
            if (obj is Rectangle)
            {
                var rect = (Rectangle) obj;
                area = rect.Length * rect.Breadth;
            }
            if (obj is Circle)
            {
                var circle = (Circle)obj;
                area = Math.PI * Math.Pow(circle.Radius, 2);
            }

            return area;

        }
    }


    //***********************************************Refactored***********************************************************************

    public interface IShape
    {
        double CalculateArea();
    }

    public class RectangleRefactored:IShape
    {
        public double Length { get; set; }
        public double Breadth { get; set; }

        public double CalculateArea()
        {
            return Length * Breadth;
        }
    }

    public class CircleRefactored:IShape
    {
        public double Radius { get; set; }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }


    //*********************************Client Code*************************************************************************************
    public class Client
    {
        public void Main()
        {
            var areaCalculator=new AreaCalculator();
            var circleArea = areaCalculator.CalculateArea(new Circle() {Radius = 4});
            var rectArea = areaCalculator.CalculateArea(new Rectangle() {Length = 4, Breadth = 5});

            //AfterRefactoring
            IShape circle=new CircleRefactored(){Radius = 4};
            var CircleAreaNew = circle.CalculateArea();
            IShape rectangleShape=new RectangleRefactored(){Length = 3,Breadth = 5};
            var rectangleAreaNew = rectangleShape.CalculateArea();
        }
    }


    public class ReportGenerator
    {
        public string ReportType { get; set; }

        public void GenerateReport(string ReportType)
        {
            if (ReportType == "PDF")
            {
                //
            }
            if (ReportType == "CSV")
            {
                //
            }
        }
    }

    public abstract class ReportGeneratorRef
    {
        public abstract void GenerateReport();

    }

    public class CSVGenerator:ReportGeneratorRef
    {
        public override void GenerateReport()
        {
           //
        }
    }
    public class PDFGenerator : ReportGeneratorRef
    {
        public override void GenerateReport()
        {
            //
        }
    }

    public class Client1
    {
        public void ReportGen()
        {
           var pdfGen=new PDFGenerator();
           pdfGen.GenerateReport();
        }

    }

    public abstract class employee
    {
        public abstract Guid Id { get; set; }

        public abstract void GetEmployeeProDetails();
        public abstract void GetEmployeeDetails();

    }

    public class PermanenetEmployee:employee
    {
        public override Guid Id { get; set; }

        public override void GetEmployeeProDetails()
        {
            //
        }

        public override void GetEmployeeDetails()
        {
          //
        }
    }
    public class TemperoryEmplyee : employee
    {
        public override Guid Id { get; set; }

        public override void GetEmployeeProDetails()
        {
            //
        }

        public override void GetEmployeeDetails()
        {
            new NotImplementedException();
        }
    }

    public class employeeClient
    {
        public void Method()
        {
            var emp1=new TemperoryEmplyee(){Id = new Guid()};
            var emp2 = new PermanenetEmployee() { Id = new Guid() };

            var empList=new List<employee>();
            empList.Add(emp1);
            empList.Add(emp2);
            foreach (var employee in empList)
            {
                employee.GetEmployeeDetails();
            }
        }
    }

    public class Email
    {
        public void SendEmail(string message)
        {
            //
        }
    }

    public interface IMessenger
    {
        void SendMessage(string message);
    }

    public class EmailRef:IMessenger
    {
        public void SendMessage(string message)
        {
            
            //
        }
    }
    public class SMS : IMessenger
    {
        public void SendMessage(string message)
        {

            //
        }
    }

    public class Notification
    {
        private IMessenger _message;

        public Notification(IMessenger message)
        {
            _message = message;
        }
        public void SendNotification(string data)
        {
            _message.SendMessage(data);
        }
    }
    public class Notification1
    {
        private IMessenger _messanger;
        public IMessenger Type 
        {
            set
            {
                _messanger = value;
            }
        }
        public void SendNotification(string data)
        {
            _messanger.SendMessage(data);
        }
    }
    public class Notification2
    {
      
        public void SendNotification(IMessenger messanger,string data)
        {
            messanger.SendMessage(data);
        }
    }
}
