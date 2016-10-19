using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using semester7.Program1;

namespace semester7.Program10
{
    class NumberHandler : BaseThread
    {
        public delegate void OnSevenEncounteredListener(string message);

        public event OnSevenEncounteredListener Listener;

        public NumberHandler()
        {
            this.Start();
        }

        public void SetListener(OnSevenEncounteredListener listener)
        {
            this.Listener = listener;
        }

        public void OnChanged(int number)
        {
            if (number == 7)
            {
                if (Listener != null)
                {
                    Listener("7 has been encountered. The execution will halt now.");
                    if (this.IsAlive)
                    {
                        this.Stop();
                    }
                }
            }
        }

        public override void RunThread()
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                var num = random.Next(0, 10);
                Console.WriteLine("Number is " + num);
                this.OnChanged(num);
                Thread.Sleep(500);
            }
        }
    }
}