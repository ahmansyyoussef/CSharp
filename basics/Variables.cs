using System;

namespace CSharp
{
    class Variables
    {
        public static void Run()
        {
            Console.WriteLine("--------------------------");
            int x = 10;
            int y = 20;
            Console.WriteLine($"Sum = {x + y}");
            string fname = "ahmed";
            string lname = "hamdy";
            Console.WriteLine($"Full Name = {fname + lname}");
            Console.WriteLine("--------------------------");
        }
    }
}
