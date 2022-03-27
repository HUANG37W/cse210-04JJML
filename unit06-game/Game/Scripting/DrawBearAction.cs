using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class DrawBearAction : Action
    {
        private VideoService videoService;
        
        public DrawBearAction(VideoService videoService)
        {
            this.videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            
            foreach (Bear bear in cast.GetActors(Constants.BEAR_GROUP))
            {
                Body body = bear.GetBody();

                if (bear.IsDebug())
                {
                    Rectangle rectangle = body.GetRectangle();
                    Point size = rectangle.GetSize();
                    Point pos = rectangle.GetPosition();
                    videoService.DrawRectangle(size, pos, Constants.PURPLE, false);
                }
                else
                {
                    Animation animation = bear.GetAnimation();
                    Image image = animation.NextImage();
                    Point position = body.GetPosition();
                    videoService.DrawImage(image, position);
                }
            }

        }
    }
}