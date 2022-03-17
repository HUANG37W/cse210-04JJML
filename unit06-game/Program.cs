using System;
using Unit06.Game.Casting;
using Unit06.Game.Directing;
using Unit06.Game.Scripting;
using Unit06.Game.Services;

namespace unit06_game
{
    class Program
    {
        static void Main(string[] args)
        {

            // creates the cast
            Cast cast = new Cast();

             // creates the services
            KeyboardService keyboardService = new KeyboardService();
            VideoService videoService = new VideoService(false);
           
            // creates the script
            Script script = new Script();

            // creates the director
            Director director = new Director(videoService);
            director.StartGame(cast, script);
        }
    }
}
