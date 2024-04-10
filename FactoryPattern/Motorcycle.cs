using System;
namespace FactoryPattern
{
	public class Motorcycle : IVehicle
	{
        public int NumberOfTires { get; set; } = 2;

        public void Drive()
        {
            Console.WriteLine("Vehicle is Building");
        }
    }
}

