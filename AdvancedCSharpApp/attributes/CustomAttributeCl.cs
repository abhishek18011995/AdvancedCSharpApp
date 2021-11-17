using System;
using System.Reflection;

namespace AdvancedCSharpApp.attributes
{
    [DeBugInfo(45, "Zara Ali", "12/8/2012", Message = "Return type mismatch")]
    [DeBugInfo(49, "Nuha Ali", "10/10/2012", Message = "Unused variable")]
    class CustomAttributeCl
    {
        //member variables
        protected double length;
        protected double width;
        public CustomAttributeCl(double l, double w)
        {
            length = l;
            width = w;
        }
        [DeBugInfo(55, "Zara Ali", "19/10/2012", Message = "Return type mismatch")]

        public double GetArea()
        {
            return length * width;
        }
        [DeBugInfo(56, "Zara Ali", "19/10/2012")]

        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }

        static void Main()
        {
            //CustomAttributeCl ca = new CustomAttributeCl(10,5);
            //ca.Display();

            Type CustomAttributeClType = typeof(CustomAttributeCl);
            object[] customAttributesClassArray = CustomAttributeClType.GetCustomAttributes(false);

            Console.WriteLine("Custom attributes of Class");
            foreach (DeBugInfo obj in customAttributesClassArray)
            {
                Console.WriteLine(obj.BugNo);
                Console.WriteLine(obj.Developer);
                Console.WriteLine(obj.LastReview);
                Console.WriteLine(obj.Message);
                Console.WriteLine(" ");
            }

            Console.WriteLine("Custom attributes of methods");
            foreach(MethodInfo method in CustomAttributeClType.GetMethods())
            {
               //object[] customAttributesMethodArray = method.GetCustomAttributes(false);
                foreach (Attribute obj in method.GetCustomAttributes(true))
                {   
                    DeBugInfo dbi = obj as DeBugInfo;
                    if (null != dbi)
                    {
                        Console.WriteLine(dbi.BugNo);
                        Console.WriteLine(dbi.Developer);
                        Console.WriteLine(dbi.LastReview);
                        Console.WriteLine(dbi.Message);
                    }
                    Console.WriteLine(" ");
                }
            }




            Console.ReadKey();

        }
    }
}
