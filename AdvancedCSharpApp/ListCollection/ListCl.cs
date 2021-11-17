using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpApp.ListCollection
{
    class Customer: IComparable<Customer>
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Salary { get; set; }
        public string Type { get; set; }

        public int CompareTo(Customer other)
        {
            //if(this.Salary > other.Salary)
            //{
            //    return 1;
            //} else if (this.Salary < other.Salary)
            //{
            //    return -1;
            //} else
            //{
            //    return 0;
            //}
            return this.Salary.CompareTo(other.Salary);
        }
    }

    class ListCl
    {
        static void Main()
        {
            Customer cust1 = new Customer() { Name = "Abhi", Id = 24, Salary = 96000, Type= "Retail" };
            Customer cust2 = new Customer() { Name = "BBBB", Id = 25, Salary = 86000, Type = "Retail" };
            Customer cust3 = new Customer() { Name = "CCCC", Id = 26, Salary = 76000, Type = "Corporate" };
            Customer cust4 = new Customer() { Name = "DDDD", Id = 27, Salary = 66000, Type = "Corporate" };

            List<Customer> custList = new List<Customer>(2);
            custList.Add(cust1);
            custList.Add(cust2);
            custList.Add(cust3);
            custList.Add(cust4);

            Console.WriteLine("All customers in List");
            //custList.OrderBy
            foreach (Customer _cust in custList)
            {
                Console.WriteLine("Name: {0}, Id: {1}, Salary: {2}", _cust.Name, _cust.Id, _cust.Salary);
            }

            //check if the element exists in list
            if (custList.Contains(cust4))
            {
                Console.WriteLine("\nContained Mentioned custumer");
            }

            //exists method in List            
            Console.WriteLine("\nMentioaned custumer exists or not : {0}", custList.Exists(_cust => _cust.Salary > 90000));

            // Find the customer who is satisfying the condition
            List<Customer> resCust = custList.FindAll(_cust => _cust.Salary > 80000);
            foreach(Customer _cust in resCust)
            {
                Console.WriteLine("Name: {0}, Id: {1}, Salary: {2}", _cust.Name, _cust.Id, _cust.Salary);
            }


            int matchIndex = custList.FindLastIndex(_cust => _cust.Salary> 80000);
            Console.WriteLine("\nMtached Index : {0}", matchIndex);

            // Convert to array
            Customer[] custArr = custList.ToArray();
            Console.WriteLine("\nDisplay the converted customer array");
            foreach (Customer _cust in custArr)
            {
                Console.WriteLine("Name: {0}, Id: {1}, Salary: {2}", _cust.Name, _cust.Id, _cust.Salary);
            }

            //var path = Path.Combine(Directory.GetCurrentDirectory(), "test", "test.txt");
            //using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            using (FileStream fs = File.Create(@"C:\Users\kabhishek\Desktop\Reimbursement"))
            {
                StreamReader s = new StreamReader(fs);
                //fs.Write("");
                Console.WriteLine(s.ReadLine());
            }

            Console.ReadKey();
        }
    }
}
