using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankExamples
{
    // https://www.hackerrank.com/challenges/30-linked-list-deletion/problem
    class _30DaysDay24MoreLinkedLists
    {
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }
        public static Node removeDuplicates(Node head)
        {
            //Write your code here

            // HashSet to hold unique vals from the LinkedList
            HashSet<int> hashList = new HashSet<int>();
            // newHead will be the head node to return
            Node newHead = null;
            // Iterate through LL and add unique values to hashList
            while (head != null)
            {
                if (hashList.Contains(head.data))
                {
                    head = head.next;
                }
                else hashList.Add(head.data);
            }
            // Convert hashList back to LinkedList/nodes
            foreach (int i in hashList)
            {
                newHead = insert(newHead, i);
            }
            return newHead;
        }

        public static Node insert(Node head, int data)
        {
            Node p = new Node(data);


            if (head == null)
                head = p;
            else if (head.next == null)
                head.next = p;
            else
            {
                Node start = head;
                while (start.next != null)
                    start = start.next;
                start.next = p;

            }
            return head;
        }
        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
        static void Main(String[] args)
        {

            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            head = removeDuplicates(head);
            display(head);
        }
    }
}
