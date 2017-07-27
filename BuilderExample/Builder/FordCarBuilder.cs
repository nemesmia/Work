using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample
{
	public  class FordCarBuilder: CarBuilder
	{
		public override void SetName()
		{
			_car.Name = "Ford";
		}
		public override void SetSpeed()
		{
			_car.Speed = 100;
		}
		public override void SetColor()
		{
			_car.Color = "Grün";
		}


	}
}
