using System;
namespace FactoryPattern
{
	public class VehicleFactory
	{

		public static IVehicle GetVehicle(string choiceTires)
		{
			switch(choiceTires)
			{
				case "18":
					Console.WriteLine("BigRig");
					return new BigRig();
				case "2":
					Console.WriteLine("Motorcycle");
					return new Motorcycle();
				default:
                    Console.WriteLine("Motorcycle");
                    return new Motorcycle();
			}
		}
		
	}
}

