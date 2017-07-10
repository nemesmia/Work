using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class BigCarBuilder : CarBuilder
    {
        public override void SetMaxSpeed()
        {
            _car.MaxSpeed = 330;
        }

        public override void SetMaxPower()
        {
            _car.MaxPower = 150;
        }

        public override void SetColor()
        {
            _car.Color = "Black";
        }
    }
}
