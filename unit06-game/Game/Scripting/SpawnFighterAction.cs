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
            // Actor selector = cast.GetActors(Constants.FIGHTER_GROUP);
            //Point P1 = selector.GetPosition(); //keep track of Selector1's position.

            Fighter f = (Fighter)cast.GetFirstActor(Constants.FIGHTER_GROUP);
            // Fighter f2 = (Fighter)cast.GetFirstActor(Constants.FIGHTER_GROUP2);

            if (keyboardService.IsKeyPressed("e"))
            {
                Body body = f.GetBody();
                //spawn a fighter on the left or player 1 side of the field
                f.GetBody();
                //f.SetPosition(); //set fighter's spawning position to be that of corresponding selector
                cast.AddActor(Constants.FIGHTER_GROUP, f);
                
            }

            else if (keyboardService.IsKeyPressed("u"))
            {
                //spawn a fighter on the right or player 2 side of the field
                //Figure this out as soon as Player 1 Fighters work!
            }
        }

    }
}