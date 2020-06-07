using System;
using System.Collections.Generic;
using System.Reflection;

namespace lesson_8
{
    public static class ReflectionInfo
    {

        public static void GetFieldsInfo(string className)
        {
            var prm = "lesson_8." + className;
            Type myType = Type.GetType(prm, false, true);

            // Получаем информацию о полях
            Console.WriteLine("Поля:");
            foreach (FieldInfo field in myType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public))
            {
                string modificator = "";
                if (field.IsPrivate)
                {
                    modificator = "private";
                }
                else if (field.IsPublic)
                {
                    modificator = "public";
                }
                else
                {
                    modificator = "protected";
                }
                Console.WriteLine($"{modificator} {field.FieldType} {field.Name}");
            }
        }

        public static void GetPropertiesInfo(string className)
        {
            var prm = "lesson_8." + className;
            Type myType = Type.GetType(prm, false, true);

            // Получаем информацию о свойствах
            Console.WriteLine("Свойства:");
            foreach (PropertyInfo property in myType.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public))
            {
                Console.WriteLine($"{property.PropertyType} {property.Name}");
            }
        }

        public static void GetMethodsInfo(string className)
        {
            var prm = "lesson_8." + className;
            Type myType = Type.GetType(prm, false, true);

            // Получаем информацию о методах
            Console.WriteLine("Методы:");
            foreach (MethodInfo method in myType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public))
            {
                string modificator = "";
                if (method.IsPrivate)
                {
                    modificator = "private ";
                }
                else if (method.IsPublic)
                {
                    modificator = "public ";
                }
                else
                {
                    modificator = "protected ";
                }
                if (method.IsStatic)
                    modificator += "static ";
                if (method.IsVirtual)
                    modificator += "virtual ";
                Console.Write($"{modificator}{method.ReturnType.Name} {method.Name} (");

                //получаем все параметры
                ParameterInfo[] parameters = method.GetParameters();
                for (int i = 0; i < parameters.Length; i++)
                {
                    Console.Write($"{parameters[i].ParameterType.Name} {parameters[i].Name}");
                    if (i + 1 < parameters.Length) Console.Write(", ");
                }
                Console.WriteLine(")");
            }
        }

        public static void GetFieldsValues(string className)
        {
            Console.WriteLine("Текущие значения полей:");
            
            var user = new User("Олег", "Oleg", "12345");
            var prm = "lesson_8." + className;
            Type myType = Type.GetType(prm, false, true);

            var publicField = myType.GetField("Type", 
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            Console.WriteLine($"{publicField.Name}: {(string)publicField.GetValue(user)}");

            var protectedField = myType.GetField("Code", 
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            Console.WriteLine($"{protectedField.Name}: {(int)protectedField.GetValue(user)}");

            var privateField = myType.GetField("_version", 
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            Console.WriteLine($"{privateField.Name}: {(double)privateField.GetValue(user)}");
        }
        
        public static void SetFieldsValues(string className)
        {
            Console.WriteLine("Значения полей после изменения: ");
            
            var user = new User("Олег", "Oleg", "12345");
            var prm = "lesson_8." + className;
            Type myType = Type.GetType(prm, false, true);

            var publicField = myType.GetField("Type", 
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            publicField.SetValue(user, "NewPlayer");
            
            var protectedField = myType.GetField("Code", 
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            protectedField.SetValue(user, 1001);

            var privateField = myType.GetField("_version", 
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            privateField.SetValue(user, 0.2);

            user.PrintUserInfo();
        }

        public static void GetPropertiesValues(string className)
        {
            Console.WriteLine("Текущие значения свойств: ");
            
            var user = new User("Олег", "Oleg", "12345");
            var prm = "lesson_8." + className;
            Type myType = Type.GetType(prm, false, true);

            var publicProp = myType.GetProperty("Name",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            Console.WriteLine($"{publicProp.Name}: {(string) publicProp.GetValue(user)}");
            
            var protectedProp = myType.GetProperty("Login",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            Console.WriteLine($"{protectedProp.Name}: {(string) protectedProp.GetValue(user)}");
            
            var privateProp = myType.GetProperty("Password",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            Console.WriteLine($"{privateProp.Name}: {(string) privateProp.GetValue(user)}");
        }
        
        public static void SetPropertiesValues(string className)
        {
            Console.WriteLine("Значения свойств после изменения: ");
            
            var user = new User("Олег", "Oleg", "12345");
            var prm = "lesson_8." + className;
            Type myType = Type.GetType(prm, false, true);

            var publicProp = myType.GetProperty("Name",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            publicProp.SetValue(user, "Максим");
            
            var protectedProp = myType.GetProperty("Login",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            protectedProp.SetValue(user, "Max");
            
            var privateProp = myType.GetProperty("Password",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            privateProp.SetValue(user, "67890");

            user.PrintUserInfo();
        }

        public static void InvokeMethod(string className)
        {
            var prm = "lesson_8." + className;
            Type myType = Type.GetType(prm, false, true);
            var user = new User("Олег", "Oleg", "12345");

            Console.WriteLine("До вызова приватного метода:");
            user.PrintUserInfo();
            var privateMethod = myType.GetMethod("ChangePassword", BindingFlags.NonPublic | BindingFlags.Instance);
            privateMethod.Invoke(user, new object[] {"NewPassword"});
            Console.WriteLine("После вызова приватного метода:");
            user.PrintUserInfo();
            
        }
        
        public static void InvokeCtors(string className)
        {
            var prm = "lesson_8." + className;
            Type myType = Type.GetType(prm, false, true);
            var user = new User("Олег", "Oleg", "12345");
            
            // Получение всех конструкторов  из класса.
            ConstructorInfo[] constructorInfo = myType.GetConstructors();
            
            List<User> users = new List<User>();
            // Создание экземпляров класса через вызов конструкторов.
            foreach (var constructor in constructorInfo)
            {
                var person =
                    (constructor.GetParameters().Length == 0)
                        ? constructor.Invoke(new object[]{})
                        : constructor.Invoke(new object[] {"Обиван", "Кеноби", "666"});

                users.Add((User)person);
            }

            foreach (var person in users)
            {
                Console.WriteLine("Current user: ");
                person.PrintUserInfo();
                Console.WriteLine();
            }
        }

        // TODO: Сделать функции получения значений свойств, задания значений полей и свойств. 
        // TODO: Посмотреть остальные задания в документе.
    }
}