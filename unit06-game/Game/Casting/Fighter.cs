using System;

namespace Unit06.Game.Casting
{
    /// <summary>
    /// <para>A thing that participates in the game.</para>
    /// <para>
    /// The responsibility of Actor is to keep track of its appearance, position and velocity in 2d 
    /// space.
    /// </para>
    /// </summary>
    public class Fighter : Actor
    {
        private Point position = new Point(0,0);

        public Fighter(int y, Color color)
        {
            //constructor
        }

        public override void MoveNext()
        {
            Actor fighter = new Actor();

            Point velocity = fighter.GetVelocity();
            Point position = fighter.GetPosition();


        }

    }
}