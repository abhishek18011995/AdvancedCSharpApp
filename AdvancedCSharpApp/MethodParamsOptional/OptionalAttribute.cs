using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpApp.MethodParamsOptional
{
    class optional
    {
        static void AddNumbers(int firstNum, int secondNum, [Optional] int[] restOfNums)
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

        static void Main()
        {
            AddNumbers(10, 20);
            AddNumbers(10, 20, new int[] { 30, 40 });
            Console.ReadKey();
        }
    }
}
