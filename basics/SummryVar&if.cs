using System;
using System.Diagnostics;
namespace CSharp
{
    class SummryVar_if
    {
        public static void run()
        {
            Console.WriteLine("Enter Your First Name: ");
            string? fname = Console.ReadLine();

            Console.WriteLine("Enter Your Last Name: ");
            string? lname = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(fname) || string.IsNullOrWhiteSpace(lname))
            {
                Console.WriteLine("Invalid input. Please enter  values.");
                run();   // استدعاء الدالة مرة تانية
                return; // يوقف التنفيذ الحالي
            }

            Console.WriteLine($"Welcome: {fname} {lname} Now You Can Continue");
            Console.WriteLine("Enter First Number: ");
            double? num1 = double.TryParse(Console.ReadLine(), out double result) ? result : null;
            Console.WriteLine("Enter Second Number: ");
            double? num2 = double.TryParse(Console.ReadLine(), out result) ? result : null;
            if (num1 == null || num2 == null)
            {
                Console.WriteLine("Invalid input. Please enter numeric values.");
                run(); // استدعاء الدالة مرة تانية
                return; // يوقف التنفيذ الحالي
            }
            double sum = num1.Value + num2.Value;
            Console.WriteLine($"The Sum of {num1} + {num2} = {sum}");
            double subtraction = num1.Value - num2.Value;
            Console.WriteLine($"The Subtraction of {num1} - {num2} = {subtraction}");
            double multiplication = num1.Value * num2.Value;
            Console.WriteLine($"The Multiplication of {num1} * {num2} = {multiplication}");
            if (num2 != 0)
            {
                double division = num1.Value / num2.Value;
                Console.WriteLine($"The Division of {num1} / {num2} = {division.ToString("0.00")}");
            }
            else
            {
                Console.WriteLine("Division by zero is not allowed.");
            }
            double Modules = num1.Value % num2.Value;
            Console.WriteLine($"The Modules of {num1} % {num2} = {Modules}");

          
        }
      
    }
}
