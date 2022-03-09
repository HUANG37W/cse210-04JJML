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
            Cycler cycler = new Cycler(100,Constants.MAX_Y/4, Constants.RED);
            Cycler cycler2 = new Cycler(100,Constants.MAX_Y*3/4, Constants.GREEN);
            //cycler.SetColor(Constants.RED);
            //cycler2.SetColor(Constants.GREEN);
            
            //int x = Constants.MIN_X + 100;
            //int y = Constants.MAX_Y - 100;

            // Point position = new Point(x, y);

            // Point position2 = new Point(300,500);
            // cycler.SetPosition(position);
            // cycler2.SetPosition(position2);

            Score score = new Score();
            Score score2 = new Score();
            score.SetColor(Constants.RED);
            score.SetText("Player 1");

            score2.SetColor(Constants.GREEN);
            score2.SetText("Player 2");

            Point position = new Point(100,100);
            Point position2 = new Point(300,500);
            Point screpos = new Point(20,20);
            Point screpos2 = new Point(800,20);
            cycler.SetPosition(position);
            cycler2.SetPosition(position2);
            score.SetPosition(screpos);
            score2.SetPosition(screpos2);
           
            cast.AddActor("cycler", cycler);
            cast.AddActor("cycler2", cycler2);
            cast.AddActor("score", score);
            cast.AddActor("score2", score2);

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
