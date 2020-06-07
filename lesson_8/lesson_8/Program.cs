using System;
using System.Reflection;

namespace lesson_8
{
    class Program
    {
        static void Main(string[] args)
        {
            ReflectionInfo.GetFieldsInfo("User");
            ReflectionInfo.GetPropertiesInfo("User");
            ReflectionInfo.GetMethodsInfo("User");
            ReflectionInfo.GetFieldsValues("User");
            ReflectionInfo.SetFieldsValues("User");
            ReflectionInfo.GetPropertiesValues("User");
            ReflectionInfo.SetPropertiesValues("User");
            ReflectionInfo.InvokeMethod("User");
            ReflectionInfo.InvokeCtors("User");
        }
    }
}