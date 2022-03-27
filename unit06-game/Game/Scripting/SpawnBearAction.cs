using Unit06.Game.Casting;
using Unit06.Game.Services;

namespace Unit06.Game.Scripting
{
    public class SpawnBearAction : Action
    {
        private KeyboardService keyboardService;

        public SpawnBearAction(KeyboardService keyboardService)
        {
            this.keyboardService = keyboardService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Selector selector1 = (Selector)cast.GetFirstActor(Constants.SELECTOR_GROUP);
            Point b1 = new Point(50, selector1.GetBody().GetPosition().GetY());

            Selector selector2 = (Selector)cast.GetActors(Constants.SELECTOR_GROUP)[1];
            Point b2 = new Point(Constants.SCREEN_WIDTH - 50, selector2.GetBody().GetPosition().GetY());
             //keep track of Selector positions.
            
            

            if (keyboardService.IsKeyPressed("q"))
            {
                //sets the pixel size and velocity values
                Point size = new Point(Constants.BEAR_WIDTH, Constants.BEAR_HEIGHT);
                Point velocity = new Point(Constants.BEAR_VELOCITY, 0);


                //sets the point b1, size, and velocity to the bear
                Body bearBody = new Body(b1, size, velocity);
                Animation animation = new Animation(Constants.BLACK_BEAR_IMAGES, 0, Constants.BEAR_RATE);
                Bear b = new Bear(bearBody, animation);
                Body body = b.GetBody();
                cast.AddActor(Constants.BEAR_GROUP, b); //adds bear b to the cast
            }

            else if (keyboardService.IsKeyPressed("o"))
            {
                //sets the pixel size and velocity values to size and velocity
                Point size = new Point(Constants.BEAR_WIDTH, Constants.BEAR_HEIGHT);
                Point velocity = new Point(Constants.BEAR_VELOCITY, 0);

                //sets the point b2, size, and velocity to the player2 bear
                Body bearBody = new Body(b2, size, velocity);
                Animation animation = new Animation(Constants.BROWN_BEAR_IMAGES, 0, Constants.SELECTOR_RATE);
                Bear b = new Bear(bearBody, animation);
                Body body = b.GetBody();
                cast.AddActor(Constants.BEAR_GROUP, b); //adds bear b to the cast
            }
        }

    }
}