using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpApp.ProblemSolving
{
    class GetFrequencyInArrayClass
    {
        public static void getFrequencyString()
        {
            string str = "aaaabbeeeeeeeff";

            char[] chrs = str.ToCharArray();

            var dict = new Dictionary<char, int>();

            for (int i =0; i< chrs.Count(); i++) {
                if (dict.ContainsKey(chrs[i]))
                {

                    dict[chrs[i]] += 1;
                }
                else
                {
                    dict[chrs[i]] = 1;
                }
            }

            foreach (var i in dict)
            {
                Console.WriteLine("{0} count - {1}", i.Key, i.Value);
            }

        }

        public static void getFrequencyInArray()
        {
            int[] arr = { 2, 3, 1, 5, 12, 4, 1, 7, 5, 9, 3, 6, 6, 3, 2, 1, 1 };

            var dict = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (dict.Keys.Contains(arr[i]))
                {
                    dict[arr[i]] += 1;
                }
                else
                {
                    dict.Add(arr[i], 1);
                }
            }

            foreach (var i in dict)
            {
                Console.WriteLine("{0} count - {1}", i.Key, i.Value);
            }

        }

        public static void Main()
        {
            Console.WriteLine(typeof(string).Assembly.ImageRuntimeVersion);
            //getFrequencyInArray();
            getFrequencyString();
            Console.ReadKey();
        }
    }
}
