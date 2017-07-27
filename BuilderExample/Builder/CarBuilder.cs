using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample
{
	public abstract class CarBuilder
	{
		protected Car _car = new Car();

		public Car GetCar()
		{
			return _car;
		}

		public abstract void SetName();
		public abstract void SetSpeed();
		public abstract void SetColor();


	}
}
