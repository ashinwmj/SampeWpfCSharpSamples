using System;
using System.Collections.Generic;
namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var booklist=new BookList();
            booklist.Add(new Book());

            var numList=new GenericList<int>();
            numList.Add(1);

            var genBook=new GenericList<Book>();
            genBook.Add(new Book());

            
        }

 
    }
}
