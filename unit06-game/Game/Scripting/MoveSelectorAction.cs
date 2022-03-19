using Unit06.Game.Casting;

namespace Unit06.Game.Scripting
{
    public class MoveSelectorAction : Action
    {
        public MoveSelectorAction()
        {
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Selector selector = (Selector)cast.GetFirstActor(Constants.SELECTOR_GROUP);
            Body body = selector.GetBody();
            Point position = body.GetPosition();
            Point velocity = body.GetVelocity();
            int x = position.GetX();

            position = position.Add(velocity);
            if (x < 0)
            {
                position = new Point(0, position.GetY());
            }
            else if (x > Constants.SCREEN_WIDTH - Constants.SELECTOR_WIDTH)
            {
                position = new Point(Constants.SCREEN_WIDTH - Constants.SELECTOR_WIDTH, 
                    position.GetY());
            }

            body.SetPosition(position);       
        }
    }
}