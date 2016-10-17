using System;
using System.Collections;

namespace semester7.Program3
{
    public class Program3 : IRunner
    {
        public void Run(string[] args)
        {
            /**
            * Part 1.a - Creating a int array
            */
            int[] a = {0, 1, 2, 3, 4, 5};
            PrintArray(a);


            /**
            * Part 1.b - Creating a object array
            */

            object[] b = {0, 1, 2, 3, 4, 5};
            PrintArray(b);

            /**
             * Part 2 - Reading phone numbers of multiple people. The person class is the model
             * for this solution.
             */
            Console.WriteLine("How many people do you want to add ?");
            string num = Console.ReadLine();
            int number;
            Int32.TryParse(num, out number);
            var persons = new ArrayList();

            for (var i = 0; i < number; i++)
            {
                var person = new Person();
                Console.WriteLine("Enter name ");
                person.Name = Console.ReadLine();
                Console.WriteLine("How many phone numbers do you want to add? ");
                string num1 = Console.ReadLine();
                int number1;
                Int32.TryParse(num1, out number1);
                for (var j = 0; j < number1; j++)
                {
                    Console.WriteLine("Enter phone number");
                    person.AddPhoneNumber(Console.ReadLine());
                }

                persons.Add(person);
            }

            foreach (Person person in persons)
            {
                person.Print();
            }
        }

        private void PrintArray(int[] arr)
        {
            Console.WriteLine("int Array");
            if (arr.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(" [{0}] -> [{1}]", i, arr[i]);
                }
            }
            else
            {
                Console.WriteLine("Nothing here.");
            }
        }


        private void PrintArray(object[] arr)
        {
            Console.WriteLine("Object Array");
            if (arr.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(" [{0}] -> [{1}]", i, arr[i]);
                }
            }
            else
            {
                Console.WriteLine("Nothing here.");
            }
        }
    }
}