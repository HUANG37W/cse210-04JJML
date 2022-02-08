using System;

namespace unit03_jumper
{
    class Director
    {   
        private SkyGuy skyguy = new SkyGuy();
        private bool isPlaying = true;
        private Word word = new Word();
        private Terminal terminal = new Terminal();

        public string userInput = "y";
        public void SetupGame()
        {
            word.PickWord(string pull);
            skyguy.PrintGuy();
        }

        public void StartGame()
        {
            while (isPlaying == true)
            {
                //reference the methods that make the game work
            }
            //stub
        }

        public void DoInput()
        {
            //stub
        }

        public void DoUpdate()
        {
            //check if the game is still okay to continue
            isPlaying = word.CheckWin(isPlaying);
            //stub
            if (isPlaying == false)
            {
                terminal.WriteText("Do you want to play again? y/n");
                terminal.ReadText(userInput);
                userInput = userInput.ToUpper();
                if (userInput == "Y")
                {
                    isPlaying = true;
                }
                else
                {
                    isPlaying = false;
                }
            }
        }

        public void DoOutput()
        {
            //stub
        }
    }
}