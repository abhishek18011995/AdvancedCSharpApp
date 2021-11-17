using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AdvancedCSharpApp.Threading
{
    class ThreadStartDelegateCallback
    {
        int target = 0;
        CallbackDelegate callBackMethod;
        public ThreadStartDelegateCallback(int _target, CallbackDelegate _callBackMethod )
        {
            this.target = _target;
            this.callBackMethod = _callBackMethod;
        }

        public void printNums()
        {
            int i, sum = 0;

            for (i = 0; i <= target; i++)
            {
                sum = sum + i;
            }

            callBackMethod(sum);
        }
        
    }

    delegate void CallbackDelegate(int sum);
    class ThreadCallback
    {
        public static void displaySum(int sum)
        {
            Console.WriteLine(sum);
        }

        static void Main()
        {
            ThreadStartDelegateCallback tc = new ThreadStartDelegateCallback(5, displaySum);
            CallbackDelegate callbackDelegate = new CallbackDelegate(displaySum);
            
            Thread thread1 = new Thread(tc.printNums);
            thread1.Start();

            Console.ReadKey();
        }
    }
}
