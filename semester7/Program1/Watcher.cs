using System;
using System.Security.AccessControl;
using System.Threading;

namespace semester7.Program1
{
    public abstract class BaseThread
    {
        private Thread _thread;

        protected BaseThread()
        {
            _thread = new Thread(new ThreadStart(this.RunThread));
        }

        // Thread methods / properties
        public void Start()
        {
            _thread.Start();
        }

        public void Join()
        {
            _thread.Join();
        }

        public void Stop()
        {
            if (_thread.IsAlive)
            {
                _thread.Abort();
            }
        }

        public bool IsAlive
        {
            get { return _thread.IsAlive; }
        }

        // Override in base class
        public abstract void RunThread();
    }

    public class Watcher : BaseThread
    {
        public override void RunThread()
        {
            Console.WriteLine("Please type a key to check the status of Nums Lock and " +
                              "\n Caps Lock. Please space key twice to exit.");
            do
            {
                Console.WriteLine("\n*********** Watch Start *************");
                Console.WriteLine("Waiting for input ...... Press space bar twice to quit");
                var a = Console.ReadKey(true).KeyChar;
                Console.WriteLine("Key " + a + " pressed. ");
                Console.WriteLine("Caps Lock is " +
                                  (Console.CapsLock ? "active " : "inactive") + ".");
                Console.WriteLine("Num Lock is " + (Console.NumberLock ? "active " : "inactive") + ".");                Console.WriteLine("*************************************");
                Console.WriteLine("\n*********** Watch End *************\n");
            } while (Console.ReadKey().Key != ConsoleKey.Spacebar);

            Console.WriteLine("Stopping Execution now.");
            Console.WriteLine("=========== ++ STOPPED ++ =================");
            this.Stop();
        }
    }
}