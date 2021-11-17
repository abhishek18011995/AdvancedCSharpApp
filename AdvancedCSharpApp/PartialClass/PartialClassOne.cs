using System;

namespace AdvancedCSharpApp.PartialClass
{
    public partial class PartialClass 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        partial void testPartialMethod()
        {
            Console.WriteLine("testPartialMethod");
        }

        static void Main()
        {
            PartialClass p = new PartialClass();
            p.FirstName = "Abhi";
            p.LastName = "Kumar";
            Console.WriteLine(p.GetFullName());
            p.testPartialMethod();
            Console.ReadKey();
        }
    }
}