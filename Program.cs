using System;
using System.Collections.Generic;

namespace garys_wholesale_garage
{
    class Program
    {
        static void Main(string[] args)
        {
            var electric = new List<BatteryCar>();
            electric.Add(new BatteryCar("Leaf"));
            electric.Add(new BatteryCar("Volt"));
            electric.Add(new BatteryCar("Prius"));

            var gas = new List<GasCar>();
            gas.Add(new GasCar("Corvette"));
            gas.Add(new GasCar("Hummer"));
            gas.Add(new GasCar("Wrangler"));

            var bStation = new BatteryStation();
            bStation.Refuel(electric);

            var gStation = new GasStation();
            gStation.Refuel(gas);

        }
    }
}
