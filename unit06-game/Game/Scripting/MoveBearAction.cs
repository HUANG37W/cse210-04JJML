using Unit06.Game.Casting;
using System.Collections.Generic;
namespace Unit06.Game.Scripting
{
    public class MoveBearAction : Action
    {
        public MoveBearAction()
        {
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            List<Actor> bears = cast.GetActors(Constants.BEAR_GROUP);

            foreach (Bear b in bears)
            {
                b.MoveNext();
            }
        }
        
    }
}