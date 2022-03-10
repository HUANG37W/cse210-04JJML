using System;
using System.Collections.Generic;
using System.Data;
using Unit05.Game.Casting;
using Unit05.Game.Services;


namespace Unit05.Game.Scripting
{
    /// <summary>
    /// <para>An update action that handles interactions between the actors.</para>
    /// <para>
    /// The responsibility of HandleCollisionsAction is to handle the situation when the Cycler 
    /// collides with the food, or the Cycler collides with its segments, or the game is over.
    /// </para>
    /// </summary>
    public class HandleCollisionsAction : Action
    {
        private bool isGameOver = false;
         private bool isGameOver2 = false;

        /// <summary>
        /// Constructs a new instance of HandleCollisionsAction.
        /// </summary>
        public HandleCollisionsAction()
        {
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            if (isGameOver == false && isGameOver2 == false)
            {
                HandleSegmentCollisions(cast);
                HandleGameOver(cast);
            }
        }

        /// <summary>
        /// Sets the game over flag if the Cycler collides with one of its segments.
        /// </summary>
        /// <param name="cast">The cast of actors.</param>
        private void HandleSegmentCollisions(Cast cast)
        {
            Cycler cycler = (Cycler)cast.GetFirstActor("cycler");
            Cycler cycler2 = (Cycler)cast.GetFirstActor("cycler2");
            Actor head = cycler.GetHead();
            Actor head2 = cycler2.GetHead();
            List<Actor> body = cycler.GetBody();
            List<Actor> body2 = cycler2.GetBody();

            foreach (Actor segment in body)
            {
                if (segment.GetPosition().Equals(head.GetPosition()))
                {
                    int x =Constants.MAX_X/2 ;
                    int y =0;
                    Point position = new Point(x, y);
                    Actor message = new Actor();
                    message.SetText("Player One SUICIDE");
                    message.SetPosition(position);
                    cast.AddActor("messages", message);
                    isGameOver = true && isGameOver2 == false;
                }
            }

            foreach (Actor segment in body)
            {
                if (segment.GetPosition().Equals(head2.GetPosition()))
                {
                    int x =Constants.MAX_X/2 ;
                    int y =0;
                    Point position = new Point(x, y);
                    Actor message = new Actor();
                    message.SetText("Player One Wins");
                    message.SetPosition(position);
                    cast.AddActor("messages", message);
                    isGameOver2 = true;
                }
            }

             foreach (Actor segment in body2)
            {
                if (segment.GetPosition().Equals(head2.GetPosition()))
                {
                    int x =Constants.MAX_X/2 ;
                    int y =0;
                    Point position = new Point(x, y);
                    Actor message = new Actor();
                    message.SetText("Player Two SUICIDE");
                    message.SetPosition(position);
                    cast.AddActor("messages", message);
                    isGameOver2 = true;
                }
            }

             foreach (Actor segment in body2)
            {
                if (segment.GetPosition().Equals(head.GetPosition()))
                {
                    int x =Constants.MAX_X/2 ;
                    int y =0;
                    Point position = new Point(x, y);
                    Actor message = new Actor();
                    message.SetText("Player Twe Wins");
                    message.SetPosition(position);
                    cast.AddActor("messages", message);
                    isGameOver = true;
                }
            }

        }

        private void HandleGameOver(Cast cast)
        {
            if (isGameOver == true)
            {
                Cycler cycler = (Cycler)cast.GetFirstActor("cycler");
                List<Actor> segments = cycler.GetSegments();
                // Cycler cycler2 = (Cycler)cast.GetFirstActor("cycler2");
                // List<Actor> segments2 = cycler2.GetSegments();

                // create a "game over" message
                int x = (Constants.MAX_X / 2) - 40;
                int y = Constants.MAX_Y / 2;
                Point position = new Point(x, y);

                Actor message = new Actor();
                message.SetText("Game Over!");
                message.SetPosition(position);
                cast.AddActor("messages", message);

                // make everything white
                foreach (Actor segment in segments)
                {   
                    
                    segment.SetColor(Constants.WHITE);
                    cycler.SetColor(Constants.WHITE);
                    Actor head = cycler.GetHead();
                    head.SetColor(Constants.WHITE);
                   
                }

            if (isGameOver2 == true)
            {
            
                Cycler cycler2 = (Cycler)cast.GetFirstActor("cycler2");
                List<Actor> segments2 = cycler2.GetSegments();

                // create a "game over" message
                // int x = (Constants.MAX_X / 2) - 40;
                // int y = Constants.MAX_Y / 2;
                // Point position2 = new Point(x, y);

                // Actor message2 = new Actor();
                // message2.SetText("Game Over!");
                // message2.SetPosition(position);
                // cast.AddActor("messages", message2);

                // make everything white
                
                } 
                foreach (Actor segment in segments)
                {   
                    segment.SetColor(Constants.WHITE);
                    cycler.SetColor(Constants.WHITE);
                    Actor head2 = cycler.GetHead();
                    head2.SetColor(Constants.WHITE);
                }    
            }
        }

    }
}