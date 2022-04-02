using Unit06.Game.Casting;
using Unit06.Game.Services;
using System.Collections.Generic;

namespace Unit06.Game.Scripting
{
    /// <summary>
    /// Handles the outcomes when two or more fighters from opposing
    /// sides collide or battle each other.
    /// </summary>
    public class CollideFightersAction : Action
    {
        private AudioService audioService;
        private PhysicsService physicsService;

        public CollideFightersAction(PhysicsService physicsService, AudioService audioService)
        {
            this.physicsService = physicsService;
            this.audioService = audioService;
        }

         public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Stats stats = (Stats)cast.GetFirstActor(Constants.STATS_GROUP);

            // Dictionary<string, List<Actor>> fighters = cast.GetActors(Constants.FIGHTER_GROUP);

            List<Actor> fighters = cast.GetActors(Constants.FIGHTER_GROUP);
            
            foreach (Fighter f1 in fighters) 
            {
                foreach (Fighter f2 in fighters)
                {
                    if (f1 != f2 && f1.GetTeam() != f2.GetTeam())
                    {
                        Body b1 = f1.GetBody();
                        Body b2 = f2.GetBody();
                        if (physicsService.HasCollided(b1, b2))
                        {
                            f1.ReduceHealth(f2.GetDamage());
                            if (f1.IsDead())
                            {
                                cast.RemoveActor(Constants.FIGHTER_GROUP, f1);
                            }
                            else if (f2.IsDead())
                            {
                                cast.RemoveActor(Constants.FIGHTER_GROUP, f2);
                            }
                        }
                    }
                }



                // }
                
                // if (physicsService.HasCollided(swfBody, bwfBody))
                // {

                // }
                // if (physicsService.HasCollided(bfBody, bfBody))
                // {

                // }
                // if (physicsService.HasCollided(bfBody, bwfBody))
                // {

                // }
                // if (physicsService.HasCollided(swfBody, swfBody))
                // {

                // }
                // if (physicsService.HasCollided(bwfBody, bwfBody))
                // {

                // }
               
        }
            
            

            //Point sp1 = new Point(50, fighter.GetBody().GetPosition().GetY());

        // public void Execute(Cast cast, Script script, ActionCallback actionCallback)
        // {
        //     List<Actor> bowfighters = cast.GetActors(Constants.BOW_FIGHTER_GROUP);
        //     List<Actor> bears = cast.GetActors(Constants.BEAR_GROUP);
        //     List<Actor> swordfighters = cast.GetActors(Constants.FIGHTER_GROUP);

        //     Stats stats = (Stats)cast.GetFirstActor(Constants.STATS_GROUP);

            
            // Body bearbody = bears.GetBody();
            // Body swordfightersbody = swordfighters.GetBody();
            // if (physicsService.HasCollided(bearbody,swordfightersbody))
            // {
            //     Sound sound = new Sound(Constants.BEAR_GROWL_SOUND);
            //     audioService.PlaySound(sound);
            //     int points = bears.GetPoints();
            //     stats.AddPoints(points);
            //     cast.RemoveActor(Constants.FIGHTER_GROUP, swordfighters);
            // }

            
            //maybe try a for each loop to loop through every fighter that could collide with one another.
        }
    }
}