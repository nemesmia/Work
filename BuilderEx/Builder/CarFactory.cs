using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderEx
{
	public  class CarFactory
	{
		public Car BuildCar(CarBuilder builder)
		{
			builder.SetName();
			builder.SetSpeed();

			return builder.GetCar();
		}
	}
}
