using System;
using System.Collections.Generic;
using System.Linq;

namespace unit03_jumper
{
    class SkyGuy
    {
        int _lives = 6;
        private Terminal terminal = new Terminal(); 
        /// <summary>
        /// Constructs instance SkyGuy.
        /// </summary>     
        public SkyGuy()
        {
            
        }

        // the body of the skyguy
        private string[] body = new string[2]
        {
            "  /|\\", "  / \\"
        };

        // the parachute of the skyguy
        private List<string> parachute = new List<string>()
        {
             "   ___", "  /   \\ ", "  ____", "  \\  /" , "   \\/ ", "   0"
        };

        /// <summary>
        /// Prints the fixed body of skyguy.
        /// </summary>
        public void PrintGuy()
        {
            foreach (string i in body)
            {
                terminal.WriteText(i);
            }
        }
        /// <summary>
        /// Prints the parachute of skyguy in rows, indexed, and includes the head.
        /// </summary>
        public void PrintParachute()
        {
            foreach (string i in parachute)
            {
                terminal.WriteText(i);
            }
            
        }
        /// <summary>
        /// Removes the first object in the list parachute.
        /// <para>
        /// Subtracts lives if removing part of parachute.
         /// </para>
        /// </summary>
        public void UpdateParachute()
        {
            parachute.RemoveAt(0);
            _lives --;
            if (IsDead())
            {
                parachute[parachute.Count - 1] = "x";
            }
        }
        ///<summary>
        ///Changes head from 0 to x if lives at 0
        ///</summary>
        public bool IsDead()
        {
            return _lives <= 0;
        }
        
    }


}
