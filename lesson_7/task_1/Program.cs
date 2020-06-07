using System;
using System.Linq;

namespace lesson_7
{
    class Program
    {
        public delegate double MyDel(int[] a);

        static void Main(string[] args)
        {
            var a = new[] { 2, 5, 77, 25, 88 };

            Console.WriteLine($"{a.Length}");
        }
    }
}