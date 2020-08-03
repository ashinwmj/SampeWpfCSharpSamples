using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList
{
    //each node has data and ref to next node
    public class SinglyLinkedList
    {
        public class Node
        {
            public int Data { get; set; }
            public Node next { get; set; }
        }

        public bool IsCircular(Node head)
        {
            if (head == null)
                return true;
            var nextNode = head.next;
            while (nextNode!=null && nextNode!=head)
            {
                nextNode = nextNode.next;
            }

            return (nextNode == head);
        }

        public Node CreateNewNode(int data)
        {
            var node=new Node();
            node.Data = data;
            node.next = null;
            return node;
        }
        public void Main()
        {
            var head = CreateNewNode(1);
            head.next = CreateNewNode(2);
            head.next.next = CreateNewNode(3);
           // head.next.next.next = head;
          var isCircular=  IsCircular(head);

        }
    }

  

}
