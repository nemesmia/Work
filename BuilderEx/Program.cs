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
			FordCarBuilder fordCarBuilder = new FordCarBuilder();

			CarFactory factory = new CarFactory();
			var ford = factory.BuildCar(fordCarBuilder);
			var toyota = factory.BuildCar(toyotaBuilder);


			Console.WriteLine(toyota.ToString());
			Console.WriteLine(ford.ToString()); 

			 Console.ReadLine();
		}
	}
}
