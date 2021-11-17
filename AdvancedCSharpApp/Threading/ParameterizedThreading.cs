using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AdvancedCSharpApp.Threading
{
    class ParameterizedThreading
    {
        public static void printNums(object target)
        {
            int i = 0;
            int _target;
            //int _target = Convert.ToInt32(target);

            if (int.TryParse(target.ToString(), out _target))
            {
                for (i = 0; i <= _target; i++)
                {
                    Console.WriteLine(i);
                }
            } else
            {
                Console.WriteLine("wrong format");
            }
        }

        static void Main()
        {
            ParameterizedThreadStart p1 = new ParameterizedThreadStart(printNums);

            Thread thread1 = new Thread(p1);

            // short for of using thread
            //Thread thread1 = new Thread(displayMsg);
            thread1.Start("6");

            Console.ReadKey();
        }
    }
}
