using System;
using System.Diagnostics;
using System.Threading;

namespace semester7.Program1
{
    // All programs must implemet the IRunner inteface in order to run.
    public class Program1 : IRunner
    {
        private Thread thread;
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
                // Trying to parse the Command Line Argument to Integer. When this fails,
                // the catch will print the Command Line Argument as a string.
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

            /**
             * Alternatively, the thread can be created here. Though this is not
             * recommended. The BaseThread Class in the Watcher.cs file can be used
             * in multiple places thus increasing code reusability. Still, the other
             * way to use it here.
             **/

            // 1. Create a new instance of the thread. Use the constructor which accepts a
            // function to run. The other constructor accepts parameters when the thread runs.
            // That is not required here. Method OnRun will be executed when the Thread starts.

            /*
             * Uncomment this line to run
             */
            // thread = new Thread(new ThreadStart(OnRun));

            //2. Call thread.Start() to start the execution of the thread.

            /*
             * Uncomment this line to run
             */
            thread.Start();
        }


        private void OnRun()
        {
            Console.WriteLine("Please type a key to check the status of Nums Lock and " +
                              "\n Caps Lock. Please space key to exit.");
            do
            {
                Console.WriteLine("\n*********** Watch Start *************");
                Console.WriteLine("Waiting for input ...... Press space bar to quit");
//                var a = Console.ReadKey(true).KeyChar;
//                Console.WriteLine("Key " + a + " pressed. ");
                Console.WriteLine("Caps Lock is " +
                                  (Console.CapsLock ? "active" : "inactive") + ".");
                Console.WriteLine("Num Lock is " + (Console.NumberLock ? "active" : "inactive") + ".");
                Console.WriteLine("*************************************");
            } while (Console.ReadKey().Key != ConsoleKey.Spacebar);

            Console.WriteLine("Stopping Execution now.");
            Console.WriteLine("=========== ++ STOPPED ++ =================");

            // If the thread is alive, kill it.
            if (thread.IsAlive)
            {
                Console.WriteLine("Killing the thread now.");
                thread.Abort();
            }
        }
    }
}