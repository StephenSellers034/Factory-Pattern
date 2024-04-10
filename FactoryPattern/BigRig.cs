using System;
namespace FactoryPattern
{
	public class BigRig : IVehicle
	{
        public int NumberOfTires { get; set; } = 18;

        public void Drive()
        {
            Console.WriteLine("Vehicle is Building");
        }
    }
}

