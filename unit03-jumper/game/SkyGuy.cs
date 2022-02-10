using System;
using System.Collections.Generic;
using System.Linq;

namespace unit03_jumper
{
    class SkyGuy
    {
        int _lives = 6;
        /// <summary>
        /// Constructs a new SkyGuy.
        /// </summary>

        public SkyGuy()
        {
            //SkyGuy Instance Constructor
        }

        // the body of the skyguy
        private string[] body = new string[2]
        {
            "  / | \\", "  /  \\"
        };

        // the parachute of the skyguy
        private List<string> parachute = new List<string>()
        {
             " ____", " /   \\ ", " _____", "  \\  /" , "   \\/ ", "   0"
        };

        /// <summary>
        /// Prints the fixed body of skyguy.
        /// </summary>
        public void PrintGuy()
        {
            foreach (string i in body)
            {
                Console.WriteLine(i);
            }
        }
        /// <summary>
        /// Prints the parachute of skyguy in rows, indexed, and includes the head.
        /// </summary>
        public void PrintParachute()
        {
            foreach (string i in parachute)
            {
                Console.WriteLine(i);
            }
            
        }
        /// <summary>
        /// Removes the first object in the list parachute.
        /// </summary>
        public void UpdateParachute()
        {
            parachute.RemoveAt(0);
        }
        /// <summary>
        /// Returns the number of objects left in the list, stores in variable lives.
        /// </summary>
        public int GetLives()
        {
            _lives = parachute.Count();
            return _lives;
        }
        
    }


}
