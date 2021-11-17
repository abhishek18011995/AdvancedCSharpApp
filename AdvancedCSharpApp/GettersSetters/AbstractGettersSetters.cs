using System;

namespace AdvancedCSharpApp.GettersSetters
{

    abstract class Person
    {
        public abstract string Name { get; set; }
        public abstract int Age { get; set; }
    }

    class Employer : Person
    {
        private string address = "1st street";
        private string name = "1st street";
        private int age = 11;

        public override string Name {
            get => name;
            set => name =value;
        }

        //public override int Age
        //{
        //    get => age;
        //    set => age = value;
        //}
        public override int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public override string ToString()
        {
            return "Address = " + Address + ", Name = " + Name + ", Age = " + Age;
        }
    }

    class AbstractGettersSetters
    {
        static void Main()
        {
            Employer e1 = new Employer();
            e1.Name = "Abhi";
            e1.Age = 24;
            e1.Address = "3rd cross";
            Console.WriteLine("Employee Info:- {0}", e1);
            
            MovieCl mc1 = new MovieCl("Avengers Endgame", 9);
            Console.WriteLine("Movie Info:- {0}", mc1);

            Console.ReadKey();
        }

    }
}
