using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpApp.methods
{
    class OutputParameter
    {
        public void assignOutputParams(out int x) {

            Console.WriteLine("Enter the number: ");
            x = Convert.ToInt32(Console.ReadLine());
        }

        static void Main()
        {
            OutputParameter op = new OutputParameter();

            int a;

            op.assignOutputParams(out a);
            Console.WriteLine("a: {0}",a);
            Console.ReadKey();
        }
    }
}
