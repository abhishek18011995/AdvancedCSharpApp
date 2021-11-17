using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpApp.Inheritance
{
	public abstract class Fruit
	{
		public abstract string GetColor();
	}
	public class Apple : Fruit
	{
		public override string GetColor()
		{
			return "Red";
		}
	}
	public class Orange : Fruit
	{
		public override string GetColor()
		{
			return "Orange";
		}
	}

	class C
	{
	}

	class A
	{
		public virtual void disp()
		{
			Console.WriteLine("a");
		}

		public void disp2()
		{
			Console.WriteLine("a");
		}
	}

	class B:A
	{
		public override void disp()
		{
			Console.WriteLine("b");
		}

		public new void disp2()
		{
			Console.WriteLine("b");
		}
	}


	class Overiding
	{
		public static void Main()
		{
			B bo = new B();
			A ao = new B();
			bo.disp(); // b
			ao.disp(); // b
			bo.disp2(); // b
			ao.disp2(); // a
			Console.WriteLine("Hello World");
			Fruit fruit = new Orange();
			//Console.WriteLine(fruit.GetColor());
			Console.ReadKey();
		}
	}


}
