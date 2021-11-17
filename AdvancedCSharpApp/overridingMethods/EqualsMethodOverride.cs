using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpApp.overridingMethods
{
    class EqualsMethodOverride
    {
        static void Main()
        {
            Employee1 e1 = new Employee1();
            Employee1 e2 = new Employee1();

            e1.Name = "Abhi";
            e1.Age = 24;
            e2.Name = "Abhi";
            e2.Age = 24;

            Console.WriteLine(e1 == e2);
            Console.WriteLine(e1.Equals(e2));
            Console.ReadKey();
        }
    }

  public  class Employee1
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override bool Equals(object obj)
        {
            Console.WriteLine(base.ToString());
            Console.WriteLine(this);
            if (obj != null && obj is Employee1)
            {
                return (Name == ((Employee1)obj).Name && Age == ((Employee1)obj).Age);
            } else
            {
                return false;
            }

        }
    }
}
