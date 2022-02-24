using System;
using System.Collections.Generic;

namespace Unit04.Game.Casting
{
    class SkyDrops : Actor
    {
        private string _type;

        public SkyDrops(bool isGem)
        {
            if (isGem)
            {
                SetText(((char)42).ToString());
                _type = "gem";
            }
            else 
            {
                SetText(((char)79).ToString());
                _type = "rock";
            }
            Random random = new Random();
            int r = random.Next(0, 256);
            int g = random.Next(0, 256);
            int b = random.Next(0, 256);
            SetColor(new Color(r, g, b));
            SetFontSize(20);
            SetPosition(new Point(random.Next(0,640),0)); 
        }

        public string GetDropType()
        {
            return _type;
        }
        
    }
}