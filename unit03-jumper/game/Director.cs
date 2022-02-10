using System;

namespace unit03_jumper
{
    class Director
    {   
        private SkyGuy skyguy = new SkyGuy();
        private bool isPlaying = true;
        private Word word = new Word();
        private Terminal terminal = new Terminal();

        private Board board = new Board();

        public string userInput = "y";
        public void SetupGame()
        {
            word.PickWord();
            skyguy.PrintParachute();
            skyguy.PrintGuy();
            board.DisplayWord();
            board.GetGuess();
        }

        public void StartGame()
        {
            DoOutput();
            while (isPlaying == true)
            {
                //reference the methods that make the game work
                
            }
        }

        public void DoInput()
        {
            //stub
        }

        public void DoUpdate()
        {   
            if (skyguy.IsDead())
                isPlaying = false;
            //check if the game is still okay to continue
            //need to add lives >0
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
            board.DisplayWord();
            skyguy.PrintParachute();
            skyguy.PrintGuy();
        }
    }
}

               