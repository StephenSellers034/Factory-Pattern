using System;
namespace FactoryPattern
{
	public class Motorcycle : IVehicle
	{
        public int NumberOfTires { get; set; } = 2;

        public int Year { get; set; } = 2025;

        public string Speed { get; set; } = "Extra Fast";

        public void Drive()
        {
            Console.WriteLine("Vehicle is Building");
        }
    }
}

