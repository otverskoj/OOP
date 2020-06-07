using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());
            var o = Console.ReadLine();
            
            Console.WriteLine(Delegates.myDel(x, y, o));
        }
    }
}