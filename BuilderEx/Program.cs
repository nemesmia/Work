﻿using System;
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

			car.Drive();

			*/

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
				car.Drive()
			}*/

			// drive  cars with fluent
			new FluentCarBuilder()
					.WithName("Ford")
					.WithSpeed(130)
					.GetCar()
					.Drive();

			new FluentCarBuilder()
				.WithName("Toyota")
				.WithSpeed(150)
				.GetCar()
				.Drive();

			Console.ReadLine();
		}
	}
}
