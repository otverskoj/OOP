using System;

namespace task_2
{
    public class Delegates
    {
        public delegate double MyDel(int a, int b, string operation);

        //public static myDel1 = (x, y) => { return x * y; };
        //public static myDel2 = (x, y) => { return x / y; };
        
        public static MyDel myDel =  (int x, int y, string oper) =>
        {
            switch (oper)
            {
                case "*":
                    return x * y;
                
                case "/":
                    return x / y;
                
                default:
                    Console.WriteLine("Некорректный ввод");
                    return 0;
            }
        };
    }
}