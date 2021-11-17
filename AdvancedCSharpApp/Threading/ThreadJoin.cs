using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AdvancedCSharpApp.Threading
{
    class ThreadJoin
    {
        public static void Display1()
        {
            Thread.Sleep(4000);
            Console.WriteLine("Display 1");
        }

        public static void Display2()
        {
            Console.WriteLine("Display 2");
        }

        static void Main() {
            Thread thread1 = new Thread(Display1);
            Thread thread2 = new Thread(Display2);

            thread1.Start();
            thread2.Start();

            thread1.Join();
            //thread2.Join();

            Console.WriteLine("Main thread finshed");
            Console.ReadKey();
        }
    }
}
