using Unit06.Game.Casting;
using Unit06.Game.Services;
using System.Collections.Generic;


namespace Unit06.Game.Scripting
{
    ///Heads up display
    public class DrawSceneAction : Action
    {
        private VideoService videoService;
        
        public DrawSceneAction(VideoService videoService)
        {
            this.videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {

            // videoService.DrawImage(Constants.SCENE_GROUP, Constants.SCREEN_WIDTH);
            
        }

    }
}

