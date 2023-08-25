using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithread
{
    internal class Threaddemo
    {
        public class SampleThreadDemo
        {
            public void M1()
            {
                Thread t1 = Thread.CurrentThread;// to read the thread name
                Console.WriteLine(t1.Name);
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(2000);
                }
            }
            public void M2()
            {
                Thread t1 = Thread.CurrentThread;
                Console.WriteLine(t1.Name);
                for (int i = 10; i <= 15; i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(2000);
                }
            }
        }

    }
}