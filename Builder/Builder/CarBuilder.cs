using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class CarBuilder
    {
        protected readonly Car _car = new Car();

        // Setter only
        public abstract void SetMaxSpeed();
        public abstract void SetMaxPower();
        public abstract void SetColor();

        public virtual Car GetCar()
        {
            return _car;
        }
    }
}
