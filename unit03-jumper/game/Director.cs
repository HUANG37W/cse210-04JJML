using System;
using System.Collections.Generic;


namespace unit03_jumper
{
    class Director
    {   
        private SkyGuy skyguy = new SkyGuy();
        private bool isPlaying = true;
        private Word word = new Word();
        private Terminal terminal = new Terminal();

        private Board board = new Board();

        private string userInput = "Y";
        

        //set up the game: pick a random word, display the initial look of the board.
        public void SetupGame()
        {
            skyguy.PrintParachute();
            skyguy.PrintGuy();
            board.DisplayWord();
            word.PickWord();
            board.GetGuess();
       }

        //start the actual game, looping through all the functions until the game is over
        public void StartGame()
        {
            SetupGame();
            while (isPlaying == true)
            {
                DoInput();
                DoUpdate();
                DoOutput();
   
                //reference the methods that make the game work
                
            }
        }

        public void DoInput()
        {
            //ask the user for their letter guess
            board.GetGuess();
        }

        public void DoUpdate()
        {   

            if (skyguy.IsDead())
                isPlaying = false;
            //check if the game is still okay to continue
            //need to add lives >0
            // isPlaying = board.CheckWin(isPlaying);
        
            //asks user if they want to play again after game over
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
            //Displays the paracute, then the guy attatched to the parachute,
            //and then the spaces where the word needs to filled.
            skyguy.PrintParachute();
            skyguy.PrintGuy();
            board.KillSkyGuy();
            terminal.WriteText(" \n");
            board.DisplayWord();
            
        }
    }
}

               