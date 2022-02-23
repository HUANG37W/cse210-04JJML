using System.Collections.Generic;
using Unit04.Game.Casting;
using Unit04.Game.Services;


namespace Unit04.Game.Directing
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
    {
        private KeyboardService keyboardService = null;
        private VideoService videoService = null;

        /// <summary>
        /// Constructs a new instance of Director using the given KeyboardService and VideoService.
        /// </summary>
        /// <param name="keyboardService">The given KeyboardService.</param>
        /// <param name="videoService">The given VideoService.</param>
        public Director(KeyboardService keyboardService, VideoService videoService)
        {
            this.keyboardService = keyboardService;
            this.videoService = videoService;
        }

        /// <summary>
        /// Starts the game by running the main game loop for the given cast.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        public void StartGame(Cast cast)
        {
            videoService.OpenWindow();
            while (videoService.IsWindowOpen() == true)
            {
                GetInputs(cast);
                DoUpdates(cast);
                DoOutputs(cast);
            }
            videoService.CloseWindow();
        }

        /// <summary>
        /// Gets directional input from the keyboard and applies it to the player.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        private void GetInputs(Cast cast)
        {
            Actor Player = cast.GetFirstActor("player");
            Actor Stone = cast.GetFirstActor("stone");
            Actor Gem = cast.GetFirstActor("gem");
            //need to figure out downward velocity for gem and stone.


            //for controlling player
            Point velocity = keyboardService.GetDirection();
            Player.SetVelocity(velocity);

        }

        /// <summary>
        /// Updates the player's position and resolves any collisions with artifacts.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        private void DoUpdates(Cast cast)
        {
            Actor scoreboard = cast.GetFirstActor("scoreboard");
            Actor player = cast.GetFirstActor("player");
            // change artifacts to skydrops
            // List<Actor> artifacts = cast.GetActors("artifacts");

            // was an empty string
            scoreboard.SetText("Your score is");
            scoreboard.SetText("Your score is");
            int maxX = videoService.GetWidth();
            int maxY = videoService.GetHeight();
            player.MoveNext(maxX, maxY);
/// figure out actor in cast.
            
            

            foreach (SkyDrops)
            {
                if (player.GetPosition().Equals(actor.GetPosition()))
                {
                    Skydrops skydrops = (Skydrops) actor;
                        ScoreBoard scoreboard = (ScoreBoard) actor;
                        ScoreBoard.score += 10;
                    string message = artifact.GetMessage();
                    banner.SetText(message);
                }
            } 
        }

        /// <summary>
        /// Draws the actors on the screen.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        public void DoOutputs(Cast cast)
        {
            List<Actor> actors = cast.GetAllActors();
            videoService.ClearBuffer();
            videoService.DrawActors(actors);
            videoService.FlushBuffer();
            
        }

    }
}