using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankExamples
{
    // https://www.hackerrank.com/challenges/30-linked-list/problem
    // Essentially getting the tail of a linked list to add a new node to it
    class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }

    }
    class _30DaysDay15LinkedList
    {
        static void Main(String[] args)
        {

            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = Insert(head, data);
            }
            Display(head);
        }

        public static void Display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }

        public static Node Insert(Node head, int data)
        {
            //Complete this method
            if (head == null)
            {
                Node newNode = new Node(data);
                return newNode;
            }
            else
            {
                Node newNode = new Node(data);
                // To follow through next links until we hit the tail
                // TODO determine if this needs to be a clone of head to avoid accidentally changing head?
                Node tempNode = head;
                while (tempNode.next != null)
                {
                    tempNode = tempNode.next;
                }
                // When we exit the while, tempNode is the tail. Set its next to newNode and then return head. 
                tempNode.next = newNode;
                return head;
            }
        }
    }
}
