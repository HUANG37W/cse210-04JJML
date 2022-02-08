using System;
using System.Collections.Generic;

namespace unit03_jumper
{
    class SkyGuy
    {

         private string[] parachute = new string[8]
        {
            " ____", " /   \\", " _____", "  \\  /" , "  \\ / ", "   0", "  / | \\", "  /  \\"
        
        };  

        public void PrintGuy()
        {
            foreach (string i in parachute)
            {
                Console.WriteLine(i);
            }

            
        }
    }

<<<<<<< HEAD
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

    
    
=======
   
>>>>>>> 3380698fee0f3d00b69045c13c3ecc5d77ede4c1
}
