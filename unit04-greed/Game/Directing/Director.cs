using System.Collections.Generic;
using Unit04.Game.Casting;
using Unit04.Game.Services;
using System;


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
            


            // foreach (Actor actor in cast.GetFirstActor("player"))
            // {
                int maxX = videoService.GetWidth();
                int maxY = videoService.GetHeight();
                player.MoveNext(maxX, maxY , true);

            // }
            
            foreach (SkyDrops drop in skyDrops)
            {
                drop.MoveNext(Constants.MAX_X, Constants.MAX_Y, false);
            }
            
            Random random = new Random();
            int nextSkyDrop = random.Next(1,25);

            /// adding skydrops - gem or stone according to list size.
            if (nextSkyDrop == 5)
            {
                cast.AddActor("skyDrops", new SkyDrops(true));
            }
            else if (nextSkyDrop ==10)
            {
                cast.AddActor("skyDrops", new SkyDrops(false));
            }
            /// collision logic adds 20 for gem, lose 25 for stone
            foreach (SkyDrops drops in skyDrops)
            {
                if (IsCollision(player,drops))
                {
                    Console.WriteLine("hit skydrop");
                    cast.RemoveActor("skyDrops",drops);
                    if (drops.GetDropType() == "gem")
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

        /// <summary>
        /// Checks if a SkyDrop collides with the Player.
        /// </summary>
        /// <param name="first, second">The given cast.</param>
         private bool IsCollision(Actor first, Actor second)
        {
            int size = Constants.CELL_SIZE;
            int x1 = first.GetPosition().GetX(); 
            int y1 = first.GetPosition().GetY();

            int x2 = second.GetPosition().GetX();
            int y2 = second.GetPosition().GetY();

            bool foundCollision = false;

            if (Math.Abs(x1-x2) < size && Math.Abs(y1 - y2) < size)
            {
                return foundCollision = true;
            }
            return foundCollision;
        } 

    }
}