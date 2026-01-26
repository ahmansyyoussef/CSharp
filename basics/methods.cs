using System;
namespace CSharp
{
    class Methods
    {
     public static  void run()
        {
            Console.WriteLine("Methods");
            int result = Add(5, 10);
            Console.WriteLine("Sum: " + result);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }   
    }
}