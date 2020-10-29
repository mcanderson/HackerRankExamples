using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankExamples
{
    //https://www.hackerrank.com/challenges/30-binary-trees/problem 
    // Level order goes left to right to traverse a binary tree from its root. 
    class _30DaysDay23BSTLevelOrder
    {
        class Node
        {
            public Node left, right;
            public int data;
            public Node(int data)
            {
                this.data = data;
                left = right = null;
            }
        }

        static void levelOrder(Node root)
        {
            //Write your code here
            // Queue for holding nodes as processing through tree
            Queue<Node> traversal = new Queue<Node>();

            // Problem doesn't mention how to handle empty root, so just going to do nothing.
            if (root == null)
            {
                Console.Write("");
            }
            // Initialize queue if root isn't empty
            else traversal.Enqueue(root);

            // Iterate through the tree, dequeueing previous node's data and enqueueing branch nodes as you keep going. Exits while when queue is empty - done going through leaves. 
            while (traversal.Count > 0)
            {
                Node tempNode = traversal.Dequeue();
                Console.Write(tempNode.data + " ");
                if (tempNode.left != null)
                {
                    traversal.Enqueue(tempNode.left);
                }
                if (tempNode.right != null)
                {
                    traversal.Enqueue(tempNode.right);
                }
            }
        }

        static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }
        static void Main(String[] args)
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            levelOrder(root);

        }
    }
}
