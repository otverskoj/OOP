using System.Linq;
using lesson_6;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoles = Console.Generate100();
            
            var consoleSelectQuery =
                from console in consoles
                select new {console.ProcessorType, console.HardDiskCapacity, console.SystemAccounts};
            var consoleSelectQueryList = consoleSelectQuery.ToList();
            
            consoleSelectQueryList.ForEach(c => 
                System.Console.WriteLine($"{c.ProcessorType}, {c.HardDiskCapacity}, {c.SystemAccounts}"));
            System.Console.WriteLine();
        }
    }
}