using Unit06.Game.Casting;
using Unit06.Game.Services;

namespace Unit06.Game.Scripting
{
    public class SpawnBowFighterAction : Action
    {
        private KeyboardService keyboardService;

        public SpawnBowFighterAction(KeyboardService keyboardService)
        {
            this.keyboardService = keyboardService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Selector selector1 = (Selector)cast.GetFirstActor(Constants.SELECTOR_GROUP);
            Point sp1 = new Point(50, selector1.GetBody().GetPosition().GetY());

            Selector selector2 = (Selector)cast.GetActors(Constants.SELECTOR_GROUP)[1];
            Point sp2 = new Point(Constants.SCREEN_WIDTH- 120, selector2.GetBody().GetPosition().GetY());
             //keep track of Selector positions.
            
            

            if (keyboardService.IsKeyPressed("c"))
            {
                //sets the pixel size and velocity values
                Point size = new Point(Constants.BOW_FIGHTER_WIDTH, Constants.BOW_FIGHTER_HEIGHT);
                Point velocity = new Point(Constants.BOW_FIGHTER_VELOCITY, 0);


                //sets the point sp1, size, and velocity to the fighter
                Body BowFighterBody = new Body(sp1, size, velocity);
                Animation animation = new Animation(Constants.BOW_FIGHTER_IMAGES, 0, Constants.BOW_FIGHTER_RATE);
                BowFighter bf = new BowFighter(BowFighterBody, animation);
                Body body = bf.GetBody();
                cast.AddActor(Constants.BOW_FIGHTER_GROUP, bf); //adds bowfighter f to the cast
            }

            else if (keyboardService.IsKeyPressed("n"))
            {
                //sets the pixel size and velocity values to size and velocity
                Point size = new Point(Constants.BOW_FIGHTER_WIDTH, Constants.BOW_FIGHTER_HEIGHT);
                Point velocity = new Point(Constants.BOW_FIGHTER2_VELOCITY, 0);

                //sets the point sp2, size, and velocity to the player2 fighter
                Body BowFighterBody = new Body(sp2, size, velocity);
                Animation animation = new Animation(Constants.BOW_FIGHTER2_IMAGES, 0, Constants.BOW_FIGHTER_RATE);
                BowFighter bf = new BowFighter(BowFighterBody, animation);
                Body body = bf.GetBody();
                cast.AddActor(Constants.BOW_FIGHTER_GROUP, bf); //adds fighter f to the cast
            }
        }

    }
}