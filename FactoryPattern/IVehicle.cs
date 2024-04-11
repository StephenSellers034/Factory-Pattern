using System;
namespace FactoryPattern
{
	public interface IVehicle
	{
		public int NumberOfTires { get; set; }

		public int Year { get; set;}

		public string Speed { get; set; }

		public void Drive();
	}
}

