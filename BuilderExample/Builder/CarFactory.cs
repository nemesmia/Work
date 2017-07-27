using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample
{
	public class CarFactory
	{

		public Car GetCar(CarBuilder builder)
		{
			builder.SetName();
			builder.SetColor();
			builder.SetSpeed();

			return builder.GetCar();
		}
	}
}
