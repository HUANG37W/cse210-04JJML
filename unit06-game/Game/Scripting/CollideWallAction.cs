using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    /// <summary>
    /// Implements the consequences of a fighter colliding with 
    /// or passing through the left or right side of the screen.
    /// </summary>
    public class CollideWallAction : Action
    {
        private AudioService audioService;
        private PhysicsService physicsService;
        
        public CollideWallAction(PhysicsService physicsService, AudioService audioService)
        {
            this.physicsService = physicsService;
            this.audioService = audioService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            // Defining needed variables for player 1 fighters to have collisions with border.
            Fighter fighter = (Fighter)cast.GetFirstActor(Constants.FIGHTER_GROUP);
            Body body = fighter.GetBody();
            Point position = body.GetPosition();
            int x = position.GetX();
            int y = position.GetY();
            Sound cheersound = new Sound(Constants.CHEER_SOUND);
            Sound oversound = new Sound(Constants.SOUND_OVER);
            //put more sound bites in
            
            

            // This is possibly for the second player when having to collid with the border.
            // Defining needed variables for player 2 fighters to have collisions with border.
            Fighter fighter2 = (Fighter)cast.GetFirstActor(Constants.FIGHTER_GROUP);
            Body body2 = fighter.GetBody();
            Point position2 = body.GetPosition();
            int x2 = position.GetX();
            int y2 = position.GetY();
            // Sound cheerSound = new Sound(Constants.CHEER_SOUND);
            // Sound overSound = new Sound(Constants.OVER_SOUND);

            if (x2 < Constants.FIELD_LEFT)
            {
                Stats stats = (Stats)cast.GetFirstActor(Constants.STATS_GROUP);
                stats.RemovePlayer1Life();
                audioService.PlaySound(cheersound);

                if (stats.GetPlayer1Lives() > 0)
                {
                    //keep game going

                    callback.OnNext(Constants.TRY_AGAIN);
                }
                else
                {
                    // Do stuff to show that Player 2 Wins!
                    callback.OnNext(Constants.GAME_OVER);
                    audioService.PlaySound(oversound);
                }

                //ball.BounceX();
                //audioService.PlaySound(bounceSound);
            }

            else if (x >= Constants.FIELD_RIGHT- Constants.SWORD_FIGHTER_WIDTH)
            {
                Stats stats = (Stats)cast.GetFirstActor(Constants.STATS_GROUP);
                stats.RemovePlayer2Life();

                if (stats.GetPlayer2Lives() > 0)
                {
                    //keep game going

                    callback.OnNext(Constants.TRY_AGAIN);
                }
                else
                {
                    // Do stuff to show that Player 1 Wins!
                    callback.OnNext(Constants.GAME_OVER);
                    audioService.PlaySound(oversound);
                }

                //ball.BounceX();
                //audioService.PlaySound(bounceSound);
            }

        }
    }
}