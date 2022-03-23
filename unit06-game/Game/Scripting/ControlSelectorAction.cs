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

        // public void Execute(Cast cast, Script script, ActionCallback callback)
        // {

        //     // foreach (Selector selector in cast.GetActors(Constants.SELECTOR_GROUP))
        //     // {
                
        //     // }
        //     Selector selector = (Selector)cast.GetFirstActor(Constants.SELECTOR_GROUP);
        //     //Selector selector2 = (Selector)cast.GetFirstActor(Constants.SELECTOR_GROUP);
        //     if (keyboardService.IsKeyDown(Constants.P1UP))
        //     {
        //         selector.MoveUp();
        //     }
        //     else if (keyboardService.IsKeyDown(Constants.P1DOWN))
        //     {
        //         selector.MoveDown();
        //     }
        //     else
        //     {
        //         selector.StopMoving();
        //     }
            
            
            // if (keyboardService.IsKeyDown(Constants.P2UP))
            // {
            //     selector2.MoveUp();
            // }
            // else if (keyboardService.IsKeyDown(Constants.P2DOWN))
            // {
            //     selector2.MoveDown();
            // }
            // else
            // {
            //     selector2.StopMoving();
            // }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {

            // foreach (Selector selector in cast.GetActors(Constants.SELECTOR_GROUP))
            // {
                
            // }
            Selector selector = (Selector)cast.GetFirstActor(Constants.SELECTOR_GROUP);
            //Selector selector2 = (Selector)cast.GetFirstActor(Constants.SELECTOR_GROUP);
            if (keyboardService.IsKeyDown(Constants.P1UP))
            {
                selector.MoveUp();
            }
             else if (keyboardService.IsKeyDown(Constants.P1DOWN))
            {
                selector.MoveDown();
            }
            else
            {
                selector.StopMoving();  
            }      
        }
    }
}