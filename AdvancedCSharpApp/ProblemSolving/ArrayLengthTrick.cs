using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpApp.ProblemSolving
{
    class ArrayLengthTrick
    {
        static void ChangeArr(int[] a, int[] c)
        {
            int[] b = new int[5] { 11,22,33,44,55};
            a = b;
            c = b;

            Console.WriteLine(a.Length);
            Console.WriteLine(b.Length);

            foreach (var val in a)
            {
                Console.WriteLine(val);
            };
        }
        static void Main()
        {
            int[] arr = new int[10] { 1,2,3,4,5,6,7,8,89,09};
            int[] c = new int[5] { 1,2,3,4,5};
            ChangeArr(arr, c);

            Console.WriteLine("Original");
            Console.WriteLine(arr.Length);

            foreach (var val in c)
            {
                Console.WriteLine(val);
            };
            Console.ReadKey();
        }
    }
}
