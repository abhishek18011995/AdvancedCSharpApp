using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpApp.interfaces
{
    interface IInterface4
    {
        void InterfaceMethod();
    }

    interface IInterface5
    {
        void InterfaceMethod();
    }
    class ExplicitInterface : IInterface4, IInterface5
    {
        public void InterfaceMethod()
        {
            Console.WriteLine("InterfaceMethod");
        }

    static void Main()
        {
            ExplicitInterface ei = new ExplicitInterface();

            ei.InterfaceMethod();
            ((IInterface4)ei).InterfaceMethod();
            ((IInterface5)ei).InterfaceMethod();
            Console.ReadKey();
        }
    }
}
