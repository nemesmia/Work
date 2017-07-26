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
			/*Car car = new Car();

			car.Name = "Toyota";
			car.Speed = 160;

			Console.WriteLine(car.ToString());*/

			/*
			CarFactory factory = new CarFactory();

			var carBuilders = new List<CarBuilder>
				{
					new FordCarBuilder(),
					new ToyotaCarBuilder()
				};

			foreach(var builder in carBuilders)
			{
				var car = factory.BuildCar(builder);
				Console.WriteLine(car.ToString());
			}*/

			// create cars with fluent
			var ford = new FluentCarBuilder()
					.WithName("Ford")
					.WithSpeed(130)
					.GetChar();

			Console.WriteLine(ford.ToString());

			var toyota = new FluentCarBuilder()
				.WithName("Toyota")
				.WithSpeed(150)
				.GetChar();

			Console.WriteLine(toyota.ToString());

			Console.ReadLine();
		}
	}
}
