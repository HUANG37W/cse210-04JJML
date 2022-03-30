using System;
using System.Collections.Generic;

namespace Unit06.Game.Casting
{
    /// <summary>
    /// <para>A thing that participates in the game.</para>
    /// <para>
    /// The responsibility of Bear is to appear on the screen. 
    /// </para>
    /// </summary>
    public class SwordFighter : Fighter
    {
       
        // /// Constructs a new instance of Sword.
        // /// </summary>
        public SwordFighter(Body body, Animation animation, bool debug = false) : base(body,animation,debug) 
        {
             
        }
    public override void AttackAction()
    {
        return;
    }        

    }
}


