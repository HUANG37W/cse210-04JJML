using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    /// <summary>
    /// Implements the consequences of a fighter colliding with 
    /// or passing through the left or right side of the screen.
    /// </summary>
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
            // Defining needed variables for player 1 fighters to have collisions with border.
            // Fighter fighter = (Fighter)cast.GetFirstActor(Constants.FIGHTER_GROUP);
            // Body body = fighter.GetBody();
            // Point position = body.GetPosition();
            // int x = position.GetX();
            // int y = position.GetY();
            //Sound bounceSound = new Sound(Constants.BOUNCE_SOUND);
            //Sound overSound = new Sound(Constants.OVER_SOUND);
            

            // This is possibly for the second player when having to collide with the border.
            // Defining needed variables for player 2 fighters to have collisions with border.
            // Fighter fighter2 = (Fighter)cast.GetFirstActor(Constants.FIGHTER_GROUP);
            // Body body2 = fighter.GetBody();
            // Point position2 = body.GetPosition();
            // int x2 = position.GetX();
            // int y2 = position.GetY();
            //Sound bounceSound = new Sound(Constants.BOUNCE_SOUND);
            //Sound overSound = new Sound(Constants.OVER_SOUND);

            foreach (Fighter fighter in cast.GetActors(Constants.FIGHTER_GROUP))
            {
                Body body = fighter.GetBody();
                Point position = body.GetPosition();
                int x = position.GetX();
                int y = position.GetY();

                if (x < Constants.FIELD_LEFT)
                {
                    Stats stats = (Stats)cast.GetFirstActor(Constants.STATS_GROUP);
                    stats.RemovePlayer1Life();
                    cast.RemoveActor(Constants.FIGHTER_GROUP, fighter);

                    if (stats.GetPlayer1Lives() <= 0)
                    {
                        // Do stuff to show that Player 2 Wins!
                        callback.OnNext(Constants.GAME_OVER);
                        cast.ClearActors(Constants.FIGHTER_GROUP);
                        //audioService.PlaySound(overSound);
                    }
                    //audioService.PlaySound(oofSound);
                }

                else if (x >= Constants.FIELD_RIGHT - Constants.SWORD_FIGHTER_WIDTH)
                {
                    Stats stats = (Stats)cast.GetFirstActor(Constants.STATS_GROUP);
                    stats.RemovePlayer2Life();
                    cast.RemoveActor(Constants.FIGHTER_GROUP, fighter);

                    if (stats.GetPlayer2Lives() <= 0)
                    {
                        // Do stuff to show that Player 1 Wins!
                        callback.OnNext(Constants.GAME_OVER);
                        cast.ClearActors(Constants.FIGHTER_GROUP);
                        // audioService.PlaySound(overSound);
                    }
                    //audioService.PlaySound(oofSound);
                }

            }
            

        }
    }
}