namespace Unit06.Game.Casting
{
    /// <summary>
    /// A thing that participates in the game.
    /// </summary>
    public class Selector : Actor
    {
        private Body body;
        private Animation animation;
        
        /// <summary>
        /// Constructs a new instance of Actor.
        /// </summary>
        public Selector(Body body, Animation animation, bool debug) : base(debug)
        {
            this.body = body;
            this.animation = animation;
        }

        /// <summary>
        /// Gets the animation.
        /// </summary>
        /// <returns>The animation.</returns>
        public Animation GetAnimation()
        {
            return animation;
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
        /// Moves the Selector to its next position.
        /// </summary>
        public void MoveNext()
        {
            Point position = body.GetPosition();
            Point velocity = body.GetVelocity();
            Point newPosition = position.Add(velocity);
            body.SetPosition(newPosition);
        }

        /// <summary>
        /// Swings the Selector to the left.
        /// </summary>
        public void SwingLeft()
        {
            Point velocity = new Point(-Constants.SELECTOR_VELOCITY, 0);
            body.SetVelocity(velocity);
        }

        /// <summary>
        /// Swings the Selector to the right.
        /// </summary>
        public void SwingRight()
        {
            Point velocity = new Point(Constants.SELECTOR_VELOCITY, 0);
            body.SetVelocity(velocity);
        }

        /// <summary>
        /// Stops the Selector from moving.
        /// </summary>
        public void StopMoving()
        {
            Point velocity = new Point(0, 0);
            body.SetVelocity(velocity);
        }
        
    }
}


