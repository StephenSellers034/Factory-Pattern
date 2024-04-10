using System;
namespace FactoryPattern
{
	public interface IVehicle
	{
		public int NumberOfTires { get; set; }

		public void Drive();
	}
}

