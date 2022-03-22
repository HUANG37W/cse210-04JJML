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
            Fighter fighter = (Fighter)cast.GetFirstActor(Constants.FIGHTER_GROUP);

            if (keyboardService.IsKeyPressed("e"))
            {
                //spawn a fighter on the left or player 1 side of the field
            }

            else if (keyboardService.IsKeyPressed("u"))
            {
                //spawn a fighter on the right or player 2 side of the field
            }
        }

    }
}