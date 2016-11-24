using System;
using System.Threading;

namespace semester7.Program10
{
    public class Program10Simplified : IRunner
    {
        // The delegate or the event handler
        public delegate void NumberBetweenEventHandler(int number, string message);

        // The actual event
        public static event NumberBetweenEventHandler Handler;

        /**
        *  Same as public static void main.
        *  This method helps in running the program with a
        *  single main method in the project.
        **/
        public void Run(string[] args)
        {
            // Assigning the refernce to the method that is invoked when the event is fired.
            NumberBetweenEventHandler a = OnError;
            // Assigning the delgate to the event
            Handler = a;
            // Generates a new random number
            Random random = new Random();
            // The infinite loop
            while (true)
            {
                // Gets a new random number between 30 and 60.
                int number = random.Next(30, 60);
                // Checks if the number is between 43 and 47; Both inclusive.
                if (number >= 43 && number <= 47)
                {
                    // If the number is between 43 and 47, fires the event and sets the message.
                    Handler(number, "The program will halt now.");
                }
                // Else prints the number
                Console.WriteLine("Valid number - " + number);
                // Makes the main thread sleep for 500 ms so that a new number is generated every 500 ms.
                Thread.Sleep(500);
            }
        }

        public static void OnError(int number, string message)
        {
            // This method is called when the event has been fired. This it the event handler method.
            // It prints the number that halted the execution along with the message passed as args.
            // It then safely exits the application this halting the execution
            Console.WriteLine("Invalid Number - \nNumber  : \t{0}  \nMessage : \t{1}", number, message);
            Console.WriteLine("Exiting the application now ...");
            Environment.Exit(0);
        }
    }
}