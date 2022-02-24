using System;


namespace Unit04.Game.Casting
{

    public class Player : Actor
    {
        public Player()
        {
            SetText("#");
            SetFontSize(15);
            SetColor(new Color(75, 0, 130)); // indigo
            SetPosition(new Point(int.MaxValue/2, 350));
            SetVelocity(new Point(0,1));

        }
    }
}