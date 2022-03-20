using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class ControlSelectorAction : Action
    {
        private KeyboardService keyboardService;

        public ControlSelectorAction(KeyboardService keyboardService)
        {
            this.keyboardService = keyboardService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Selector selector = (Selector)cast.GetFirstActor(Constants.SELECTOR_GROUP);
            if (keyboardService.IsKeyDown(Constants.UP))
            {
                //move the selector up one row
            }
            else if (keyboardService.IsKeyDown(Constants.DOWN))
            {
                //move the selector down one row
            }
            else
            {
                selector.StopMoving();
            }
        }
    }
}