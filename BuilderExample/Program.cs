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
			new FluentBuilder()
				.WithName("Ford")
				.WithSpeed(100)
				.WithColor("Red")
				.GetCar()
				.Drive();

			new FluentBuilder()
			.WithName("Dacia")
			.WithSpeed(150)
			.WithColor("Blau")
			.GetCar()
			.Drive();

			Console.ReadLine();
		}
	}
}
