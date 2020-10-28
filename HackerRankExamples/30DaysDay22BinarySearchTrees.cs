using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankExamples
{
    // https://www.hackerrank.com/challenges/30-binary-search-trees/problem

    class _30DaysDay22BinarySearchTrees
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
        static int getHeight(Node root)
        {
            int heightLeft = 0;
            int heightRight = 0;

            // Not clear what value it's supposed to be if there's no leaves? 
            // Other reading said maybe -1 but putting 0 since no edges
            if (root == null)
            {
                return 0;
            }
            // Recursively go down the left side, adding to height if there's another node.
            if (root.left != null)
            {
                heightLeft = 1 + getHeight(root.left);
            }
            // Recursively go down the right side, adding to height if there's another node.
            if (root.right != null)
            {
                heightRight = 1 + getHeight(root.right);
            }
            // Use left if longer
            if (heightLeft > heightRight)
            {
                return heightLeft;
            }
            // Case when either they're the same length or right is longer
            else return heightRight;
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
            int height = getHeight(root);
            Console.WriteLine(height);

        }
    }
}
