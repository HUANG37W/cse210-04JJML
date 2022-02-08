using System;

namespace unit03_jumper
{
    class Director
    {   
        private SkyGuy skyguy = new SkyGuy();
        private bool isPlaying = true;
        private Word word = new Word();
        public void SetupGame()
        {
            word.PickWord(string GettingWord);
            skyguy.PrintGuy();
        }

        public void StartGame()
        {
            //stub
        }

        public void DoInput()
        {
            //stub
        }

        public void DoUpdate()
        {
            //stub
        }

        public void DoOutput()
        {
            //stub
        }
    }
}