using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace semester7.Program10
{
    class Program10 : IRunner
    {
        private NumberHandler handler = new NumberHandler();
        public void Run(string[] args)
        {
            handler.SetListener(new NumberHandler.OnSevenEncounteredListener(Print));
            Console.ReadLine();
        }

        public void Print(String message)
        {
            Console.WriteLine(message);
        }
    }
}
