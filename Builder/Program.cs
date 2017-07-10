using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateCarsManually();

            CreateCarsWithFluent();
        }

        public static void CreateCarsManually()
        {
            var carFactory = new CarFactory();
            var builders = new List<CarBuilder> {
                new SmallCarBuilder(),
                new BigCarBuilder() };
            
            foreach (var builder in builders)
            {
                var car = carFactory.Build(builder);

                Console.WriteLine($"\nThe car created by " +
                    $"{builder.GetType().Name}: " +
                    $"\nSpeed: {car.MaxSpeed}" +
                    $"\nPower: {car.MaxPower} " +
                    $"\nColor: {car.Color}");

                car.Drive();
            };

            Console.ReadKey();
        }

        public static void CreateCarsWithFluent()
        {
            Console.WriteLine("\nWith Fluent now: ");

            new FluentCarBuilder()
                .WithMaxSpeed(130)
                .WithMaxPower(75)
                .WithColor("White")
                .GetCar()
                .Drive();

            new FluentCarBuilder()
                .WithMaxSpeed(330)
                .WithMaxPower(150)
                .WithColor("Black")
                .GetCar()
                .Drive();

            Console.ReadKey();
        }
    }
}
