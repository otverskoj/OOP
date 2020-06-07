using System.Linq;
using lesson_6;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoles = Console.Generate100();
            
            var consoleOrderQuery = 
                from console in consoles
                orderby console.ProcessorType
                select console;
            var consoleOrderQueryList = consoleOrderQuery.ToList();
            
            consoleOrderQueryList.ForEach(c => 
                System.Console.WriteLine($"{c.ConsoleName}, {c.ProcessorType}"));
            System.Console.WriteLine();
            
            
            var consoleDoubleOrderQuery = 
                from console in consoles
                orderby console.ProcessorType, console.ManufactName
                select console;
            var consoleDoubleOrderQueryList = consoleDoubleOrderQuery.ToList();
            
            consoleDoubleOrderQueryList.ForEach(c => 
                System.Console.WriteLine($"{c.ConsoleName}, {c.ProcessorType}, {c.ManufactName}"));
            System.Console.WriteLine();
        }
    }
}