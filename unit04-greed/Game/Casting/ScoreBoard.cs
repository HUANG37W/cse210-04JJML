using System;
namespace Unit04.Game.Casting
{
    public class ScoreBoard : Actor
    {
        private int score = 0;

        /// <summary>
        /// Constructs a new instance of an Artifact.
        /// </summary>
        public ScoreBoard()
        {
        }

        /// <summary>
        /// Gets the artifact's message.
        /// </summary>
        /// <returns>The message.</returns>
        public int GetScore()
        {
            return score;
        }

        /// <summary>
        /// Sets the scoreboard score to the given value.
        /// </summary>
        /// <param name="score">The given message.</param>
        public void SetScore (int score)
        {
            this.score = score;
        }
    }    
}

