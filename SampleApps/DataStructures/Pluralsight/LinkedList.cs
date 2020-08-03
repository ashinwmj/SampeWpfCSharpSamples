using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace DataStructures.Pluralsight
{
   public class LinkedList<T>
    {
        public int Count { get; set; }
        public LinkedListNode<T> Head { get; set; }
        public LinkedListNode<T> Tail { get; set; }

        public void AddToFirst(LinkedListNode<T> node)
        {
            if (Count == 0)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                var temp=new LinkedListNode<T>();;
                temp = Head;
                Head = node;
                Head.Next = temp;

            }

            Count++;
        }
        public void AddToLast(LinkedListNode<T> node)
        {
            if (Count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
            }
            Tail = node;
            Count++;

        }

        public void RemoveFromLast()
        {
            if (Count != 0)
            {
                if (Count == 1)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    var current = Head;
                    while (current.Next!=Tail)
                    {
                        current = current.Next;
                    }

                    current.Next = null;
                    Tail = current;
                }

                Count--;
            }

        }

        public void RemoveFromFirst()
        {
            if (Count != 0)
            {
                Head = Head.Next;
                Count--;
                if (Count == 0)
                {
                    Head = null;
                    Tail = null;
                }
            }

        }
        public void IterateList(LinkedList<T> list)
        {
            if (list != null)
            {
                var node = list.Head;
                while (node!=null)
                {
                    Console.WriteLine(node.Value);
                    node = node.Next;
                }
            }
        }
    }



   public class LinkedListNode<T> 
   {
       public T Value { get; set; }
       public LinkedListNode<T> Next { get; set; }
   }

   public static class Main
   {
       public static void ListListOperationAddLast()
       {
           var linkedList = new LinkedList<int>();
           var first=new LinkedListNode<int>(){Value = 1};
           var second = new LinkedListNode<int>() {Value = 2};
           linkedList.AddToLast(first);
           linkedList.AddToLast(second);
           linkedList.IterateList(linkedList);
       }
       public static void ListListOperationAddFirst()
       {
           var linkedList = new LinkedList<int>();
           var first = new LinkedListNode<int>() { Value = 1 };
           var second = new LinkedListNode<int>() { Value = 2 };
           linkedList.AddToFirst(first);
           linkedList.AddToFirst(second);
           linkedList.IterateList(linkedList);
       }


    }


}
