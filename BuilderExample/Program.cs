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
			var builders = new List<CarBuilder>()
			{
				new FordCarBuilder(),
				new DaciaCarBuilder()
			};
			var factory = new CarFactory();

			foreach(var builder in builders)
			{
				factory.GetCar(builder).Drive();
			}

			Console.ReadLine();
		}
	}
}
