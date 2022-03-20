using System;
using System.Collections.Generic;

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
        // private Point position;
        // private Point size;
        private static Random random = new Random();
        private Body body;
        private Animation animation;
        private int points;

        private Image image;

        //  /// <summary>
        // /// Constructs a new instance of Fighter.
        // /// </summary>
        public Fighter(Body body, Animation animation, bool debug = false) : base(debug) 
        {
            this.body = body;
            this.animation = animation;
            this.points = points;
        }

        

        /// <summary>
        /// Gets the body.
        /// </summary>
        /// <returns>The body.</returns>
        public Body GetBody()
        {
            return body;
        }

        /// <summary>
        /// Gets the image.
        /// </summary>
        /// <returns>The image.</returns>
        public Image GetImage()
        {
            return image;
        }
        /// <summary>
        /// Gets the animation.
        /// </summary>
        /// <returns>The animation.</returns>
        public Animation GetAnimation()
        {
            return animation;
        }
        public int GetPoints()
        {
            return points;
        }

        /// <summary>
        /// Moves the fighter to its next position.
        /// </summary>
        public void MoveNext()
        {
            Point position = body.GetPosition();
            Point velocity = body.GetVelocity();
            Point newPosition = position.Add(velocity);
            body.SetPosition(newPosition);
        }
        /// <summary>
        /// Stops the fighter from moving.
        /// </summary>
        public void StopMoving()
        {
            Point velocity = new Point(0, 0);
            body.SetVelocity(velocity);
        }

        /// <summary>
        /// Gets the position.
        /// </summary>
        /// <returns>The position.</returns>
        // public Point GetPosition()
        // {
        //     return position;
        // }

        // /// <summary>
        // /// Gets the size.
        // /// </summary>
        // /// <returns>The size.</returns>
        // public Point GetSize()
        // {
        //     return size;
        // }
        // public override void MoveNext()
        // {
        //     Actor fighter = new Actor();

        //     Point velocity = fighter.GetVelocity();
        //     Point position = fighter.GetPosition();
        //     fighter.SetPosition(position);
        //     fighter.SetText("o");
        //     fighter.SetColor(GetColor());

        // }

        // private void SpawnFighter(int x, int y)
        // {

        //     Point position = new Point(x, y);
        //     //Point velocity = new Point(1 * Constants.CELL_SIZE, 0);

        //     Actor fighter = new Actor();
        //     //fighter.SetText("o");
        //     fighter.SetPosition(position);
        //     fighter.GetPosition();
            

        // }

        

    }
}