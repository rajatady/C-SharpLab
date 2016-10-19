using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace semester7.Program9
{
    class Program9 : IRunner
    {
        public void Run(string[] args)
        {
            /*
             * Part 9 a - Queue
             */
            Queue<int> q  = new Queue<int>();
            q.Enqueue(2);
            PrintQueue(q);
            q.Enqueue(4);
            PrintQueue(q);
            q.Enqueue(6);
            PrintQueue(q);
            q.Dequeue();
            PrintQueue(q);

            Console.WriteLine("Q contains value -> 2  {0}", q.Contains(2));
            Console.WriteLine("The element at the beginning of the queue is {0}", q.Peek());

            q.Clear();
            PrintQueue(q);


            /*
             * Part 9 b - Stack
             */


            Stack<int>  stack = new Stack<int>();
            stack.Push(2);
            PrintStack(stack);
            stack.Push(4);
            PrintStack(stack);
            stack.Push(6);
            PrintStack(stack);
            stack.Pop();
            PrintStack(stack);

            Console.WriteLine("Stack contains value -> 2  {0}", stack.Contains(2));
            Console.WriteLine("The element at the top of the stack is {0}", stack.Peek());

            stack.Clear();
            PrintStack(stack);
            Console.ReadLine();
        }


        private void PrintQueue<T>(Queue<T> queue)
        {
            Console.WriteLine("-------------- Queue Values Now--------------");
            var a = 0;
            foreach (T i in queue)
            {
                Console.WriteLine("[{0}] => {1}", a++, i);
            }
        }

        private void PrintStack<T>(Stack<T> queue)
        {
            Console.WriteLine("-------------- Stack Values Now--------------");
            var a = 0;
            foreach (T i in queue)
            {
                Console.WriteLine("[{0}] => {1}", a++, i);
            }
        }
    }
}
