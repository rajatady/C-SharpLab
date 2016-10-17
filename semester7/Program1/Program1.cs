using System;
using System.Diagnostics;

namespace semester7.Program1
{
    // All programs must implemet the IRunner inteface in order to run.
    public class Program1 : IRunner
    {
        /**
         *  Same as public static void main.
         *  This method helps in running the program with a
         *  single main method in the project.
         **/

        public void Run(string[] args)
        {
            /**
             * Part 1 - Setting title of the console
             */
            Console.Title = "Program 1";
            /**
             * Part 2 - Setting the background and
             *          foreground color of the consol
             */
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\n1. Hello World\n Hello world again!");

            /**
             * Part 3 - Understanding the command line args
             */
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            if (args.Length == 0)
            {
                Console.WriteLine("No argumnets passed to the program.");
            }
            else
            {
                Console.WriteLine("Number of command line arguments = {0}",
                    args.Length);
                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine("Arg[{0}] = [{1}]", i, args[i]);
                }


                /**
                 * Part 4 - Formatting command line args
                 */
                try
                {
                    var a = Convert.ToInt32(args[0]);
                    Console.WriteLine("Type - " + a.GetType() + " Value -> " + a);
                }
                catch (FormatException e)
                {
                    var a = args[0];
                    Console.WriteLine("Type - " + a.GetType() + " Value -> " + a);
                }
            }


            Console.ResetColor();


            /**
             * Part 5 - Watching for key presses
             */
            Watcher watcher = new Watcher();
            watcher.Start();
        }
    }
}