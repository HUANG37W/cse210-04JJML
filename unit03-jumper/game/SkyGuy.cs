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

   
}
