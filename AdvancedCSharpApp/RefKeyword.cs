using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpApp
{
    class RefKeyword
    {
        public static void Swap<T>(ref T lhs,ref T rhs) {
            T temp = lhs;
            lhs = rhs;
            rhs = temp;
            //Console.WriteLine("LHS: {0}, RHS: {1}", lhs, rhs);
        }

        static void Main()
        {
            int a = 10, b = 20;
            Console.WriteLine("LHS: {0}, RHS: {1}", a, b);
            Swap<int>(ref a,ref b);
            Console.WriteLine("LHS: {0}, RHS: {1}", a, b);
            Console.ReadKey();
        }


    }
}
