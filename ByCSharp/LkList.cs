using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace ByCSharp
{
    class Node
    {
        public int data;
        public Node next;
        public Node(int i)
        {
            data = i;
            next = null;
        }
        public void AddToEnd(int data)
        {
            if (next == null)
            {
                next = new Node(data);
            }
            else
            {
                next.AddToEnd(data);
            }
        }
        public void Display()
        {
            Console.Write($"| {data} | -->");
            if (next != null)
            {
                next.Display();
            }
        }
    }

    class  MyList
    {
        public Node head;
        public MyList()
        {
            head = null;
        }

        public void AddToEnd(int data)
        {
            if (head == null)
            {
                head = new Node(data);
            }
            else
            {
                head.AddToEnd(data);
            }
        }

        public void AddToBeg(int data)
        {
            if (head == null)
            {
                head = new Node(data);
            }
            else
            {
                Node temp = new Node(data);
                temp.next = head;
                head = temp;
            }
        }
        public void Display()
        {
            if (head != null)
            {
                head.Display();
            }
        }
    }

    class Tst
    {
        //public static void Main(string[] args)
        //{
        //    MyList myNode = new MyList();
        //    myNode.AddToEnd(7);
        //    myNode.AddToEnd(8);
        //    myNode.AddToBeg(5);
        //    myNode.Display();
        //}
    }
}
