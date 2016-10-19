using System;
using System.Collections;

namespace semester7.Program3
{
    public class Program3 : IRunner
    {
        // The Person class is the model which handles all the data related logic here.
        // It would have been easier to put the data here and handle it. But when it comes
        // to writing code which is easier to execute and handle later, its better if
        // we seperate the components of the app. Thus making a new file makes sense here.
        // It is part of the MC(Model and Controller ) design pattern, a robust
        // patter.
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

            // A fault tolerant way of taking input and converting it to integer.
            int number;
            Int32.TryParse(num, out number);

            // An array could have done the job of holding the array data. But ArrayList
            // provides methods which makes it much easier to add, delete, update and
            // traverse the dataSet. An even better alternative would be the generic List.
            // But it has not been used here to ease the process a bit.
            ArrayList persons = new ArrayList();

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

        /*
         * We can also use generics which will make it easier to call the function for any
         * type of array.
         */

        private void PrintArray<T>(T[] arr)
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

        // Without using generics, we have to write two methods using mehtod overloading.
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