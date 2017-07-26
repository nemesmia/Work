using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderEx
{
	public class FluentCarBuilder
	{
		// Properties von Car
		public string Name { get; set; }
		public int Speed { get; set; }

		public FluentCarBuilder WithName(string name)
		{
			Name = name;
			return this;
		}

		public FluentCarBuilder WithSpeed(int speed)
		{
			Speed = speed;
			return this;
		}

		public Car GetChar()
		{
			var errorMessage = "Cannot create car without: ";
			if(String.IsNullOrEmpty(Name))
			{
				throw new InvalidOperationException(errorMessage + "Name");
			}
			if (Speed == 0)
			{
				throw new InvalidOperationException(errorMessage + "Speed");
			}

			return new Car()
			{
				Name = Name,
				Speed = Speed
			};
		}
	}
}
