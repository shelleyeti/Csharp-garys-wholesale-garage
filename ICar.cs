using System.Collections.Generic;

namespace garys_wholesale_garage
{
    public interface ICar<TItem>
    {
        int Capacity(int amount);
        void Refuel(List<TItem> vehicles);
    }
}