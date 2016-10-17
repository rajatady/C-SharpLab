using System;
using System.Collections;

namespace semester7.Program3
{
    public class Person
    {
        public string Name { get; set; }
        private ArrayList PhoneNumbers;

        public Person()
        {
            this.PhoneNumbers = new ArrayList();
        }


        public void AddPhoneNumber(string number)
        {
            this.PhoneNumbers.Add(number);
        }

        public void Print()
        {
            Console.WriteLine("\n**************************");
            Console.WriteLine("Name\t{0}", this.Name);
            Console.WriteLine("Phone Numbers - ");
            var i = 0;
            foreach (string number in PhoneNumbers)
            {
                Console.WriteLine("[{0}] -> {1}", ++i, number);
            }

            Console.WriteLine("**************************\n");
        }
    }
}