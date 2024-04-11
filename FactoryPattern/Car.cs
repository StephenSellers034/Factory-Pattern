using System;
namespace FactoryPattern
{
	public class Car : IVehicle
	{
        public int NumberOfTires { get; set; } = 4;

        public int Year { get; set; } = 2023;

        public string Speed { get; set; } = "Fast";

        public void Drive()
        {
            Console.WriteLine("Vehicle is Building");
        }
    }
}

