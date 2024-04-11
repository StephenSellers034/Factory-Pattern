using System;
namespace FactoryPattern
{
	public class BigRig : IVehicle
	{
        public int NumberOfTires { get; set; } = 18;

        public int Year { get; set; } = 2020;

        public string Speed { get; set; } = "Medium";

        public void Drive()
        {
            Console.WriteLine("Vehicle is Building");
        }
    }
}

