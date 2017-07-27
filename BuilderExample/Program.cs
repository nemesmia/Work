using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample
{
	class Program
	{
		static void Main(string[] args)
		{
			Car v = new Car();
			v.Name = "Ford";
			v.Speed = 100;
			v.Color = "Grün";



			v.Drive();

			Console.ReadLine();
		}
	}
}
