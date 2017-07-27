using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample
{
	public  class DaciaCarBuilder: CarBuilder
	{
		public override void SetName()
		{
			_car.Name = "Dacia";
		}
		public override void SetSpeed()
		{
			_car.Speed = 110;
		}
		public override void SetColor()
		{
			_car.Color = "Rot";
		}


	}
}
