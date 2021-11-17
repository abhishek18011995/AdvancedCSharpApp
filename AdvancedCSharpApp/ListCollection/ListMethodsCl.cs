using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpApp.ListCollection
{
    class SortByName : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }

    class ListMethodsCl
    {
        public static int sortCustomerByName(Customer x, Customer y)
        {
            return x.Name.CompareTo(y.Name);
        }

        static void Main()
        {
            Customer cust1 = new Customer() { Name = "Abhi", Id = 24, Salary = 96000, Type = "Retail" };
            Customer cust2 = new Customer() { Name = "BBBB", Id = 25, Salary = 86000, Type = "Retail" };
            Customer cust3 = new Customer() { Name = "CCCC", Id = 26, Salary = 76000, Type = "Corporate" };
            Customer cust4 = new Customer() { Name = "DDDD", Id = 27, Salary = 66000, Type = "Corporate" };

            List<Customer> custList1 = new List<Customer>();
            List<Customer> custList2 = new List<Customer>();

            custList1.Add(cust1);
            custList1.Add(cust2);

            custList2.Add(cust3);
            custList2.Add(cust4);

            Console.WriteLine("\nMerged list");
            custList1.AddRange(custList2);
            Console.WriteLine("\nTotal customer in list1:" + custList1.Count + "\n");

            List<Customer> resCust = custList1.GetRange(1, 2);
            foreach (Customer _cust in resCust)
            {
                Console.WriteLine("Name: {0}, Id: {1}, Salary: {2}", _cust.Name, _cust.Id, _cust.Salary);
            }

            custList1.Sort();
            Console.WriteLine("\nAfter Sorting");
            foreach (Customer _cust in custList1) {
                Console.WriteLine("Salary: {0}", _cust.Salary);
            }

            SortByName sortName = new SortByName();
            Console.WriteLine("\nAfter Sorting by Name");
            custList1.Sort(sortName);
            foreach (Customer _cust in custList1)
            {
                Console.WriteLine("Name: {0}", _cust.Name);
            }

            custList1.Reverse();
            Comparison<Customer> compareCust = new Comparison<Customer>(sortCustomerByName);
            Console.WriteLine("\nAfter Sorting by Name using Comparison delegate");
            custList1.Sort(sortName);
            foreach (Customer _cust in custList1)
            {
                Console.WriteLine("Name: {0}", _cust.Name);
            }

            Console.ReadKey();
        }
    }
}
