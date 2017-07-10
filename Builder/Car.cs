using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Car
    {
        public int MaxSpeed { get; set; }
        public int MaxPower { get; set; }
        public string Color { get; set; }

        public void Drive()
        {
            Console.WriteLine("Driving... at speed {0} and power {1} and my color is '{2}'",
                MaxSpeed, MaxPower, Color);
        }
    }
}
