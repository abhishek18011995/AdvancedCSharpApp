using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpApp.Delegates
{
    delegate void SimpleDelegateExample(string msg);
    class SimpleDelegate
    {
        public void DisplayMsg(string _msg)
        {
            Console.WriteLine(_msg);
        }

        static void Main()
        {
            //DisplayMsg("Hello Abhi!");

            SimpleDelegate sd = new SimpleDelegate();
            SimpleDelegateExample del = new SimpleDelegateExample(sd.DisplayMsg);
            del("Hello Abhi!");

            Console.ReadKey();
        }
    }
}
