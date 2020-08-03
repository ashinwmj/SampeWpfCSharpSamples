using System;
using DataStructures.CollectionBaseTut;
using DataStructures.LinkedList;
using DataStructures.Stack;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Pluralsight.Main.ListListOperationAddFirst();
            //SinglyLinkedList singlyList=new SinglyLinkedList();
            //singlyList.Main();
           // StackTut stacktut=new StackTut();
            //stacktut.Main();
            //#region CollectionBase

            //var myCollection=new AshinContainer();
            //myCollection.Add("Ashin");
            //myCollection.Add("Bhavaneeth");
            //foreach (var item in myCollection)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            //Console.ReadLine();

            //#endregion

            //#region Array Rotation
            //int [] array=new int[]{1,2,3,4,5,6};  // n=6 , no of rotations =2
            ////rotate left by one
            //RotateLeft(array,2);


            //#endregion

           
        
        }

        public static void RotateLeft(int[] item, int noOfRotation)
        {
            var array = item;
            for (int i = 0; i < noOfRotation; i++)
            {
                RotateByOne(array);
            }
            foreach (var t in array)
            {
                Console.Write(t);
                Console.Write(" ,");
            }
        }

        private static void RotateByOne(int[] array)
        {
            var temp = array[0];
            int i = 0;
            for (i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            array[i] = temp;
        }

        public static class MyClass
        {
            public static int age = 10;
        }
    }
}
