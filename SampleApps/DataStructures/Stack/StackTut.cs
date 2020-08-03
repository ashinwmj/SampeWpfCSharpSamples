using System;
using System.Collections;
using System.Text;

namespace DataStructures.Stack
{
   public class StackTut
    {
        System.Collections.Stack myStack=new System.Collections.Stack();
       

        public void Main()
        {
            myStack.Push("Ashin");
            myStack.Push(true);
            myStack.Push(null);
            myStack.Push(4);
            myStack.Push(62.2);
            foreach (var item in myStack)
            {
                Console.WriteLine(Convert.ToString(item));
            }
            myStack.Pop();
            foreach (var item in myStack)
            {
                Console.WriteLine(Convert.ToString(item));
            }

            Console.WriteLine(myStack.Peek());
            foreach (var item in myStack)
            {
                Console.WriteLine(Convert.ToString(item));
            }
        }
    }
}
