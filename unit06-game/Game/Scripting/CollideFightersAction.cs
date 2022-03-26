using Unit06.Game.Casting;
using Unit06.Game.Services;

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

        public void Execute(Cast cast, Script script, ActionCallback actionCallback)
        {
            //maybe try a for each loop to loop through every fighter that could collide with one another.
        }
    }
}