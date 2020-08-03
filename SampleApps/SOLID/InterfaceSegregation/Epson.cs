using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.InterfaceSegregation
{
    public interface IPrint
    {
        void Scan();
        void Print();
        void Fax();
    }
    // Statement:Client should not be forced to implement interfaces they don't use.
    /// <summary>
    /// Supports print, copy and Fax
    /// </summary>
    public class Epson:IPrint
    {
        public void Scan()
        {
         //logic to scan
        }

        public void Print()
        {
           //logic to print
        }

        public void Fax()
        {
         //logic to fax
        }
    }
    /// <summary>
    /// Supports only print scan and print
    /// </summary>
    public class Canon:IPrint
    {
        public void Scan()
        {
            //logic to scan
        }

        public void Print()
        {
          //logic to print
        }

        public void Fax()
        {
            //force to implement 
            throw new NotImplementedException();
        }
    }


    //********************************************Refactored*****************************************************************
    public interface IPrint1
    {
        void Print();
    }
    public interface IScan
    {
        void Scan();
    }
    public interface IFax
    {
        void Fax();
    }
    public class EpsonRef : IPrint1,IScan,IFax
    {
        public void Scan()
        {
            //logic to scan
        }

        public void Print()
        {
            //logic to print
        }

        public void Fax()
        {
            //logic to fax
        }
    }
    /// <summary>
    /// Supports only print scan and print
    /// </summary>
    public class CanonRef : IPrint1,IScan
    {
        public void Scan()
        {
            //logic to scan
        }

        public void Print()
        {
            //logic to print
        }
    }

    //*******************************Client*******************************************************
    public class Client
    {
        public void Main()
        {
            //print a document using canon
            IPrint1 canon=new CanonRef();
            canon.Print();
        }
    }

}
