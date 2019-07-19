using System;
using System.Collections.Generic;

namespace garys_wholesale_garage
{
    public class BatteryStation : ICar<BatteryCar>
    {
        public int Capacity(int amount)
        {
            Console.WriteLine($"Your vehicle has been charged {amount} percent.");
            return amount;
        }

        public void Refuel(List<BatteryCar> vehicles)
        {
            foreach (var vehicle in vehicles)
                Console.WriteLine($"This battery powered vehicle {vehicle.Name}, has been refuled.");
        }
    }
}