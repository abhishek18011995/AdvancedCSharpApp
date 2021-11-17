using System;
using System.Reflection;

namespace AdvancedCSharpApp.reflection
{
    class LazyBindingReflection
    { 
        static void Main()
        {
            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            Type fullNameClass = currentAssembly.GetType("AdvancedCSharpApp.reflection.FullNamecl");

            // Creating class instance
            object fullNameClInstance = Activator.CreateInstance(fullNameClass);
            string[] parameters = { "Kumar", "Abhishek"};

            // get the fullname method from the fullnameclass
            MethodInfo fullNameMethod = fullNameClass.GetMethod("fullName");

            string fullName = (string)fullNameMethod.Invoke(fullNameClInstance, parameters);
            Console.WriteLine(fullName);
            Console.ReadKey();
        }
    }

    class FullNamecl
    {
        public string fullName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }
    }
}
