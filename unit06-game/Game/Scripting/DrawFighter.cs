using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class DrawBallAction : Action
    {
        private VideoService videoService;
        
        public DrawBallAction(VideoService videoService)
        {
            this.videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Fighter fighter = (Fighter)cast.GetFirstActor(Constants.BALL_GROUP);
            Body body = fighter.GetBody();

            // if (fighter.IsDebug())
            // {
            //     Rectangle rectangle = body.GetRectangle();
            //     Point size = rectangle.GetSize();
            //     Point pos = rectangle.GetPosition();
            //     videoService.DrawRectangle(size, pos, Constants.PURPLE, false);
            // }

            Image image = fighter.GetImage();
            Point position = body.GetPosition();
            videoService.DrawImage(image, position);
        }
    }
}