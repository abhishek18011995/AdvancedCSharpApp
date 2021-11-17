using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpApp.interfaces
{   
    // Example of explicit implementation
    class ExplicitInterface1 : IInterface4, IInterface5
    {
        void IInterface4.InterfaceMethod()
        {
            Console.WriteLine("InterfaceMethod 1");
        }


         void IInterface5.InterfaceMethod()
        {
            Console.WriteLine("InterfaceMethod 2");
        }

        static void Main()
        {
            ExplicitInterface1 e1 = new ExplicitInterface1();
            ((IInterface4)e1).InterfaceMethod();
            ((IInterface5)e1).InterfaceMethod();
            Console.ReadKey();
        }

    }
}
