using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpApp.Dictionary
{
    class Customer
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Salary { get; set; }
    }

    class DictionaryCl
    {
        static void Main()
        {
            Customer cust1 = new Customer() { Name = "Abhi", Id = 24, Salary = 96000 };
            Customer cust2 = new Customer() { Name = "BBBB", Id = 25, Salary = 86000 };
            Customer cust3 = new Customer() { Name = "CCCC", Id = 26, Salary = 76000 };
            Customer cust4 = new Customer() { Name = "DDDD", Id = 27, Salary = 66000 };

            Dictionary<int, Customer> dict = new Dictionary<int, Customer>();
            dict.Add(cust1.Id, cust1);
            dict.Add(cust2.Id, cust2);
            dict.Add(cust3.Id, cust3);
            dict.Add(cust4.Id, cust4);

            Console.WriteLine(dict[24].Name);

            foreach (KeyValuePair<int, Customer> custObj in dict)
            {
                Console.WriteLine("Name: {0}, Id: {1}, Salary: {2}", custObj.Value.Name, custObj.Value.Id, custObj.Value.Salary);
            }

            Console.WriteLine("---------------------------------- \n");


            Console.WriteLine("Keys");
            foreach (int _key in dict.Keys)
            {
                Console.WriteLine(_key);
            }
            Console.WriteLine("---------------------------------- \n");

            Console.WriteLine("All Values");
            foreach (Customer cust in dict.Values)
            {
                Console.WriteLine("Name: {0}, Id: {1}, Salary: {2}", cust.Name, cust.Id, cust.Salary);
            }
            
            // checking if the key exists or not
            const int CheckId = 24;
            Customer cust5;
            if (dict.ContainsKey(CheckId))
            {
                Console.WriteLine("\n"+ dict[CheckId].Name);
            }

            if (dict.TryGetValue(CheckId, out cust5))
            {
                Console.WriteLine("\n" + cust5.Name);
            } else
            {
                Console.WriteLine("Key not found");
            }

            // converting array into dictionary
            Customer[] custArr = new Customer[3];
            custArr[0] = cust1;
            custArr[1] = cust2;
            custArr[2] = cust3;

            Dictionary<int, Customer> arrDict =  custArr.ToDictionary(_cust => _cust.Id, _cust => _cust);
            foreach (KeyValuePair<int,Customer> _cust in arrDict)
            {
                Console.WriteLine("Name: {0}, Id: {1}, Salary: {2}", _cust.Value.Name, _cust.Value.Id, _cust.Value.Salary);
            }

            Console.ReadKey();
        }
    }
}
