// using Unit06.Game.Casting;
// using System.Collections.Generic;
// namespace Unit06.Game.Scripting
// {
//     public class MoveBowFighterAction : Action
//     {
//         public MoveBowFighterAction()
//         {
//         }

//         public void Execute(Cast cast, Script script, ActionCallback callback)
//         {
//             List<Actor> bowfighters = cast.GetActors(Constants.BOW_FIGHTER_GROUP);

//             foreach (BowFighter bf in bowfighters)
//             {
//                 bf.MoveNext();
//             }
//         }
        
//     }
// }