using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Unit04.Game.Casting;
using Unit04.Game.Directing;
using Unit04.Game.Services;


namespace unit04_greed
{
    /// <summary>
    /// The program's entry point.
    /// </summary>
    class Program
    {
        private static int FRAME_RATE = 12;
        private static int MAX_X = 900;
        private static int MAX_Y = 600;
        private static int CELL_SIZE = 15;
        private static int FONT_SIZE = 15;
        private static int COLS = 60;
        private static int ROWS = 40;
        
        private static Color WHITE = new Color(255, 255, 255);
        private static int DEFAULT_gem = 5;
        private static int DEFAULT_stone = 10;

        private static string CAPTION = "Greed";


        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static void Main(string[] args)
        {
            // create the cast
            Cast cast = new Cast();

            // create scoreboard 
            ScoreBoard scoreboard = new ScoreBoard();
            cast.AddActor("scoreboard", scoreboard);

            // create the player
            Player player = new Player();
            cast.AddActor("player", player);


            // create the gems
            Random random = new Random();
            for (int i = 0; i < DEFAULT_gem; i++)
            {
                SkyDrops skyDrops = new SkyDrops(true);
                cast.AddActor("skyDrops", skyDrops);
            }

             // create the stones
            Random randomTwo = new Random();
            for (int i = 0; i < DEFAULT_stone; i++)
            {
                SkyDrops skyDrops = new SkyDrops(false);
                cast.AddActor("skyDrops", skyDrops);
            }
    
           
            

            // start the game
            KeyboardService keyboardService = new KeyboardService(CELL_SIZE);
            VideoService videoService 
                = new VideoService(CAPTION, MAX_X, MAX_Y, CELL_SIZE, FRAME_RATE, false);
            Director director = new Director(keyboardService, videoService);
            director.StartGame(cast);
        }
    }
}

