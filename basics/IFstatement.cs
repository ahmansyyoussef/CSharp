using System;

namespace CSharp
{
    class IFstatement
    {
        public static void Run()
        {            
            int age = 2;

            if (age >= 18){
                Console.WriteLine("Adult");
            }
            else{
                Console.WriteLine("Minor");
            }
            Console.WriteLine("--------------------------");
        }
        
    }
}
