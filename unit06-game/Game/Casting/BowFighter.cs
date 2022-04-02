using System;
using System.Collections.Generic;


namespace Unit06.Game.Casting
{
    /// <summary>
    /// <para>A thing that participates in the game.</para>
    /// <para>
    public class BowFighter : Fighter
    {
        public BowFighter(Body body, Animation animation, bool debug = false) : base(debug) 
        {
             
        }
    public override void AttackAction()
    {
        return;
    }    
    }
}