using System.Collections.Generic;
using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    /// <summary>
    /// <para>An output action that draws all the actors.</para>
    /// <para>The responsibility of DrawActorsAction is to draw each of the actors.</para>
    /// </summary>
    public class DrawActorsAction : Action
    {
        private VideoService videoService;

        /// <summary>
        /// Constructs a new instance of ControlActorsAction using the given KeyboardService.
        /// </summary>
        public DrawActorsAction(VideoService videoService)
        {
            this.videoService = videoService;
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {

            Fighter fighter = (Fighter)cast.GetFirstActor("Fighter");
            

            videoService.ClearBuffer();

            videoService.DrawActor(fighter);
            
            videoService.FlushBuffer();



            // ADD FIGHTER AND OTHER ACTORS TO CAST AND DRAW THEM HERE

            // Snake snake = (Snake)cast.GetFirstActor("snake");
            // List<Actor> segments = snake.GetSegments();
            // Actor score = cast.GetFirstActor("score");
            // Actor food = cast.GetFirstActor("food");
            // List<Actor> messages = cast.GetActors("messages");
            
            
        }
    }
}