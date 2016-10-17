using System;

namespace semester7.Program7
{
    public class Employee : Person, IPayable
    {

        private int salary;
        private string mailingAddress;
        private int amountDue;

        public void SetMailingAddress(string mailingAddress)
        {
            this.mailingAddress = mailingAddress;
        }

        public void SetSalary(int salary)
        {
            this.salary = salary;
        }

        public int GetSalary()
        {
            return this.salary;
        }

        public int RetrieveAmountDue()
        {
            return this.amountDue;
        }

        public void AddToAmountDue(int amount)
        {
            this.amountDue += amount;
        }

        public void PaymentAddress(string address)
        {
            this.mailingAddress = address;
        }


        public void Print()
        {
            Console.WriteLine("\n\n******************* EMPLOYEE **********************");
            Console.WriteLine("Name       \t-\t {0}", this.Name);
            Console.WriteLine("Address    \t-\t {0}", this.mailingAddress);
            Console.WriteLine("Age        \t-\t {0}", this.Age);
            Console.WriteLine("Salary     \t-\t Rs. {0}", this.salary);
            Console.WriteLine("Amount Due \t-\t Rs. {0}", this.RetrieveAmountDue());
            Console.WriteLine("           \t \t -------------");
            Console.WriteLine("Total      \t-\t Rs. {0}", this.salary - this.RetrieveAmountDue());
            Console.WriteLine("\n*******************  END EMPLOYEE ******************* ");        }
    }
}