using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpApp.ProblemSolving
{
    class Panagram
    {
        public static void Main()
        {
            string str = "qwertyuiopioiplk A;LSajsklddgfjksahd mnbvcxz";
            Console.WriteLine(str.ToLower().Where(chr => char.IsLetter(chr)).GroupBy(chr => chr).Count());
            Console.ReadKey();
        }
    }
}
