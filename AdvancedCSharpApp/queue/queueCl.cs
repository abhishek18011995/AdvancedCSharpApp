using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpApp.queue
{
    class Customer
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Salary { get; set; }
        public string Type { get; set; }
    }
        class QueueCl
    {
        static void Main()
        {
            Customer cust1 = new Customer() { Name = "Abhi", Id = 24, Salary = 96000, Type = "Retail" };
            Customer cust2 = new Customer() { Name = "BBBB", Id = 25, Salary = 86000, Type = "Retail" };
            Customer cust3 = new Customer() { Name = "CCCC", Id = 26, Salary = 76000, Type = "Corporate" };
            Customer cust4 = new Customer() { Name = "DDDD", Id = 27, Salary = 66000, Type = "Corporate" };

            Queue<Customer> queueCustomers = new Queue<Customer>();
            queueCustomers.Enqueue(cust1);
            queueCustomers.Enqueue(cust2);
            queueCustomers.Enqueue(cust3);
            queueCustomers.Enqueue(cust4);

            Console.WriteLine(queueCustomers.Peek().Name);
            Console.WriteLine(queueCustomers.Count + "\n");

            foreach (Customer c1 in queueCustomers) {
                Console.WriteLine(c1.Name);
                Console.WriteLine(queueCustomers.Count);
            }


            Console.WriteLine("\n" + queueCustomers.Dequeue().Name);
            Console.WriteLine(queueCustomers.Count);

            Console.ReadKey();
        }
    }
}
