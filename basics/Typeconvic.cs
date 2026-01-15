using System;
namespace CSharp
{
    class Typeconvic
    {
        public static void Run()
        {
            /*
                Type Conversion in C#
                --------------------------
                Implicit Conversion (automatically) - converting a smaller type to a larger type size
                Explicit Conversion (manually) - converting a larger type to a smaller size type
                conversion methods:
                ToBoolean()
                ToByte()
                ToChar()
                ToDateTime()
                ToDecimal()
                ToDouble()
                ToInt16()
                ToInt32()
                ToInt64()
                ToString()
                boxing and unboxing (value types ---> reference types)
                

            */
            Console.WriteLine("--------------------------");
            Console.WriteLine("Type Conversion in C#");
            Console.WriteLine("--------------------------");

            // Implicit Conversion
            int x = 9 ;
            int y;
            y=x;
            Console.WriteLine($"Implicit Conversion Of Y:{y}"); // y = 9
            float z =1.3f;
            double w;
            w = z;
            Console.WriteLine($"Implicit Conversion Of W:{w}"); // w = 1.2999999523162842

            char ch = 'A';
            int d;
            d = ch;
            Console.WriteLine($"Implicit Conversion Of D:{d} And this value is the ASCII of 'A'"); // d = 65 => ASCII value of 'A'
            Console.WriteLine("--------------------------");
            // Explicit Conversion
            double a = 9.78;
            int b;
            b= (int)a; // Manual casting: double to int
            int k = Convert.ToInt32(a); // Using Convert class
            Console.WriteLine($"Explicit Conversion Of K:{k} "); // k = 10
            Console.WriteLine($"Explicit Conversion Of B:{b}"); // b = 9
        }
    }
}