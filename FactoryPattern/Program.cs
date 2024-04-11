namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose how many tires you would like 2 or 18:");
            int userInput = int.Parse(Console.ReadLine());

            IVehicle vehicle = VehicleFactory.GetVehicle(userInput);
            vehicle.Drive();
            Console.WriteLine($"The number of tires you choose is: {vehicle.NumberOfTires}");
            Console.WriteLine($"The vehicle speed rate is: {vehicle.Speed}");
            Console.WriteLine($"The vehicle year is: {vehicle.Year}");
        }

    }
}
