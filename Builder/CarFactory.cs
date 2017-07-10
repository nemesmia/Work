using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// The 'Director' class
    /// </summary>
    public class CarFactory
    {
        public Car Build(CarBuilder builder)
        {
            builder.SetMaxPower();
            builder.SetMaxSpeed();
            builder.SetColor();

            return builder.GetCar();
        }
    }
}
