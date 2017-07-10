using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class FluentCarBuilder
    {
        #region Properties from 'Car' new definiert
        public int MaxSpeed { get; set; }
        public int MaxPower { get; set; }
        public string Color { get; set; }
        #endregion

        public FluentCarBuilder WithMaxSpeed(int maxSpeed)
        {
            MaxSpeed = maxSpeed;
            return this;
        }
        public FluentCarBuilder WithMaxPower(int maxPower)
        {
            MaxPower = maxPower;
            return this;
        }
        public FluentCarBuilder WithColor(string color)
        {
            Color = color;
            return this;
        }

        public Car GetCar()
        {
            var errorMessage = "Cannot create a car without ";
            if (MaxSpeed == 0)
                throw new InvalidOperationException(errorMessage + "MaxSpeed");
            if (MaxPower == 0)
                throw new InvalidOperationException(errorMessage + "MaxPower");
            if (String.IsNullOrEmpty(Color))
                throw new InvalidOperationException(errorMessage + "Color");

            return new Car()
            {
                MaxSpeed = MaxSpeed,
                MaxPower = MaxPower,
                Color = Color
            };
        }
    }
}
