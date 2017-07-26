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

			ToyotaCarBuilder toyotaBuilder = new ToyotaCarBuilder();
			toyotaBuilder.SetName();
			toyotaBuilder.SetSpeed();
			var toyota = toyotaBuilder.GetCar();

			Console.WriteLine(toyota.ToString());


			FordCarBuilder fordCarBuilder = new FordCarBuilder();
			fordCarBuilder.SetName();
			fordCarBuilder.SetSpeed();
			var ford = fordCarBuilder.GetCar();

			Console.WriteLine(ford.ToString()); 

			 Console.ReadLine();
		}
	}
}
