using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdvancedCSharpApp.ProblemSolving
{
    class RemoveConsecutiveChars
    {
        public void removeConsecutiveChars()
        {
            string str = "ABCCCCBCBCCCCCCCCBBCCA";
            var hashset = new HashSet<char>(str.ToCharArray());
            bool continueLoop = true;

            while (continueLoop)
            {
                foreach (var val in hashset)
                {
                    //var regex = new Regex();
                }
            }

        }

        public static void Main()
        {
            

            Console.WriteLine(String.Concat("asdfg".OrderBy(chr => chr)));
            Console.ReadKey();
        }
    }
}
