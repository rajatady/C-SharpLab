using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace semester7.Program8
{
    public class Program8 : IRunner
    {
        public void Run(string[] args)
        {
            /**
             * Part 8 a - Exploring the arraylist class
             */

            ArrayList list = new ArrayList();
            list.Add(3);
            list.Add(5);
            list.Add(10);
            PrintList(list);
            Console.WriteLine("Size of list - {0}", list.Count);
            list[1] = 100;
            Console.WriteLine("Updated Values");
            PrintList(list);
            list.Add(154);
            Console.WriteLine("Updated Values");
            PrintList(list);
            list.Sort();
            Console.WriteLine("Sorted Values");
            PrintList(list);
            list.Remove(3);
            Console.WriteLine("Deleted Values");
            PrintList(list);
            list.RemoveAt(2);
            Console.WriteLine("Deleted Values");
            PrintList(list);
            list.RemoveRange(0, 1);
            Console.WriteLine("Deleted Values");
            PrintList(list);
            list.Clear();
            Console.WriteLine("Cleared Values");
            PrintList(list);

            /**
             * Part 8 b - Phone directory
             */

            PhoneDirectory directory = new PhoneDirectory();

            Console.WriteLine("How many records do you want to set? ");
            int count = Convert.ToInt32(Console.ReadLine());

            Dictionary<long, string> dictionary = new Dictionary<long, string>();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter Name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Mobile Number");
                long number = Convert.ToInt64(Console.ReadLine());
                dictionary.Add(number, name);
            }

            directory.SetDictionary(dictionary);

            Console.WriteLine("******************* SEARCHING *******************");
            Console.WriteLine("Search By Name");
            Console.WriteLine("Enter a Name");
            string name_ = Console.ReadLine();
            long number_ = directory.Search(name_);
            if (number_ != 0)
            {
                Console.WriteLine("Number for {0} is  {1}", name_, number_);
            }
            else
            {
                Console.WriteLine("No User/Number found");
            }

            Console.WriteLine("Search By Number");
            Console.WriteLine("Enter a Number");
            long number__ = Convert.ToInt64(Console.ReadLine());
            string name__ = directory.Search(number__);
            if (name__ != null)
            {
                Console.WriteLine("Name of person with {0} is  {1}", number__, name__);
            }
            else
            {
                Console.WriteLine("No User/Number found");
            }
        }


        public void PrintList(ArrayList list)
        {
            int i = 0;
            foreach (var obj in list)
            {
                Console.WriteLine("[{0}] => {1}", i++, obj);
            }
        }
    }
}