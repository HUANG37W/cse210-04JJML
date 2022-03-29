// using Unit06.Game.Casting;
// using Unit06.Game.Services;


// namespace Unit06.Game.Scripting
// {
//     public class DrawBowFighterAction : Action
//     {
//         private VideoService videoService;
        
//         public DrawBowFighterAction(VideoService videoService)
//         {
//             this.videoService = videoService;
//         }

//         public void Execute(Cast cast, Script script, ActionCallback callback)
//         {
            
//             foreach (BowFighter bow in cast.GetActors(Constants.BOW_FIGHTER_GROUP))
//             {
//                 Body body = bow.GetBody();

//                 if (bow.IsDebug())
//                 {
//                     Rectangle rectangle = body.GetRectangle();
//                     Point size = rectangle.GetSize();
//                     Point pos = rectangle.GetPosition();
//                     videoService.DrawRectangle(size, pos, Constants.PURPLE, false);
//                 }
//                 else
//                 {
//                     Animation animation = bow.GetAnimation();
//                     Image image = animation.NextImage();
//                     Point position = body.GetPosition();
//                     videoService.DrawImage(image, position);
//                 }
//             }

//         }
//     }
// }