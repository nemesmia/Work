using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderEx
{
	public  class ToyotaCarBuilder: CarBuilder
	{
		public override void SetName() { _car.Name = "Toyota"; }

		public override void SetSpeed() { _car.Speed = 130; }
	}
}
