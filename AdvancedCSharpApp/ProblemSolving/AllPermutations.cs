using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpApp.ProblemSolving
{
    class AllPermutations
    {
        public static String swapString(String a, int i, int j)
        {
            //Console.WriteLine("swap i" + i);
            //Console.WriteLine("swap j" + j);

            char[] b = a.ToCharArray();
            char ch;
            ch = b[i];
            b[i] = b[j];
            b[j] = ch;
            //Converting characters from array into single string  
            return string.Join("", b);
        }

        public static void Main()
        {
            String str = "ABC";
            int len = str.Length;
            Console.WriteLine("All the permutations of the string are: ");
            generatePermutation(str, 0, len);
            Console.ReadKey();

        }

        //Function for generating different permutations of the string  
        public static void generatePermutation(String str, int start, int end)
        {
            //Prints the permutations  
            if (start == end - 1)
                Console.WriteLine(str);
            else
            {
                for (int i = start; i < end; i++)
                {
                    //Console.WriteLine("i " + i);
                    //Console.WriteLine("start " + start);
                    //Console.WriteLine(">>>> " + str);

                    //Swapping the string by fixing a character  
                    str = swapString(str, start, i);

                    //Console.WriteLine("---- " + str);


                    //Recursively calling function generatePermutation() for rest of the characters   
                    generatePermutation(str, start + 1, end);
                    //Backtracking and swapping the characters again.  
                    str = swapString(str, start, i);
                }
            }
        }
    }
}
