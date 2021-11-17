using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpApp.ProblemSolving
{
    class Anagram
    {
        public static void Main()
        {
            string str1 = "army";
            string str2 = "yarm";
            string str3 = "yarm";

            string[] str1Arr = str1.Split();
            string[] str2Arr = str2.Split();

            char[] chr1 = str1.ToCharArray();
            char[] chr2 = str2.ToCharArray();
            char[] chr3 = str3.ToCharArray();

            Array.Sort(str1Arr);
            Array.Sort(str2Arr);
            Array.Sort(chr1);
            Array.Sort(chr2);
            Array.Sort(chr3);

            var res1 = string.Join("", chr1);
            var res2 = string.Join("", chr2);
            var res3 = new string(chr3);
            var res4 = new string(new char[]{ 'a','r','m','y'});
            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.WriteLine(res1 == res2 ? "Anagram" : "Not Anagram");
            Console.WriteLine(res1 == res3 ? "Anagram" : "Not Anagram");
            Console.WriteLine(res1 == res4 ? "Anagram" : "Not Anagram");

            //  for testing purpose
            foreach (var sub in str1Arr)
            {
                Console.WriteLine($"Substring: {sub}");
            }


            Console.WriteLine(String.Concat("asdfg".OrderBy(chr => chr)));
            Console.ReadKey();
        }
    }
}
