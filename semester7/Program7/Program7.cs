using System;

namespace semester7.Program7
{
    public class Program7:IRunner
    {
        public void Run(string[] args)
        {
            Employee employee = new Employee();
            Console.WriteLine("Enter Name");
            employee.SetName(Console.ReadLine());

            Console.WriteLine("Enter Age");
            employee.SetAge(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Enter Mailing Address");
            employee.SetMailingAddress(Console.ReadLine());

            Console.WriteLine("Enter Salary");
            employee.SetSalary(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Enter Any Outstanding Amount");
            employee.AddToAmountDue(Convert.ToInt32(Console.ReadLine()));


            employee.Print();
        }
    }
}