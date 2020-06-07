using System.Collections.Generic;
using System.Linq;
using lesson_6;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoles = Console.Generate100();
            
            // Задание 2
            var intelConsolesWhereQueryList = consoles.Where(console => 
                console.ProcessorType == ProcessorTypes.Intel).ToList();
            
            var amdAndSegaConsolesWhereQueryList = consoles.Where(console => 
                console.ProcessorType == ProcessorTypes.AMD && console.ManufactName == ManufacturerNames.Sega).ToList();
            
            var consolesWhereQuery = consoles.Where(console => 
                console.SystemAccounts.Contains("Lunar") && console.HardDiskCapacity < 90).ToList();
            
            // Задание 3
            var consoleOrder = consoles.OrderBy(console => console.ProcessorType).ToList();

            var consoleDoubleOrder = consoles.OrderBy(console => console.ProcessorType)
                .OrderBy(console => console.ManufactName).ToList();


            // Задание 4
            var consoleSelect = consoles.Select(console =>
                new {console.ProcessorType, console.HardDiskCapacity, console.SystemAccounts}).ToList();


            // Задание 5
            var manufacturersList = new List<Manufacturer>()
            {
                new Manufacturer(ManufacturerNames.Nintendo, Countries.Japan, 1000),
                new Manufacturer(ManufacturerNames.Sega, Countries.Japan, 4000),
                new Manufacturer(ManufacturerNames.Microsoft, Countries.USA, 10000)
            };
            
            
            
        }
    }
}