using System.Linq;

namespace lesson_7
{
    public class Delegates
    {
        public delegate double MyDel(int[] a);
        
        public static MyDel myDel = delegate(int[] ints) { return ints.Sum() / ints.Length; };
    }
}