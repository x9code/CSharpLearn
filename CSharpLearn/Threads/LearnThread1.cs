using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CSharpLearn.Threads
{
    internal class LearnThread1
    {
        static void Work()
        {
            Console.WriteLine("Started");

            Thread.Sleep(2000);

            Console.WriteLine("Finished");
        }

        static void Main()
        {
            Thread t = new Thread(Work);

            Console.WriteLine(t.ThreadState);

            t.Start();

            Console.WriteLine(t.ThreadState);

            Thread.Sleep(500);

            Console.WriteLine(t.ThreadState);

            t.Join();

            Console.WriteLine(t.ThreadState);
        }
    }
}
