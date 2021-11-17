using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpApp.overridingMethods
{
    class A
    {
        protected A()
        {
            Disp();
        }

        protected virtual void Disp()
        {
            Console.WriteLine("Disp A - Base");
        }
    }

    class B: A
    {
        public string title;

        public B(string title)
        {
            this.title = title;
        }

        // Note- Overirding methods cannot change access modofiers
        // public override void Disp()
        protected override void Disp()
        {
            Console.WriteLine("Disp B - {0}" , this.title);
        }
    }

    class OverridingTrickQues
    {
        static void Main()
        {
            B bo = new B("Derived");
            Console.ReadKey();
        }

    }
}
