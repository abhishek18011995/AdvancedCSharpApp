using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpApp
{

    class Test
    {
        public string FirstName{get; set;}
        //public string LastName{get; set;}


    }

    class Program
    {
        static void Main(string[] args)
        {
            Test t1 = new Test();
            Test t2 = new Test();

            t1.FirstName = "Abhi";
            t2.FirstName = "Abhi";

            Console.WriteLine(t1 == t2);
            Console.WriteLine(t1.Equals(t2));
            Console.ReadKey();
        }
    }
}
