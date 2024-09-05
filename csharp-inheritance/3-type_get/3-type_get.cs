using System;
using System.Reflection;
class Obj
{
    public static void Print(object myObj)
    {
        Type type = myObj.GetType();
        PropertyInfo[] properties = type.GetProperties();
        Type types = myObj.GetType();
        MethodInfo[] methods = type.GetMethods();

        Console.WriteLine($"{types.Name} Properties:");
        foreach (var item in properties)
        {
            Console.WriteLine(item.Name);
        }

        Console.WriteLine($"{types.Name} Methods:");
        foreach (var item in methods)
        {
            Console.WriteLine(item.Name);
        }
    }
}