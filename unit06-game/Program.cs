using System;
using Unit06.Game.Casting;
using Unit06.Game.Directing;
using Unit06.Game.Scripting;
using Unit06.Game.Services;
using Unit06.Game;

namespace Unit06
{
    class Program
    {
        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>

        static void Main(string[] args)
        {

            // creates the cast
            Cast cast = new Cast();
            
            // creates a test fighter on the screen
            Fighter fighter = new Fighter(100, Constants.WHITE);

             // creates the services
            KeyboardService keyboardService = new KeyboardService();
            VideoService videoService = new VideoService(false);
           
            // creates the script
            Script script = new Script();
            script.AddAction("update", new ControlActorsAction(keyboardService));
            //script.AddAction("update", new HandleCollision());
            script.AddAction("output", new DrawActorsAction(videoService));

            // creates the director
            Director director = new Director(videoService);
            director.StartGame(cast, script);
        }
    }
}
