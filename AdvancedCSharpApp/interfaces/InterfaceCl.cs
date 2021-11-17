using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpApp.interfaces
{   
    interface IInterface1
    {
        void InterfaceMethod1();
    }

    interface IInterface2
    {
        void InterfaceMethod2();
    }

    interface IInterface3:IInterface1
    {
        void InterfaceMethod3();
    }


    class InterfaceCl : IInterface1, IInterface2
    {
        public void InterfaceMethod1()
        {
            Console.WriteLine();
        }

        public void InterfaceMethod2()
        {
            Console.WriteLine();
        }
    }

    class InterfaceCl2 : IInterface2, IInterface3
    {
        public void InterfaceMethod1()
        {
            Console.WriteLine();
        }

        public void InterfaceMethod2()
        {
            Console.WriteLine();
        }

        public void InterfaceMethod3()
        {
            Console.WriteLine();
        }
    }
}
