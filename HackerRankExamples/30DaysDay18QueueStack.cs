using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankExamples
{
    // https://www.hackerrank.com/challenges/30-queues-stacks/problem
    class _30DaysDay18QueueStack
    {
        //Write your code here
        Stack<char> palinStack = new Stack<char>();
        Queue<char> palinQueue = new Queue<char>();

        public void pushCharacter(char c)
        {
            palinStack.Push(c);
        }

        public void enqueueCharacter(char c)
        {
            palinQueue.Enqueue(c);
        }

        public char popCharacter()
        {
            char popped = palinStack.Pop();
            return popped;
        }

        public char dequeueCharacter()
        {
            char dequeued = palinQueue.Dequeue();
            return dequeued;
        }

        static void Main(String[] args)
        {
            // read the string s.
            string s = Console.ReadLine();

            // create the Solution class object p.
            // Megan note: renamed from Solution to this. 
            _30DaysDay18QueueStack obj = new _30DaysDay18QueueStack();

            // push/enqueue all the characters of string s to stack.
            foreach (char c in s)
            {
                obj.pushCharacter(c);
                obj.enqueueCharacter(c);
            }

            bool isPalindrome = true;

            // pop the top character from stack.
            // dequeue the first character from queue.
            // compare both the characters.
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (obj.popCharacter() != obj.dequeueCharacter())
                {
                    isPalindrome = false;

                    break;
                }
            }

            // finally print whether string s is palindrome or not.
            if (isPalindrome)
            {
                Console.Write("The word, {0}, is a palindrome.", s);
            }
            else
            {
                Console.Write("The word, {0}, is not a palindrome.", s);
            }
        }
    }
}
