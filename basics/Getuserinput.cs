using System;
namespace CSharp
{
    class Getuserinput
    {
        public static void Run()
        {
            Console.WriteLine("Enter your frist name: ");
            string? fname = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            string? lname = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            int ?age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your full name is: " + fname + " " + lname);
            Console.WriteLine("Your age is: " + age);   
        }
    }
}