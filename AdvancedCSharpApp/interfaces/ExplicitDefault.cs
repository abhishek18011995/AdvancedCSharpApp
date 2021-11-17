using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpApp.interfaces
{
    class ExplicitDefault:IInterface4, IInterface5
    {
        public void InterfaceMethod()
        {
            Console.WriteLine("InterfaceMethod 1");
        }


        void IInterface5.InterfaceMethod()
        {
            Console.WriteLine("InterfaceMethod 2");
        }

        static void Main()
        {
            ExplicitDefault e1 = new ExplicitDefault();
            e1.InterfaceMethod();
            ((IInterface5)e1).InterfaceMethod();
            Console.ReadKey();
        }

    }
}
