using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderEx
{

	public class FordCarBuilder : CarBuilder
	{
		public override void SetName() { _car.Name = "Ford"; }

		public override void SetSpeed() { _car.Speed = 160; }
	}
}
