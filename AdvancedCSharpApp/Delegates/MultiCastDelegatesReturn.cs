using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpApp.Delegates
{
    public delegate string SimpleMulticastRetrun();
    class MultiCastDelegatesReturn
    {
        public string SampleMethod1()
        {
            return "SampleMethod1";
        }
        public string SampleMethod2()
        {
           return "SampleMethod2";
        }
        
        static void Main()
        {
            MultiCastDelegatesReturn md = new MultiCastDelegatesReturn();

            SimpleMulticastRetrun sm1;
            sm1 = new SimpleMulticastRetrun(md.SampleMethod1);
            sm1+= md.SampleMethod2;
            Console.WriteLine(sm1());
            Console.ReadKey();
        }
    }
}
