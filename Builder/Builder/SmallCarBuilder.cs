using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class SmallCarBuilder : CarBuilder
    {
        public override void SetMaxSpeed()
        {
            _car.MaxSpeed = 130;
        }

        public override void SetMaxPower()
        {
            _car.MaxPower = 75;
        }

        public override void SetColor()
        {
            _car.Color = "White";
        }
    }
}
