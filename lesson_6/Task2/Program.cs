using System.Linq;
using lesson_6;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoles = Console.Generate100();

            var intelConsolesWhereQuery = 
                from console in consoles
                where (console.ProcessorType == ProcessorTypes.Intel)
                select console;
            var intelConsolesWhereQueryList =  intelConsolesWhereQuery.ToList();
            intelConsolesWhereQueryList.ForEach(ic => System.Console.WriteLine($"{ic.ConsoleName}, {ic.ProcessorType} "));
            System.Console.WriteLine();
            
            var amdAndSegaConsolesWhereQuery = 
                from console in consoles
                where (console.ProcessorType == ProcessorTypes.AMD && console.ManufactName == ManufacturerNames.Sega)
                select console;
            var amdAndSegaConsolesWhereQueryList =  amdAndSegaConsolesWhereQuery.ToList();
            amdAndSegaConsolesWhereQueryList.ForEach(asc => 
                System.Console.WriteLine($"{asc.ConsoleName}, {asc.ProcessorType}, {asc.ManufactName}"));
            System.Console.WriteLine();
            
            var consolesWhereQuery = 
                from console in consoles
                where (console.SystemAccounts.Contains("Lunar") && console.HardDiskCapacity < 90)
                select console;
            var consolesQueryWhereQueryList = consolesWhereQuery.ToList();
            consolesQueryWhereQueryList.ForEach(c => 
                System.Console.WriteLine($"{c.ConsoleName}, {c.HardDiskCapacity}"));
            System.Console.WriteLine();
            
        }
    }
}