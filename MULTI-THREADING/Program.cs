﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Multithread.Threaddemo;

namespace Multithread
{

    public class Program
    {

        static void Main(string[] args)
        {
            SampleThreadDemo obj = new SampleThreadDemo();
            // this is normal way of execution where M2() ramains in wait state
            // until M1() completes its execution
            //obj.M1();
            //obj.M2(); 

            // using multithreading

            // unstarted state
            Thread t1 = new Thread(new ThreadStart(obj.M1));
            Thread t2 = new Thread(new ThreadStart(obj.M2));
            t1.Name = "First Thread"; // assign a name to thread
            t2.Name = "Second Thread";

            // this is the req to the OS  ( this is not order)
            // default priority is Normal
            t1.Priority = ThreadPriority.Lowest;
            t2.Priority = ThreadPriority.Highest;

            // runnable state
            t1.Start();
            // t1.Join();// block the further thread execution,until the current completes the exe
            // t1.Join(3000);//block the exe of further threads for 3 sec only
            t2.Start();
        }
    }

}