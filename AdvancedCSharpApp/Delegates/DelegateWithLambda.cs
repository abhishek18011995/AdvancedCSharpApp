using System;
using System.Collections.Generic;

namespace AdvancedCSharpApp.Delegates
{

    //Developer class is taken from DelegatesExampleCl.cs
    class DelegateWithLambda
    {
        //public static bool Promote(Developer dev)
        //{
        //    return dev.experience > 5 ? true : false;
        //}

        static void Main()
        {
            Developer d1 = new Developer(101, "Abhi", 3);
            Developer d2 = new Developer(101, "Vishnu", 4);
            Developer d3 = new Developer(101, "Kinjal", 9);
            Developer d4 = new Developer(101, "Praveen", 10);

            List<Developer> devList = new List<Developer>();
            devList.Add(d1);
            devList.Add(d2);
            devList.Add(d3);
            devList.Add(d4);

            //IsPromotable _isPromote = new IsPromotable(Promote);

            Developer.promoteEmployees(devList, emp => emp.experience >5);
            Console.ReadKey();
        }
    }
}
