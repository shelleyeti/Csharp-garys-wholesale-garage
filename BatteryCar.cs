using System;

namespace garys_wholesale_garage
{
    public class BatteryCar
    {
        public string Name { get; set; }
        public void Message(string name)
        {
            Name = name;
            Console.WriteLine($"The {name} has been recharged. Shh, shh.");
        }

        public BatteryCar(string name)
        {
            Name = name;
        }
    }
}