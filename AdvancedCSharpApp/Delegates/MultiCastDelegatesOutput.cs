using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpApp.Delegates
{
    class MultiCastDelegatesOutput
    {
        public void SampleMethod1()
        {
            Console.WriteLine("SampleMethod1");
        }
        public void SampleMethod2()
        {
            Console.WriteLine("SampleMethod2");
        }
        public void SampleMethod3()
        {
            Console.WriteLine("SampleMethod3");
        }

        static void Main()
        {
            MultiCastDelegates md = new MultiCastDelegates();

            SimpleMulticast sm1;
            sm1 = new SimpleMulticast(md.SampleMethod1);
            sm1+= md.SampleMethod2;
            sm1+= md.SampleMethod3;
            sm1();
            Console.ReadKey();
        }
    }
}
