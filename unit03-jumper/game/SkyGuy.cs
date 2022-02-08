using System;
using System.Collections.Generic;

namespace unit03_jumper
{
    class SkyGuy
    {
        static void Main(string[] args)
        {

            List<string> parachute = AddNumbers();
            {
                PrintGuy(parachute);
            }

        static List<string> AddNumbers()
        {
            List<string> parachute = new List<string>();
            for (int i = 1; i< 7; i++)
            {
                parachute.Add(i.ToString());
            }
            return parachute;

            
        }
    }

    static void PrintGuy(List<string> parachute)
    {
        Console.WriteLine();
        Console.WriteLine($" {parachute[0]}____");
        Console.WriteLine($" /{parachute[1]}   \\ " );
        Console.WriteLine($" {parachute[2]}_____");
        Console.WriteLine($"  \\{parachute[3]}  /" );
        Console.WriteLine($"   \\{parachute[4]}/ " );
        Console.WriteLine($" {parachute[5]}  0" );
        Console.WriteLine($"  / | \\" );
        Console.WriteLine($"   /  \\" );



    }
    
}
}