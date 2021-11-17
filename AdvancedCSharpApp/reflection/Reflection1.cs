using System;
using System.Reflection;

namespace AdvancedCSharpApp.reflection
{
    class Reflection1
    {
        static void Main()
        {
            //ReflectionTest1 rf = new ReflectionTest1();
            //rf.Id = 5;
            //rf.Name = "Abhi";
            //Type t = Type.GetType("AdvancedCSharpApp.ReflectionTest1");
            Type t = typeof(ReflectionTest1);

            PropertyInfo[] p = t.GetProperties();
            Console.WriteLine("Properties listed below");
            foreach (PropertyInfo i in p)
            {
                Console.WriteLine("Properties : {0}", i.Name);
            }

            Console.WriteLine(" ");

            MethodInfo[] m = t.GetMethods();
            Console.WriteLine("Methods listed below");
            foreach (MethodInfo i in m)
            {
                Console.WriteLine("Methods : {0}", i.Name);
            }

            Console.WriteLine(" ");

            ConstructorInfo[] c = t.GetConstructors();
            Console.WriteLine("Constructors listed below");
            foreach (ConstructorInfo i in c)
            {
                Console.WriteLine("Constructors : {0}", i.ToString());
            }

            Console.ReadKey();

        }

    }


    class ReflectionTest1
    {
        public string Name { get; set; }
        private int id;
        //private int Id { get; set; }

        public ReflectionTest1()
        {
            Id = -1;
            Name = "XXXX";
        }
        public ReflectionTest1(int _id, string _name)
        {
            Id = _id;
            Name = _name;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
