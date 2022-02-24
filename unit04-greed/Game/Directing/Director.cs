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
        private int maxX;
        private int maxY;
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
            //Actor Stone = cast.GetFirstActor("stone");
            //Actor Gem = cast.GetFirstActor("gem");
            //need to figure out downward velocity for gem and stone.
            //for controlling player
            Point velocity = keyboardService.GetDirection();
            Player.SetVelocity(velocity);

        }

        /// <summary>
        /// Updates the player's position and resolves any collisions with skydrops.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        private void DoUpdates(Cast cast)
        {
            ScoreBoard scoreboard = (ScoreBoard)cast.GetFirstActor("scoreboard");
            Actor player = cast.GetFirstActor("player");
            List<Actor> skyDrops = cast.GetActors("skyDrops");


            // foreach (Actor actor in cast.GetAllActors())
            // (
            //     int maxX = videoService.GetWidth();
            //     int maxY = videoService.GetHeight();
            //     actor.MoveNext(maxX, maxY);

            // }
            
            foreach (SkyDrops drop in skyDrops)
            {
                if (player.GetPosition().Equals(drop.GetPosition()))
                {
                    if (drop.GetDropType() == "gem")
                    {
                        scoreboard.UpdateScore(20);
                    }
                    else
                    {
                        scoreboard.UpdateScore(-25);
                    }

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