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
            body.SetPosition(position);
        }
    }
}