using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class DrawHudAction : Action
    {
        private VideoService videoService;
        
        public DrawHudAction(VideoService videoService)
        {
            this.videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Stats stats = (Stats)cast.GetFirstActor(Constants.STATS_GROUP);
            DrawLabel(cast, Constants.LIVES1_GROUP, Constants.LIVES1_FORMAT, stats.GetTeam1Lives());
            DrawLabel(cast, Constants.LIVES2_GROUP, Constants.LIVES2_FORMAT, stats.GetTeam2Lives());
            //DrawLabel(cast, Constants.SCORE_GROUP, Constants.SCORE_FORMAT, stats.GetScore());
        }

        // **********************************************************************************************
        // You found the bug. Great job!
        // **********************************************************************************************
        // todo: fix the bug by making sure the text value is set to the appropriate variable.
        private void DrawLabel(Cast cast, string group, string format, int data)
        {
            string theValueToDisplay = string.Format(format, data);
            Label label = (Label)cast.GetFirstActor(group);
            Text text = label.GetText();
            text.SetValue(string.Format(format, data)); //add data as a parameter somehow?
            Point position = label.GetPosition();
            videoService.DrawText(text, position);
            
        }
    }
}