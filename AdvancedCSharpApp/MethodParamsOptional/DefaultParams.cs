using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpApp.MethodParamsOptional
{
    class DefaultParams
    {
        static void AddNumbers(int firstNum, int secondNum, int[] restOfNums = null)
        {
            int result;

            result = firstNum + secondNum;

            if (restOfNums != null)
            {
                foreach (int i in restOfNums)
                {
                    result += i;
                }
            }
            Console.WriteLine("Result : {0}", result);
        }

        static void DisplayOptionalParms(int a, int b = 10, int c =20) {

            Console.WriteLine("a =" + a);
            Console.WriteLine("b =" + b);
            Console.WriteLine("c =" + c + "\n");
        }

        static void Main()
        {   

            AddNumbers(10, 20);
            AddNumbers(10, 20, new int[] { 30, 40 });

            //skipping the middle params
            Console.WriteLine("");
            DisplayOptionalParms(100);
            DisplayOptionalParms(100, c: 40);
            Console.ReadKey();
        }
    }
}
