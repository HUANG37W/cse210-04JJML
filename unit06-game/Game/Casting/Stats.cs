namespace Unit06.Game.Casting
{
    /// <summary>
    /// A thing that participates in the game.
    /// </summary>
    public class Stats : Actor
    {
        private int lives1;
        private int lives2;

        /// <summary>
        /// Constructs a new instance of Actor.
        /// </summary>
        public Stats(int lives1 = 5, int lives2 = 5, 
                bool debug = false) : base(debug)
        {
            this.lives1 = lives1;
            this.lives2 = lives2;
        }

        /// <summary>
        /// Adds one level.
        /// </summary>
        public void AddTeam1Lives()
        {
            lives1++;
        }

        /// <summary>
        /// Adds an extra life.
        /// </summary>
        public void AddTeam2Lives()
        {
            lives2++;
        }

        /// <summary>
        /// Gets the level.
        /// </summary>
        /// <returns>The level.</returns>
        public int GetTeam1Lives()
        {
            return lives1;
        }

        /// <summary>
        /// Gets the lives.
        /// </summary>
        /// <returns>The lives.</returns>
        public int GetTeam2Lives()
        {
            return lives2;
        }

        /// <summary>
        /// Removes a life from team 1.
        /// </summary>
        public void RemoveTeam1Life()
        {
            lives1--;
            if (lives1 <= 0)
            {
                lives1 = 0;
            }
        }

        /// <summary>
        /// Removes a life from team 2.
        /// </summary>
        public void RemoveTeam2Life()
        {
            lives2--;
            if (lives2 <= 0)
            {
                lives2 = 0;
            }
        }
        
    }
}