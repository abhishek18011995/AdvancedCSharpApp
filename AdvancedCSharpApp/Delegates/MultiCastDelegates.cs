using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpApp.Delegates
{
    public delegate void SimpleMulticast();
    class MultiCastDelegates
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

            SimpleMulticast sm1, sm2, sm3, sm4;
            sm1 = new SimpleMulticast(md.SampleMethod1);
            sm2 = new SimpleMulticast(md.SampleMethod2);
            sm3 = new SimpleMulticast(md.SampleMethod3);
            sm4 = sm1 + sm2 + sm3;
            sm4();
            Console.ReadKey();
        }
    }
}
