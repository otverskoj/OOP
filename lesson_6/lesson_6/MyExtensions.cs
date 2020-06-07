using System;

namespace lesson_6
{
    public static class MyExtensions
    {
        public static string DeleteLatinLetters(this String str)
        {
            const string latinLetters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            var result = "";
            foreach (var c in str)
            {
                if (!latinLetters.Contains(c))
                {
                    result += c;
                }
                else continue;
            }

            return result;
        }
    }
}