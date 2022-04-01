using Unit06.Game.Casting;
using Unit06.Game.Services;
using System.Collections.Generic;

namespace Unit06.Game.Scripting
{
    public class SpawnFighterAction : Action
    {
        private KeyboardService keyboardService;
        private AudioService audioService;
        private List<string> swordfighters = new List<string>();
        private List<string> bowfighters = new List<string>();
        private List<string> bears = new List<string>();
        


        public SpawnFighterAction(KeyboardService keyboardService, AudioService audioService)
        {
            this.keyboardService = keyboardService;
            this.audioService = audioService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Selector selector1 = (Selector)cast.GetFirstActor(Constants.SELECTOR_GROUP);
            Point sp1 = new Point(50, selector1.GetBody().GetPosition().GetY());

            Selector selector2 = (Selector)cast.GetActors(Constants.SELECTOR_GROUP)[1];
            Point sp2 = new Point(Constants.SCREEN_WIDTH - 120, selector2.GetBody().GetPosition().GetY());
             //keep track of Selector positions.
            
            

            if (keyboardService.IsKeyPressed("e"))
            {
                //sets the pixel size and velocity values
                Point size = new Point(Constants.SWORD_FIGHTER_WIDTH, Constants.SWORD_FIGHTER_HEIGHT);
                Point velocity = new Point(Constants.SWORD_FIGHTER_VELOCITY, 0);


                //sets the point sp1, size, and velocity to the fighter
                Body fighterBody = new Body(sp1, size, velocity);
                Animation animation = new Animation(Constants.SWORD_FIGHTER_IMAGES, 0, Constants.FIGHTER_RATE);
                Fighter f = new Fighter(fighterBody, animation);
                Body body = f.GetBody();
                cast.AddActor(Constants.FIGHTER_GROUP, f); 
                //adds fighter f to the cast
                // swordfighters.Add("f");
                // if (swordfighters.Count > 5)
                // {

                // }

                // Make the sound
                
                
            }

            else if (keyboardService.IsKeyPressed("u"))
            {
                //sets the pixel size and velocity values to size and velocity
                Point size = new Point(Constants.SWORD_FIGHTER_WIDTH, Constants.SWORD_FIGHTER_HEIGHT);
                Point velocity = new Point(Constants.FIGHTER2_VELOCITY, 0);

                //sets the point sp2, size, and velocity to the player2 fighter
                Body fighterBody = new Body(sp2, size, velocity);
                Animation animation = new Animation(Constants.SWORD_FIGHTER2_IMAGES, 0, Constants.FIGHTER_RATE);
                Fighter f = new Fighter(fighterBody, animation);
                Body body = f.GetBody();
                cast.AddActor(Constants.FIGHTER_GROUP, f); //adds fighter f to the cast
                // Make the sound
            }

            else if (keyboardService.IsKeyPressed("q"))
            {
                //sets the pixel size and velocity values
                Point size = new Point(Constants.BEAR_WIDTH, Constants.BEAR_HEIGHT);
                Point velocity = new Point(Constants.BEAR_VELOCITY, 0);


                //sets the point b1, size, and velocity to the bear
                Body bearBody = new Body(sp1, size, velocity);
                Animation animation = new Animation(Constants.BLACK_BEAR_IMAGES, 0, Constants.FIGHTER_RATE);
                Bear b = new Bear(bearBody, animation);
                Body body = b.GetBody();
                cast.AddActor(Constants.FIGHTER_GROUP, b); //adds bear b to the cast
                // Make the sound
            }

            else if (keyboardService.IsKeyPressed("o"))
            {
                //sets the pixel size and velocity values to size and velocity
                Point size = new Point(Constants.BEAR_WIDTH, Constants.BEAR_HEIGHT);
                Point velocity = new Point(Constants.BEAR2_VELOCITY, 0);

                //sets the point b2, size, and velocity to the player2 bear
                Body bearBody = new Body(sp2, size, velocity);
                Animation animation = new Animation(Constants.BROWN_BEAR_IMAGES, 0, Constants.FIGHTER_RATE);
                Bear b = new Bear(bearBody, animation);
                Body body = b.GetBody();
                cast.AddActor(Constants.FIGHTER_GROUP, b); //adds bear b to the cast
                // Make the sound
            }

            else if (keyboardService.IsKeyPressed("c"))
            {
                //sets the pixel size and velocity values
                Point size = new Point(Constants.BOW_FIGHTER_WIDTH, Constants.BOW_FIGHTER_HEIGHT);
                Point velocity = new Point(Constants.BOW_FIGHTER_VELOCITY, 0);


                //sets the point sp1, size, and velocity to the fighter
                Body BowFighterBody = new Body(sp1, size, velocity);
                Animation animation = new Animation(Constants.BOW_FIGHTER_IMAGES, 0, Constants.FIGHTER_RATE);
                BowFighter bf = new BowFighter(BowFighterBody, animation);
                Body body = bf.GetBody();
                cast.AddActor(Constants.FIGHTER_GROUP, bf); //adds bowfighter f to the cast
                // Make the sound
            }

            else if (keyboardService.IsKeyPressed("n"))
            {
                //sets the pixel size and velocity values to size and velocity
                Point size = new Point(Constants.BOW_FIGHTER_WIDTH, Constants.BOW_FIGHTER_HEIGHT);
                Point velocity = new Point(Constants.BOW_FIGHTER2_VELOCITY, 0);

                //sets the point sp2, size, and velocity to the player2 fighter
                Body BowFighterBody = new Body(sp2, size, velocity);
                Animation animation = new Animation(Constants.BOW_FIGHTER2_IMAGES, 0, Constants.FIGHTER_RATE);
                BowFighter bf = new BowFighter(BowFighterBody, animation);
                Body body = bf.GetBody();
                cast.AddActor(Constants.FIGHTER_GROUP, bf); //adds fighter f to the cast
                // Make the sound
            }
        }

    }
}