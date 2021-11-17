using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpApp.Generics
{   
    class GenericIsEqualCl
    {
        public static bool isEqual<T>(T a, T  b)
        {
            return a.Equals(b);
        }

        static void Main()
        {
            int c = 20, d = 30;

            Console.WriteLine(isEqual<string>("AB","AB"));
            Console.WriteLine(isEqual<double>(10.0,10));
            Console.WriteLine(isEqual(10.0,10));
            Console.WriteLine(isEqual(c,d));
            Console.ReadKey();
        }
    }
}
