using Unit06.Game.Casting;
using Unit06.Game.Services;

namespace Unit06.Game.Scripting
{
    public class SpawnFighterAction : Action
    {
        private KeyboardService keyboardService;

        public SpawnFighterAction(KeyboardService keyboardService)
        {
            this.keyboardService = keyboardService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Selector selector1 = (Selector)cast.GetFirstActor(Constants.SELECTOR_GROUP);
            Point sp1 = new Point(50, selector1.GetBody().GetPosition().GetY());

            Selector selector2 = (Selector)cast.GetActors(Constants.SELECTOR_GROUP)[1];
            Point sp2 = new Point(Constants.SCREEN_WIDTH - 50, selector2.GetBody().GetPosition().GetY());
             //keep track of Selector positions.
            
            

            if (keyboardService.IsKeyPressed("e"))
            {
                //sets the pixel size and velocity values
                Point size = new Point(Constants.SWORD_FIGHTER_WIDTH, Constants.SWORD_FIGHTER_HEIGHT);
                Point velocity = new Point(Constants.SWORD_FIGHTER_VELOCITY, 0);


                //sets the point sp1, size, and velocity to the fighter
                Body fighterBody = new Body(sp1, size, velocity);
                Animation animation = new Animation(Constants.SWORD_FIGHTER_IMAGES, 0, Constants.SELECTOR_RATE);
                Fighter f = new Fighter(fighterBody, animation);
                Body body = f.GetBody();
                cast.AddActor(Constants.FIGHTER_GROUP, f); //adds fighter f to the cast
            }

            else if (keyboardService.IsKeyPressed("u"))
            {
                //sets the pixel size and velocity values to size and velocity
                Point size = new Point(Constants.SWORD_FIGHTER_WIDTH, Constants.SWORD_FIGHTER_HEIGHT);
                Point velocity = new Point(Constants.FIGHTER2_VELOCITY, 0);

                //sets the point sp2, size, and velocity to the player2 fighter
                Body fighterBody = new Body(sp2, size, velocity);
                Animation animation = new Animation(Constants.SWORD_FIGHTER2_IMAGES, 0, Constants.SELECTOR_RATE);
                Fighter f = new Fighter(fighterBody, animation);
                Body body = f.GetBody();
                cast.AddActor(Constants.FIGHTER_GROUP, f); //adds fighter f to the cast
            }
        }

    }
}