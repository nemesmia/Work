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

		public virtual void Drive() { Console.WriteLine($"Driving {Name} with {Speed} km/h"); }
	}
}
