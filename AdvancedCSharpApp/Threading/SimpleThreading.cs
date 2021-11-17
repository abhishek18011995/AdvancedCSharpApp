using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdvancedCSharpApp.Threading
{
    class SimpleThreading
    {
        public static void printNums()
        {
            int i = 0;
            for (i = 0; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void displayMsg()
        {
            Console.WriteLine("before sleep time");
            Thread.Sleep(5000);
            Console.WriteLine("after sleep time");
        }

        static void Main()
        {

            //Thread thread1 = new Thread(new ThreadStart(displayMsg));
            //Thread thread1 = new Thread(delegate () { displayMsg(); });
            Thread thread1 = new Thread(() => displayMsg());

            // short for of using thread
            //Thread thread1 = new Thread(displayMsg);
            thread1.Start();
            printNums();

            Console.ReadKey();
        }


    }
}
