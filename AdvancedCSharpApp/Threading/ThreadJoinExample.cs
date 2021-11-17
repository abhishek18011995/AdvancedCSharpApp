using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AdvancedCSharpApp.Threading
{
    class ThreadJoinExample
    {
        public static Thread t1 = new Thread(Display1);
        public static Thread t2 = new Thread(Display2);

        public static void Display1()
        {
            Thread.Sleep(4000);
            Console.WriteLine("Display 1");
        }

        public static void Display2()
        {
            Thread.Sleep(8000);
            Console.WriteLine("Display 2");
        }

        public static void Display3()
        {
            Console.WriteLine("Display 3");
        }

        public static void M1()
        {
            t1.Start();
            t1.Join();
            t2.Join(10);
            Display3();
        }

        public static void M2()
        {
            t2.Start();
            //Display2();
            t1.Join();
            t2.Join();
            Display3();
        }

        static void Main() {
            //Thread thread1 = new Thread(M1);
            //Thread thread2 = new Thread(M2);

            //thread1.Start();
            //thread2.Start();

            //thread1.Join();
            //thread2.Join();

            M1();
            M2();

            //t1.Start();
            //t2.Start();

            Console.WriteLine("Main thread finshed");
            Console.ReadKey();
        }
    }
}
