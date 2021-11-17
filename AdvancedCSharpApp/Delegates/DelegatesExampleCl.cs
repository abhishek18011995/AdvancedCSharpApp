using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpApp.Delegates
{
    delegate bool IsPromotable(Developer _developer);
    class Developer
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public int experience {get; set; }

        public Developer(int _id, string _name, int _exp) {
            Id = _id;
            Name = _name;
            experience = _exp;
        }

        public static void promoteEmployees(List<Developer> _devList, IsPromotable _promote)
        {
            foreach(Developer _dev in _devList)
            {
                if (_promote(_dev))
                {
                    Console.WriteLine("{0} promoted!", _dev.Name);
                }
            }
        }
    }

    class DelegatesExampleCl
    {   
        public static bool Promote(Developer dev)
        {
            return dev.experience > 5 ? true : false;
        }

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

            IsPromotable _isPromote = new IsPromotable(Promote);

            Developer.promoteEmployees(devList, _isPromote);
            Console.ReadKey();
        }
    }
}
