using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderEx
{
	class Program
	{
		static void Main(string[] args)
		{
			Car car = new Car();

			car.Name = "Toyota";
			car.Speed = 160;

			Console.WriteLine(car.ToString());

			Console.ReadLine();
		}
	}
}
