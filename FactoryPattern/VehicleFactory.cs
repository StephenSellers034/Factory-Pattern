using System;
namespace FactoryPattern
{
	public class VehicleFactory
	{

		public static IVehicle GetVehicle(int amountOfTires)
		{
			if(amountOfTires == 2)
			{
				Console.WriteLine("MotorCycle");
				return new Motorcycle();
			}
			if(amountOfTires == 18)
			{
				Console.WriteLine("BigRig");
				return new BigRig();
			}
			else
			{
				Console.WriteLine("Car");
				return new Car();
			}
		}
		
	}
}

