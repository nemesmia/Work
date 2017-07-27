using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample
{
	public class FluentBuilder
	{

		public string Name { get; set; }
		public int Speed { get; set; }
		public string Color { get; set; }

		public FluentBuilder WithName( string name ) {
			Name = name;
			return this;
		}
		public FluentBuilder WithSpeed( int speed ) {
			Speed = speed;
			return this;
		}
		public FluentBuilder WithColor(string color) {
			Color = color;
			return this;
		}

		public Car GetCar()
		{
			if(string.IsNullOrEmpty(Name))
			{
				throw new InvalidOperationException("Name fehlt");
			}
			if (Speed == 0)
			{
				throw new InvalidOperationException("Speed fehlt");
			}
			return new Car()
			{
				Name = Name,
				Speed = Speed,
				Color = Color
			};
		}

	}
}
