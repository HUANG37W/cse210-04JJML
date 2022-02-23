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

            // create the scoreboard
            Actor scoreboard = new Actor();
            scoreboard.SetText("");
            scoreboard.SetFontSize(FONT_SIZE);
            scoreboard.SetColor(WHITE);
            scoreboard.SetPosition(new Point(CELL_SIZE, 0));
            cast.AddActor("scoreboard", scoreboard);

            // create the player
            Actor player = new Actor();
            player.SetText("#");
            player.SetFontSize(FONT_SIZE);
            player.SetColor(WHITE);
            player.SetPosition(new Point(450, 550));
            cast.AddActor("player", player);

            
            

            // create the artifacts
            Random random = new Random();
            for (int i = 0; i < DEFAULT_gem; i++)
            {
                string gem = ((char)random.Next(42,42)).ToString();
                // string message = messages[i];

                int x = random.Next(1, COLS);
                int y = random.Next(1, ROWS);
                Point position = new Point(x, 0);
                position = position.Scale(CELL_SIZE);

                int r = random.Next(0, 256);
                int g = random.Next(0, 256);
                int b = random.Next(0, 256);
                Color color = new Color(r, g, b);

                SkyStones skyStones = new SkyStones();
                skyStones.SetText(gem);
                skyStones.SetFontSize(FONT_SIZE);
                skyStones.SetColor(color);
                skyStones.SetPosition(position);
                // skyStones.SetMessage(message);
                cast.AddActor("skystone", skyStones);
            }

             // create the artifacts
            Random randomTwo = new Random();
            for (int i = 0; i < DEFAULT_stone; i++)
            {
                string stone = ((char)randomTwo.Next(79,79)).ToString();
                // string message = messages[i];

                int x = randomTwo.Next(1, COLS);
                int y = randomTwo.Next(1, ROWS);
                Point position = new Point(x, 0);
                position = position.Scale(CELL_SIZE);

                int r = randomTwo.Next(0, 256);
                int g = randomTwo.Next(0, 256);
                int b = randomTwo.Next(0, 256);
                Color color = new Color(r, g, b);

                SkyStones skyStones = new SkyStones();
                skyStones.SetText(stone);
                skyStones.SetFontSize(FONT_SIZE);
                skyStones.SetColor(color);
                skyStones.SetPosition(position);
                // skyStones.SetMessage(message);
                cast.AddActor("skystone", skyStones);
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

