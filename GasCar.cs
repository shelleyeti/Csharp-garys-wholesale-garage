using System;

namespace garys_wholesale_garage
{
    public class GasCar
    {
        public string Name { get; set; }
        public void Message(string name)
        {
            Name = name;
            Console.WriteLine($"The {name} has been refuled. Vroom, vroom.");
        }
        public GasCar(string name)
        {
            Name = name;
        }
    }
}