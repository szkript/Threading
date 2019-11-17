using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SimpleThreadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart threadStart = new ThreadStart(Counting);
            Thread thread1 = new Thread(threadStart);
            Thread thread2 = new Thread(threadStart);
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();
            Thread.Sleep(10);

            Console.ReadLine();
        }

        public static void Counting()
        {
            for (int i=1; i <= 10; i++)
            {
                Console.WriteLine($"Count : {0}, Thread : {1}", i, Thread.CurrentThread.ManagedThreadId);
            }
        }
    }
}
