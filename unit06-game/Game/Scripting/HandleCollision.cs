namespace Unit06.Game.Scripting
{
    /// <summary>
    /// <para>Keeps a fighter on screen from moving through another fighter blocking its path.
    /// </para>
    /// <para>HandleCollision also cause loss of health or death
    /// of a fighter when it recieves an attack from another fighter.
    /// </para>
    /// </summary>
    public class HandleCollision
    {
        public HandleCollision()
        {
            //constructor
        }

        /// <summary>Prevents fighters from walking through eachother when they run into eachother.
        /// </summary>
        public void FighterCollision()
        {
            //stub
        }

        ///<summary>Checks if a weapon collision causes death of enemy fighter</summary>
        public void WeaponCollision()
        {
            //stub
        }
        
        ///<summary>Check health stat to see if a fighter dies from attack</summary>
        public void CheckDeath()
        {
            //stub
        }
    }
}