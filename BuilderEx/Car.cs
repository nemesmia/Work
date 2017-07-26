using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderEx
{
	public class Car
	{
		public string Name { get; set; }
		public int Speed { get; set; }

		public override string ToString() => $"Driving {Name} with {Speed} km/h";
	}
}
