using System;
using System.Collections.Generic;

namespace garys_wholesale_garage
{
    public class GasStation : ICar<GasCar>
    {
        public int Capacity(int amount)
        {
            Console.WriteLine($"Your vehicle has been refuled {amount} percent.");
            return amount;
        }

        public void Refuel(List<GasCar> vehicles)
        {
            foreach (var vehicle in vehicles)
                Console.WriteLine($"This gas powered vehicle {vehicle.Name}, has been refuled.");
        }
    }
}