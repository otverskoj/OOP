using System.Collections.Generic;
using lesson_6;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoles = Console.Generate100();
            
            var manufacturersList = new List<Manufacturer>()
            {
                new Manufacturer(ManufacturerNames.Nintendo, Countries.Japan, 1000),
                new Manufacturer(ManufacturerNames.Sega, Countries.Japan, 4000),
                new Manufacturer(ManufacturerNames.Microsoft, Countries.USA, 10000)
            };
        }
    }
}