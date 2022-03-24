using Unit06.Game.Casting;
namespace Unit06.Game.Scripting
{
    public class MoveFighterAction : Action
    {
        public MoveFighterAction()
        {
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Fighter fighter = (Fighter)cast.GetFirstActor(Constants.FIGHTER_GROUP);
            Body body = fighter.GetBody();
            Point position = body.GetPosition();
            Point velocity = body.GetVelocity();
            position = position.Add(velocity);
            int y = position.GetY();
            int x = position.GetX();
            body.SetPosition(position);

            /// position of selector
            position = position.Add(velocity);
            if (x < 0)
            {
                position = new Point(0,position.GetY());
            }
            else if (x > Constants.SCREEN_WIDTH - Constants.FIGHTER_WIDTH)
            {
                position = new Point(Constants.SCREEN_HEIGHT - Constants.SELECTOR_HEIGHT, 
                    position.GetX());
            }

            body.SetPosition(position);  

        }
        
    }
}