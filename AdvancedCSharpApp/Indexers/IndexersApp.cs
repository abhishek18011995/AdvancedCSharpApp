using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpApp.Indexers
{
    class Employee1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

    }

    class Company
    {
        private List<Employee1> listEmployees;

        public Company()
        {
            listEmployees = new List<Employee1>();
            listEmployees.Add(new Employee1() { Id = 11, Name = "Abhi" , Gender = "Male" });
            listEmployees.Add(new Employee1() { Id = 12, Name = "Suraj", Gender = "Male" });
            listEmployees.Add(new Employee1() { Id = 13, Name = "Anuj", Gender = "Female" });
            listEmployees.Add(new Employee1() { Id = 14, Name = "Pratysh", Gender = "Female" });
        }

        public string this[int employeeId]
        {
            get
            {
                return listEmployees.FirstOrDefault(employee => employee.Id == employeeId).Name;
            }

            set
            {
                listEmployees.FirstOrDefault(employee => employee.Id == employeeId).Name = value;
            }
        }
        public string this[string gender]
        {
            get
            {
                return listEmployees.Count(employee => employee.Gender == gender).ToString();
            }

            set
            {
                listEmployees.ForEach(employee =>
                {
                    if (employee.Gender == gender)
                    {
                        employee.Gender = value;
                    }
                });
            }
        }

    }

    class IndexersApp
    {
        static void Main()
        {
            Company cm = new Company();

            Console.WriteLine("Employee Names");
            Console.WriteLine("Employee id 11: {0}", cm[11]);
            Console.WriteLine("Employee id 11: {0}", cm[14]);
            cm[11] = "kumar";
            Console.WriteLine("Employee id 11: {0} \n", cm[11]);


            Console.WriteLine("Employee Gender before update");
            Console.WriteLine("total number of male employees : {0}", cm["Male"]);
            cm["Female"] = "Male";
            Console.WriteLine("total number of male employees : {0}", cm["Male"]);


            Console.ReadKey();
        }
    }
}
