using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpApp.dbs
{
    //Armstrong number is a number that is equal to the sum of cubes of its digits.
    public class armstrong
    {
        static void Main()
        {
            Console.WriteLine("Please enter the number to check if it is armstrong or not");
            int num, sum = 0, rem = 0, temp = 0;
            num = Convert.ToInt32(Console.ReadLine());
            temp = num;

            while (num > 0)
            {
                rem = num % 10;
                sum = sum + (rem * rem * rem);
                num = num / 10;
            }

            if (sum == temp)
            {
                Console.WriteLine("Given number is armstrong: {0}", temp);
            }
            else
            {
                Console.WriteLine("Given number is not armstrong: {0}", temp);
            }

            Console.ReadKey();
        }
    }
}
