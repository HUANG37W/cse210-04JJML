using System;
using System.Collections.Generic;

namespace Unit04.Game.Casting
{
    class Stone : Actor
    {
        public Stone()
        {
            //constructor
        }

        private int randomX = 0;
        
        /// <summary>
        /// Sets a random integer to be used for the column or X position
        /// of the falling object.
        /// </summary>
        public int SetRandColumn()
        {
            Random random = new Random();
            randomX = random.Next(0, 59);
            //picks random column among 60 total to have the stone fall from
            return randomX;
        }
        


        //falling object.
        //looks like a square
        //removes points when caught

    }
}