using System;
namespace CSharp
{
    class Datatypes1
    {
        public static void Run()
        {
            /* datatypes in C# It is divided into
            1- Value Types -> directly contains data , stored in stack memory(fixed size,faster access)
                a- Simple Types (int, float, double, char, bool)
                b- Struct Types (user-defined types using struct keyword)
                c- Enum Types (user-defined types using enum keyword)
                d- Nullable Types (can represent all values of its underlying type plus an additional null value)
            2- Reference Types -> contains a reference to the data's memory address, stored in heap memory (dynamic size, slower access)
                a- Class Types (user-defined types using class keyword)
                b- Interface Types (user-defined types using interface keyword)
            3- Pointer Types (unsafe code) types that hold memory addresses of other types

            --- suffixes ---    
            

            */
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("----- Welcome to Datatypes -----------");
            Console.WriteLine("--------------------------------------");
            int a = 10; // int32
            float b = 20.5f; // float32
            double c = 30.5; // float64
            char d = 'A'; // single 16-bit Unicode character
            bool e = true; // true or false

            // to get defualt values
            Console.WriteLine($"Default int: {default(int)}");
            Console.WriteLine($"Integer: {a}, Float: {b}, Double: {c}, Char: {d}, Bool: {e}");
        
        }
    }
}