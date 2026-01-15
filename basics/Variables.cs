using System;

namespace CSharp
{
    class Variables
    {
        public static void Run()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Variables");
            Console.WriteLine("--------------------------");
            // Declare a variable
            int num = 10;
            double decimalNum = 5.5;
            string message = "Hello, World!";
            char letter = 'A';
            bool isTrue = true;
            // Print the variable
            Console.WriteLine($"Number = {num}");
            Console.WriteLine($"Decimal Number = {decimalNum}");
            Console.WriteLine($"Message = {message}");
            Console.WriteLine($"Letter = {letter}");
            Console.WriteLine($"Is True = {isTrue}");
        }
    }
}
