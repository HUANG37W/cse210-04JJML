using Unit06.Game.Casting;
using Unit06.Game.Services;
using System.Collections.Generic;

namespace Unit06.Game.Scripting
{
    public class SpawnFighterAction : Action
    {
        private KeyboardService keyboardService;
        private AudioService audioService;
    
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
                SwordFighter swf = new SwordFighter(sp1, 1, false);
                cast.AddActor(Constants.FIGHTER_GROUP, swf);
                //adds fighter f to the cast
                // swordfighters.Add("f");
                // if (swordfighters.Count > 5)
                // {

                // }

                // Make the sound
                
                
            }

            else if (keyboardService.IsKeyPressed("u"))
            {
                SwordFighter swf = new SwordFighter(sp2, 2, false);
                cast.AddActor(Constants.FIGHTER_GROUP, swf); //adds swordfighter swf to the cast
            }

            else if (keyboardService.IsKeyPressed("q"))
            {
                Bear b = new Bear(sp1, 1, false);
                cast.AddActor(Constants.FIGHTER_GROUP, b); //adds bear b to the cast
                // Make the sound
            }

            else if (keyboardService.IsKeyPressed("o"))
            {
                Bear b = new Bear(sp2, 2, false);
                cast.AddActor(Constants.FIGHTER_GROUP, b); //adds bear b to the cast
                // Make the sound
            }

            else if (keyboardService.IsKeyPressed("c"))
            {
                BowFighter bwf = new BowFighter(sp1, 1, false);
                cast.AddActor(Constants.FIGHTER_GROUP, bwf); //adds bowfighter swf to the cast
            }

            else if (keyboardService.IsKeyPressed("n"))
            {
                BowFighter bwf = new BowFighter(sp2, 2, false);
                cast.AddActor(Constants.FIGHTER_GROUP, bwf); //adds swordfighter swf to the cast
                
            }
        }

    }
}