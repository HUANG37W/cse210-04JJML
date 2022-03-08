using Unit05.Game.Casting;
using Unit05.Game.Directing;
using Unit05.Game.Scripting;
using Unit05.Game.Services;
using Unit05.Game;


namespace Unit05
{
    /// <summary>
    /// The program's entry point.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static void Main(string[] args)
        {   
            // create the cast
            Cast cast = new Cast();
            Cycler cycler = new Cycler();
            Cycler cycler2 = new Cycler();
            cycler.SetColor(Constants.RED);
            cycler2.SetColor(Constants.GREEN);
            
            int x = Constants.MIN_X + 100;
            int y = Constants.MAX_Y - 100 ;

            Point position = new Point(x, y);

            Point position2 = new Point(300,500);
            cycler.SetPosition(position);
            cycler2.SetPosition(position2);
           ;
            cast.AddActor("cycler", cycler);
            cast.AddActor("cycler2", cycler2);
            cast.AddActor("score", new Score());
            cast.AddActor("score2", new Score());

            // create the services
            KeyboardService keyboardService = new KeyboardService();
            VideoService videoService = new VideoService(false);
           
            // create the script
            Script script = new Script();
            script.AddAction("input", new ControlActorsAction(keyboardService));
            script.AddAction("update", new MoveActorsAction());
            script.AddAction("update", new HandleCollisionsAction());
            script.AddAction("output", new DrawActorsAction(videoService));

            // start the game
            Director director = new Director(videoService);
            director.StartGame(cast, script);
        }
    }
}
