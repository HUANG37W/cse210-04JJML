using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class CollideBordersAction : Action
    {
        private AudioService audioService;
        private PhysicsService physicsService;
        
        public CollideBordersAction(PhysicsService physicsService, AudioService audioService)
        {
            this.physicsService = physicsService;
            this.audioService = audioService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Fighter fighter = (Fighter)cast.GetFirstActor(Constants.FIGHTER_GROUP);
            Body body = fighter.GetBody();
            Point position = body.GetPosition();
            int x = position.GetX();
            int y = position.GetY();
            //Sound bounceSound = new Sound(Constants.BOUNCE_SOUND);
            //Sound overSound = new Sound(Constants.OVER_SOUND);
            

            // This is possibly for the second player when having to collid with the border.
            Fighter fighter2 = (Fighter)cast.GetFirstActor(Constants.FIGHTER_GROUP);
            Body body2 = fighter.GetBody();
            Point position2 = body.GetPosition();
            int x2 = position.GetX();
            int y2 = position.GetY();
            //Sound bounceSound = new Sound(Constants.BOUNCE_SOUND);
            //Sound overSound = new Sound(Constants.OVER_SOUND);

            if (x < Constants.FIELD_LEFT)
            {
                Stats stats = (Stats)cast.GetFirstActor(Constants.STATS_GROUP);
                stats.RemovePlayer1Life();

                if (stats.GetPlayer1Lives() > 0)
                {
                    //keep game going

                    /// callback.OnNext(Constants.TRY_AGAIN);
                }
                else
                {
                    // Do stuff to show that Player 2 Wins!

                    /// callback.OnNext(Constants.GAME_OVER);
                    /// audioService.PlaySound(overSound);
                }

                //ball.BounceX();
                //audioService.PlaySound(bounceSound);
            }

            else if (x >= Constants.FIELD_RIGHT - Constants.SWORD_FIGHTER_WIDTH)
            {
                Stats stats = (Stats)cast.GetFirstActor(Constants.STATS_GROUP);
                stats.RemovePlayer2Life();

                if (stats.GetPlayer2Lives() > 0)
                {
                    //keep game going

                    /// callback.OnNext(Constants.TRY_AGAIN);
                }
                else
                {
                    // Do stuff to show that Player 1 Wins!
                    
                    /// callback.OnNext(Constants.GAME_OVER);
                    /// audioService.PlaySound(overSound);
                }

                //ball.BounceX();
                //audioService.PlaySound(bounceSound);
            }

        }
    }
}