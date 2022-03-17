using System;


namespace Unit06.Game.Casting
{
    /// <summary>
    /// <para>Class description here</para>
    /// <para>
    /// The responsibility of Stats is to keep track of
    /// the different stat bars like, Fighter Hitpoints,
    /// and player Lives.
    /// </para>
    /// </summary>
    public class Stats : Actor
    {
        private int lives = 3;
        private int fighterHP = 10;

        public Stats()
        {

        }

        public void LoseLife()
        {
            lives--;
            SetText($"Lives: {this.lives}");
        }
    }
}

