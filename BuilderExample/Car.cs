using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample
{
	public class Car
	{
		public string Name { get; set; }
		public  int Speed { get; set; }
		public  string Color { get; set; }

		public void Drive()
		{
			Console.WriteLine($"Driving {Name} with speed {Speed} and color {Color}");
		}

	}
}
